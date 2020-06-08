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

namespace HealthClinic.View.HomeUsersControls.ScheduleUserControls
{
    /// <summary>
    /// Interaction logic for DoctorsSepcialistTerms.xaml
    /// </summary>
    public partial class DoctorsSepcialistTerms : UserControl
    {
        List<Termin> termini = new List<Termin>();
        public DoctorsSepcialistTerms(string selectedDate)
        {
            InitializeComponent();
            dateLabel.Content = selectedDate;
        }

        private void fillData()
        {
            termini.Add(new Termin() { Vreme = "09:00 - 10:00", Sala = "A1", Lekar = "Ana Anić", Pacijent = "Petar Perić", Status = "Zauzet" });
            termini.Add(new Termin() { Vreme = "10:00 - 11:00", Sala = null, Lekar = "Ana Anić", Pacijent = null, Status = "Slobodan" });
            termini.Add(new Termin() { Vreme = "11:00 - 11:30", Sala = "B2", Lekar = "Ana Anić", Pacijent = "Miloš Milošević", Status = "Zauzet" });
            termini.Add(new Termin() { Vreme = "14:00 - 14:30", Sala = "B2", Lekar = "Petra Anić", Pacijent = "Miloš Mišić", Status = "Zauzet" });
            termini.Add(new Termin() { Vreme = "15:00 - 15:30", Sala = "B1", Lekar = "Miša Mikić", Pacijent = "Miloš Mišić", Status = "Zauzet" });
            dgTerms.ItemsSource = termini;
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            fillData();
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            GridDoctorsTerms.Children.Clear();
            UserControl usc = new TypeOfDoctors(dateLabel.Content.ToString());
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

        private static void fillTermWithDataFromSelectedRow(Termin term)
        {
            term.Vreme = Convert.ToString(term.Vreme);
            term.Sala = Convert.ToString(term.Sala);
            term.Lekar = Convert.ToString(term.Lekar);
            term.Pacijent = Convert.ToString(term.Pacijent);
            term.Status = Convert.ToString(term.Status);
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            UserControl usc = new SearchInOthersRoom(dateLabel.Content.ToString());
            (this.Parent as Panel).Children.Add(usc);
        }

        private void dgTerms_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Termin term = dgTerms.SelectedItem as Termin;
            fillTermWithDataFromSelectedRow(term);
            if (term.Status.Equals("Slobodan"))
            {
                btnRelocate.IsEnabled = false;
                btnCanceling.IsEnabled = false;
                btnSchedule.IsEnabled = true;
            }
            else if (term.Status.Equals("Zauzet"))
            {
                btnRelocate.IsEnabled = true;
                btnCanceling.IsEnabled = true;
                btnSchedule.IsEnabled = false;
            }
        }
    }
}
