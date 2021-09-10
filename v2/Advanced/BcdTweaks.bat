@echo off
echo Applying BCD Tweaks for lower Input Delay
echo.
bcdedit /set disabledynamictick yes
bcdedit /deletevalue useplatformclock
bcdedit /set useplatformtick yes
echo.
exit