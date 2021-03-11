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

namespace MicrosoftTutoria.WPF
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

        private void ButtonAddName_Click(object sender, RoutedEventArgs e)
        {
            txtError.Content = "";

            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                txtError.Content = "Error! Input empty!";
            }
            else if (lstNames.Items.Contains(txtName.Text))
            { 
                txtError.Content = "Error! Name already in list!";
            } else
            {
                lstNames.Items.Add(txtName.Text);
                txtName.Text = "";
            }
        }

        private void ButtonRemoveName_Click(object sender, RoutedEventArgs e)
        {
            txtError.Content = "";

            if (lstNames.SelectedItem != null)
                lstNames.Items.Remove(lstNames.SelectedItem);
            else
                txtError.Content = "Error! No name selected in list!";
        }
    }
}
