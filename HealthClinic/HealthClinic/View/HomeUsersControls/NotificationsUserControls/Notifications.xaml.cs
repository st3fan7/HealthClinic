using HealthClinic.Model;
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
    /// Interaction logic for Notifications.xaml
    /// </summary>
    public partial class Notifications : UserControl
    {
        List<Obavestenja> obavestenja = new List<Obavestenja>();
        public Notifications()
        {
            InitializeComponent();
        }

        private void fillData()
        {
            obavestenja.Add(new Obavestenja() { Obavestenje = "Sala A1 je na renoviranju do 10. aprila ovog meseca.", Posiljalac = "Upravnik", Datum = "7 apr"});
            obavestenja.Add(new Obavestenja() { Obavestenje = "Sala A3 je na renoviranju do 23. aprila ovog meseca.", Posiljalac = "Upravnik", Datum = "6 apr" });
            obavestenja.Add(new Obavestenja() { Obavestenje = "Sala B2 je na renoviranju do 14. aprila ovog meseca.", Posiljalac = "Upravnik", Datum = "6 apr" });
            dgTerms.ItemsSource = obavestenja;
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            fillData();
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            GridNotifications.Children.Clear();
            UserControl usc = new Home();
            GridNotifications.Children.Add(usc);

        }

        private void homeBtn2_Click(object sender, RoutedEventArgs e)
        {

            GridNotifications.Children.Clear();
            UserControl usc = new Home();
            GridNotifications.Children.Add(usc);
        }

        private void scheduleBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridNotifications.Children.Clear();
            UserControl usc = new Schedule();
            GridNotifications.Children.Add(usc);

        }

        private void patienstBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridNotifications.Children.Clear();
            UserControl usc = new Patient();
            GridNotifications.Children.Add(usc);
        }

        private void settingsBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridNotifications.Children.Clear();
            UserControl usc = new Settings();
            GridNotifications.Children.Add(usc);
        }

        private void reportBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridNotifications.Children.Clear();
            UserControl usc = new Report();
            GridNotifications.Children.Add(usc);
        }

        private void closeBtn_Click(object sender, RoutedEventArgs e)
        {
            GridNotifications.Children.Clear();
            UserControl usc = new Home();
            GridNotifications.Children.Add(usc);
        }
    }
}
