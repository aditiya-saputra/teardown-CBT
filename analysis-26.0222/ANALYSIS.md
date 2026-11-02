# Teardown Elekbrowser 26.0222 — Analisis `main.js` + .NET

**Tanggal:** 2026-11-02
**Target:** `64BitExambrowserClient_26.0222` (path lokal di-redaksi)
**Scope:** Electron main process (`Application/service/elekbrowser/resources/app/main.js`), config, preload/renderer/404/loading, dan decompile 6 assembly .NET.
**Metode:** static analysis, deobfuscation string-array + webcrack, dekripsi config, verifikasi hash, decompile .NET dengan `ilspycmd`, cross-check repo `teardown-CBT`, dan docs Electron 11.
**Batasan:** client **tidak dijalankan** (tidak menyentuh server produksi); decompile .NET bersifat statis, bukan runtime.

---

## 1. Verifikasi Target

| Item | Nilai | Status |
|---|---|---|
| `version.txt` | `26.0222` | ✅ |
| `package.json` elekbrowser | name `elekbrowser`, version `02.12.21`, electron `^11.2.0` | ✅ |
| `main.js` | 19.129 byte, 1 baris, SHA-256 `FE2CE0F7C6BABF3B316BF09A88FD21370A55C837E5D99415DB10AE04378635FD` | ✅ |
| String array obfuscator | 172 string, berhasil didekode 172/172 | ✅ |
| Target repo `teardown-CBT` | 18,7 KB, string array 172, versi 26.0222 | ✅ cocok |
| Config aktif | `versi: "26.0222"`, `jenisbit: "Bit64"` | ✅ |
| `hash64` config | `1DE9FE76…4C0F` | ✅ = SHA-256 `elekbrowser.exe` |
| `OSVersionInfo.dll` | SHA-256 `A33662B4…8BE9` | ✅ = konstanta embedded repo |
| `main.reconstructed.js` | `node --check` exit 0 | ✅ |
| Webcrack lokal | 491 baris, 16.924 B, `Compare-Object` 0 diff vs repo `deobfuscated.js` (CRLF vs LF) | ✅ |
| Decompile .NET | 6/6 assembly exit 0; `ilspycmd` 11.2.0.10050 Native AOT | ✅ |
| Output .NET | 6 file `.cs`, total 2.281.337 byte | ✅ |

**Kesimpulan verifikasi:** file lokal adalah target yang sama dengan yang dianalisis repo (bukan versi 25.0525). Line reference di bawah mengacu ke `teardown-CBT/js/main.annotated.js`; isinya token-identik dengan `deobfuscated.js` repo (3.258 token vs 3.258 token dengan tokenizer yang sama).

**Verifikasi independen webcrack:** `npx webcrack@latest` pada `main.js` lokal menghasilkan 491 baris; setelah normalisasi line ending, isinya **identik** dengan `teardown-CBT/js/deobfuscated.js`. Log webcrack: string array `_0x162f` length 172, rotate yes, decoder `_0x46df`, **638 changes**—sama dengan angka di README repo. Jadi output repo bukan asumsi; itu memang output webcrack dari file lokal ini.

---

## 2. Arsitektur `main.js`

Urutan load:

```text
require electron/fs/crypto/request/electron-log/node-datetime
  → baca setting_exambro.json
  → decrypt() AES-256-CBC
  → JSON.parse → oncam, durasipes, durasistat, urlfrku, kegiatanku
  → app.commandLine.appendSwitch("ignore-certificate-errors")
  → appendSwitch("incognito")
  → windowParams (kiosk, show:false, nodeIntegration:false, webviewTag:true)
  → app.on("ready") → createWindow()
```

### 2.1 Handler di `createWindow()`

| # | Handler | Baris | Perilaku |
|---|---|---|---|
| 1 | `onBeforeSendHeaders` | 188-194 | Set `User-Agent = process.argv[1]` untuk semua request |
| 2 | `did-finish-load` #1 | 226-239 | `win.show()` + daftar shortcut zoom `Ctrl+= / Ctrl+- / Ctrl+0` |
| 3 | `did-finish-load` #2 | 243-290 | Ambil username dari DOM `#exambrousername`, fallback response header `Username` |
| 4 | `did-finish-load` #3 | 295-341 | Tulis `username.json` + `statuskirim` berdasarkan URL |
| 5 | `new-window` | 344-369 | Buat BrowserWindow popup; meneruskan `postData`/`referrer` |
| 6 | `will-download` | 372-399 | Simpan ke Documents dengan prefix timestamp, buka folder |
| 7 | `did-fail-load` | 402-421 | Buka `404.html`, daftar `F5` untuk reload |
| 8 | `did-navigate` | 424-443 | Cek HTTP 500 → buka `404.html`, daftar `F5` |
| 9 | `Worker1` | 448-495 | Polling `api/task-get-pesan/{username}/{kegiatan}` |
| 10 | `Worker2` | 500-572 | Polling `api/task-get-status-peserta/{username}/{kegiatan}`; status `2` → kick |
| 11 | `win.on("closed")` | 575-581 | Clear interval, `win = null` |

### 2.2 Worker

- **Worker1** hanya jalan jika `oncam == 1` dan `usernamearthur != ""` dan `username.json` ada. Jika `created` berubah → tulis `pesan.json` + dialog "Pesan Pengawas".
- **Worker2** hanya jalan dengan syarat yang sama. Jika `status == "2"` dan `updated` berubah → tulis `kick.json`, dialog "Pesan Peringatan", `app.quit()`, timer pengaman 15 detik, `clearInterval(Worker2)`.

### 2.3 File state

| File | Path | Isi |
|---|---|---|
| `username.json` | relatif cwd | `{username, statuskirim}` |
| `pesan.json` | `Application/service/elekbrowser/pesan.json` | `{username, pesan, created}` |
| `kick.json` | `Application/service/elekbrowser/kick.json` | `{username, statuskirim, updated}` |

### 2.4 Argumen CLI

| Index | Isi | Dipakai |
|---|---|---|
| `argv[1]` | User-Agent | header semua request |
| `argv[2]` | mode (`"2"` = daring) | label menu |
| `argv[3]` | URL ujian | `loadURL()` |

---

## 3. Config

### 3.1 Config aktif vs bundled

| Field | Aktif (`<root>/setting_exambro.json`) | Bundled (`resources/app/setting_exambro.json`) |
|---|---|---|
| `versi` | **26.0222** | 22.1205 |
| `aktifkamera` | **1** | 0 |
| `PesanInterval` | 300.000 ms | 20.000 ms |
| `StatusInterval` | 300.000 ms | 20.000 ms |
| `ImageInterval` | 300.000 ms | 30.000 ms |
| `HeartInterval` | 600.000 ms | 600.000 ms |
| `urlonline` | `https://anbk-siswa.pusmendik.kemendikdasmen.go.id` | `http://118.98.236.40:8093/` |
| `urlfr` | `https://smart-production.pusmendik.kemendikdasmen.go.id/` | `https://smart.pusmendik.kemdikbud.go.id/` |
| `urlgetagent` | `https://anbk-webapi.pusmendik.kemendikdasmen.go.id/auth/api/v1/user-agent/generate` | `https://anbk-production.pusmendik.kemdikbud.go.id/ubkapi/api/workstation/token/` |
| `validdesktop` | **0** | 1 |
| `sharingsession` | 1 | 0 |
| `Kegiatan` | `2020` | `2020` |
| `jenisapps` | `radya` | — |
| `passwd` | *redacted* (5 digit, lemah) | *redacted* (5 digit, lemah) |
| `unlockkeys` | `LControlKey,C,B` | `LControlKey,C,B` |

**Catatan:** `main.js` membaca `setting_exambro.json` dari **cwd**, jadi config aktif di root client yang dipakai. Config bundled hanya fallback/leftover dan hash-nya (`8433FDEB…`) tidak cocok dengan `elekbrowser.exe` saat ini.

### 3.2 Kriptografi config

| Parameter | Nilai |
|---|---|
| Algoritma | AES-256-CBC |
| KDF | PBKDF1-SHA1, 100 iterasi, salt kosong |
| IV | `mko0bhu8cft6zse5` (statis) |
| Password | hardcoded di `main.js` |
| Padding | PKCS#7 |

Config terenkripsi disimpan sebagai Base64 dalam file UTF-32LE. `main.js` membaca sebagai UTF-8 lalu `Buffer.from(..., "base64")`; karakter NUL diabaikan oleh decoder Base64, sehingga tetap berhasil didekripsi.

**Temuan kripto:** static IV + salt kosong + password hardcoded = enkripsi deterministik. Siapa pun yang punya binary bisa membuat ulang ciphertext untuk plaintext yang sama. Ini bukan proteksi rahasia, hanya obfuscation.

---

## 4. Temuan

Severity mengikuti dampak nyata, bukan jumlah baris.

### 4.1 Koreksi terhadap analisis repo

**Koreksi 1 — `did-navigate` HTTP 500 bukan dead code.**

- **Klaim lama** (`teardown-CBT/README.md` §9 #1): `httpResponseCode == "500"` membandingkan number dengan string, sehingga kondisi tidak pernah true dan handler 500 mati.
- **Bukti pembantah:** operator `==` adalah loose equality. `500 == "500"` → `true` (diverifikasi dengan Node v24.20.0). Docs Electron 11 juga menyatakan `httpResponseCode` adalah `Integer`; handler tetap berjalan untuk status 500.
- **Klaim benar:** perbandingan itu **rapuh** dan sebaiknya `=== 500`, tetapi bukan dead code.
- **Dampak koreksi:** finding #1 di README JS harus dicabut/downgrade; jangan dipakai sebagai bukti kerentanan.

**Koreksi 2 — payload login memakai username lama.**

- **Klaim lama** (`README.md` §5): saat halaman login, `username=""` lalu `statuskirim="2"`.
- **Kode nyata** (`main.annotated.js` 297-310): `logoutPayload` dibentuk **sebelum** `usernamearthur = ""`. Jadi file `username.json` di halaman login masih berisi username lama dengan `statuskirim:"2"`.
- **Dampak:** state peserta bisa terbawa ke halaman login; deteksi "belum login" di sisi .NET bisa salah.

**Koreksi 3 — `examServicesisRunning()` bukan sekadar nama terbalik; call site-nya juga terbalik/racy.**

- **Klaim lama** (`REVERSE_ENGINEERING.md` #3): body mengembalikan `true` saat service **absen**, tetapi "call site uses it correctly".
- **Bukti independen:** `runningexam.decompiled.cs:90-98` mengembalikan `true` jika `GetProcessesByName("ExamServices").Length < 1`. Satu-satunya call site, `runningexam.decompiled.cs:778`, masuk ke cabang `if (ValidasiExam.examServicesisRunning())` yang menulis log **"Examservices sudah running"** lalu menampilkan desktop/`StartExplore()`. Artinya cabang "sudah running" dijalankan justru saat proses **belum ada**; saat proses ada, code masuk `else` dan men-disable tombol Run.
- **Dampak:** minimal race condition setelah `Process.Start(ExamServices)`; bisa juga branch yang memang terbalik. Klaim repo "call site uses it correctly" tidak terbukti dan perlu dicabut/dikoreksi. Butuh uji runtime untuk memastikan dampak operasional.

### 4.2 Prioritas tinggi

| # | Temuan | Bukti | Dampak |
|---|---|---|---|
| H1 | **TLS verification dimatikan di dua tempat** — `appendSwitch("ignore-certificate-errors")` dan `process.env.NODE_TLS_REJECT_UNAUTHORIZED = 0` | `main.annotated.js` 97, 511 | MITM pada halaman ujian, API pesan/status, dan FR upload; penyerang di jalur jaringan bisa menyamar sebagai server ujian |
| H2 | **Error window memakai `nodeIntegration: true` + mutasi global `windowParams`** | 404-410, 427-432; `Object.assign(windowParams, ...)` | Window error punya akses Node penuh; `webPreferences` yang sudah dimutasi bisa diwarisi window berikutnya. `404.html` punya sink `innerHTML` dari query string — RCE bersyarat jika URL bisa dikendalikan |
| H3 | **Config gagal parse → `setInterval(fn, undefined)`** | 495, 572; `durasipes`/`durasistat` undefined | Node meng-clamp interval ke 1 ms → CPU spin + hammering API pesan/status. Terjadi jika `setting_exambro.json` hilang/rusak |

### 4.3 Prioritas sedang

| # | Temuan | Bukti | Dampak |
|---|---|---|---|
| M1 | **`JSON.parse` file state tanpa try/catch** | 201, 210, 219 | `pesan.json`/`kick.json`/`username.json` korup → exception tak tertangkap di callback `fs.readFile` → main process crash saat start |
| M2 | **Login URL hardcoded tidak cocok dengan config** | 308 vs config `urlonline` | Deteksi halaman login gagal di domain `anbk-siswa.pusmendik.kemendikdasmen.go.id`; `statuskirim` bisa tetap `1` di halaman login dan username tidak dibersihkan |
| M3 | **`logoutPayload` menangkap username sebelum di-reset** | 297-310 | `username.json` di halaman login berisi username lama + `statuskirim:"2"` |
| M4 | **`reject(requestError)` saat statusCode != 200** | 461-467, 513-519 | `requestError` bisa `null`; log jadi `getapipesan=null` (terlihat di `Browser.log` 2026-10-26) dan status code hilang |
| M5 | **`status == "null"` type mismatch** | 525 | Jika API mengembalikan JSON `null`, `null == "null"` adalah `false`; cabang "data API kosong" tidak pernah jalan. Baru benar jika API mengirim string `"null"` |
| M6 | **Listener `onCompleted` menumpuk** | 275-288 | Registrasi terjadi di setiap `did-finish-load` saat `usernamearthur == ""`, tidak pernah di-unregister; listener duplikat dan log ganda |
| M7 | **Electron 11 EOL + `contextIsolation` default false** | `package.json`; `main.annotated.js` 109-114 | Chromium 87 sudah EOL; `webviewTag:true`, `allowRunningInsecureContent:true`, `allowDisplayingInsecureContent:true`, tanpa `contextIsolation` |
| M8 | **Path download dari filename server** | 378 | `setSavePath(documents + formatted + item.getFilename())`; jika filename tidak disanitasi Chromium, ada potensi path traversal. **Perlu uji runtime** |
| M9 | **Kunci/IV/password hardcoded** | 48-51; config | Siapa pun bisa dekripsi config, membuat ulang ciphertext, dan membaca parameter ujian |

### 4.4 Prioritas rendah / info

| # | Temuan |
|---|---|
| L1 | `createLoadingScreen()` didefinisikan tetapi tidak pernah dipanggil (1 occurrence = definisi) |
| L2 | `ipcMain` di-import tetapi tidak dipakai |
| L3 | `debug` dan `ppg` konstanta `false` — dead branch (`openDevTools`, `oncam=1`) |
| L4 | `formatted` dihitung sekali saat startup → semua download memakai prefix timestamp yang sama |
| L5 | `did-navigate` memakai `==` — benar secara kebetulan, rapuh |
| L6 | `log.error("CAM= " + oncam)` untuk kondisi normal — level log salah |
| L7 | `dialog.showMessageBox(null, ...)` — API mengizinkan `browserWindow` opsional; bukan bug, tapi lebih baik `dialog.showMessageBox(options)` |
| L8 | `request` sudah deprecated; tidak ada `.catch()` di chain Worker1/Worker2 |
| L9 | `app.commandLine.appendSwitch` di dalam Worker1 tidak berpengaruh setelah `ready` (dead effect) |
| L10 | Tiga listener `did-finish-load` terpisah pada event yang sama |

---

## 5. Bug Hunt Report

**Platform:** Windows, PowerShell 5.1, Node v24.20.0 (untuk verifikasi logika).
**Cakupan:** `main.js` (19.129 byte, 172 string), `preload.js`, `renderer.js`, `404.html`, `loading.html`, `package.json`, dua config terenkripsi, `Browser.log` (agregat), docs Electron 11.
**Sumber:** source 📖, docs Electron 11 📖, runtime log 📖, penalaran 🧠.
**Reproduksi:** tidak menjalankan client (menghindari koneksi ke server produksi). Verifikasi yang dilakukan: hash, dekripsi config, `node --check`, uji coercion `500 == "500"` dan `null == "null"`, hitung occurrence handler.

### 5.1 Cakupan yang diuji
- Struktur dan handler `main.js`.
- Alur config → window → worker.
- Dekripsi config aktif dan bundled.
- Integritas `elekbrowser.exe` vs `hash64`.
- Konsistensi dengan repo `teardown-CBT`.
- Decompile .NET 6 assembly dengan `ilspycmd`; verifikasi klaim kunci.
- Perilaku tipe data pada perbandingan kritis.

### 5.2 Cakupan yang BELUM diuji
- Runtime Electron 11 aktual (tidak dijalankan).
- Koneksi ke API pesan/status/FR.
- Path traversal download (butuh server yang mengirim filename khusus).
- Respons API `status: null` vs `"null"`.
- Runtime .NET (decompile statis sudah dilakukan; eksekusi `runningexam.exe`/service tidak).
- Dekripsi string .NET secara independen (plaintext memakai tabel `dotnet-strings` repo; control-flow .NET sudah independen).
- Efek `setContentProtection` di GPU/driver tertentu.

### 5.3 Status
- 2 koreksi finding lama (false positive HTTP 500; payload login).
- 1 koreksi baru dari decompile .NET (`examServicesisRunning` call site).
- 3 temuan tinggi JS terverifikasi dari source/docs.
- 9 temuan sedang JS, 10 rendah/info.
- 6/6 assembly .NET berhasil didecompile; temuan kunci repo diverifikasi.
- 0 bug diperbaiki di client (ini analisis, bukan patch).

---

## 6. Batas JS vs .NET

Electron `main.js` **bukan** lapisan lockdown utama. Ia hanya:

- kiosk window + `setContentProtection`,
- inject User-Agent,
- ambil username,
- polling pesan/kick,
- simpan download.

Lockdown sebenarnya ada di .NET:

| File | Peran |
|---|---|
| `Application/runningexam.exe` | Orkestrator: cek integritas, kill browser lain, keyboard hook, desktop, launch service |
| `Application/LibraryExam.dll` | Config, kripto, validasi, WCF |
| `Application/service/ExamServices.exe` | Service pendukung |
| `Application/service/ExamCam.exe` | Kamera / FR upload |
| `Application/OSVersionInfo.dll` | Cek versi OS |
| `Application/runningexam.exe.config` | `Password`, `BrowserArguments`, `SpecialKeys`, `ModeUjian` |

`runningexam.exe.config` (redacted): `Password` 5 digit, `BrowserArguments` berisi `-incognito -kiosk --allow-running-insecure-content --disable-extensions --disable-plugins --debug-plugin-loading`, `SpecialKeys` `LControlKey,C,B`, `ModeUjian` `2`.

**Status:** .NET sekarang **di-decompile ulang** dengan `ilspycmd` 11.2.0.10050 (Native AOT). Hasil dan verifikasi ada di §6.1.

### 6.1 Decompilasi .NET independen (2026-11-02)

**Toolchain:** `dnSpy.Console` 6.1.8 gagal di sesi non-interaktif—`System.IO.IOException: The handle is invalid` pada `Console.set_OutputEncoding` (Program.cs line 58), bukan masalah assembly. Fallback: `ilspycmd` 11.2.0.10050 `win-x64` Native AOT dari NuGet (`ilspycmd.win-x64.11.2.0.10050.nupkg`, 9.134.969 byte), tanpa .NET runtime/SDK/admin. `OSVersionInfo.dll` diuji terpisah (exit 0); 5 assembly sisanya di batch `dotnet-decompile.log` (5× `exit=0`). Semua 6 output ada.

**Output:** `dotnet-decompiled/<assembly>/<assembly>.decompiled.cs`

| Assembly | Byte | SHA-256 (awal) |
|---|---:|---|
| `ExamBrowser.exe` | 120.772 | `01DADC77…DD413E` |
| `runningexam.exe` | 283.397 | `E7A34C32…EF7226` |
| `LibraryExam.dll` | 1.562.318 | `AA43BE6F…D7314F` |
| `OSVersionInfo.dll` | 26.009 | `0C487EB3…4B8AFA` |
| `ExamCam.exe` | 123.001 | `403D4FDC…9FA77D` |
| `ExamServices.exe` | 165.840 | `BB76E9B9…93B19` |

**Verifikasi klaim repo (langsung dari C#):**

| Repo # | Klaim | Bukti independen | Status |
|---|---|---|---|
| 1 | Single-instance check `GetProcessesByName("ExamBrowser")` | `runningexam:441`; callmap `Form_Main.cs:39` → `ExamBrowser`; proses = `runningexam` | ✅ |
| 2 | Camera consent no-op | `runningexam:741-749`—Yes dan No sama-sama `LXHRt0Eoqg = 1` | ✅ |
| 3 | `examServicesisRunning()` nama terbalik, call site benar | Body `runningexam:90-98`; call site `:778` masuk cabang "sudah running" saat service **absen** | ⚠️ **call site juga terbalik/racy** |
| 4 | `qATbVOKyM`/`HeMfjAI6P` selalu true | `runningexam:964-972` | ✅ |
| 5 | `HeartInterval` tidak dipakai timer | `LibraryExam:17284` default 300000; `runningexam:2262/2336` UI saja | ✅ |
| 6 | `Contains()` version check | `ExamBrowser:158` `versionupdate.Contains(value)` | ✅ |
| 8 | URL semi hardcoded | table `ExamCam` offset 634: `https://192.168.0.200/unbk/api/workstation/upload-fr-image` | ✅ |
| 9 | Duplikat blocklist | callmap: AnyDesk 3×, ROMFUSClient 2×, RPCSuite 2×, vncviewer 2× | ✅ |
| 10 | PBKDF1 tanpa salt, IV statis | `PasswordDeriveBytes(passPhrase, null)` di `LibraryExam:18777/18895/19099/19212`; IV `mko0bhu8cft6zse5` | ✅ |
| 13 | `WH_KEYBOARD_LL` hook | `LibraryExam:5738` `SetWindowsHookEx(13, …)`; mouse hook 14 di `:5124` | ✅ |
| 14 | `CreateDesktop` user-mode | `LibraryExam:11525/11790/13125` | ✅ |
| 15/16 | `Fijar love Feyy`, `anaslopyanto` | callmap `getAgent.cs:766/863`; `ExamCam Form1.cs:297/309`; table offset 622/220 | ✅ |
| 19 | Kunci crypto hardcoded | table: `nji9vgy7xdr6` @7448, `mji6tui7xdl5` @7476, `mko0bhu8cft6zse5` @7412 | ✅ |
| 20/21 | TLS validation dimatikan + fallback `Ssl3\|Tls` | `ExamBrowser:173/189/225/231`, `:190/232`; `ExamCam:320/341/382/404`, `:342/405`; `runningexam:642` | ✅ |
| 24 | Desktop isolation mati di config | `LibraryExam:17087` `bukadesktop = validdesktop`; config `validdesktop="0"`; `runningexam:756` bandingkan `"1"` (callmap `Form_Main.cs:431`) | ✅ |

**Catatan string .NET:** Konstanta string masih berupa panggilan decryptor (`JYC...EWJ9xtjenL`, `Ni7vpKp...v8Sa8hFQ7`, `LbLVEKXKyBoyApYjjwc`). Plaintext di atas diambil dari `teardown-CBT/dotnet-strings/callmap.tsv` dan `*.table.txt` yang dihasilkan dari binary yang sama. Control-flow .NET sudah independen; eksekusi/reimplementasi decryptor string tidak dilakukan di sesi ini. Jadi klaim "decompile .NET" valid untuk struktur dan logika, tetapi plaintext string masih bergantung pada tabel repo.

**Temuan baru (Koreksi 3):** `examServicesisRunning()` mengembalikan `true` saat service absen; satu-satunya call site (`runningexam:778`) memakai `if (examServicesisRunning())` untuk cabang log "Examservices sudah running". Ini bukan "call site uses it correctly" seperti klaim repo. Minimal race setelah `Process.Start(ExamServices)`; perlu uji runtime.

---

## 7. Rekomendasi Defensif

1. **TLS:** hapus `ignore-certificate-errors` dan `NODE_TLS_REJECT_UNAUTHORIZED=0`; gunakan pinning/CA yang benar.
2. **Electron:** upgrade ke versi supported; `contextIsolation: true`, `nodeIntegration: false` di semua window, `sandbox: true`, matikan `webviewTag`, `allowRunningInsecureContent`, `allowDisplayingInsecureContent`.
3. **Config:** jangan hardcode password/IV; gunakan KDF dengan salt + IV acak; validasi schema dan tipe field.
4. **State file:** bungkus `JSON.parse` dengan try/catch; tulis atomik (temp + rename); validasi `username`/`status`.
5. **URL detection:** jangan hardcode host; ambil dari config atau cocokkan path + origin secara eksplisit.
6. **Worker:** handle non-200 dengan status code + body; tambahkan `.catch()`; guard `setInterval` minimal 1.000 ms.
7. **Download:** sanitasi `getFilename()` dan verifikasi path tetap di dalam folder tujuan.
8. **404.html:** tambahkan CSP dan hindari `innerHTML` dari query string.
9. **Dead code:** hapus `createLoadingScreen`, `ipcMain`, `debug`/`ppg` branch, atau implementasikan.
10. **Disclosure:** laporkan temuan ke Pusmendik/Kemdikbud melalui kanal resmi; jangan publikasikan langkah eksploitasi.

---

## 8. Artefak

| File | Isi |
|---|---|
| `main.reconstructed.js` | `main.js` lokal dengan 172 string di-inline; identifier masih `_0x*`; `node --check` OK |
| `webcrack-out/deobfuscated.js` | Output webcrack lokal; identik dengan repo (CRLF vs LF) |
| `webcrack.log` | Log webcrack: 172 string, 638 changes |
| `dotnet-decompiled/<assembly>/*.decompiled.cs` | 6 assembly .NET hasil `ilspycmd`; total 2.281.337 byte |
| `dotnet-decompile.log` | Log decompile: exit 0 untuk 6 assembly |
| `GENERATED_SHA256SUMS.txt` | SHA-256 output webcrack + 6 `.cs` |
| `config.active.decrypted.json` | Config aktif 26.0222; `passwd` redacted |
| `config.bundled.decrypted.json` | Config bundled 22.1205; `passwd` redacted |
| `SHA256SUMS.txt` | SHA-256 file kunci |
| `ANALYSIS.md` | Dokumen ini |

---

## 9. Debt / Batasan

- **Static only.** Tidak ada eksekusi client, tidak ada dynamic instrumentation, tidak ada koneksi ke server ujian.
- **.NET sudah di-decompile ulang** (6/6, `ilspycmd`), tetapi **string decryptor .NET belum dijalankan ulang**; plaintext memakai tabel `dotnet-strings` repo.
- **Runtime .NET belum diuji:** `examServicesisRunning` call-site inversion/race, service startup timing, dan desktop branch perlu uji terisolasi.
- **Beberapa temuan perlu uji runtime:** path traversal download, `status: null`, perilaku `setContentProtection` di driver tertentu.
- **Log berisi data peserta.** `Browser.log` memuat username peserta dan URL ujian; nilai tersebut tidak disalin ke dokumen ini.
- **Koreksi repo belum di-upstream.** Repo `teardown-CBT` milik pihak lain; jangan edit tanpa izin. Jika kamu pemiliknya, finding #1, urutan payload login, dan `examServicesisRunning` call-site perlu diperbaiki di README/CHANGELOG.
