using System.Windows;
using System.Windows.Controls;

namespace Wpfpractice;

public partial class FrmDinamic : Window
{
    public FrmDinamic()
    {
        InitializeComponent();

        TextBlock textBlock = new TextBlock();
        textBlock.Text = "Personal Information";
        textBlock.Margin = new Thickness(28, 15, 0, 0);
        MainGrid.Children.Add(textBlock);
    }
}