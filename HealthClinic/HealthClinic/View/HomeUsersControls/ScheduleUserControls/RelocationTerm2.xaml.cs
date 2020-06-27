using HealthClinic.View.Dialogues;
using HealthClinic.View.ViewModel;
using Model.Term;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
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
    /// Interaction logic for RelocationTerm2.xaml
    /// </summary>
    public partial class RelocationTerm2 : UserControl
    {
        //Termin termForRelocation = new Termin();
        ViewTerm odlTerm = new ViewTerm();
        ViewTerm termForRelocation = new ViewTerm();
        private static int counter = 0;
        private static ObservableCollection<Room> roomsFromCmbx = new ObservableCollection<Room>();

        private ObservableCollection<ViewTerm> currentTerms = new ObservableCollection<ViewTerm>();
        public RelocationTerm2(string selectedDate, ViewTerm term, ViewTerm oldTerm, ObservableCollection<Room> rooms)
        {
            InitializeComponent();
            dateLabel.Content = selectedDate;
            timeLabel.Content = oldTerm.Time;
            roomLabel.Content = oldTerm.Room;
            doctorLabel.Content = oldTerm.Doctor;
            patientLabel.Content = oldTerm.Patient;
            termForRelocation = term; // popunio sam mu datum, status i zadatak
            this.odlTerm = oldTerm;
            textWarning.Visibility = textWarningHidden;
            counter = 0;
            roomsFromCmbx = rooms;
            textWarning.Visibility = textWarningHidden;
            
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            (this.Parent as Panel).Children.Remove(this);
        }

        private void homeBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridRelocationTerm2.Children.Clear();
            UserControl usc = new Home();
            GridRelocationTerm2.Children.Add(usc);
        }

        private void scheduleBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridRelocationTerm2.Children.Clear();
            UserControl usc = new Schedule();
            GridRelocationTerm2.Children.Add(usc);

        }

        private void patienstBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridRelocationTerm2.Children.Clear();
            UserControl usc = new PatientView();
            GridRelocationTerm2.Children.Add(usc);
        }

        private void settingsBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridRelocationTerm2.Children.Clear();
            UserControl usc = new Settings();
            GridRelocationTerm2.Children.Add(usc);
        }

        private void reportBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridRelocationTerm2.Children.Clear();
            UserControl usc = new Report();
            GridRelocationTerm2.Children.Add(usc);
        }

        private void nextBtn_Click(object sender, RoutedEventArgs e)
        {
            String[] cmbxParts = cmbx.SelectedItem.ToString().Split(' ');
            String[] timeParts = cmbxParts[1].Split('-');

            String timeStart = timeParts[0];
            String timeEnd = timeParts[1];

            termForRelocation.Time = termForRelocation.Date + " " + timeStart + " - " + termForRelocation.Date + " " + timeEnd;
            //Console.WriteLine("Vreme termina: " + termForRelocation.Time);

            UserControl usc = new RelocationTerm3(odlTerm, termForRelocation, roomsFromCmbx);
            (this.Parent as Panel).Children.Add(usc);

        }

        private Visibility textWarningVisible
        {
            get { return Visibility.Visible; }
        }
        private Visibility textWarningHidden
        {
            get { return Visibility.Hidden; }
        }

        private void cmbx_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            counter++;
            if (counter > 1)
                textWarning.Visibility = textWarningHidden;
            
        }
    }
}
