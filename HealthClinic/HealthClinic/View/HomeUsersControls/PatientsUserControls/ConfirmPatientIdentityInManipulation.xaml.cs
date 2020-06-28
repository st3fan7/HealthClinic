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
    /// Interaction logic for ConfirmPatientIdentityInManipulation.xaml
    /// </summary>
    public partial class ConfirmPatientIdentityInManipulation : UserControl
    {
        Patient patient = new Patient();
        public ConfirmPatientIdentityInManipulation(Patient patient)
        {
            InitializeComponent();
            nameLabel2.Content = patient.Name;
            lastNameLabel2.Content = patient.Surname;
            jmbgLabel2.Content = patient.Jmbg;

            if (!patient.UserName.Equals(""))
            {
                usernameLabel2.Content = patient.UserName;
            }
            this.patient = patient;
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            GridConfirmPatientIdentityInManipulation.Children.Clear();
            UserControl usc = new AccountManipulation();
            GridConfirmPatientIdentityInManipulation.Children.Add(usc);
        }

        private void homeBtn2_Click(object sender, RoutedEventArgs e)
        {

            GridConfirmPatientIdentityInManipulation.Children.Clear();
            UserControl usc = new Home();
            GridConfirmPatientIdentityInManipulation.Children.Add(usc);
        }

        private void scheduleBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridConfirmPatientIdentityInManipulation.Children.Clear();
            UserControl usc = new Schedule();
            GridConfirmPatientIdentityInManipulation.Children.Add(usc);

        }

        private void patienstBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridConfirmPatientIdentityInManipulation.Children.Clear();
            UserControl usc = new PatientView();
            GridConfirmPatientIdentityInManipulation.Children.Add(usc);
        }


        private void settingsBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridConfirmPatientIdentityInManipulation.Children.Clear();
            UserControl usc = new Settings();
            GridConfirmPatientIdentityInManipulation.Children.Add(usc);
        }

        private void reportBtn_Click(object sender, RoutedEventArgs e)
        {
            GridConfirmPatientIdentityInManipulation.Children.Clear();
            UserControl usc = new Report();
            GridConfirmPatientIdentityInManipulation.Children.Add(usc);
        }

        private void yesBtn_Click(object sender, RoutedEventArgs e)
        {
            GridConfirmPatientIdentityInManipulation.Children.Clear();
            UserControl usc = new ManipulationOptions(patient);
            GridConfirmPatientIdentityInManipulation.Children.Add(usc);
        }

        private void noBtn_Click(object sender, RoutedEventArgs e)
        {
            GridConfirmPatientIdentityInManipulation.Children.Clear();
            UserControl usc = new AccountManipulation();
            GridConfirmPatientIdentityInManipulation.Children.Add(usc);
        }
    }
}
