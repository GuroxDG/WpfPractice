using System.IO;
using System.Windows;
using System.Windows.Input;

namespace Wpfpractice;

public partial class FrmCalendar : Window
{
    public FrmCalendar()
    {
        InitializeComponent();
    }

    private void Calendar1_OnMouseDoubleClick(object sender, MouseButtonEventArgs e)
    {
        ListBox1.Items.Clear();
        Label1.Content = Calendar1.SelectedDate?.ToString("yy-MM-dd");

        foreach ( FileInfo fileInfo in new DirectoryInfo("C:\\").GetFiles())
        {
            if (fileInfo.CreationTime.Year==Calendar1.SelectedDate?.Year)
            {
                ListBox1.Items.Add(fileInfo.Name);
            }
        }
        
    }
}