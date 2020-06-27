using Controller.UsersControlers;
using HealthClinic.View.Dialogues;
using HealthClinic.View.ViewModel;
using MaterialDesignThemes.Wpf;
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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HealthClinic.View
{
    /// <summary>
    /// Interaction logic for PatientValidation.xaml
    /// </summary>
    public partial class PatientValidation : UserControl
    {
        //Termin terminKojiSeZakazuje = new Termin();
        //private static List<String> doctorsFromCmbx = new List<String>();

        private readonly UserController userController;

        ViewTerm termForSchedule = new ViewTerm();
        ObservableCollection<User> doctorsFromCmbx = new ObservableCollection<User>();
        public PatientValidation(string selectedDate, ViewTerm term)
        {
            InitializeComponent();
            termForSchedule = term;
            dateLabel.Content = selectedDate;
            textWarning.Visibility = textWarningHidden;
            doctorsFromCmbx = MedicalExaminationRooms.DoctorsForMedicalExamination;

            var app = Application.Current as App;
            userController = app.UserController;

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

        private void reportBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridPatientValidation.Children.Clear();
            UserControl usc = new Report();
            GridPatientValidation.Children.Add(usc);
        }

        private void backBtn_Click_1(object sender, RoutedEventArgs e)
        {
            (this.Parent as Panel).Children.Remove(this);
        }

        private void confirmBtn_Click(object sender, RoutedEventArgs e)
        {

            if(!usernameTextBox.Text.Equals(""))
            {
                textWarning.Visibility = textWarningHidden;
                usernameTextBox.BorderBrush = Brushes.Black;
                var thic = new ThicknessConverter();
                usernameTextBox.BorderThickness = (Thickness)thic.ConvertFrom("1");
                confirmBtn.BorderBrush = Brushes.Black;
                confirmBtn.BorderThickness = (Thickness)thic.ConvertFrom("1");

                UserControl usc = null;
                Patient patient = (Patient)userController.GetUserByUsername(usernameTextBox.Text);
                // ima nalog
                if (patient != null) 
                {
                    usc = new ConfirmPatientIdentity(dateLabel.Content.ToString(), patient, termForSchedule); // datum ne moras ovako vec datum od termina uzmi
                    (this.Parent as Panel).Children.Add(usc);
                    return;
                }
                patient = (Patient)userController.GetUserByJMBG(usernameTextBox.Text);
                // ima guest account
                if (patient != null) // napravi metodu
                {
                    usc = new ConfirmPatientIdentity(dateLabel.Content.ToString(), patient, termForSchedule);
                    (this.Parent as Panel).Children.Add(usc);
                    return;
                }
                // nema nalog
                usc = new GuestAccount(dateLabel.Content.ToString(), usernameTextBox.Text, termForSchedule);
                (this.Parent as Panel).Children.Add(usc);
            } else
            {
                var bc = new BrushConverter();
                var thic = new ThicknessConverter();
                usernameTextBox.BorderBrush = (Brush)bc.ConvertFrom("#FF761616");
                usernameTextBox.BorderThickness = (Thickness)thic.ConvertFrom("3");
                confirmBtn.BorderBrush = (Brush)bc.ConvertFrom("#FF761616");
                confirmBtn.BorderThickness = (Thickness)thic.ConvertFrom("3");
                textWarning.Visibility = textWarningVisible;
                
            }


        }

        private Visibility textWarningHidden
        {
            get { return Visibility.Hidden; }
        }
        private Visibility textWarningVisible
        {
            get { return Visibility.Visible; }
        }



        private void usernameTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!usernameTextBox.Text.Equals(""))
            {
                textWarning.Visibility = textWarningHidden;
                usernameTextBox.BorderBrush = Brushes.Black;
                var thic = new ThicknessConverter();
                usernameTextBox.BorderThickness = (Thickness)thic.ConvertFrom("1");
                confirmBtn.BorderBrush = Brushes.Black;
                confirmBtn.BorderThickness = (Thickness)thic.ConvertFrom("1");
            } 
        }
    }
}
