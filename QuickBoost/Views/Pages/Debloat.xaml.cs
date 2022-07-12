using System.Windows;
using System.Windows.Controls;
using System;
using System.Net;
using System.Diagnostics;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Win32;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace QuickBoost.Views.Pages
{
    /// <summary>
    /// Interaction logic for Debloat.xaml
    /// </summary>
    public partial class Debloat : Page
    {
        public Debloat()
        {
            InitializeComponent();
        }

        private void OldContext(object sender, RoutedEventArgs e)
        {
            Registry.SetValue("HKEY_CURRENT_USER\\Software\\Classes\\CLSID\\{86ca1aa0-34aa-4e8b-a509-50c905bae2a2}\\InprocServer32", "", "");
            string message = "Windows 10 Style Context Menu Applied!";
            MessageBox.Show(message);
            Process p = new Process();
            foreach (Process exe in Process.GetProcesses())
            {
                if (exe.ProcessName == "explorer")
                    exe.Kill();
            }
            Process.Start("explorer.exe");
        }

        private void NewContext(object sender, RoutedEventArgs e)
        {
            ProcessStartInfo contextdel = new ProcessStartInfo("WT.exe");
            contextdel.UseShellExecute = true;
            contextdel.Arguments = "REG DELETE \"HKCU\\Software\\Classes\\CLSID\\{86ca1aa0-34aa-4e8b-a509-50c905bae2a2}\" /f";
            Process.Start(contextdel);
            string message = "Windows 11 Style Context Menu Applied!";
            MessageBox.Show(message);
        }

        private void HiddenFolders(object sender, RoutedEventArgs e)
        {
            Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", "Hidden", "00000001", RegistryValueKind.DWord);
            string message = "Hidden Folders Visible now!";
            MessageBox.Show(message);
        }

        private void HideHiddenFolders(object sender, RoutedEventArgs e)
        {
            Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", "Hidden", "00000000", RegistryValueKind.DWord);
            string message = "Hidden Folders Invisible now!";
            MessageBox.Show(message);
        }

        private void Extensions(object sender, RoutedEventArgs e)
        {
            Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", "HideFileExt", "00000000", RegistryValueKind.DWord);
            string message = "File Extensions visible now!";
            MessageBox.Show(message);
        }

        private void HideExtensions(object sender, RoutedEventArgs e)
        {
            Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", "HideFileExt", "00000001", RegistryValueKind.DWord);
            string message = "File Extensions invisible now!";
            MessageBox.Show(message);
        }

        private void EnableNoti(object sender, RoutedEventArgs e)
        {
            Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\PushNotifications", "ToastEnabled", "00000001", RegistryValueKind.DWord);

            ProcessStartInfo restartService = new ProcessStartInfo("powershell.exe");
            restartService.Arguments = "Restart-Service -DisplayName 'Windows Push Notifications User Service*'";
            restartService.CreateNoWindow = true;
            Process.Start(restartService);
            string message = "Notifications Enabled!";
            MessageBox.Show(message);
        }

        private void DisableNoti(object sender, RoutedEventArgs e)
        {
            Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\PushNotifications", "ToastEnabled", "00000000", RegistryValueKind.DWord);

            ProcessStartInfo restartService = new ProcessStartInfo("powershell.exe");
            restartService.Arguments = "Restart-Service -DisplayName 'Windows Push Notifications User Service*'";
            restartService.CreateNoWindow = true;
            Process.Start(restartService);
            string message = "Notifications Disabled!";
            MessageBox.Show(message);
        }

        private void ClipON(object sender, RoutedEventArgs e)
        {
            Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Clipboard", "EnableClipboardHistory", "00000001", RegistryValueKind.DWord);
            string message = "Clipboard History Enabled!";
            MessageBox.Show(message);
        }

        private void ClipOFF(object sender, RoutedEventArgs e)
        {
            Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Clipboard", "EnableClipboardHistory", "00000000", RegistryValueKind.DWord);
            string message = "Clipboard History Disabled!";
            MessageBox.Show(message);
        }

        private void TransparencyON(object sender, RoutedEventArgs e)
        {
            Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Themes\\Personalize", "EnableTransparency", "00000001", RegistryValueKind.DWord);
            string message = "Transparency Effects Enabled!";
            MessageBox.Show(message);
        }

        private void TransparencyOFF(object sender, RoutedEventArgs e)
        {
            Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Themes\\Personalize", "EnableTransparency", "00000000", RegistryValueKind.DWord);
            string message = "Transparency Effects Disabled!";
            MessageBox.Show(message);
        }
    }
}
