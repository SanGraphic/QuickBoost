using System.Windows;
using System.Windows.Controls;
using System;
using System.Net;
using System.Diagnostics;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.Win32;

namespace QuickBoost.Views.Pages
{
    /// <summary>
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            WebClient webClient = new WebClient();
            webClient.DownloadFile("https://raw.githubusercontent.com/SanGraphic/QuickBoost/main/v2/Advanced/DisablePowerThrottling.bat", "DisablePowerThrottling.bat");
            File.SetAttributes(@"DisablePowerThrottling.bat", File.GetAttributes(@"DisablePowerThrottling.bat") | FileAttributes.Hidden);

            Process process = new Process();
            // Start Process properties.
            process.StartInfo.FileName = "DisablePowerThrottling.bat";
            process.StartInfo.Arguments = "-n";
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            process.StartInfo.CreateNoWindow = true;
            process.Start();
            process.WaitForExit(); // Wait  for the process to exit.

            // Delete file after it finishes
            if (File.Exists(@"DisablePowerThrottling.bat"))
            {
                File.Delete(@"DisablePowerThrottling.bat");
            }

            string message = "PowerThrottling Disabled!";
            MessageBox.Show(message);

        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            WebClient webClient = new WebClient();
            webClient.DownloadFile("https://raw.githubusercontent.com/SanGraphic/QuickBoost/main/v2/Advanced/SvcHost.bat", "SvcHost.bat");
            File.SetAttributes(@"SvcHost.bat", File.GetAttributes(@"SvcHost.bat") | FileAttributes.Hidden);

            Process process = new Process();
            // Start Process properties.
            process.StartInfo.FileName = "SvcHost.bat";
            process.StartInfo.Arguments = "-n";
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            process.StartInfo.CreateNoWindow = false;
            process.Start();
            process.WaitForExit(); // Wait  for the process to exit.

            // Delete file after it finishes
            if (File.Exists(@"SvcHost.bat"))
            {
                File.Delete(@"SvcHost.bat");
            }

            string message = "SvcHostSplitThreshold Memory Tweaks Applied!";
            MessageBox.Show(message);
        }

        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            WebClient webClient = new WebClient();
            webClient.DownloadFile("https://raw.githubusercontent.com/SanGraphic/QuickBoost/main/v2/MemoryTweaks.bat", "MemoryTweaks.bat");
            File.SetAttributes(@"MemoryTweaks.bat", File.GetAttributes(@"MemoryTweaks.bat") | FileAttributes.Hidden);

            Process process = new Process();
            // Start Process properties.
            process.StartInfo.FileName = "MemoryTweaks.bat";
            process.StartInfo.Arguments = "-n";
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            process.StartInfo.CreateNoWindow = false;
            process.Start();
            process.WaitForExit(); // Wait  for the process to exit.

            // Delete file after it finishes
            if (File.Exists(@"MemoryTweaks.bat"))
            {
                File.Delete(@"MemoryTweaks.bat");
            }

            string message = "Memory Tweaks Applied!";
            MessageBox.Show(message);
        }

        private void Button_Click4(object sender, RoutedEventArgs e)
        {
            WebClient webClient = new WebClient();
            webClient.DownloadFile("https://raw.githubusercontent.com/SanGraphic/QuickBoost/main/v2/Advanced/HardwareDataQueueSize.bat", "HardwareDataQueueSize.bat");
            File.SetAttributes(@"HardwareDataQueueSize.bat", File.GetAttributes(@"HardwareDataQueueSize.bat") | FileAttributes.Hidden);

            Process process = new Process();
            // Start Process properties.
            process.StartInfo.FileName = "HardwareDataQueueSize.bat";
            process.StartInfo.Arguments = "-n";
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            process.StartInfo.CreateNoWindow = false;
            process.Start();
            process.WaitForExit(); // Wait  for the process to exit.

            // Delete file after it finishes
            if (File.Exists(@"HardwareDataQueueSize.bat"))
            {
                File.Delete(@"HardwareDataQueueSize.bat");
            }

            string message = "HardwareDataQueueSize Latency Tweaks Applied!";
            MessageBox.Show(message);
        }

        private void Button_Click5(object sender, RoutedEventArgs e)
        {
            WebClient webClient = new WebClient();
            webClient.DownloadFile("https://raw.githubusercontent.com/SanGraphic/QuickBoost/main/v2/Advanced/BcdTweaks.bat", "BcdTweaks.bat");
            File.SetAttributes(@"BcdTweaks.bat", File.GetAttributes(@"BcdTweaks.bat") | FileAttributes.Hidden);

            Process process = new Process();
            // Start Process properties.
            process.StartInfo.FileName = "BcdTweaks.bat";
            process.StartInfo.Arguments = "-n";
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            process.StartInfo.CreateNoWindow = false;
            process.Start();
            process.WaitForExit(); // Wait  for the process to exit.

            // Delete file after it finishes
            if (File.Exists(@"BcdTweaks.bat"))
            {
                File.Delete(@"BcdTweaks.bat");
            }

            string message = "Bcd Latency Tweaks Applied!";
            MessageBox.Show(message);
        }

        private void DisablePreemption(object sender, RoutedEventArgs e)
        {
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\GraphicsDrivers\Scheduler", "EnablePreemption", 0, RegistryValueKind.DWord);
            
            string message = "Preemption Disabled!";
            MessageBox.Show(message);
        }

        private void EnablePreemption(object sender, RoutedEventArgs e)
        {
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\GraphicsDrivers\Scheduler", "EnablePreemption", 1, RegistryValueKind.DWord);

            string message = "Preemption Enabled!";
            MessageBox.Show(message);
        }

        private void PstateH(object sender, RoutedEventArgs e)
        {
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000", "DisableDynamicPstate", 1, RegistryValueKind.DWord);

            string message = "Highest PState Applied!";
            MessageBox.Show(message);
        }

        private void PstateL(object sender, RoutedEventArgs e)
        {
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Class\{4d36e968-e325-11ce-bfc1-08002be10318}\0000", "DisableDynamicPstate", 0, RegistryValueKind.DWord);

            string message = "Highest PState Disabled!";
            MessageBox.Show(message);
        }
    }
}
