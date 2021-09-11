@echo off
takeown /f %LocalAppData%\Microsoft\Windows\Explorer\ /r /d y
takeown /f %%G\AppData\Local\Temp\ /r /d y
takeown /f %SystemRoot%\TEMP\ /r /d y
takeown /f %systemdrive%\$Recycle.bin\ /r /d y
takeown /f C:\Users\%USERNAME%\AppData\Local\BraveSoftware\Brave-Browser\User Data\Default\Code Cache\ /r /d y
takeown /f C:\Users\%USERNAME%\AppData\Local\Fortnitegame\saved\ /r /d y
takeown /f C:\Users\%USERNAME%\AppData\Local\Google\Chrome\User Data\Default\Code Cache\ /r /d y
del /q /s %systemdrive%\$Recycle.bin\*
for /d %%x in (%systemdrive%\$Recycle.bin\*) do @rd /s /q "%%x"
cls
powershell.exe Remove-Item -Path $env:TEMP -Recurse -Force -ErrorAction SilentlyContinue
cls
echo Clearing Epic Games and Fortnite Temporary Files:
erase /F /S /Q "%SystemRoot%\TEMP*.*"
for /D %%G in ("%SystemRoot%\TEMP*") do RD /S /Q "%%G"
for /D %%G in ("%SystemDrive%\Users*") do erase /F /S /Q "%%G\AppData\Local\Temp*.*"
for /D %%G in ("%SystemDrive%\Users*") do RD /S /Q "%%G\AppData\Local\Temp\" 

set FortDir=C:\Users\%USERNAME%\AppData\Local\Fortnitegame\saved\Logs
del /s /Q /f "%FortDir%"> nul
rd /s /q "%FortDir%"> nul

set EpicDir=C:\Users\%USERNAME%\AppData\Local\EpicGamesLauncher\Saved\Logs
del /s /Q /f "%EpicDir%"> nul
rd /s /q "%EpicDir%"> nul

set EbicDir=C:\Users\%USERNAME%\AppData\Local\EpicGamesLauncher\Saved\Crashes
del /s /Q /f "%EbicDir%"> nul
rd /s /q "%EbicDir%"> nul

cls

echo Clearing Log Files From The System
echo.
@echo off
cd/
del *.log /a /s /q /f
powershell taskkill /F /IM explorer.exe
timeout 2 /nobreak>nul
DEL /F /S /Q /A %LocalAppData%\Microsoft\Windows\Explorer\thumbcache_*.db
DEL /f /s /q %temp%\
DEL /f /s /q %temp%\*.tmp
DEL /f /s /q %temp%\*
DEL /f /s /q %systemdrive%\*.tmp
DEL /f /s /q %systemdrive%\*._mp
DEL /f /s /q %systemdrive%\*.log
DEL /f /s /q %systemdrive%\*.gid
DEL /f /s /q %systemdrive%\*.chk
DEL /f /s /q %systemdrive%\*.old
DEL /f /s /q %systemdrive%\recycled\*.*
DEL /f /s /q %systemdrive%\$Recycle.Bin\*.*
DEL /f /s /q %windir%\*.bak
DEL /f /s /q %windir%\prefetch\*.*
rd /s /q %windir%\temp & md %windir%\temp
DEL /f /q %userprofile%\cookies\*.*
DEL /f /q %userprofile%\recent\*.*
DEL /f /s /q "%userprofile%\Local Settings\Temporary Internet Files\*.*"
DEL /f /s /q "%userprofile%\Local Settings\Temp\*.*"
DEL /f /s /q "%userprofile%\recent\*.*"
timeout 3 /nobreak>nul
Invoke-Command COMPUTERNAME -command{Stop-Process -ProcessName Explorer}
Invoke-Command COMPUTERNAME -command{Start-Process -ProcessName Explorer}
powershell Start explorer.exe
cls
@echo
net stop UsoSvc
@echo
net stop bits
@echo
net stop dosvc
@echo
echo Deleting Windows Update Files:
rd /s /q C:\Windows\SoftwareDistribution
md C:\Windows\SoftwareDistribution
cls
echo.
cls
echo Running Windows Cleaner (cleanmgr.exe)
start "" /wait "C:\Windows\System32\cleanmgr.exe" /sagerun:50 
exit
