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
    /// Interaction logic for RecoveryRooms.xaml
    /// </summary>
    public partial class RecoveryRooms : UserControl
    {
        List<Oporavak> oporavak = new List<Oporavak>();
        public RecoveryRooms()
        {
            InitializeComponent();
        }

        private void fillData()
        {
            oporavak.Add(new Oporavak() { Prijem = "03/04/2020", Odjava = "13/04/2020", Sala = "O1", Pacijent = "Igor Petrić", Status = "Zauzet" });
            oporavak.Add(new Oporavak() { Prijem = "01/04/2020", Odjava = null, Sala = "O1", Pacijent = "Jelena Jelić", Status = "Zauzet" });
            oporavak.Add(new Oporavak() { Prijem = "02/04/2020", Odjava = null, Sala = "O1", Pacijent = null, Status = "Slobodan" });
            dgTerms.ItemsSource = oporavak;
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            fillData();
        }


        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            GridRecoveryRooms.Children.Clear();
            UserControl usc = new TypeOfRoom();
            GridRecoveryRooms.Children.Add(usc);

        }

        private void homeBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridRecoveryRooms.Children.Clear();
            UserControl usc = new Home();
            GridRecoveryRooms.Children.Add(usc);
        }

        private void scheduleBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridRecoveryRooms.Children.Clear();
            UserControl usc = new Schedule();
            GridRecoveryRooms.Children.Add(usc);

        }

        private void patienstBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridRecoveryRooms.Children.Clear();
            UserControl usc = new Patient();
            GridRecoveryRooms.Children.Add(usc);
        }

        private void settingsBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridRecoveryRooms.Children.Clear();
            UserControl usc = new Settings();
            GridRecoveryRooms.Children.Add(usc);
        }

        private void reportBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridRecoveryRooms.Children.Clear();
            UserControl usc = new Report();
            GridRecoveryRooms.Children.Add(usc);
        }


        private void btnAccommodate_Click(object sender, RoutedEventArgs e)
        {
            GridRecoveryRooms.Children.Clear();
            UserControl usc = new PatientValidationForRecovery();
            GridRecoveryRooms.Children.Add(usc);
        }

        private void btnMove_Click(object sender, RoutedEventArgs e)
        {
            GridRecoveryRooms.Children.Clear();
            UserControl usc = new DataModificationInRecoveryRoom();
            GridRecoveryRooms.Children.Add(usc);
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            GridRecoveryRooms.Children.Clear();
            UserControl usc = new SearchInRecoveryRooms();
            GridRecoveryRooms.Children.Add(usc);
        }
    }
}
