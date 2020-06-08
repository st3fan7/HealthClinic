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
    /// Interaction logic for PatientValidationForRecovery.xaml
    /// </summary>
    public partial class PatientValidationForRecovery : UserControl
    {
        public PatientValidationForRecovery(string selectedDate)
        {
            InitializeComponent();
            dateLabel.Content = selectedDate;
        }

        private void homeBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridPatientValidationForRecovery.Children.Clear();
            UserControl usc = new Home();
            GridPatientValidationForRecovery.Children.Add(usc);
        }

        private void scheduleBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridPatientValidationForRecovery.Children.Clear();
            UserControl usc = new Schedule();
            GridPatientValidationForRecovery.Children.Add(usc);
        }

        private void patienstBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridPatientValidationForRecovery.Children.Clear();
            UserControl usc = new Patient();
            GridPatientValidationForRecovery.Children.Add(usc);
        }

        private void settingsBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridPatientValidationForRecovery.Children.Clear();
            UserControl usc = new Settings();
            GridPatientValidationForRecovery.Children.Add(usc);
        }

        private void reportBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridPatientValidationForRecovery.Children.Clear();
            UserControl usc = new Report();
            GridPatientValidationForRecovery.Children.Add(usc);
        }

        private void confirmBtn_Click(object sender, RoutedEventArgs e)
        {

            UserControl usc = new AccommodationPatient(dateLabel.Content.ToString());
            (this.Parent as Panel).Children.Add(usc);
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            (this.Parent as Panel).Children.Remove(this);
        }
    }
}
