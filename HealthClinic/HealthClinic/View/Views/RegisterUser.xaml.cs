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
    /// Interaction logic for RegisterUser.xaml
    /// </summary>
    public partial class RegisterUser : UserControl
    {
        public RegisterUser()
        {
            InitializeComponent();
        }

        private void RegistracijaBackButton_Click(object sender, RoutedEventArgs e)
        {
            RegisterUserGrid.Children.Clear();
            Window window = new MainWindow();
            //RegisterUserGrid = window;
        }

        private void RegistrujSeButton_Click(object sender, RoutedEventArgs e)
        {
            RegisterUserGrid.Children.Clear();
            UserControl usc = new Login();
            RegisterUserGrid.Children.Add(usc);
        }
    }
}
