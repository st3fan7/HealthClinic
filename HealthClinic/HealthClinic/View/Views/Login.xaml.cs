using Controller.UsersControlers;
using Model.AllActors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : UserControl, INotifyPropertyChanged
    {
        public static Patient currentUser;
        public event PropertyChangedEventHandler PropertyChanged;
        UserController userController;
        public String _username;
        private String _password;

        public Login()
        {
            InitializeComponent();
            this.DataContext = this;

            var app = Application.Current as App;
            userController = app.UserController;
            
            currentUser = null;

            usernameInput.SelectAll();
        }

        public String LoginUsername
        {
            get { return _username; }
            set
            {
                if (_username != value)
                {
                    _username = value;

                }
            }
        }

        public String LoginPassword
        {
            get { return _password; }
            set
            {
                if (_password != value)
                {
                    _password = value;

                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (this.LoginUsername != null && this.LoginPassword != null)
            {
                currentUser = (Patient)userController.Login(this.LoginUsername, this.LoginPassword);
            }

            if (currentUser != null)
            {
                LoginGrid.Children.Clear();
                UserControl usc = new Home();
                LoginGrid.Children.Add(usc);
            }
            else
            {

            }
        }


        protected virtual void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }       

        private void ZaboravljenaLozinkaButton_Click(object sender, RoutedEventArgs e)
        {
            LoginGrid.Children.Clear();
            UserControl usc = new NewPasswordRequest();
            LoginGrid.Children.Add(usc);
        }
    }
}
