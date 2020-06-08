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
    /// Interaction logic for RelocationTerm.xaml
    /// </summary>
    public partial class RelocationTerm : UserControl
    {
        public RelocationTerm(string selectedDate, Termin term)
        {
            InitializeComponent();
            datePickerSchedule.DisplayDateStart = DateTime.Now;
            textWarning.Visibility = textWarningVisible;
            dateLabel.Content = selectedDate;
            timeLabel.Content = term.Vreme;
            roomLabel.Content = term.Sala;
            doctorLabel.Content = term.Lekar;
            patientLabel.Content = term.Pacijent;
        }

        private void homeBtn2_Click(object sender, RoutedEventArgs e)
        {

            GridRelocationTerm.Children.Clear();
            UserControl usc = new Home();
            GridRelocationTerm.Children.Add(usc);
        }

        private void scheduleBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridRelocationTerm.Children.Clear();
            UserControl usc = new Schedule();
            GridRelocationTerm.Children.Add(usc);

        }

        private void patienstBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridRelocationTerm.Children.Clear();
            UserControl usc = new Patient();
            GridRelocationTerm.Children.Add(usc);
        }

        private void settingsBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridRelocationTerm.Children.Clear();
            UserControl usc = new Settings();
            GridRelocationTerm.Children.Add(usc);
        }

        private void reportBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridRelocationTerm.Children.Clear();
            UserControl usc = new Report();
            GridRelocationTerm.Children.Add(usc);
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            (this.Parent as Panel).Children.Remove(this);
        }

        private void nextBtn_Click(object sender, RoutedEventArgs e)
        {


            if (datePickerSchedule.SelectedDate != null)
            {
                Termin term = new Termin();
                term.Vreme = timeLabel.Content.ToString();
                term.Sala = roomLabel.Content.ToString();
                term.Lekar = doctorLabel.Content.ToString();
                term.Pacijent = patientLabel.Content.ToString();
                term.Status = null;

                UserControl usc = new RelocationTerm2(dateLabel.Content.ToString(), term);
                (this.Parent as Panel).Children.Add(usc);
            }
            else
            {
                textWarning.Visibility = textWarningHidden;

            }
        }

        private Visibility textWarningHidden
        {
            get { return Visibility.Visible; }
        }
        private Visibility textWarningVisible
        {
            get { return Visibility.Hidden; }
        }

        private void datePickerSchedule_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            if (datePickerSchedule.SelectedDate != null)
            {

                textWarning.Visibility = textWarningVisible;
            }
            else
            {
                textWarning.Visibility = textWarningHidden;
            }

        }
    }
}
