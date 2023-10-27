using System;
using System.IO;
using System.Windows;
using System.Media;

namespace Wpfpractice
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
            SplashScreen splashScreen = new SplashScreen("gurox.png");
            splashScreen.Show(true,true);
            splashScreen.Close(TimeSpan.FromSeconds(2));
        }

        private void Btn_OnClick(object sender, RoutedEventArgs e)
        {
            AboutUs window = new AboutUs();
            window.Show();
        }

        private void BtnSingIn_OnClick(object sender, RoutedEventArgs e)
        {
            FrmSingIn window = new FrmSingIn();
            window.Show();
        }

        private void BtnDinamic_OnClick(object sender, RoutedEventArgs e)
        {
            FrmDinamic window = new FrmDinamic();
            window.Show();
        }

        private void BtnControls_OnClick(object sender, RoutedEventArgs e)
        {
            FrmControls window = new FrmControls();
            window.Show();
        }

        private void BtnCalendar_OnClick(object sender, RoutedEventArgs e)
        {
            FrmCalendar window = new FrmCalendar();
            window.Show();
        }
    }
}











