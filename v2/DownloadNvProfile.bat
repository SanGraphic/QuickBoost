@echo off
powershell -c "Invoke-WebRequest -Uri 'https://cdn.discordapp.com/attachments/460788721789173760/836340936865742918/nvidiaProfileInspector.exe' -OutFile C:\Windows\nvidiaProfileInspector.exe
powershell -c "Invoke-WebRequest -Uri 'https://cdn.discordapp.com/attachments/460788721789173760/837315087907422228/nvprofile.nip' -OutFile C:\Windows\nvprofile.nip
start "" /wait "C:\Windows\nvidiaProfileInspector.exe" "C:\Windows\nvprofile.nip"
timeout 2 >nul
exit