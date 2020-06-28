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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HealthClinic.View
{
    /// <summary>
    /// Interaction logic for ConfirmPatientIdentityInTransformation.xaml
    /// </summary>
    public partial class ConfirmPatientIdentityInTransformation : UserControl
    {
        Patient patient = new Patient();
        public ConfirmPatientIdentityInTransformation(Patient p)
        {
            InitializeComponent();
            patient = p;
            nameLabel2.Content = patient.Name;
            lastNameLabel2.Content = patient.Surname;
            jmbgLabel2.Content = patient.Jmbg;
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            GridPatientValidationInTransformation.Children.Clear();
            UserControl usc = new TransformationGuestAccount();
            GridPatientValidationInTransformation.Children.Add(usc);
        }

        private void homeBtn2_Click(object sender, RoutedEventArgs e)
        {

            GridPatientValidationInTransformation.Children.Clear();
            UserControl usc = new Home();
            GridPatientValidationInTransformation.Children.Add(usc);
        }

        private void scheduleBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridPatientValidationInTransformation.Children.Clear();
            UserControl usc = new Schedule();
            GridPatientValidationInTransformation.Children.Add(usc);

        }

        private void patientsBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridPatientValidationInTransformation.Children.Clear();
            UserControl usc = new PatientView();
            GridPatientValidationInTransformation.Children.Add(usc);
        }

        private void settingsBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridPatientValidationInTransformation.Children.Clear();
            UserControl usc = new Settings();
            GridPatientValidationInTransformation.Children.Add(usc);
        }

        private void reportBtn_Click(object sender, RoutedEventArgs e)
        {
            GridPatientValidationInTransformation.Children.Clear();
            UserControl usc = new Report();
            GridPatientValidationInTransformation.Children.Add(usc);
        }

        private void yesBtn_Click(object sender, RoutedEventArgs e)
        {
            GridPatientValidationInTransformation.Children.Clear();
            UserControl usc = new FillDataForTransformation(patient);
            GridPatientValidationInTransformation.Children.Add(usc);
        }

        private void noBtn_Click(object sender, RoutedEventArgs e)
        {
            GridPatientValidationInTransformation.Children.Clear();
            UserControl usc = new TransformationGuestAccount();
            GridPatientValidationInTransformation.Children.Add(usc);
        }
    }
}
