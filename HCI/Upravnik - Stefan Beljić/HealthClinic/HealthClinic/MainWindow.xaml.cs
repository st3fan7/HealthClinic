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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click_UlogujSe(object sender, RoutedEventArgs e)
        {
            var home = new Home();
            home.Show();
            this.Close();
        }

        private void Button_Click_Izadji(object sender, RoutedEventArgs e)
        {
            this.Close();
        }


        private void Button_Click_ZaboravljenaLozinka(object sender, RoutedEventArgs e)
        {
            LoginGrid.Children.Clear();
            UserControl usc = new ForgottenPassword();
            LoginGrid.Children.Add(usc);
        }
    }
}
