using System;
using System.Collections.Generic;
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
using System.Windows.Resources;

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

        private void PnlMainGrid_OnMouseUp(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("you clicked"+e.GetPosition(this).ToString());
        }

        private void BtnPlay_OnClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("cambios");
            this.btnPlay.SetResourceReference(BackgroundProperty, "brush"); 
        }
    }
}











