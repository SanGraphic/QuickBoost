using System.Windows;
using System.Windows.Controls;
using System;
using System.Net;
using System.Diagnostics;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using System.Linq;
namespace QuickBoost.Views.Pages
{
    /// <summary>
    /// Interaction logic for Cleanup.xaml
    /// </summary>
    public partial class Cleanup : Page
    {
        public Cleanup()
        {
            InitializeComponent();
        }

        private void Button_Click1(object sender, System.Windows.RoutedEventArgs e)
        {
            WebClient webClient = new WebClient();
            webClient.DownloadFile("https://raw.githubusercontent.com/SanGraphic/QuickBoost/main/v2/Clean-up/ClearTempFiles.bat", "ClearTempFiles.bat");
            File.SetAttributes(@"ClearTempFiles.bat", File.GetAttributes(@"ClearTempFiles.bat") | FileAttributes.Hidden);

            Process process = new Process();
            // Start Process properties.
            process.StartInfo.FileName = "ClearTempFiles.bat";
            process.StartInfo.Arguments = "-n";
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            process.StartInfo.CreateNoWindow = false;
            process.Start();
            process.WaitForExit(); // Wait  for the process to exit.

            // Delete file after it finishes
            if (File.Exists(@"ClearTempFiles.bat"))
            {
                File.Delete(@"ClearTempFiles.bat");
            }
        }

        private void Button_Click2(object sender, System.Windows.RoutedEventArgs e)
        {
            WebClient webClient = new WebClient();
            webClient.DownloadFile("https://raw.githubusercontent.com/SanGraphic/QuickBoost/main/v2/Clean-up/ClearLogFiles.bat", "ClearLogFiles.bat");
            File.SetAttributes(@"ClearLogFiles.bat", File.GetAttributes(@"ClearLogFiles.bat") | FileAttributes.Hidden);

            Process process = new Process();
            // Start Process properties.
            process.StartInfo.FileName = "ClearLogFiles.bat";
            process.StartInfo.Arguments = "-n";
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            process.StartInfo.CreateNoWindow = false;
            process.Start();
            process.WaitForExit(); // Wait  for the process to exit.

            // Delete file after it finishes
            if (File.Exists(@"ClearLogFiles.bat"))
            {
                File.Delete(@"ClearLogFiles.bat");
            }
        }

        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            WebClient webClient = new WebClient();
            webClient.DownloadFile("https://raw.githubusercontent.com/SanGraphic/QuickBoost/main/v2/Clean-up/RunCleanmgr.bat", "RunCleanmgr.bat");
            File.SetAttributes(@"RunCleanmgr.bat", File.GetAttributes(@"RunCleanmgr.bat") | FileAttributes.Hidden);

            Process process = new Process();
            // Start Process properties.
            process.StartInfo.FileName = "RunCleanmgr.bat";
            process.StartInfo.Arguments = "-n";
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            process.StartInfo.CreateNoWindow = true;
            process.Start();
            process.WaitForExit(); // Wait  for the process to exit.

            // Delete file after it finishes
            if (File.Exists(@"RunCleanmgr.bat"))
            {
                File.Delete(@"RunCleanmgr.bat");
            }
        }

        private void Button_Click4(object sender, RoutedEventArgs e)
        {
            WebClient webClient = new WebClient();
            webClient.DownloadFile("https://raw.githubusercontent.com/SanGraphic/QuickBoost/main/v2/Clean-up/CleanUpAll.bat", "CleanUpAll.bat");
            File.SetAttributes(@"CleanUpAll.bat", File.GetAttributes(@"CleanUpAll.bat") | FileAttributes.Hidden);

            Process process = new Process();
            // Start Process properties.
            process.StartInfo.FileName = "CleanUpAll.bat";
            process.StartInfo.Arguments = "-n";
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            process.StartInfo.CreateNoWindow = false;
            process.Start();
            process.WaitForExit(); // Wait  for the process to exit.

            // Delete file after it finishes
            if (File.Exists(@"CleanUpAll.bat"))
            {
                File.Delete(@"CleanUpAll.bat");
            }
        }

        private void ProgressBar_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }
    }
}
