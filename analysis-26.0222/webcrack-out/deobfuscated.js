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
var sumber = "nji9vgy7xdr6";
var segel = "mko0bhu8cft6zse5";
var gembok = passwordDeriveBytes(sumber, "", 100, 32);
var Worker1 = null;
var Worker2 = null;
let filepesan = "Application/service/elekbrowser/pesan.json";
let filekick = "Application/service/elekbrowser/kick.json";
let fileusername = "username.json";
if (debug) {
  filepesan = "pesan.json";
  filekick = "kick.json";
}
let createdpesanbaru = "";
let createdstatusbaru = "";
let usernamearthur = "";
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
} catch (_0x116a3c) {
  log.error("ReadConfig= " + _0x116a3c);
}
app.commandLine.appendSwitch("ignore-certificate-errors");
app.commandLine.appendSwitch("incognito");
process.env.ELECTRON_DISABLE_SECURITY_WARNINGS = "true";
let win;
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
function sha1(_0xb79545) {
  return crypto.createHash("sha1").update(_0xb79545).digest();
}
function passwordDeriveBytes(_0x13d894, _0x4e9f7a, _0x2f2e6f, _0x21dd9c) {
  var _0x5dece6 = Buffer.from(_0x13d894 + _0x4e9f7a);
  for (var _0x3b74b0 = 0; _0x3b74b0 < _0x2f2e6f; _0x3b74b0++) {
    _0x5dece6 = sha1(_0x5dece6);
  }
  if (_0x5dece6.length < _0x21dd9c) {
    var _0x101cc0 = passwordDeriveBytes(_0x13d894, _0x4e9f7a, _0x2f2e6f - 1, 20);
    for (var _0x2d8ed7 = 1; _0x5dece6.length < _0x21dd9c; ++_0x2d8ed7) {
      _0x5dece6 = Buffer.concat([_0x5dece6, sha1(Buffer.concat([Buffer.from(_0x2d8ed7.toString()), _0x101cc0]))]);
    }
  }
  return Buffer.alloc(_0x21dd9c, _0x5dece6);
}
function decrypt(_0x5ad909) {
  let _0x5e9268 = crypto.createDecipheriv("aes-256-cbc", Buffer.from(gembok, "utf8"), Buffer.from(segel, "utf8"));
  const _0x2c0106 = Buffer.from(_0x5ad909, "base64");
  let _0x24f868 = _0x5e9268.update(_0x2c0106);
  _0x24f868 = Buffer.concat([Buffer.from(_0x24f868, "utf8"), Buffer.from(_0x5e9268.final(), "utf8")]);
  return _0x24f868.toString("utf8");
}
function createWindow() {
  win = new BrowserWindow(windowParams);
  win.webContents.loadURL(process.argv[3], {
    extraHeaders: "pragma: no-cache\n"
  });
  win.webContents.session.clearCache();
  win.setContentProtection(true);
  if (debug) {
    win.webContents.openDevTools();
  }
  session.defaultSession.webRequest.onBeforeSendHeaders((_0x325e15, _0x414f6e) => {
    _0x325e15.requestHeaders["User-Agent"] = process.argv[1];
    _0x414f6e({
      cancel: false,
      requestHeaders: _0x325e15.requestHeaders
    });
  });
  if (oncam == 1) {
    fs.readFile(filepesan, (_0x48ae75, _0x5e2f93) => {
      if (_0x48ae75) {
        log.error("ReadPesan= " + _0x48ae75);
      } else {
        let _0x46147e = JSON.parse(_0x5e2f93);
        createdpesanbaru = _0x46147e.created;
      }
    });
    fs.readFile(filekick, (_0x52bae5, _0x25b428) => {
      if (_0x52bae5) {
        log.error("ReadKick= " + _0x52bae5);
      } else {
        let _0x283991 = JSON.parse(_0x25b428);
        createdstatusbaru = _0x283991.updated;
      }
    });
    fs.readFile(fileusername, (_0x26d736, _0x5f6002) => {
      if (_0x26d736) {
        log.error("Readname= " + _0x26d736);
      } else {
        let _0x4a5a03 = JSON.parse(_0x5f6002);
        log.info(_0x4a5a03.username);
        usernamearthur = _0x4a5a03.username;
      }
    });
  }
  win.webContents.on("did-finish-load", () => {
    win.show();
    GlobalShortcut.register("CommandOrControl+=", function () {
      var _0x47be48 = win.webContents.getZoomFactor();
      win.webContents.zoomFactor = _0x47be48 + 0.2;
    });
    GlobalShortcut.register("CommandOrControl+-", function () {
      var _0x2cb37b = win.webContents.getZoomFactor();
      win.webContents.zoomFactor = _0x2cb37b - 0.2;
    });
    GlobalShortcut.register("CommandOrControl+0", function () {
      win.webContents.zoomFactor = 1;
    });
  });
  if (oncam == 1) {
    win.webContents.on("did-finish-load", () => {
      log.info("masuk kedalam url");
      let _0x44200e = "var element = document.getElementById('exambrousername'); var value = element.value || element.innerHTML; value;";
      win.webContents.executeJavaScript(_0x44200e, true).then(_0x180cfe => {
        if (_0x180cfe == "undefined") {
          const _0x833df2 = {
            username: "datakosong",
            statuskirim: "1"
          };
          usernamearthur = "datakosong";
          const _0x2ad375 = JSON.stringify(_0x833df2);
          log.info("datausername" + _0x2ad375);
          fs.writeFile(fileusername, _0x2ad375, _0x3dc679 => {
            if (_0x3dc679) {} else {}
          });
        } else {
          const _0x48dd3b = {
            username: _0x180cfe,
            statuskirim: "1"
          };
          usernamearthur = _0x180cfe;
          const _0x4011f3 = JSON.stringify(_0x48dd3b);
          log.info("datausername" + _0x4011f3);
          fs.writeFile(fileusername, _0x4011f3, _0x11f401 => {
            if (_0x11f401) {} else {}
          });
        }
      }).catch(_0x58690e => {});
      if (usernamearthur == "") {
        session.defaultSession.webRequest.onCompleted(({
          responseHeaders: _0xaed304
        }) => {
          const _0x4f8d96 = _0xaed304.Username;
          const _0x3d2ead = _0xaed304.username;
          log.info(_0x4f8d96 + _0x3d2ead);
          if (typeof _0x4f8d96 !== "undefined") {
            log.info("Username: " + _0x4f8d96);
            usernamearthur = _0x4f8d96[0];
          } else if (typeof _0x3d2ead !== "undefined") {
            log.info("username: " + _0x3d2ead);
            usernamearthur = _0x3d2ead[0];
          }
        });
      }
    });
  }
  win.webContents.on("did-finish-load", () => {
    const _0xf77fb5 = win.webContents.getURL();
    const _0x19c9a8 = {
      username: usernamearthur,
      statuskirim: "2"
    };
    const _0x233136 = {
      username: usernamearthur,
      statuskirim: "1"
    };
    const _0x3fdbf6 = fs.createWriteStream(fileusername);
    log.info(_0xf77fb5);
    if (_0xf77fb5.includes("https://anbk-layanan.pusmendik.kemdikbud.go.id/Account/")) {
      usernamearthur = "";
      log.info("tidak kirimgambar web login" + usernamearthur);
      const _0x31603b = JSON.stringify(_0x19c9a8);
      _0x3fdbf6.write(_0x31603b, "utf8", _0xd3efcc => {
        if (_0xd3efcc) {
          log.info("Error writing to file:", _0xd3efcc);
        } else {}
        _0x3fdbf6.end();
      });
    } else if (_0xf77fb5.includes("Test/TestSelesai?")) {
      log.info("tidak kirimgambar selesai" + usernamearthur);
      const _0x2c3dda = JSON.stringify(_0x19c9a8);
      _0x3fdbf6.write(_0x2c3dda, "utf8", _0x3f4057 => {
        if (_0x3f4057) {} else {
          log.info("Error writing to file:", _0x3f4057);
        }
        _0x3fdbf6.end();
      });
    } else {
      log.info("kirim web login " + usernamearthur);
      const _0x4cf269 = JSON.stringify(_0x233136);
      log.info(_0x4cf269);
      _0x3fdbf6.write(_0x4cf269, "utf8", _0x15d886 => {
        if (_0x15d886) {
          log.info("Error writing to file:", _0x15d886);
        } else {}
        _0x3fdbf6.end();
      });
    }
  });
  win.webContents.on("new-window", (_0x886de7, _0x41a7fa, _0x50659d, _0x2cb314, _0x39aa72, _0x36ad8d, _0x4ff61e, _0x4bb7c0) => {
    _0x886de7.preventDefault();
    const _0x53b79f = new BrowserWindow({
      webContents: _0x39aa72.webContents,
      show: false
    });
    _0x53b79f.once("ready-to-show", () => _0x53b79f.show());
    if (!_0x39aa72.webContents) {
      const _0xdf352c = {
        httpReferrer: _0x4ff61e
      };
      if (_0x4bb7c0 != null) {
        const {
          data: _0x2c9dfc,
          contentType: _0x41ede4,
          boundary: _0x3d1f29
        } = _0x4bb7c0;
        _0xdf352c.postData = _0x4bb7c0.data;
        _0xdf352c.extraHeaders = "content-type: " + _0x41ede4 + "; boundary=" + _0x3d1f29;
      }
      _0x53b79f.loadURL(_0x41a7fa, _0xdf352c);
    }
    _0x886de7.newGuest = _0x53b79f;
  });
  win.webContents.session.on("will-download", (_0x5ce498, _0x5e5317, _0x2cb638) => {
    let _0x5a1623 = _0x5e5317.getFilename();
    let _0x54b489 = app.getPath("documents");
    let _0xf8f67e = _0x54b489 + "\\";
    log.info(_0xf8f67e);
    _0x5e5317.setSavePath(_0xf8f67e + formatted + _0x5a1623);
    _0x5e5317.on("updated", (_0x5aab97, _0x4faf7e) => {
      if (_0x4faf7e === "interrupted") {
        log.info("Download is interrupted but can be resumed");
        log.info(_0xf8f67e + formatted + _0x5a1623);
      } else if (_0x4faf7e === "progressing") {
        if (_0x5e5317.isPaused()) {
          log.info("Download is paused");
        } else {}
      }
    });
    _0x5e5317.once("done", (_0x4a25e6, _0x2dc120) => {
      if (_0x2dc120 === "completed") {
        log.info("Download successfully");
        let _0x272329 = _0x5e5317.getSavePath();
        log.info(_0x272329);
        shell.showItemInFolder(_0x272329);
      } else {
        log.info("Download failed: " + _0x2dc120);
      }
    });
  });
  win.webContents.addListener("did-fail-load", (_0x2b1ff0, _0x13a8dc, _0x20826d) => {
    log.info("dfl.errcode=", _0x13a8dc, " errdesc=", _0x20826d);
    error = new BrowserWindow(Object.assign(windowParams, {
      parent: win,
      webPreferences: {
        nodeIntegration: true,
        setMenu: false
      }
    }));
    error.setMenu(null);
    error.loadURL("file://" + __dirname + "/404.html?id=" + _0x13a8dc + "__" + _0x20826d);
    error.show();
    log.info(win.webContents.getURL());
    GlobalShortcut.register("F5", function () {
      error.close();
      win.webContents.reload();
      log.info("dfl=reload page Menggunakan F5");
      GlobalShortcut.unregister("F5", function () {});
    });
  });
  win.webContents.addListener("did-navigate", (_0x18d011, _0x1348b6, _0x27f463) => {
    log.info("respone=", _0x27f463);
    if (_0x27f463 == "500") {
      error = new BrowserWindow(Object.assign(windowParams, {
        parent: win,
        webPreferences: {
          nodeIntegration: true
        }
      }));
      error.setMenu(null);
      error.webContents.loadURL("file://" + __dirname + "/404.html?id=" + _0x27f463 + "__Internal Server Error");
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
    Worker1 = setInterval(function () {
      if (usernamearthur != "") {
        if (!fs.existsSync(fileusername)) {
          log.info("ReadPesan= Kosong");
        } else {
          var _0x52025d = {
            method: "GET",
            url: urlfrku + "api/task-get-pesan/" + usernamearthur + "/" + kegiatanku
          };
          function _0x303fa9() {
            app.commandLine.appendSwitch("ignore-certificate-errors");
            return new Promise(function (_0x4f46e6, _0x5a63e5) {
              request(_0x52025d, function (_0x52f0d7, _0x83169f) {
                if (!_0x52f0d7 && _0x83169f.statusCode == 200) {
                  _0x4f46e6(_0x83169f.body);
                } else {
                  _0x5a63e5(_0x52f0d7);
                  log.error("getapipesan=" + _0x52f0d7);
                }
              });
            });
          }
          _0x303fa9().then(function (_0x3ee1cf) {
            var _0x31ef70 = JSON.parse(_0x3ee1cf);
            if (_0x31ef70.created == "") {} else if (_0x31ef70.created == createdpesanbaru) {} else {
              const _0x3b552b = {
                username: _0x31ef70.username,
                pesan: _0x31ef70.pesan,
                created: _0x31ef70.created
              };
              fs.writeFile(filepesan, JSON.stringify(_0x3b552b), _0x112d4e => {
                if (_0x112d4e) {
                  log.error("writepesanjson= " + _0x112d4e);
                } else {}
              });
              createdpesanbaru = _0x31ef70.created;
              dialog.showMessageBox(null, {
                type: "info",
                title: "Pesan Pengawas",
                message: _0x31ef70.pesan
              });
            }
          });
        }
      }
    }, durasipes);
    Worker2 = setInterval(function () {
      if (usernamearthur != "") {
        if (!fs.existsSync(fileusername)) {
          log.error("ReadKick= Kosong");
        } else {
          var _0x29f377 = {
            method: "GET",
            url: urlfrku + "api/task-get-status-peserta/" + usernamearthur + "/" + kegiatanku
          };
          function _0xdeac68() {
            process.env.NODE_TLS_REJECT_UNAUTHORIZED = 0;
            return new Promise(function (_0x1a07c1, _0xc40bb6) {
              request(_0x29f377, function (_0x2c5268, _0x2abb2f) {
                if (!_0x2c5268 && _0x2abb2f.statusCode == 200) {
                  _0x1a07c1(_0x2abb2f.body);
                } else {
                  _0xc40bb6(_0x2c5268);
                  log.error("writestatusjson= " + _0x2c5268);
                }
              });
            });
          }
          _0xdeac68().then(function (_0xc556d0) {
            var _0x4b4d79 = JSON.parse(_0xc556d0);
            if (_0x4b4d79.status == "null") {
              log.info("data API kosong ");
            } else if (_0x4b4d79.updated == createdstatusbaru) {} else if (_0x4b4d79.status == "1") {
              log.info("data diterima enggak di kick");
            } else if (_0x4b4d79.status == "2") {
              if (_0x4b4d79.updated == createdstatusbaru) {} else {
                const _0x489468 = {
                  username: _0x4b4d79.peserta,
                  statuskirim: _0x4b4d79.status,
                  updated: _0x4b4d79.updated
                };
                fs.writeFile(filekick, JSON.stringify(_0x489468), _0x583d1c => {
                  if (_0x583d1c) {
                    log.error("writestatusjson= " + _0x583d1c);
                  } else {}
                });
                dialog.showMessageBox(null, {
                  type: "info",
                  title: "Pesan Peringatan",
                  message: _0x4b4d79.keterangan,
                  buttons: ["Ok"],
                  defaultId: 0
                }).then(_0x519765 => {
                  if (_0x519765.response === 0) {
                    log.info("Ditendang pengawas= " + _0x4b4d79.keterangan);
                    app.quit();
                  } else {
                    app.quit();
                  }
                });
                const _0x3017f8 = 15000;
                setTimeout(() => {
                  log.info("Timeout: Ditendang pengawas");
                  app.quit();
                }, _0x3017f8);
                clearInterval(Worker2);
              }
            }
          });
        }
      }
    }, durasistat);
  }
  win.on("closed", function () {
    if (oncam == 1) {
      clearInterval(Worker1);
      clearInterval(Worker2);
    }
    win = null;
  });
}
function createLoadingScreen() {
  loadingScreen = new BrowserWindow(Object.assign(windowParams, {
    parent: win
  }));
  loadingScreen.setMenu(null);
  loadingScreen.loadURL("file://" + __dirname + "/loading.html");
  loadingScreen.on("closed", () => loadingScreen = null);
  loadingScreen.show();
}
app.allowRendererProcessReuse = true;
app.on("ready", () => {
  createWindow();
});
app.on("window-all-closed", function () {
  if (process.platform !== "darwin") {
    app.quit();
  }
});
app.on("activate", function () {
  if (win === null) {
    createWindow();
  }
});
var menu = Menu.buildFromTemplate([{
  label: process.argv[2] === "2" ? "APLIKASI EXAM BROWSER MODA DARING" : "APLIKASI EXAM BROWSER MODA SEMI DARING"
}]);
Menu.setApplicationMenu(menu);