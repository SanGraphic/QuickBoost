@Echo off
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