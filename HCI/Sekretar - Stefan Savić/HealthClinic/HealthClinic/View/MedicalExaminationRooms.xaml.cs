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
    /// Interaction logic for TermsForMedicalExamination.xaml
    /// </summary>
    public partial class MedicalExaminationRooms : UserControl
    {
        List<Termin> termini = new List<Termin>();
        public MedicalExaminationRooms()
        {
            InitializeComponent();
            Schedule s = new Schedule();
            datumLabel.Content = s.datePickerSchedule.DisplayDate; // treba da povuces datum i prikazes
        }

        private void fillData()
        {
            termini.Add(new Termin() { Vreme = "09:00 - 10:00", Sala = "D1", Lekar = "Miloš Mišić", Pacijent = "Zoran Zokić", Status = "Zauzet" });
            termini.Add(new Termin() { Vreme = "10:00 - 12:00", Sala = "D1", Lekar = null, Pacijent = null, Status = "Slobodan" });
            termini.Add(new Termin() { Vreme = "12:00 - 13:00", Sala = "D1", Lekar = "Petar Petrović", Pacijent = "Miroslava Pekić", Status = "Zauzet" });
            dgTerms.ItemsSource = termini;
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            fillData();
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            GridMedicalExaminationRooms.Children.Clear();
            UserControl usc = new TypeOfRoom();
            GridMedicalExaminationRooms.Children.Add(usc);


        }

        private void homeBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridMedicalExaminationRooms.Children.Clear();
            UserControl usc = new Home();
            GridMedicalExaminationRooms.Children.Add(usc);
        }

        private void scheduleBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridMedicalExaminationRooms.Children.Clear();
            UserControl usc = new Schedule();
            GridMedicalExaminationRooms.Children.Add(usc);
        }

        private void patienstBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridMedicalExaminationRooms.Children.Clear();
            UserControl usc = new Patient();
            GridMedicalExaminationRooms.Children.Add(usc);
        }

        private void settingsBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridMedicalExaminationRooms.Children.Clear();
            UserControl usc = new Settings();
            GridMedicalExaminationRooms.Children.Add(usc);
        }

        private void reportBtn_Click(object sender, RoutedEventArgs e)
        {
            GridMedicalExaminationRooms.Children.Clear();
            UserControl usc = new Report();
            GridMedicalExaminationRooms.Children.Add(usc);
        }


        private void btnSchedule_Click(object sender, RoutedEventArgs e)
        {
            GridMedicalExaminationRooms.Children.Clear();
            UserControl usc = new PatientValidation();
            GridMedicalExaminationRooms.Children.Add(usc);


            //SurgeryRooms sr = new SurgeryRooms();
            //var row_list = (Termin)dgTerms.SelectedItem;
            //ScheduleTerm st = new ScheduleTerm();
            //st.l1.Content = row_list.Vreme;

            //Console.WriteLine(row_list.Vreme);
            //Console.WriteLine("Proba" + proba);

        }

        private void btnRelocate_Click(object sender, RoutedEventArgs e)
        {
            GridMedicalExaminationRooms.Children.Clear();
            UserControl usc = new RelocationTerm();
            GridMedicalExaminationRooms.Children.Add(usc);
        }

        private void btnCanceling_Click(object sender, RoutedEventArgs e)
        {
            GridMedicalExaminationRooms.Children.Clear();
            UserControl usc = new CancelingTerm();
            GridMedicalExaminationRooms.Children.Add(usc);
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            GridMedicalExaminationRooms.Children.Clear();
            UserControl usc = new SearchInOthersRoom();
            GridMedicalExaminationRooms.Children.Add(usc);
        }
    }
}
