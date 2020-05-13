using HealthClinic.View;
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

namespace HealthClinic
{
    /// <summary>
    /// Interaction logic for UserControlForgotPassword.xaml
    /// </summary>
    public partial class UserControlForgotPassword : UserControl
    {
        public UserControlForgotPassword()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            mw.Show();
            Window.GetWindow(this).Close();
        }

        private void confirmBtn_Click(object sender, RoutedEventArgs e)
        {
            GridForgotPassword.Children.Clear();
            UserControl usc = new NotificationForPassword();
            GridForgotPassword.Children.Add(usc);
        }
    }
}
