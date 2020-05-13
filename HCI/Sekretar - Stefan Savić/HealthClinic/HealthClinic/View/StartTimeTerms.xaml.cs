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
    /// Interaction logic for StartTimeTerms.xaml
    /// </summary>
    public partial class StartTimeTerms : UserControl
    {
        List<Termin> termini = new List<Termin>();
        public StartTimeTerms()
        {
            InitializeComponent();
        }

        private void fillData()
        {
            termini.Add(new Termin() { Vreme = "08:00 - 10:00", Sala = "A1", Lekar = "Ana Anić", Pacijent = "Petar Perić", Status = "Zauzet" });
            termini.Add(new Termin() { Vreme = "08:00 - 09:00", Sala = "C1", Lekar = null, Pacijent = null, Status = "Slobodan" });
            termini.Add(new Termin() { Vreme = "08:00 - 08:30", Sala = "B2", Lekar = "Ana Anić", Pacijent = "Miloš Milošević", Status = "Zauzet" });
            dgTerms.ItemsSource = termini;
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            fillData();
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            GridStartTimeTerms.Children.Clear();
            UserControl usc = new StartTimeView();
            GridStartTimeTerms.Children.Add(usc);
        }

        private void homeBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridStartTimeTerms.Children.Clear();
            UserControl usc = new Home();
            GridStartTimeTerms.Children.Add(usc);

        }

        private void scheduleBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridStartTimeTerms.Children.Clear();
            UserControl usc = new Schedule();
            GridStartTimeTerms.Children.Add(usc);
        }

        private void patienstBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridStartTimeTerms.Children.Clear();
            UserControl usc = new Patient();
            GridStartTimeTerms.Children.Add(usc);
        }

        private void settingsBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridStartTimeTerms.Children.Clear();
            UserControl usc = new Settings();
            GridStartTimeTerms.Children.Add(usc);
        }

        private void reportBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridStartTimeTerms.Children.Clear();
            UserControl usc = new Report();
            GridStartTimeTerms.Children.Add(usc);
        }

        private void btnSchedule_Click(object sender, RoutedEventArgs e)
        {

            GridStartTimeTerms.Children.Clear();
            UserControl usc = new PatientValidation();
            GridStartTimeTerms.Children.Add(usc);


            //SurgeryRooms sr = new SurgeryRooms();
            //var row_list = (Termin)dgTerms.SelectedItem;
            //ScheduleTerm st = new ScheduleTerm();
            //st.l1.Content = row_list.Vreme;

            //Console.WriteLine(row_list.Vreme);
            //Console.WriteLine("Proba" + proba);

        }

        private void btnRelocate_Click(object sender, RoutedEventArgs e)
        {

            GridStartTimeTerms.Children.Clear();
            UserControl usc = new RelocationTerm();
            GridStartTimeTerms.Children.Add(usc);
        }

        private void btnCanceling_Click(object sender, RoutedEventArgs e)
        {
            GridStartTimeTerms.Children.Clear();
            UserControl usc = new CancelingTerm();
            GridStartTimeTerms.Children.Add(usc);
        }
    }
}
