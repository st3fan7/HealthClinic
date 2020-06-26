using Controller.UsersControlers;
using Model.AllActors;
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
using System.Windows.Shapes;

namespace HealthClinic
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        private readonly UserController userController;
        public static Doctor ulogovaniDoctor = null;

        public Window1()
        {
            InitializeComponent();
            var app = App.Current as App;
            userController = app.UserController;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            /*
            if (txtUserName.Text.Equals("pera") && txtPassword.Password.ToString().Equals("pera"))
            {
                
                var mainWindow = new MainWindow();
                mainWindow.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Username or password is not valid");
            }
            */

            
            ulogovaniDoctor = (Doctor)userController.Login(txtUserName.Text, txtPassword.Password);
            var mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();


        }

        
    }
}
