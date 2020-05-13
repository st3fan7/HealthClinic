using HealthClinic.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
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
using PagedList;

namespace HealthClinic.View
{
    /// <summary>
    /// Interaction logic for SurgeryRooms.xaml
    /// </summary>
    public partial class SurgeryRooms : UserControl
    {
        List<Termin> termini = new List<Termin>();
        //int pageNumber = 1;
        //IPagedList<Termin> list;

        public SurgeryRooms()
        {
            InitializeComponent();
            

            Schedule s = new Schedule();
            datumLabel.Content = s.datePickerSchedule.DisplayDate; // treba da povuces datum i prikazes
                                                                   //this.DataContext = this;
                                                                   //Termini = new ObservableCollection<Termin>();

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
            GridSurgeryRooms.Children.Clear();
            UserControl usc = new TypeOfRoom();
            GridSurgeryRooms.Children.Add(usc);

        }

        private void homeBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridSurgeryRooms.Children.Clear();
            UserControl usc = new Home();
            GridSurgeryRooms.Children.Add(usc);
        }

        private void scheduleBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridSurgeryRooms.Children.Clear();
            UserControl usc = new Schedule();
            GridSurgeryRooms.Children.Add(usc);
        }

        private void patienstBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridSurgeryRooms.Children.Clear();
            UserControl usc = new Patient();
            GridSurgeryRooms.Children.Add(usc);
        }

        private void settingsBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridSurgeryRooms.Children.Clear();
            UserControl usc = new Settings();
            GridSurgeryRooms.Children.Add(usc);
        }

        private void reportBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridSurgeryRooms.Children.Clear();
            UserControl usc = new Report();
            GridSurgeryRooms.Children.Add(usc);
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            fillData();
        }

        private void btnSchedule_Click(object sender, RoutedEventArgs e)
        {
            GridSurgeryRooms.Children.Clear();
            UserControl usc = new PatientValidation();
            GridSurgeryRooms.Children.Add(usc);


            //SurgeryRooms sr = new SurgeryRooms();
            //var row_list = (Termin)dgTerms.SelectedItem;
            //ScheduleTerm st = new ScheduleTerm();
            //st.l1.Content = row_list.Vreme;
            //Console.WriteLine(row_list.Vreme);


        }

        private void btnRelocate_Click(object sender, RoutedEventArgs e)
        {
            GridSurgeryRooms.Children.Clear();
            UserControl usc = new RelocationTerm();
            GridSurgeryRooms.Children.Add(usc);
        }

        private void btnCanceling_Click(object sender, RoutedEventArgs e)
        {
            GridSurgeryRooms.Children.Clear();
            UserControl usc = new CancelingTerm();
            GridSurgeryRooms.Children.Add(usc);
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            GridSurgeryRooms.Children.Clear();
            UserControl usc = new SearchInOthersRoom();
            GridSurgeryRooms.Children.Add(usc);
        }

    }
}
