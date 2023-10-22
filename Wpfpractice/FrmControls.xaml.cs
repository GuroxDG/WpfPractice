using System.Windows;
using System.Windows.Controls;

namespace Wpfpractice;

public partial class FrmControls : Window
{
    public FrmControls()
    {
        InitializeComponent();
        ComboBox1.Items.Add(("A001", "New York"));
    }

    private void Window_loaded(object sender, RoutedEvent e)
    {
        MessageBox.Show("hola");
    }

}