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
    /// Interaction logic for AccommodationPatient.xaml
    /// </summary>
    public partial class AccommodationPatient : UserControl
    {
        public AccommodationPatient()
        {
            InitializeComponent();
        }

        private void homeBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridAccommodationPatient.Children.Clear();
            UserControl usc = new Home();
            GridAccommodationPatient.Children.Add(usc);
        }

        private void scheduleBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridAccommodationPatient.Children.Clear();
            UserControl usc = new Schedule();
            GridAccommodationPatient.Children.Add(usc);
        }

        private void patienstBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridAccommodationPatient.Children.Clear();
            UserControl usc = new Patient();
            GridAccommodationPatient.Children.Add(usc);
        }

        private void settingsBtn_Click(object sender, RoutedEventArgs e)
        {
            GridAccommodationPatient.Children.Clear();
            UserControl usc = new Settings();
            GridAccommodationPatient.Children.Add(usc);
        }

        private void reportBtn_Click(object sender, RoutedEventArgs e)
        {
            GridAccommodationPatient.Children.Clear();
            UserControl usc = new Report();
            GridAccommodationPatient.Children.Add(usc);
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            GridAccommodationPatient.Children.Clear();
            UserControl usc = new PatientValidationForRecovery();
            GridAccommodationPatient.Children.Add(usc);
        }

        private void yesBtn_Click(object sender, RoutedEventArgs e)
        {
            GridAccommodationPatient.Children.Clear();
            UserControl usc = new RecoveryRooms();
            GridAccommodationPatient.Children.Add(usc);
        }
    }
}
