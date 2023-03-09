using System.Windows;
using System.Windows.Controls;
using System;
using System.Net;
using System.Diagnostics;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace QuickBoost.Views
{
    /// <summary>
    /// Interaction logic for Container.xaml
    /// </summary>
    public partial class Container : Window
    {
        public Container()
        {

            InitializeComponent();

            

            WPFUI.Appearance.Background.Apply(
                this,
                WPFUI.Appearance.BackgroundType.Mica);

            WPFUI.Appearance.Accent.Apply(
                WPFUI.Appearance.Accent.GetColorizationColor(),
                WPFUI.Appearance.ThemeType.Dark);

            WebClient webClient = new WebClient();

            try
            {
                if (!webClient.DownloadString("https://raw.githubusercontent.com/SanGraphic/QuickBoost/main/v2/version.txt").Contains("2.9.4"))
                {
                    string message = "New Update Available, click OK to Open the download link";
                    MessageBox.Show(message);
                    Process.Start(@"C:\Windows\explorer.exe", "https://github.com/SanGraphic/QuickBoost/releases");
                }
            }
            catch
            {

            }

            string message2 = "⚠️ Please make a System Restore Point, This program is tested by hundreds of volunteers and community members, but I'm not resposnible if you break your OS!";
            MessageBox.Show(message2);
            

        }
    }
}