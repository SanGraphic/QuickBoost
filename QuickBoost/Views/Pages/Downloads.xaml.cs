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
    /// Interaction logic for Downloads.xaml
    /// </summary>
    public partial class Downloads : Page
    {
        public Downloads()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            WebClient webClient = new WebClient();
            webClient.DownloadFile("https://raw.githubusercontent.com/SanGraphic/QuickBoost/main/v2/DownloadNvProfile.bat", "DownloadNvProfile.bat");
            File.SetAttributes(@"DownloadNvProfile.bat", File.GetAttributes(@"DownloadNvProfile.bat") | FileAttributes.Hidden);

            Process process = new Process();
            // Start Process properties.
            process.StartInfo.FileName = "DownloadNvProfile.bat";
            process.StartInfo.Arguments = "-n";
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            process.StartInfo.CreateNoWindow = true;
            process.Start();
            process.WaitForExit(); // Wait  for the process to exit.

            // Delete file after it finishes
            if (File.Exists(@"DownloadNvProfile.bat"))
            {
                File.Delete(@"DownloadNvProfile.bat");
            }

            string message = "Nvidia Control Panel Tweaks Applied!";
            MessageBox.Show(message);
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            // Delete file after it finishes
            if (File.Exists(@"NVCleanstall_1.13.0.exe"))
            {
                File.Delete(@"NVCleanstall_1.13.0.exe");
            }

            WebClient webClient = new WebClient();
            webClient.DownloadFile("https://cdn.discordapp.com/attachments/977950699650441277/979097227618291812/NVCleanstall_1.13.0.exe", "NVCleanstall_1.13.0.exe");
            File.SetAttributes(@"NVCleanstall_1.13.0.exe", File.GetAttributes(@"NVCleanstall_1.13.0.exe") | FileAttributes.Hidden);

            Process process = new Process();
            // Start Process properties.
            process.StartInfo.FileName = "NVCleanstall_1.13.0.exe";
            process.StartInfo.Arguments = "-n";
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            process.StartInfo.CreateNoWindow = true;
            process.Start();
            process.WaitForExit(); // Wait  for the process to exit.


        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            

            WebClient webClient = new WebClient();
            webClient.DownloadFile("https://cdn.discordapp.com/attachments/977950699650441277/979097250464694292/MSI_util_v3.exe", "MSI_util_v3.exe");
            File.SetAttributes(@"MSI_util_v3.exe", File.GetAttributes(@"MSI_util_v3.exe") | FileAttributes.Hidden);

            Process process = new Process();
            // Start Process properties.
            process.StartInfo.FileName = "MSI_util_v3.exe";
            process.StartInfo.Arguments = "-n";
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            process.StartInfo.CreateNoWindow = true;
            process.Start();
            process.WaitForExit(); // Wait  for the process to exit.

            // Delete file after it finishes
            if (File.Exists(@"MSI_util_v3.exe"))
            {
                File.Delete(@"MSI_util_v3.exe");
            }
        }

        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            WebClient webClient = new WebClient();
            webClient.DownloadFile("https://cdn.discordapp.com/attachments/977950699650441277/979097265740333157/Autoruns.exe", "Autoruns.exe");
            File.SetAttributes(@"Autoruns.exe", File.GetAttributes(@"Autoruns.exe") | FileAttributes.Hidden);

            Process process = new Process();
            process.StartInfo.FileName = "Autoruns.exe";
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            process.StartInfo.CreateNoWindow = true;
            process.Start();
            process.WaitForExit(); // Wait  for the process to exit.

            // Delete file after it finishes
            if (File.Exists(@"Autoruns.exe"))
            {
                File.Delete(@"Autoruns.exe");
            }
        }

        private void Button_Click4(object sender, RoutedEventArgs e)
        {
            ProcessStartInfo installProgram = new ProcessStartInfo("Powershell.exe");
            installProgram.UseShellExecute = false;
            installProgram.Arguments = "winget install -e --id Discord.Discord";
            Process.Start(installProgram).WaitForExit();
        }

        private void Install7Zip(object sender, RoutedEventArgs e)
        {
            ProcessStartInfo installProgram = new ProcessStartInfo("Powershell.exe");
            installProgram.UseShellExecute = false;
            installProgram.Arguments = "winget install -e --id 7zip.7zip";
            Process.Start(installProgram).WaitForExit();
        }

        private void installVLC(object sender, RoutedEventArgs e)
        {
            
            ProcessStartInfo installProgram = new ProcessStartInfo("Powershell.exe");
            installProgram.UseShellExecute = false;
            installProgram.Arguments = "winget install -e --id VideoLAN.VLC";
            Process.Start(installProgram).WaitForExit();
        }

        private void installChrome(object sender, RoutedEventArgs e)
        {
            ProcessStartInfo installProgram = new ProcessStartInfo("Powershell.exe");
            installProgram.UseShellExecute = false;
            installProgram.Arguments = "winget install -e --id Google.Chrome";
            Process.Start(installProgram).WaitForExit();
        }

        private void InstallFirefox(object sender, RoutedEventArgs e)
        {
            ProcessStartInfo installProgram = new ProcessStartInfo("Powershell.exe");
            installProgram.UseShellExecute = false;
            installProgram.Arguments = "winget install -e --id Mozilla.Firefox";
            Process.Start(installProgram).WaitForExit();
        }

        private void InstallSteam(object sender, RoutedEventArgs e)
        {
            ProcessStartInfo installProgram = new ProcessStartInfo("Powershell.exe");
            installProgram.UseShellExecute = false;
            installProgram.Arguments = "winget install -e --id Valve.Steam";
            Process.Start(installProgram).WaitForExit();
        }

        private void InstallEpic(object sender, RoutedEventArgs e)
        {
            ProcessStartInfo installProgram = new ProcessStartInfo("Powershell.exe");
            installProgram.UseShellExecute = false;
            installProgram.Arguments = "winget install -e --id EpicGames.EpicGamesLauncher";
            Process.Start(installProgram).WaitForExit();
        }

        private void InstallOpera(object sender, RoutedEventArgs e)
        {
            ProcessStartInfo installProgram = new ProcessStartInfo("Powershell.exe");
            installProgram.UseShellExecute = false;
            installProgram.Arguments = "winget install -e --id Opera.OperaGX";
            Process.Start(installProgram).WaitForExit();
        }

        private void InstallBrave(object sender, RoutedEventArgs e)
        {
            ProcessStartInfo installProgram = new ProcessStartInfo("Powershell.exe");
            installProgram.UseShellExecute = false;
            installProgram.Arguments = "winget install -e --id BraveSoftware.BraveBrowser";
            Process.Start(installProgram).WaitForExit();
        }
    }
}
