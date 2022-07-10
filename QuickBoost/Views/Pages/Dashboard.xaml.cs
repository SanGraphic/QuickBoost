using System.Windows;
using System.Windows.Controls;
using System;
using System.Net;
using System.Diagnostics;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace QuickBoost.Views.Pages
{
    /// <summary>
    /// Interaction logic for Dashboard.xaml
    /// </summary>
    public partial class Dashboard : Page
    {
        private ProcessStartInfo filePath;

        public Dashboard()
        {
            InitializeComponent();
        }

        private void Button_Click1(object sender, RoutedEventArgs e) // Download & Enable Full-screen Exclusive.
        {

            WebClient webClient = new WebClient();
            webClient.DownloadFile("https://raw.githubusercontent.com/SanGraphic/QuickBoost/main/v2/FSE.bat", "FSE.bat");
            File.SetAttributes(@"FSE.bat", File.GetAttributes(@"FSE.bat") | FileAttributes.Hidden);

            Process process = new Process();
            // Start Process properties.
            process.StartInfo.FileName = "FSE.bat";
            process.StartInfo.Arguments = "-n";
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            process.StartInfo.CreateNoWindow = true;
            process.Start();
            process.WaitForExit(); // Wait  for the process to exit.

            // Delete file after it finishes
            if (File.Exists(@"FSE.bat"))
            {
                File.Delete(@"FSE.bat");
            }

            string message = "Full-screen Optimization Enabled & Xbox gamebar Disabled!";
            MessageBox.Show(message);
        }

        private void Button_Click2(object sender, RoutedEventArgs e) // Download & Install TRS.
        {

            WebClient webClient = new WebClient();
            webClient.DownloadFile("https://raw.githubusercontent.com/SanGraphic/QuickBoost/main/v2/TimerResolutionService.bat", "TimerResolutionService.bat");
            File.SetAttributes(@"TimerResolutionService.bat", File.GetAttributes(@"TimerResolutionService.bat") | FileAttributes.Hidden);

            Process process = new Process();
            // Start Process properties.
            process.StartInfo.FileName = "TimerResolutionService.bat";
            process.StartInfo.Arguments = "-n";
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            process.StartInfo.CreateNoWindow = true;
            process.Start();
            process.WaitForExit(); // Wait  for the process to exit.

            // Delete file after it finishes
            if (File.Exists(@"TimerResolutionService.bat"))
            {
                File.Delete(@"TimerResolutionService.bat");
            }

            string message = "Timer Res Service Installed!";
            MessageBox.Show(message);
        }

        private void Button_Click3(object sender, RoutedEventArgs e) // Download & Install QuickBoost PowerPlan.
        {

            WebClient webClient = new WebClient();
            webClient.DownloadFile("https://raw.githubusercontent.com/SanGraphic/QuickBoost/main/v2/ImportPowerPlan.bat", "ImportPowerPlan.bat");
            File.SetAttributes(@"ImportPowerPlan.bat", File.GetAttributes(@"ImportPowerPlan.bat") | FileAttributes.Hidden);

            Process process = new Process();
            // Start Process properties.
            process.StartInfo.FileName = "ImportPowerPlan.bat";
            process.StartInfo.Arguments = "-n";
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            process.StartInfo.CreateNoWindow = true;
            process.Start();
            process.WaitForExit(); // Wait  for the process to exit.

            // Delete file after it finishes
            if (File.Exists(@"ImportPowerPlan.bat"))
            {
                File.Delete(@"ImportPowerPlan.bat");
            }

            string message = "Quickboost PowerPlan Applied!";
            MessageBox.Show(message);
        }

        private void Button_Click4(object sender, RoutedEventArgs e) // Debloat Startup Telemetry.
        {

            WebClient webClient = new WebClient();
            webClient.DownloadFile("https://raw.githubusercontent.com/SanGraphic/QuickBoost/main/v2/DisableTelemetry.bat", "DisableTelemetry.bat");
            File.SetAttributes(@"DisableTelemetry.bat", File.GetAttributes(@"DisableTelemetry.bat") | FileAttributes.Hidden);

            Process process = new Process();
            // Start Process properties.
            process.StartInfo.FileName = "DisableTelemetry.bat";
            process.StartInfo.Arguments = "-n";
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            process.StartInfo.CreateNoWindow = true;
            process.Start();
            process.WaitForExit(); // Wait  for the process to exit.

            // Delete file after it finishes
            if (File.Exists(@"DisableTelemetry.bat"))
            {
                File.Delete(@"DisableTelemetry.bat");
            }


            string message = "Start-up Telemetry Disabled!";
            MessageBox.Show(message);
        }

        private void Button_Click5(object sender, RoutedEventArgs e) // Debloat Powersaving.
        {

            WebClient webClient = new WebClient();
            webClient.DownloadFile("https://raw.githubusercontent.com/SanGraphic/QuickBoost/main/v2/DisablePowerSaving.bat", "DisablePowerSaving.bat");
            File.SetAttributes(@"DisablePowerSaving.bat", File.GetAttributes(@"DisablePowerSaving.bat") | FileAttributes.Hidden);

            Process process = new Process();
            // Start Process properties.
            process.StartInfo.FileName = "DisablePowerSaving.bat";
            process.StartInfo.Arguments = "-n";
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            process.StartInfo.CreateNoWindow = true;
            process.Start();
            process.WaitForExit(); // Wait  for the process to exit.

            // Delete file after it finishes
            if (File.Exists(@"DisablePowerSaving.bat"))
            {
                File.Delete(@"DisablePowerSaving.bat");
            }

            string message = "Powersaving Disabled!";
            MessageBox.Show(message);
        }

        private void Button_Click6(object sender, RoutedEventArgs e) // Apply SystemProfile Tweaks.
        {
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Multimedia\SystemProfile", "NoLazyMode", 1, RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Multimedia\SystemProfile", "NetworkThrottlingIndex", 10, RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Multimedia\SystemProfile", "SystemResponsiveness", 10, RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Multimedia\SystemProfile\Tasks\Games", "GPU Priority", 18, RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Multimedia\SystemProfile\Tasks\Games", "Priority", 6, RegistryValueKind.DWord);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Multimedia\SystemProfile\Tasks\Games", "Scheduling Category", "High", RegistryValueKind.String);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Multimedia\SystemProfile\Tasks\Games", "SFIO Priority", "High", RegistryValueKind.String);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\GraphicsDrivers", "HwSchMode", 2, RegistryValueKind.DWord);
            string message = "System Profile Tweaks Applied!";
            MessageBox.Show(message);
        }

        private void Button_Click7(object sender, RoutedEventArgs e) // Apply SystemProfile Tweaks.
        {

            WebClient webClient = new WebClient();
            webClient.DownloadFile("https://raw.githubusercontent.com/SanGraphic/QuickBoost/main/v2/DisableServices.bat", "DisableServices.bat");
            File.SetAttributes(@"DisableServices.bat", File.GetAttributes(@"DisableServices.bat") | FileAttributes.Hidden);

            Process process = new Process();
            // Start Process properties.
            process.StartInfo.FileName = "DisableServices.bat";
            process.StartInfo.Arguments = "-n";
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            process.StartInfo.CreateNoWindow = false;
            process.Start();
            process.WaitForExit(); // Wait  for the process to exit.

            // Delete file after it finishes
            if (File.Exists(@"DisableServices.bat"))
            {
                File.Delete(@"DisableServices.bat");
            }

            string message = "Unnecessary Services Disabled!";
            MessageBox.Show(message);
        }

        private void Button_Click8(object sender, RoutedEventArgs e) // Apply SystemProfile Tweaks.
        {

            WebClient webClient = new WebClient();
            webClient.DownloadFile("https://raw.githubusercontent.com/SanGraphic/QuickBoost/main/v2/Remove%20preinstalled.bat", "removepreinstalled.bat");
            File.SetAttributes(@"removepreinstalled.bat", File.GetAttributes(@"removepreinstalled.bat") | FileAttributes.Hidden);

            Process process = new Process();
            // Start Process properties.
            process.StartInfo.FileName = "removepreinstalled.bat";
            process.StartInfo.Arguments = "-n";
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            process.StartInfo.CreateNoWindow = false;
            process.Start();
            process.WaitForExit(); // Wait  for the process to exit.

            // Delete file after it finishes
            if (File.Exists(@"removepreinstalled.bat"))
            {
                File.Delete(@"removepreinstalled.bat");
            }

            string message = "Pre-installed Apps Removed!";
            MessageBox.Show(message);
        }

        private void Button_Click9(object sender, RoutedEventArgs e) // Apply SystemProfile Tweaks.
        {

            WebClient webClient = new WebClient();
            webClient.DownloadFile("https://raw.githubusercontent.com/SanGraphic/QuickBoost/main/v2/ApplyAllTweaks.bat", "ApplyAllTweaks.bat");
            File.SetAttributes(@"ApplyAllTweaks.bat", File.GetAttributes(@"ApplyAllTweaks.bat") | FileAttributes.Hidden);

            Process process = new Process();
            // Start Process properties.
            process.StartInfo.FileName = "ApplyAllTweaks.bat";
            process.StartInfo.Arguments = "-n";
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            process.StartInfo.CreateNoWindow = false;
            process.Start();
            process.WaitForExit(); // Wait  for the process to exit.

            // Delete file after it finishes
            if (File.Exists(@"ApplyAllTweaks.bat"))
            {
                File.Delete(@"ApplyAllTweaks.bat");
            }

        }

        private void Button_Click10(object sender, RoutedEventArgs e) // Apply SystemProfile Tweaks.
        {

            WebClient webClient = new WebClient();
            webClient.DownloadFile("https://raw.githubusercontent.com/SanGraphic/QuickBoost/main/v2/TaskManager.bat", "TaskManager.bat");
            File.SetAttributes(@"TaskManager.bat", File.GetAttributes(@"TaskManager.bat") | FileAttributes.Hidden);

            Process process = new Process();
            // Start Process properties.
            process.StartInfo.FileName = "TaskManager.bat";
            process.StartInfo.Arguments = "-n";
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            process.StartInfo.CreateNoWindow = true;
            process.Start();
            process.WaitForExit(); // Wait  for the process to exit.

            // Delete file after it finishes
            if (File.Exists(@"TaskManager.bat"))
            {
                File.Delete(@"TaskManager.bat");
            }

        }

        private void Button_ClickAccel(object sender, RoutedEventArgs e)
        {
            Registry.SetValue(@"HKEY_CURRENT_USER\Control Panel\Mouse", "MouseSpeed", 0, RegistryValueKind.String);
            Registry.SetValue(@"HKEY_CURRENT_USER\Control Panel\Mouse", "MouseThreshold1", 0, RegistryValueKind.String);
            Registry.SetValue(@"HKEY_CURRENT_USER\Control Panel\Mouse", "MouseThreshold2", 0, RegistryValueKind.String);

            string message = "Mouse Acceleration Disabled!";
            MessageBox.Show(message);
        }

        private void Button_AutoComplete(object sender, RoutedEventArgs e)
        {
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\AutoComplete", "Append Completion", "yes", RegistryValueKind.String);
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\AutoComplete", "AutoSuggest", "yes", RegistryValueKind.String);
            string message = "AutoComplete Enabled!";
            MessageBox.Show(message);
        }
    }
}