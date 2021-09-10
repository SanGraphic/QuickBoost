@echo off
Echo Installing QuickBoost PowerPlan
echo.
powershell -c "Invoke-WebRequest -Uri 'https://cdn.discordapp.com/attachments/460788721789173760/836157669298667570/SanGraphicPOWERPLAN.pow' -OutFile C:\Windows\SanGraphicPOWERPLAN.pow
powercfg -import "C:\Windows\SanGraphicPOWERPLAN.pow" f42fe57c-e762-287e-984a-4e9613d9e9d3
del /f "C:\Windows\SanGraphicPOWERPLAN.pow"
powercfg -SETACTIVE "f42fe57c-e762-287e-984a-4e9613d9e9d3"
exit