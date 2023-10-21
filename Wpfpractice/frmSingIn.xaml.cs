using System;
using System.Windows;

namespace Wpfpractice;

public partial class frmSingIn : Window
{
    public frmSingIn()
    {
        InitializeComponent();
    }

    private void FrmSingIn_OnClosed(object? sender, EventArgs e)
    {
        if (MessageBox.Show("Are you sure to exit ?",
                "Hola",
                MessageBoxButton.OKCancel,
                MessageBoxImage.Question,
                MessageBoxResult.Cancel) == MessageBoxResult.Cancel)
        {
            Application.Current.Shutdown ();
        }
        else
        {
            this.Close();
        }
        
    }
}