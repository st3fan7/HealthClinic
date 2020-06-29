using Controller.UsersControlers;
using HealthClinic.View;
using Model.AllActors;
using System;
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
        public static string UsernameForSecretary;

        private readonly UserController userController;
        public static Secretary secretary = null;


        public MainWindow()
        {
            InitializeComponent();
            
            var app = App.Current as App;
            userController = app.UserController;

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
            if(usernameTextBox.Text != "")
            {
                try
                {
                    secretary = (Secretary)userController.Login(usernameTextBox.Text, passwordTextBox.Password);
                }
                catch (InvalidCastException e1)
                {
                    loginBtn.BorderBrush = (Brush)bc.ConvertFrom("#FF761616");
                    loginBtn.BorderThickness = (Thickness)thic.ConvertFrom("3");
                    passwordTextBox.BorderBrush = (Brush)bc.ConvertFrom("#FF761616");
                    passwordTextBox.BorderThickness = (Thickness)thic.ConvertFrom("3");
                    usernameTextBox.BorderBrush = (Brush)bc.ConvertFrom("#FF761616");
                    usernameTextBox.BorderThickness = (Thickness)thic.ConvertFrom("3");
                    Console.WriteLine(e1);
                    return;
                }
            }
           
            if(secretary != null)
            {
                UsernameForSecretary = usernameTextBox.Text;
                UserControl usc = new Home();
                GridMain.Children.Add(usc);
            } else
            {
                loginBtn.BorderBrush = (Brush)bc.ConvertFrom("#FF761616");
                loginBtn.BorderThickness = (Thickness)thic.ConvertFrom("3");
                passwordTextBox.BorderBrush = (Brush)bc.ConvertFrom("#FF761616");
                passwordTextBox.BorderThickness = (Thickness)thic.ConvertFrom("3");
                usernameTextBox.BorderBrush = (Brush)bc.ConvertFrom("#FF761616");
                usernameTextBox.BorderThickness = (Thickness)thic.ConvertFrom("3");
            }


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
