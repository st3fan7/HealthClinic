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
    /// Interaction logic for ManipulationOptions.xaml
    /// </summary>
    public partial class ManipulationOptions : UserControl
    {
        Patient patient = new Patient();
        public ManipulationOptions(Patient patient)
        {
            InitializeComponent();
            this.patient = patient;
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            GridManipulationOptions.Children.Clear();
            UserControl usc = new AccountManipulation();
            GridManipulationOptions.Children.Add(usc);
        }

        private void homeBtn2_Click(object sender, RoutedEventArgs e)
        {

            GridManipulationOptions.Children.Clear();
            UserControl usc = new Home();
            GridManipulationOptions.Children.Add(usc);
        }

        private void scheduleBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridManipulationOptions.Children.Clear();
            UserControl usc = new Schedule();
            GridManipulationOptions.Children.Add(usc);

        }

        private void patienstBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridManipulationOptions.Children.Clear();
            UserControl usc = new PatientView();
            GridManipulationOptions.Children.Add(usc);
        }


        private void settingsBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridManipulationOptions.Children.Clear();
            UserControl usc = new Settings();
            GridManipulationOptions.Children.Add(usc);
        }

        private void reportBtn_Click(object sender, RoutedEventArgs e)
        {
            GridManipulationOptions.Children.Clear();
            UserControl usc = new Report();
            GridManipulationOptions.Children.Add(usc);
        }

        private void viewBtn_Click(object sender, RoutedEventArgs e)
        {
            GridManipulationOptions.Children.Clear();
            UserControl usc = new ViewPatientAccount(patient);
            GridManipulationOptions.Children.Add(usc);
        }

        private void changeBtn_Click(object sender, RoutedEventArgs e)
        {
            GridManipulationOptions.Children.Clear();
            UserControl usc = new ChangePatientAccount(patient);
            GridManipulationOptions.Children.Add(usc);
        }

        private void deactivateBtn_Click(object sender, RoutedEventArgs e)
        {
            GridManipulationOptions.Children.Clear();
            UserControl usc = new DeactivationPatientAccount(patient);
            GridManipulationOptions.Children.Add(usc);
        }
    }
}
