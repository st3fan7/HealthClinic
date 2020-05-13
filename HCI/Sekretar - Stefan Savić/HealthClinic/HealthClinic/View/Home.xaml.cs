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

namespace HealthClinic.View
{
    /// <summary>
    /// Interaction logic for Home.xaml
    /// </summary>
    public partial class Home : UserControl
    {
        public Home()
        {
            InitializeComponent();
        }

        private void logoutBtn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            mw.Show();
            Window.GetWindow(this).Close();
        }

        private void scheduleBtn_Click(object sender, RoutedEventArgs e)
        {
            GridHome.Children.Clear();
            UserControl usc = new Schedule();
            GridHome.Children.Add(usc);
        }

        private void patientsBtn_Click(object sender, RoutedEventArgs e)
        {
            GridHome.Children.Clear();
            UserControl usc = new Patient();
            GridHome.Children.Add(usc);
        }

        private void patienstBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridHome.Children.Clear();
            UserControl usc = new Patient();
            GridHome.Children.Add(usc);
        }

        private void settingsBtn_Click(object sender, RoutedEventArgs e)
        {
            GridHome.Children.Clear();
            UserControl usc = new Settings();
            GridHome.Children.Add(usc);
        }

        private void reportBtn_Click(object sender, RoutedEventArgs e)
        {
            GridHome.Children.Clear();
            UserControl usc = new Report();
            GridHome.Children.Add(usc);
        }

        private void btnNotification_Click(object sender, RoutedEventArgs e)
        {
            GridHome.Children.Clear();
            UserControl usc = new Notifications();
            GridHome.Children.Add(usc);
        }
    }
}
