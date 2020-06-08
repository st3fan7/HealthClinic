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

namespace HealthClinic.View
{
    /// <summary>
    /// Interaction logic for SurgeryRooms.xaml
    /// </summary>
    public partial class SurgeryRooms : UserControl
    {
        List<Termin> termini = new List<Termin>();
        public SurgeryRooms(string selectedDate)
        {
            InitializeComponent();

            dateLabel.Content = selectedDate; 
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
            UserControl usc = new TypeOfRoom(dateLabel.Content.ToString());
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
            
            UserControl usc = new PatientValidation(dateLabel.Content.ToString());
            (this.Parent as Panel).Children.Add(usc);

        }

        private void btnRelocate_Click(object sender, RoutedEventArgs e)
        {
            Termin term = dgTerms.SelectedItem as Termin;
            fillTermWithDataFromSelectedRow(term);

            UserControl usc = new RelocationTerm(dateLabel.Content.ToString(), term);
            (this.Parent as Panel).Children.Add(usc);

        }



        private void btnCanceling_Click(object sender, RoutedEventArgs e)
        {
            Termin term = dgTerms.SelectedItem as Termin;
            fillTermWithDataFromSelectedRow(term);

            UserControl usc = new CancelingTerm(dateLabel.Content.ToString(), term);
            (this.Parent as Panel).Children.Add(usc);
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            UserControl usc = new SearchInOthersRoom(dateLabel.Content.ToString());
            (this.Parent as Panel).Children.Add(usc);
        }

        private static void fillTermWithDataFromSelectedRow(Termin term)
        {
            term.Vreme = Convert.ToString(term.Vreme);
            term.Sala = Convert.ToString(term.Sala);
            term.Lekar = Convert.ToString(term.Lekar);
            term.Pacijent = Convert.ToString(term.Pacijent);
            term.Status = Convert.ToString(term.Status);
        }

        private void dgTerms_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Termin term = dgTerms.SelectedItem as Termin;
            fillTermWithDataFromSelectedRow(term);
            if (term.Status.Equals("Slobodan"))
            {
                //btnRelocate.BorderBrush = Brushes.Red;
                //btnCanceling.BorderBrush = Brushes.Red;
                //btnSchedule.BorderBrush = Brushes.Black;
                btnRelocate.IsEnabled = false;
                btnCanceling.IsEnabled = false;
                btnSchedule.IsEnabled = true;
            } else if (term.Status.Equals("Zauzet"))
            {
                //btnRelocate.BorderBrush = Brushes.Black;
                //btnCanceling.BorderBrush = Brushes.Black;
                //btnSchedule.BorderBrush = Brushes.Red;
                btnRelocate.IsEnabled = true;
                btnCanceling.IsEnabled = true;
                btnSchedule.IsEnabled = false;
            }
        }
    }
}
