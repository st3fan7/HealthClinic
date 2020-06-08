using HealthClinic.View;
using System.Windows;
using System.Windows.Controls;

namespace HealthClinic
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            textWarningUsername.Visibility = textWarningHidden;
            textWarningPassword.Visibility = textWarningHidden;
        }


        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void forgotPasswordBtn_Click(object sender, RoutedEventArgs e)
        {
            UserControl usc = new UserControlForgotPassword();
            GridMain.Children.Add(usc);
        }

        private void loginBtn_Click(object sender, RoutedEventArgs e)
        {

            if (!usernameTextBox.Text.Equals("ana")) {
                textWarningUsername.Visibility = textWarningVisible;
                return;
            }

            if (!passwordTextBox.Password.ToString().Equals("123"))
            {
                textWarningPassword.Visibility = textWarningVisible;
                return;
            }
            UserControl usc = new Home();
            GridMain.Children.Add(usc);
            
       
        }
        private Visibility textWarningVisible
        {
            get { return Visibility.Visible; }
        }
        private Visibility textWarningHidden
        {
            get { return Visibility.Hidden; }
        }

        private void usernameTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
                textWarningUsername.Visibility = textWarningHidden;          
        }

        private void passwordTextBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            textWarningPassword.Visibility = textWarningHidden;
        }
    }
}
