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
    /// Interaction logic for DoctorsTerm.xaml
    /// </summary>
    public partial class DoctorsTerm : UserControl
    {
        List<Termin> termini = new List<Termin>();
        public DoctorsTerm()
        {
            InitializeComponent();
        }

        private void fillData()
        {
            termini.Add(new Termin() { Vreme = "09:00 - 10:00", Sala = "A1", Lekar = "Ana Anić", Pacijent = "Petar Perić", Status = "Zauzet" });
            termini.Add(new Termin() { Vreme = "10:00 - 11:00", Sala = null, Lekar = "Ana Anić", Pacijent = null, Status = "Slobodan" });
            termini.Add(new Termin() { Vreme = "11:00 - 11:30", Sala = "B2", Lekar = "Ana Anić", Pacijent = "Miloš Milošević", Status = "Zauzet" });
            dgTerms.ItemsSource = termini;
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            fillData();
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            GridDoctorsTerms.Children.Clear();
            UserControl usc = new DisplayType();
            GridDoctorsTerms.Children.Add(usc);

        }

        private void homeBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridDoctorsTerms.Children.Clear();
            UserControl usc = new Home();
            GridDoctorsTerms.Children.Add(usc);
        }

        private void scheduleBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridDoctorsTerms.Children.Clear();
            UserControl usc = new Schedule();
            GridDoctorsTerms.Children.Add(usc);
        }
        private void patienstBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridDoctorsTerms.Children.Clear();
            UserControl usc = new Patient();
            GridDoctorsTerms.Children.Add(usc);
        }

        private void settingsBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridDoctorsTerms.Children.Clear();
            UserControl usc = new Settings();
            GridDoctorsTerms.Children.Add(usc);
        }

        private void reportBtn_Click(object sender, RoutedEventArgs e)
        {
            GridDoctorsTerms.Children.Clear();
            UserControl usc = new Report();
            GridDoctorsTerms.Children.Add(usc);
        }

        private void btnSchedule_Click(object sender, RoutedEventArgs e)
        {

            GridDoctorsTerms.Children.Clear();
            UserControl usc = new PatientValidation();
            GridDoctorsTerms.Children.Add(usc);


            //SurgeryRooms sr = new SurgeryRooms();
            //var row_list = (Termin)dgTerms.SelectedItem;
            //ScheduleTerm st = new ScheduleTerm();
            //st.l1.Content = row_list.Vreme;

            //Console.WriteLine(row_list.Vreme);
            //Console.WriteLine("Proba" + proba);

        }

        private void btnRelocate_Click(object sender, RoutedEventArgs e)
        {

            GridDoctorsTerms.Children.Clear();
            UserControl usc = new RelocationTerm();
            GridDoctorsTerms.Children.Add(usc);
        }

        private void btnCanceling_Click(object sender, RoutedEventArgs e)
        {
            GridDoctorsTerms.Children.Clear();
            UserControl usc = new CancelingTerm();
            GridDoctorsTerms.Children.Add(usc);
        }
    }
}
