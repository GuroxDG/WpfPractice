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
using Microsoft.Win32;
using System.Drawing;
using System.Windows;
using System.Windows.Interop;

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
            //MessageBox.Show("cambios");
            //this.BtnPlay.SetResourceReference(BackgroundProperty, "Brush"); 
        }

        private void MainWindow_OnActivated(object sender, EventArgs e)
        {
            //Box.Items.Add("punto1");
            //Box.Items.Add("punto2");
            //Box.Items.Add("punto3");
        }

        private void BtnOpenPdf_OnClick(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos PDF (*.pdf)|*.pdf";

            if (openFileDialog.ShowDialog() == true)
            {
                string pdfPath = openFileDialog.FileName;
                
                MessageBox.Show(pdfPath, "Informacion");
            }
        }
            
        
    }
}











