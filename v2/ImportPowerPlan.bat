@echo off
Echo Installing QuickBoost PowerPlan
echo.
powershell -c "Invoke-WebRequest -Uri 'https://github.com/SanGraphic/QuickBoost/raw/main/v2/Adamx's%20Power%20Plan.pow' -OutFile C:\Windows\SanGraphicPOWERPLAN.pow
powercfg -import "C:\Windows\SanGraphicPOWERPLAN.pow" 945fe57c-e762-487e-984a-4e9213d9e9d7
del /f "C:\Windows\SanGraphicPOWERPLAN.pow"
powercfg -SETACTIVE "945fe57c-e762-487e-984a-4e9213d9e9d7"
exit
