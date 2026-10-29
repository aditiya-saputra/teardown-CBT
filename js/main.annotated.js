/**
 * main.annotated.js — Versi beranotasi dari main process ExamBrowser Client (ANBK Kemdikbud).
 *
 * Ringkasan modul:
 * - Membaca "setting_exambro.json", mendekripsinya (AES-256-CBC, key turunan password), lalu
 *   memakai hasilnya untuk: status kamera (oncam), interval polling pesan/status, URL server, Kegiatan.
 * - Membuat BrowserWindow kiosk (createWindow) serta layar loading terpisah (createLoadingScreen).
 * - Menyuntikkan User-Agent dari process.argv[1] ke semua request lewat onBeforeSendHeaders,
 *   menonaktifkan cache, serta mengaktifkan setContentProtection (anti screen-capture).
 * - Mengambil username peserta dari DOM halaman ujian (executeJavaScript) atau dari response header
 *   (onCompleted), lalu menyimpannya ke username.json.
 * - Worker1: polling pesan pengawas (api/task-get-pesan) -> tulis pesan.json + dialog "Pesan Pengawas".
 * - Worker2: polling status peserta (api/task-get-status-peserta) -> tulis kick.json + dialog peringatan
 *   + app.quit() bila peserta di-kick (status "2").
 * - Handler webContents: did-finish-load, did-fail-load, did-navigate, new-window, will-download.
 * - Menu aplikasi dibentuk dari process.argv[2] ("2" = moda daring, selain itu moda semi daring).
 *
 * Catatan penting: seluruh logika, string literal, angka, dan urutan statement dipertahankan PERSIS
 * seperti file sumber (DECOMPILED/js/deobfuscated.js). Yang berubah hanya nama identifier _0x*,
 * indentasi, dan tambahan komentar.
 */

const debug = false;
const ppg = false;
const electron = require("electron");
const {
  app,
  ipcMain,
  shell,
  dialog
} = require("electron");
const {
  session
} = require("electron");
var Menu = electron.Menu;
var GlobalShortcut = require("electron").globalShortcut;
const BrowserWindow = electron.BrowserWindow;
const log = require("electron-log");
const fs = require("fs");
var crypto = require("crypto");
log.transports.file.file = __dirname + "/Browser.log";
log.transports.file.level = "info";
var dateTime = require("node-datetime");
var dt = dateTime.create();
var formatted = dt.format("Ymd_H-M-S_");
var request = require("request");
// Password dan IV (salt/IV string) untuk dekripsi config. Nama asli dipertahankan agar mudah dicocokkan.
var sumber = "nji9vgy7xdr6";
var segel = "mko0bhu8cft6zse5";
// Kunci AES-256 (32 byte) hasil derivasi 100 iterasi SHA-1 dari password di atas.
var gembok = passwordDeriveBytes(sumber, "", 100, 32);
// Handle interval untuk dua worker polling.
var Worker1 = null;
var Worker2 = null;
// Path file state yang dipakai lintas proses (relatif terhadap direktori kerja aplikasi).
let filepesan = "Application/service/elekbrowser/pesan.json";
let filekick = "Application/service/elekbrowser/kick.json";
let fileusername = "username.json";
// Mode debug memakai file state di direktori kerja saat ini (bukan path produksi).
if (debug) {
  filepesan = "pesan.json";
  filekick = "kick.json";
}
// Penanda "created"/"updated" terakhir agar dialog tidak muncul berulang untuk data yang sama.
let createdpesanbaru = "";
let createdstatusbaru = "";
// Username peserta yang sedang login (dipakai sebagai bagian URL API dan isi username.json).
let usernamearthur = "";
// Variabel konfigurasi hasil dekripsi setting_exambro.json.
var mantapmantap;
let hastemp;
let parsingfile;
let oncam;
let durasipes;
let durasistat;
let urlfrku;
let kegiatanku;
if (ppg) {
  oncam = 1;
}
// Baca + dekripsi konfigurasi. Jika gagal, nilai variabel konfigurasi tetap undefined
// (dan log mencatat error) sehingga aplikasi berjalan dengan setelan bawaan.
try {
  mantapmantap = fs.readFileSync("setting_exambro.json");
  hastemp = decrypt(mantapmantap.toString("utf8"));
  parsingfile = JSON.parse(hastemp);
  oncam = parsingfile.aktifkamera;
  durasipes = parsingfile.PesanInterval;
  durasistat = parsingfile.StatusInterval;
  urlfrku = parsingfile.urlfr;
  kegiatanku = parsingfile.Kegiatan;
  log.error("CAM= " + oncam);
} catch (configReadError) {
  log.error("ReadConfig= " + configReadError);
}
// Matikan validasi sertifikat & security warning, dan jalankan dalam mode incognito.
app.commandLine.appendSwitch("ignore-certificate-errors");
app.commandLine.appendSwitch("incognito");
process.env.ELECTRON_DISABLE_SECURITY_WARNINGS = "true";
// Window utama aplikasi (implicit global, sama seperti aslinya).
let win;
// Parameter BrowserWindow: kiosk (fullscreen terkunci), tanpa nodeIntegration, memakai preload.js.
windowParams = {
  kiosk: true,
  show: false,
  setVisibleOnAllWorkspaces: true,
  allowDisplayingInsecureContent: true,
  allowRunningInsecureContent: true,
  webPreferences: {
    nodeIntegration: false,
    webviewTag: true,
    enableRemoteModule: false,
    preload: "preload.js"
  }
};

/**
 * sha1 — Menghitung digest SHA-1 (binary Buffer) dari input.
 * Dipakai sebagai primitif derivasi kunci pada passwordDeriveBytes.
 * @param {Buffer|string} inputBytes data yang akan di-hash
 * @returns {Buffer} digest SHA-1 20 byte
 */
function sha1(inputBytes) {
  return crypto.createHash("sha1").update(inputBytes).digest();
}

/**
 * passwordDeriveBytes — Meniru PBKDF "PasswordDeriveBytes" milik .NET:
 * hash berantai (iterasi SHA-1) atas password+salt, lalu diperluas dengan blok tambahan
 * sampai panjang kunci yang diminta terpenuhi.
 * Hasil akhirnya di-pad menjadi tepat keyLength byte dan dipakai sebagai key AES-256-CBC.
 * @param {string} password password sumber ("nji9vgy7xdr6")
 * @param {string} salt salt string (kosong pada pemakaian di modul ini)
 * @param {number} iterations jumlah iterasi hash berantai
 * @param {number} keyLength panjang kunci yang diinginkan dalam byte (32 untuk AES-256)
 * @returns {Buffer} kunci sepanjang keyLength byte
 */
function passwordDeriveBytes(password, salt, iterations, keyLength) {
  // Langkah 1: hash berantai password+salt sebanyak `iterations` kali.
  var hashBuffer = Buffer.from(password + salt);
  for (var iterationIndex = 0; iterationIndex < iterations; iterationIndex++) {
    hashBuffer = sha1(hashBuffer);
  }
  // Langkah 2: bila hash masih lebih pendek dari keyLength, perluas dengan blok turunan
  // dari hash iterasi sebelumnya (perilaku khas PasswordDeriveBytes .NET).
  if (hashBuffer.length < keyLength) {
    var previousBlock = passwordDeriveBytes(password, salt, iterations - 1, 20);
    for (var blockIndex = 1; hashBuffer.length < keyLength; ++blockIndex) {
      hashBuffer = Buffer.concat([hashBuffer, sha1(Buffer.concat([Buffer.from(blockIndex.toString()), previousBlock]))]);
    }
  }
  // Langkah 3: pad/truncate ke panjang kunci yang diminta.
  return Buffer.alloc(keyLength, hashBuffer);
}

/**
 * decrypt — Mendekripsi string Base64 hasil enkripsi AES-256-CBC (config/setting_exambro.json).
 * Key diambil dari variabel global `gembok`, IV dari `segel` (16 byte, dipakai sebagai utf8 string).
 * @param {string} encryptedBase64 ciphertext dalam bentuk Base64 (tanpa IV terpisah)
 * @returns {string} plaintext UTF-8 (biasanya JSON konfigurasi)
 */
function decrypt(encryptedBase64) {
  let decipher = crypto.createDecipheriv("aes-256-cbc", Buffer.from(gembok, "utf8"), Buffer.from(segel, "utf8"));
  const ciphertextBuffer = Buffer.from(encryptedBase64, "base64");
  let decryptedBuffer = decipher.update(ciphertextBuffer);
  // Gabungkan hasil update dengan blok final (menyelesaikan padding PKCS#7).
  decryptedBuffer = Buffer.concat([Buffer.from(decryptedBuffer, "utf8"), Buffer.from(decipher.final(), "utf8")]);
  return decryptedBuffer.toString("utf8");
}

/**
 * createWindow — Membuat window ujian utama beserta seluruh perilakunya:
 * load URL ujian (process.argv[3]), inject User-Agent, ambil username peserta,
 * pasang handler navigasi/error/download, dan jalankan dua worker polling (bila kamera aktif).
 */
function createWindow() {
  win = new BrowserWindow(windowParams);
  win.webContents.loadURL(process.argv[3], {
    extraHeaders: "pragma: no-cache\n"
  });
  win.webContents.session.clearCache();
  // Cegah konten window di-capture / di-screenshot oleh aplikasi lain.
  win.setContentProtection(true);
  if (debug) {
    win.webContents.openDevTools();
  }
  // Override User-Agent setiap request dengan nilai dari process.argv[1] (UA yang diharapkan server ujian).
  session.defaultSession.webRequest.onBeforeSendHeaders((details, callback) => {
    details.requestHeaders["User-Agent"] = process.argv[1];
    callback({
      cancel: false,
      requestHeaders: details.requestHeaders
    });
  });
  if (oncam == 1) {
    // Muat penanda pesan terakhir yang sudah ditampilkan (agar tidak muncul dialog duplikat).
    fs.readFile(filepesan, (pesanReadError, pesanFileContents) => {
      if (pesanReadError) {
        log.error("ReadPesan= " + pesanReadError);
      } else {
        let pesanData = JSON.parse(pesanFileContents);
        createdpesanbaru = pesanData.created;
      }
    });
    // Muat penanda status kick terakhir.
    fs.readFile(filekick, (kickReadError, kickFileContents) => {
      if (kickReadError) {
        log.error("ReadKick= " + kickReadError);
      } else {
        let kickData = JSON.parse(kickFileContents);
        createdstatusbaru = kickData.updated;
      }
    });
    // Muat username terakhir yang tersimpan (bila ada).
    fs.readFile(fileusername, (usernameReadError, usernameFileContents) => {
      if (usernameReadError) {
        log.error("Readname= " + usernameReadError);
      } else {
        let usernameData = JSON.parse(usernameFileContents);
        log.info(usernameData.username);
        usernamearthur = usernameData.username;
      }
    });
  }
  // Handler 1: setelah halaman selesai dimuat -> tampilkan window dan daftarkan shortcut zoom.
  win.webContents.on("did-finish-load", () => {
    win.show();
    GlobalShortcut.register("CommandOrControl+=", function () {
      var currentZoom = win.webContents.getZoomFactor();
      win.webContents.zoomFactor = currentZoom + 0.2;
    });
    GlobalShortcut.register("CommandOrControl+-", function () {
      var currentZoom = win.webContents.getZoomFactor();
      win.webContents.zoomFactor = currentZoom - 0.2;
    });
    GlobalShortcut.register("CommandOrControl+0", function () {
      win.webContents.zoomFactor = 1;
    });
  });
  if (oncam == 1) {
    // Handler 2 (khusus mode kamera aktif): ambil username peserta dari DOM halaman ujian,
    // simpan ke username.json; bila DOM belum berisi username, coba baca dari response header.
    win.webContents.on("did-finish-load", () => {
      log.info("masuk kedalam url");
      let usernameExtractionScript = "var element = document.getElementById('exambrousername'); var value = element.value || element.innerHTML; value;";
      win.webContents.executeJavaScript(usernameExtractionScript, true).then(usernameFromDom => {
        if (usernameFromDom == "undefined") {
          // DOM belum terisi: tandai dengan placeholder "datakosong".
          const emptyUsernamePayload = {
            username: "datakosong",
            statuskirim: "1"
          };
          usernamearthur = "datakosong";
          const emptyUsernameJson = JSON.stringify(emptyUsernamePayload);
          log.info("datausername" + emptyUsernameJson);
          fs.writeFile(fileusername, emptyUsernameJson, writeError => {
            if (writeError) {} else {}
          });
        } else {
          // Username berhasil dibaca dari DOM.
          const usernamePayload = {
            username: usernameFromDom,
            statuskirim: "1"
          };
          usernamearthur = usernameFromDom;
          const usernameJson = JSON.stringify(usernamePayload);
          log.info("datausername" + usernameJson);
          fs.writeFile(fileusername, usernameJson, writeError => {
            if (writeError) {} else {}
          });
        }
      }).catch(executeScriptError => {});
      // Fallback: bila username masih kosong, baca dari response header ("Username"/"username").
      if (usernamearthur == "") {
        session.defaultSession.webRequest.onCompleted(({
          responseHeaders: responseHeaders
        }) => {
          const capitalizedUsernameHeader = responseHeaders.Username;
          const lowercaseUsernameHeader = responseHeaders.username;
          log.info(capitalizedUsernameHeader + lowercaseUsernameHeader);
          if (typeof capitalizedUsernameHeader !== "undefined") {
            log.info("Username: " + capitalizedUsernameHeader);
            usernamearthur = capitalizedUsernameHeader[0];
          } else if (typeof lowercaseUsernameHeader !== "undefined") {
            log.info("username: " + lowercaseUsernameHeader);
            usernamearthur = lowercaseUsernameHeader[0];
          }
        });
      }
    });
  }
  // Handler 3: sinkronkan status kirim ke username.json setiap halaman selesai dimuat.
  // - Halaman login (Account/) atau halaman selesai ujian -> statuskirim "2" (jangan kirim gambar).
  // - Halaman ujian lainnya -> statuskirim "1" (kirim gambar).
  win.webContents.on("did-finish-load", () => {
    const currentUrl = win.webContents.getURL();
    const logoutPayload = {
      username: usernamearthur,
      statuskirim: "2"
    };
    const activePayload = {
      username: usernamearthur,
      statuskirim: "1"
    };
    // Stream ditulis ulang (overwrite) tiap kali load selesai.
    const usernameWriteStream = fs.createWriteStream(fileusername);
    log.info(currentUrl);
    if (currentUrl.includes("https://anbk-layanan.pusmendik.kemdikbud.go.id/Account/")) {
      // Halaman login: kosongkan username di memori lalu kirim status "2".
      usernamearthur = "";
      log.info("tidak kirimgambar web login" + usernamearthur);
      const logoutJsonForLoginPage = JSON.stringify(logoutPayload);
      usernameWriteStream.write(logoutJsonForLoginPage, "utf8", writeError => {
        if (writeError) {
          log.info("Error writing to file:", writeError);
        } else {}
        usernameWriteStream.end();
      });
    } else if (currentUrl.includes("Test/TestSelesai?")) {
      // Halaman ujian selesai: tetap kirim status "2".
      log.info("tidak kirimgambar selesai" + usernamearthur);
      const logoutJsonForTestDone = JSON.stringify(logoutPayload);
      usernameWriteStream.write(logoutJsonForTestDone, "utf8", writeError => {
        if (writeError) {} else {
          log.info("Error writing to file:", writeError);
        }
        usernameWriteStream.end();
      });
    } else {
      // Halaman ujian berjalan: kirim status "1" (izinkan pengambilan gambar/webcam).
      log.info("kirim web login " + usernamearthur);
      const activeJson = JSON.stringify(activePayload);
      log.info(activeJson);
      usernameWriteStream.write(activeJson, "utf8", writeError => {
        if (writeError) {
          log.info("Error writing to file:", writeError);
        } else {}
        usernameWriteStream.end();
      });
    }
  });
  // Handler 4: buka window popup (new-window). Jika popup membawa webContents (webview guest),
  // guest dipindahkan ke window baru; jika tidak, URL dimuat manual beserta postData/header aslinya.
  win.webContents.on("new-window", (event, targetUrl, frameName, disposition, options, additionalFeatures, referrer, postBody) => {
    event.preventDefault();
    const popupWindow = new BrowserWindow({
      webContents: options.webContents,
      show: false
    });
    popupWindow.once("ready-to-show", () => popupWindow.show());
    // Tanpa webContents guest: muat URL sendiri dan teruskan referrer + body (mis. form POST).
    if (!options.webContents) {
      const loadOptions = {
        httpReferrer: referrer
      };
      if (postBody != null) {
        const {
          data: uploadData,
          contentType: contentType,
          boundary: multipartBoundary
        } = postBody;
        loadOptions.postData = postBody.data;
        loadOptions.extraHeaders = "content-type: " + contentType + "; boundary=" + multipartBoundary;
      }
      popupWindow.loadURL(targetUrl, loadOptions);
    }
    // Hubungkan popup ke <webview> pemanggil.
    event.newGuest = popupWindow;
  });
  // Handler 5: unduhan file. Disimpan ke folder Documents dengan prefix timestamp,
  // lalu folder dibuka otomatis setelah unduhan selesai.
  win.webContents.session.on("will-download", (event, item, webContents) => {
    let downloadFilename = item.getFilename();
    let documentsPath = app.getPath("documents");
    let downloadDirectory = documentsPath + "\\";
    log.info(downloadDirectory);
    // Path akhir: <Documents>\<timestamp><nama file asli>
    item.setSavePath(downloadDirectory + formatted + downloadFilename);
    item.on("updated", (event, state) => {
      if (state === "interrupted") {
        log.info("Download is interrupted but can be resumed");
        log.info(downloadDirectory + formatted + downloadFilename);
      } else if (state === "progressing") {
        if (item.isPaused()) {
          log.info("Download is paused");
        } else {}
      }
    });
    item.once("done", (event, state) => {
      if (state === "completed") {
        log.info("Download successfully");
        let savedPath = item.getSavePath();
        log.info(savedPath);
        shell.showItemInFolder(savedPath);
      } else {
        log.info("Download failed: " + state);
      }
    });
  });
  // Handler 6: gagal memuat halaman -> tampilkan 404.html berisi kode & deskripsi error,
  // dan daftarkan F5 untuk menutup error window + reload halaman ujian.
  win.webContents.addListener("did-fail-load", (event, errorCode, errorDescription) => {
    log.info("dfl.errcode=", errorCode, " errdesc=", errorDescription);
    error = new BrowserWindow(Object.assign(windowParams, {
      parent: win,
      webPreferences: {
        nodeIntegration: true,
        setMenu: false
      }
    }));
    error.setMenu(null);
    error.loadURL("file://" + __dirname + "/404.html?id=" + errorCode + "__" + errorDescription);
    error.show();
    log.info(win.webContents.getURL());
    GlobalShortcut.register("F5", function () {
      error.close();
      win.webContents.reload();
      log.info("dfl=reload page Menggunakan F5");
      GlobalShortcut.unregister("F5", function () {});
    });
  });
  // Handler 7: navigasi selesai. Bila server merespons 500, tampilkan halaman error internal
  // dan sediakan F5 untuk reload.
  win.webContents.addListener("did-navigate", (event, navigatedUrl, httpResponseCode) => {
    log.info("respone=", httpResponseCode);
    if (httpResponseCode == "500") {
      error = new BrowserWindow(Object.assign(windowParams, {
        parent: win,
        webPreferences: {
          nodeIntegration: true
        }
      }));
      error.setMenu(null);
      error.webContents.loadURL("file://" + __dirname + "/404.html?id=" + httpResponseCode + "__Internal Server Error");
      error.show();
      GlobalShortcut.register("F5", function () {
        error.close();
        win.webContents.reload();
        log.info("dn=reload page Menggunakan F5");
        GlobalShortcut.unregister("F5", function () {});
      });
    }
  });
  if (oncam == 1) {
    // Worker1 — polling pesan pengawas setiap `durasipes` ms.
    // Alur: syarat username tidak kosong & username.json ada -> GET api/task-get-pesan/<user>/<kegiatan>
    //       -> bila `created` berubah: tulis pesan.json, perbarui penanda, tampilkan dialog "Pesan Pengawas".
    Worker1 = setInterval(function () {
      if (usernamearthur != "") {
        if (!fs.existsSync(fileusername)) {
          log.info("ReadPesan= Kosong");
        } else {
          var messageRequestOptions = {
            method: "GET",
            url: urlfrku + "api/task-get-pesan/" + usernamearthur + "/" + kegiatanku
          };
          // Ambil body pesan dari API pengawas (Promise agar mudah di-chain).
          function fetchSupervisorMessage() {
            app.commandLine.appendSwitch("ignore-certificate-errors");
            return new Promise(function (resolve, reject) {
              request(messageRequestOptions, function (requestError, response) {
                if (!requestError && response.statusCode == 200) {
                  resolve(response.body);
                } else {
                  reject(requestError);
                  log.error("getapipesan=" + requestError);
                }
              });
            });
          }
          fetchSupervisorMessage().then(function (responseBody) {
            var messageData = JSON.parse(responseBody);
            // Abaikan bila `created` kosong atau sama dengan pesan terakhir yang sudah ditampilkan.
            if (messageData.created == "") {} else if (messageData.created == createdpesanbaru) {} else {
              const messagePayload = {
                username: messageData.username,
                pesan: messageData.pesan,
                created: messageData.created
              };
              fs.writeFile(filepesan, JSON.stringify(messagePayload), writeError => {
                if (writeError) {
                  log.error("writepesanjson= " + writeError);
                } else {}
              });
              createdpesanbaru = messageData.created;
              dialog.showMessageBox(null, {
                type: "info",
                title: "Pesan Pengawas",
                message: messageData.pesan
              });
            }
          });
        }
      }
    }, durasipes);
    // Worker2 — polling status peserta (kick) setiap `durasistat` ms.
    // Alur: GET api/task-get-status-peserta/<user>/<kegiatan>
    //       -> status "2" = di-kick: tulis kick.json, dialog peringatan, app.quit(),
    //          plus timer pengaman 15 detik dan penghentian interval Worker2.
    Worker2 = setInterval(function () {
      if (usernamearthur != "") {
        if (!fs.existsSync(fileusername)) {
          log.error("ReadKick= Kosong");
        } else {
          var statusRequestOptions = {
            method: "GET",
            url: urlfrku + "api/task-get-status-peserta/" + usernamearthur + "/" + kegiatanku
          };
          // Ambil body status dari API (nonaktifkan verifikasi TLS sebelum request).
          function fetchParticipantStatus() {
            process.env.NODE_TLS_REJECT_UNAUTHORIZED = 0;
            return new Promise(function (resolve, reject) {
              request(statusRequestOptions, function (requestError, response) {
                if (!requestError && response.statusCode == 200) {
                  resolve(response.body);
                } else {
                  reject(requestError);
                  log.error("writestatusjson= " + requestError);
                }
              });
            });
          }
          fetchParticipantStatus().then(function (responseBody) {
            var statusResponse = JSON.parse(responseBody);
            if (statusResponse.status == "null") {
              log.info("data API kosong ");
            } else if (statusResponse.updated == createdstatusbaru) {
              // Status belum berubah sejak pengecekan terakhir -> tidak ada aksi.
            } else if (statusResponse.status == "1") {
              log.info("data diterima enggak di kick");
            } else if (statusResponse.status == "2") {
              // Status "2" = peserta dikeluarkan pengawas.
              if (statusResponse.updated == createdstatusbaru) {} else {
                const kickPayload = {
                  username: statusResponse.peserta,
                  statuskirim: statusResponse.status,
                  updated: statusResponse.updated
                };
                fs.writeFile(filekick, JSON.stringify(kickPayload), writeError => {
                  if (writeError) {
                    log.error("writestatusjson= " + writeError);
                  } else {}
                });
                // Dialog peringatan; apa pun pilihan pengguna, aplikasi tetap ditutup.
                dialog.showMessageBox(null, {
                  type: "info",
                  title: "Pesan Peringatan",
                  message: statusResponse.keterangan,
                  buttons: ["Ok"],
                  defaultId: 0
                }).then(dialogResult => {
                  if (dialogResult.response === 0) {
                    log.info("Ditendang pengawas= " + statusResponse.keterangan);
                    app.quit();
                  } else {
                    app.quit();
                  }
                });
                // Timer pengaman: tutup aplikasi bila proses quit belum berjalan.
                const kickTimeoutMs = 15000;
                setTimeout(() => {
                  log.info("Timeout: Ditendang pengawas");
                  app.quit();
                }, kickTimeoutMs);
                // Hentikan polling status setelah kick diproses.
                clearInterval(Worker2);
              }
            }
          });
        }
      }
    }, durasistat);
  }
  // Saat window ditutup: hentikan kedua worker dan lepas referensi window.
  win.on("closed", function () {
    if (oncam == 1) {
      clearInterval(Worker1);
      clearInterval(Worker2);
    }
    win = null;
  });
}

/**
 * createLoadingScreen — Menampilkan window loading kecil (child dari window utama)
 * yang memuat loading.html, lalu melepas referensinya saat ditutup.
 */
function createLoadingScreen() {
  loadingScreen = new BrowserWindow(Object.assign(windowParams, {
    parent: win
  }));
  loadingScreen.setMenu(null);
  loadingScreen.loadURL("file://" + __dirname + "/loading.html");
  loadingScreen.on("closed", () => loadingScreen = null);
  loadingScreen.show();
}

// Izinkan renderer process dipakai ulang (optimasi memori, setelan lama Electron).
app.allowRendererProcessReuse = true;
app.on("ready", () => {
  createWindow();
});
// Tutup aplikasi saat semua window ditutup, kecuali di macOS.
app.on("window-all-closed", function () {
  if (process.platform !== "darwin") {
    app.quit();
  }
});
// macOS: buat ulang window saat ikon dock diklik dan belum ada window.
app.on("activate", function () {
  if (win === null) {
    createWindow();
  }
});
// Menu aplikasi hanya berisi satu label; teksnya bergantung pada process.argv[2]
// ("2" = moda daring, selain itu moda semi daring).
var menu = Menu.buildFromTemplate([{
  label: process.argv[2] === "2" ? "APLIKASI EXAM BROWSER MODA DARING" : "APLIKASI EXAM BROWSER MODA SEMI DARING"
}]);
Menu.setApplicationMenu(menu);
