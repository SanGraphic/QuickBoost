@Echo off
set "params=%*"
cd /d "%~dp0" && ( if exist "%temp%\getadmin.vbs" del "%temp%\getadmin.vbs" ) && fsutil dirty query %systemdrive% 1>nul 2>nul || (  echo Set UAC = CreateObject^("Shell.Application"^) : UAC.ShellExecute "cmd.exe", "/k cd ""%~sdp0"" && %~s0 %params%", "", "runas", 1 >> "%temp%\getadmin.vbs" && "%temp%\getadmin.vbs" && exit /B )
del C:\Windows\QuickBoostScript.bat
del C:\Windows\QuickBoostScript.bat
del C:\Windows\QuickBoostScript.bat
del C:\Windows\QuickBoostScript.bat
del C:\Windows\QuickBoostScript.bat
cls
color b
echo QuickBoost by @SanGraphic
echo.
echo   ********     **     ****     **     ********  *******       **     *******  **      ** **   ****** 
echo  **//////     ****   /**/**   /**    **//////**/**////**     ****   /**////**/**     /**/**  **////**
echo /**          **//**  /**//**  /**   **      // /**   /**    **//**  /**   /**/**     /**/** **    // 
echo /*********  **  //** /** //** /**  /**         /*******    **  //** /******* /**********/**/**       
echo ////////** **********/**  //**/**  /**    *****/**///**   **********/**////  /**//////**/**/**       
echo        /**/**//////**/**   //****  //**  ////**/**  //** /**//////**/**      /**     /**/**//**    **
echo  ******** /**     /**/**    //***   //******** /**   //**/**     /**/**      /**     /**/** //****** 
echo ////////  //      // //      ///     ////////  //     // //      // //       //      // //   //////  
echo.
echo.
echo.
Echo Installing Updated Script

echo.
powershell -c "Invoke-WebRequest -Uri 'https://raw.githubusercontent.com/SanGraphic/QuickBoost/main/Script.bat' -OutFile QuickBoostScript.bat 
move /y QuickBoostScript.bat C:\Windows
call C:\Windows\QuickBoostScript.bat
pause
exit