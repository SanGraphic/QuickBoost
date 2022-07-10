using System.Windows.Controls;
using System.Diagnostics;
using System.Windows.Navigation;
using System;
using System.Windows;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace QuickBoost.Views.Pages
{
    /// <summary>
    /// Interaction logic for Settings.xaml
    /// </summary>
    public partial class Settings : Page
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Windows\explorer.exe", "https://github.com/SanGraphic/QuickBoost");
        }

        private void Button_Click1(object sender, EventArgs e)
        {
            Process.Start(@"C:\Windows\explorer.exe", "https://Twitter.com/SanGraphicAlt");
        }

    }
}