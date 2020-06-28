using HealthClinic.View.Dialogues;
using HealthClinic.View.ViewModel;
using Model.AllActors;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for ConfirmPatientIdentity.xaml
    /// </summary>
    public partial class ConfirmPatientIdentity : UserControl
    {
        //Pacijent pac = new Pacijent();

        //Termin terminKojiSeZakazuje = new Termin();

        Patient patient = new Patient();
        ViewTerm termForSchedule = new ViewTerm();
        ObservableCollection<User> doctorsFromCmbx = new ObservableCollection<User>();
        
        public ConfirmPatientIdentity(string selectedDate, Patient patient, ViewTerm term)
        {
            InitializeComponent();
            termForSchedule = term;
            dateLabel.Content = selectedDate;
            nameLabel2.Content = patient.Name;
            lastNameLabel2.Content = patient.Surname;
            jmbgLabel2.Content = patient.Jmbg;

            if (!patient.UserName.Equals(""))
            {
                usernameLabel2.Content = patient.UserName;
            }
            this.patient = patient;

            doctorsFromCmbx.Clear();
            if (term.Task.Equals("Pregled"))
                doctorsFromCmbx = MedicalExaminationRooms.DoctorsForMedicalExamination;

            else
                doctorsFromCmbx = SurgeryRooms.DoctorsForSurgery;

        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            (this.Parent as Panel).Children.Remove(this);
        }

        private void homeBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridPatientValidation.Children.Clear();
            UserControl usc = new Home();
            GridPatientValidation.Children.Add(usc);
        }

        private void scheduleBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridPatientValidation.Children.Clear();
            UserControl usc = new Schedule();
            GridPatientValidation.Children.Add(usc);
        }

        private void patienstBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridPatientValidation.Children.Clear();
            UserControl usc = new PatientView();
            GridPatientValidation.Children.Add(usc);
        }

        private void settingsBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridPatientValidation.Children.Clear();
            UserControl usc = new Settings();
            GridPatientValidation.Children.Add(usc);
        }

        private void reportBtn_Click(object sender, RoutedEventArgs e)
        {
            GridPatientValidation.Children.Clear();
            UserControl usc = new Report();
            GridPatientValidation.Children.Add(usc);
        }

        private void yesBtn_Click(object sender, RoutedEventArgs e)
        {

            UserControl usc = new ScheduleTerm(dateLabel.Content.ToString(), termForSchedule, patient);
            (this.Parent as Panel).Children.Add(usc);
        }

        private void noBtn_Click(object sender, RoutedEventArgs e)
        {
            (this.Parent as Panel).Children.Remove(this);
        }
    }
}
