using MaterialDesignThemes.Wpf;
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
        public PatientValidation()
        {
            InitializeComponent();
            Schedule s = new Schedule();
            datumLabel.Content = s.datePickerSchedule.DisplayDate; // treba da povuces datum i prikazes
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
            UserControl usc = new Patient();
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
            GridPatientValidation.Children.Clear();
            UserControl usc = new SurgeryRooms(); // moras nekako dobiti roditeljski user control i to zamneniti
            GridPatientValidation.Children.Add(usc);

        }

        private void confirmBtn_Click(object sender, RoutedEventArgs e)
        {
            // U zavisnosti da li ima uneti podataka postoji u bazi otvorice se razliciti prozori
            // potrebno je napraviti proveru iz baze da li ima nalog
            // ima nalog - Potvrda indentiteta
            // nema nalog - Kreiranje guest naloga

            //UserControl usc = new ConfirmPatientIdentity();


            GridPatientValidation.Children.Clear();
            UserControl usc = new GuestAccount();
            GridPatientValidation.Children.Add(usc);


        }
    }
}
