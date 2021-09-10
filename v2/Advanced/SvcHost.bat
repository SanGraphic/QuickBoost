@echo off
echo Enter the amount of RAM that you have. (Example: 4GB, 6GB, 8GB, 16GB, 32GB, 64GB)
echo.
echo. 
set choice=
set /p choice=Amount of RAM:
if not '%choice%'=='' set choice=%choice:~0,1%
if '%choice%'=='4GB' goto :4GBRam
if '%choice%'=='6GB' goto :6GBRam
if '%choice%'=='8GB' goto :8GBRam
if '%choice%'=='16GB' goto :16GBRam
if '%choice%'=='32GB' goto :32GBRam
if '%choice%'=='64GB' goto :64GBRam
ECHO "%choice%" is not valid, try again

:4GBRam
Reg.exe add "HKLM\SYSTEM\ControlSet001\Control" /v "SvcHostSplitThresholdInKB" /t REG_DWORD /d "68764420" /f
exit
:6GBRam
Reg.exe add "HKLM\SYSTEM\ControlSet001\Control" /v "SvcHostSplitThresholdInKB" /t REG_DWORD /d "103355478" /f
exit
:8GBRam
Reg.exe add "HKLM\SYSTEM\ControlSet001\Control" /v "SvcHostSplitThresholdInKB" /t REG_DWORD /d "137922056" /f
exit
:16GBRam
Reg.exe add "HKLM\SYSTEM\ControlSet001\Control" /v "SvcHostSplitThresholdInKB" /t REG_DWORD /d "376926742" /f
exit
:32GBRam
Reg.exe add "HKLM\SYSTEM\ControlSet001\Control" /v "SvcHostSplitThresholdInKB" /t REG_DWORD /d "861226034" /f
exit
:64GB
Reg.exe add "HKLM\SYSTEM\ControlSet001\Control" /v "SvcHostSplitThresholdInKB" /t REG_DWORD /d "1729136740" /f
exit