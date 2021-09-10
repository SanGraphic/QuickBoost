@echo off
Echo Installing Timer Resolution Service
echo.
powershell Invoke-WebRequest "https://cdn.discordapp.com/attachments/460788721789173760/836161440103923732/SetTimerResolutionService.exe" -OutFile "C:\Windows\SetTimerResolutionService.exe"
"C:\Windows\SetTimerResolutionService.exe" -install
sc start STR
exit