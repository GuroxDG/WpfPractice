using System.Windows;

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
        }

        private void Btn_OnClick(object sender, RoutedEventArgs e)
        {
            AboutUs window = new AboutUs();
            window.Show();
        }
    }
}











