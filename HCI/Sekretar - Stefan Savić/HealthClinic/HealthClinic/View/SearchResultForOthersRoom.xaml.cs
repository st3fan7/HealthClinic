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
    /// Interaction logic for SearchResultForOthersRoom.xaml
    /// </summary>
    public partial class SearchResultForOthersRoom : UserControl
    {
        List<Termin> termini = new List<Termin>();
        public SearchResultForOthersRoom()
        {
            InitializeComponent();
            Schedule s = new Schedule();
            datumLabel.Content = s.datePickerSchedule.DisplayDate;
        }

        private void fillData()
        {
            termini.Add(new Termin() { Vreme = "09:00 - 10:00", Sala = "A1", Lekar = "Ana Anić", Pacijent = "Petar Perić", Status = "Zauzet" });
            termini.Add(new Termin() { Vreme = "10:00 - 12:00", Sala = "A1", Lekar = null, Pacijent = null, Status = "Slobodan" });
            termini.Add(new Termin() { Vreme = "12:00 - 13:00", Sala = "A1", Lekar = "Miša Kiš", Pacijent = "Olja Pekić", Status = "Zauzet" });
            dgTerms.ItemsSource = termini;
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            GridSearchResultForOthersRooms.Children.Clear();
            UserControl usc = new SearchInOthersRoom();
            GridSearchResultForOthersRooms.Children.Add(usc);

        }

        private void homeBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridSearchResultForOthersRooms.Children.Clear();
            UserControl usc = new Home();
            GridSearchResultForOthersRooms.Children.Add(usc);
        }

        private void scheduleBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridSearchResultForOthersRooms.Children.Clear();
            UserControl usc = new Schedule();
            GridSearchResultForOthersRooms.Children.Add(usc);
        }

        private void patienstBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridSearchResultForOthersRooms.Children.Clear();
            UserControl usc = new Patient();
            GridSearchResultForOthersRooms.Children.Add(usc);
        }

        private void settingsBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridSearchResultForOthersRooms.Children.Clear();
            UserControl usc = new Settings();
            GridSearchResultForOthersRooms.Children.Add(usc);
        }

        private void reportBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridSearchResultForOthersRooms.Children.Clear();
            UserControl usc = new Report();
            GridSearchResultForOthersRooms.Children.Add(usc);
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            fillData();
        }

        private void btnSchedule_Click(object sender, RoutedEventArgs e)
        {
            GridSearchResultForOthersRooms.Children.Clear();
            UserControl usc = new PatientValidation();
            GridSearchResultForOthersRooms.Children.Add(usc);


            //SurgeryRooms sr = new SurgeryRooms();
            //var row_list = (Termin)dgTerms.SelectedItem;
            //ScheduleTerm st = new ScheduleTerm();
            //st.l1.Content = row_list.Vreme;

            //Console.WriteLine(row_list.Vreme);
            //Console.WriteLine("Proba" + proba);

        }

        private void btnRelocate_Click(object sender, RoutedEventArgs e)
        {
            GridSearchResultForOthersRooms.Children.Clear();
            UserControl usc = new RelocationTerm();
            GridSearchResultForOthersRooms.Children.Add(usc);
        }

        private void btnCanceling_Click(object sender, RoutedEventArgs e)
        {
            GridSearchResultForOthersRooms.Children.Clear();
            UserControl usc = new CancelingTerm();
            GridSearchResultForOthersRooms.Children.Add(usc);
        }
    }
}
