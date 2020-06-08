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
        public StartTimeTerms(string selectedDate /*, string selectedTime*/)
        {
            InitializeComponent();
            dateLabel.Content = selectedDate;
            //timeLabel.Content = selectedTime;
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
            UserControl usc = new StartTimeView(dateLabel.Content.ToString());
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
