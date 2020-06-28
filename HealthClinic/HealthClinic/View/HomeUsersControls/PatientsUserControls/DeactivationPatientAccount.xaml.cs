using Controller.UsersControlers;
using HealthClinic.View.Dialogues;
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
    /// Interaction logic for DeactivationPatientAccount.xaml
    /// </summary>
    public partial class DeactivationPatientAccount : UserControl
    {
        Patient patient = new Patient();

        private readonly UserController userController;

        public DeactivationPatientAccount(Patient p)
        {
            InitializeComponent();

            var app = Application.Current as App;
            userController = app.UserController;

            this.patient = p;
            nameLabel2.Content = p.Name;
            lastNameLabel2.Content = p.Surname;
            jmbgLabel2.Content = p.Jmbg;
            if (p.GuestAccount == false)
            {
                usernameLabel2.Content = p.UserName;
            }
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            GridDeactivationPatientAccount.Children.Clear();
            UserControl usc = new ManipulationOptions(patient);
            GridDeactivationPatientAccount.Children.Add(usc);
        }

        private void homeBtn2_Click(object sender, RoutedEventArgs e)
        {

            GridDeactivationPatientAccount.Children.Clear();
            UserControl usc = new Home();
            GridDeactivationPatientAccount.Children.Add(usc);
        }

        private void scheduleBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridDeactivationPatientAccount.Children.Clear();
            UserControl usc = new Schedule();
            GridDeactivationPatientAccount.Children.Add(usc);

        }

        private void patienstBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridDeactivationPatientAccount.Children.Clear();
            UserControl usc = new PatientView();
            GridDeactivationPatientAccount.Children.Add(usc);
        }

        private void settingsBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridDeactivationPatientAccount.Children.Clear();
            UserControl usc = new Settings();
            GridDeactivationPatientAccount.Children.Add(usc);
        }

        private void reportBtn_Click(object sender, RoutedEventArgs e)
        {
            GridDeactivationPatientAccount.Children.Clear();
            UserControl usc = new Report();
            GridDeactivationPatientAccount.Children.Add(usc);
        }

        private void confirmBtn_Click(object sender, RoutedEventArgs e)
        {
            userController.DeleteEntity(patient);

            GridDeactivationPatientAccount.Children.Clear();
            UserControl usc = new PatientView();
            GridDeactivationPatientAccount.Children.Add(usc);
        }

        private void giveUpBtn_Click(object sender, RoutedEventArgs e)
        {
            GridDeactivationPatientAccount.Children.Clear();
            UserControl usc = new ManipulationOptions(patient);
            GridDeactivationPatientAccount.Children.Add(usc);
        }
    }
}
