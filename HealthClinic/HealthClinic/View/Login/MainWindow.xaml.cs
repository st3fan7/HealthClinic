using HealthClinic.View;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace HealthClinic
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //public static ObservableCollection<Secretary> secreatries = new ObservableCollection<Secretary>();
        
        public MainWindow()
        {
            InitializeComponent();
            //secreatries.Add(new Secretary("ana", "123123123", "Ana", "Anić", "12121987435012", "12/12/1987", "Niš", "Republika Srbija", "Niš, Niška 2", "062/789-123", "ana@gmail.com"));

            usernameTextBox.Focus();
            usernameTextBox.SelectAll();
            textWarningUsername.Visibility = textWarningHidden;
            textWarningPassword.Visibility = textWarningHidden;
        }


        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }

        private void forgotPasswordBtn_Click(object sender, RoutedEventArgs e)
        {
            UserControl usc = new UserControlForgotPassword();
            GridMain.Children.Add(usc);
        }

        private void loginBtn_Click(object sender, RoutedEventArgs e)
        {
            var bc = new BrushConverter();
            var thic = new ThicknessConverter();

            //foreach(Secretary secretary in secreatries)
            //{
            //    if (usernameTextBox.Text.Equals(secretary.Username))
            //    {
            //        if (passwordTextBox.Password.ToString().Equals(secretary.Password))
            //        {
            UserControl usc = new Home();
            GridMain.Children.Add(usc);
            //        }
            //        else
            //        {
            //            textWarningPassword.Visibility = textWarningVisible;
            //            passwordTextBox.BorderBrush = (Brush)bc.ConvertFrom("#FF761616");
            //            passwordTextBox.BorderThickness = (Thickness)thic.ConvertFrom("3");
            //            loginBtn.BorderBrush = (Brush)bc.ConvertFrom("#FF761616");
            //            loginBtn.BorderThickness = (Thickness)thic.ConvertFrom("3");
            //            return;
            //        }


            //    }
            //    else
            //    {
            //        textWarningUsername.Visibility = textWarningVisible;
            //        usernameTextBox.BorderBrush = (Brush)bc.ConvertFrom("#FF761616");
            //        usernameTextBox.BorderThickness = (Thickness)thic.ConvertFrom("3");
            //        loginBtn.BorderBrush = (Brush)bc.ConvertFrom("#FF761616");
            //        loginBtn.BorderThickness = (Thickness)thic.ConvertFrom("3");
            //        return;
            //    }
            //}


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
            usernameTextBox.BorderBrush = Brushes.Black;
            var thic = new ThicknessConverter();
            usernameTextBox.BorderThickness = (Thickness)thic.ConvertFrom("1");
            loginBtn.BorderBrush = Brushes.Black;
            loginBtn.BorderThickness = (Thickness)thic.ConvertFrom("1");
        }

        private void passwordTextBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            textWarningPassword.Visibility = textWarningHidden;
            passwordTextBox.BorderBrush = Brushes.Black;
            var thic = new ThicknessConverter();
            passwordTextBox.BorderThickness = (Thickness)thic.ConvertFrom("1");
            loginBtn.BorderBrush = Brushes.Black;
            loginBtn.BorderThickness = (Thickness)thic.ConvertFrom("1");
        }
    }
}
