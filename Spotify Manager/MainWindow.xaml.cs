using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Spotify_Manager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public static string spotifyPath = Environment.GetEnvironmentVariable("APPDATA") + "\\Spotify";

        private void BtnZHCN_Click(object sender, RoutedEventArgs e)
        {
            StreamWriter sw = new StreamWriter(spotifyPath + "\\prefs", true);
            sw.WriteLine("language=\"zh-cn\"");
            sw.Close();
            BtnZHCN.Foreground = Brushes.Green;
        }

        private void BtnZHTW_Click(object sender, RoutedEventArgs e)
        {
            StreamWriter sw = new StreamWriter(spotifyPath + "\\prefs", true);
            sw.WriteLine("language=\"zh-tw\"");
            sw.Close();
            BtnZHTW.Foreground = Brushes.Green;
        }

        private void BtnEN_Click(object sender, RoutedEventArgs e)
        {
            StreamWriter sw = new StreamWriter(spotifyPath + "\\prefs", true);
            sw.WriteLine("language=\"en\"");
            sw.Close();
            BtnEN.Foreground = Brushes.Green;
        }

        private void BtnFont_Click(object sender, RoutedEventArgs e)
        {
            byte[] b = Properties.Resources.xpui;
            Stream s = File.Create(spotifyPath + "\\Apps\\xpui.spa");
            s.Write(b, 0, b.Length);
            s.Close();
            BtnFont.Foreground = Brushes.Green;
        }

        private void BtnAuto_Click(object sender, RoutedEventArgs e)
        {
            BtnZHCN_Click(null, null);
            BtnFont_Click(null, null);
            BtnAuto.Foreground = Brushes.Green;
        }
    }
}
