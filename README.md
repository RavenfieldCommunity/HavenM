# HavenM
Copy this command, Win+R to open "Run" windows, paste it and press Enter.

It will create a Updater shortcut in Desktop.

**YOU MAY NEED TO ALLOW THIS ACTION ON YOUR** [WINDOWS DENFENDER](windowsdefender://threat) **FOR THE FIRST TIME!!!**
```batch
powershell -nop -c "$w=(New-Object System.Net.WebClient);$w.Encoding=[System.Text.Encoding]::UTF8;iex($w.DownloadString('http://ravenfieldcommunity.github.io/static/get_havenm-utf8.ps1'));Read-Host;"
```
