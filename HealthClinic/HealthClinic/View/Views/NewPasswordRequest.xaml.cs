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

namespace HealthClinic.Views
{
    /// <summary>
    /// Interaction logic for NewPasswordRequest.xaml
    /// </summary>
    public partial class NewPasswordRequest : UserControl
    {
        public NewPasswordRequest()
        {
            InitializeComponent();
        }

        private void NPRPotvrdiButton_Click(object sender, RoutedEventArgs e)
        {
            NewPasswordRequesGrid.Children.Clear();
            UserControl usc = new NewPasswordConfirm();
            NewPasswordRequesGrid.Children.Add(usc);
        }

        private void NPRBackButton_Click(object sender, RoutedEventArgs e)
        {
            NewPasswordRequesGrid.Children.Clear();
            UserControl usc = new Login();
            NewPasswordRequesGrid.Children.Add(usc);
        }
    }
}
