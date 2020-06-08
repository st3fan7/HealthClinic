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
    /// Interaction logic for RelocationTerm3.xaml
    /// </summary>
    public partial class RelocationTerm3 : UserControl
    {
        public RelocationTerm3(string selectedDate, Termin term)
        {
            InitializeComponent();
            dateLabel.Content = selectedDate;
            timeLabel.Content = term.Vreme;
            roomLabel.Content = term.Sala;
            doctorLabel.Content = term.Lekar;
            patientLabel.Content = term.Pacijent;
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            (this.Parent as Panel).Children.Remove(this);
        }

        private void homeBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridRelocationTerm3.Children.Clear();
            UserControl usc = new Home();
            GridRelocationTerm3.Children.Add(usc);
        }

        private void scheduleBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridRelocationTerm3.Children.Clear();
            UserControl usc = new Schedule();
            GridRelocationTerm3.Children.Add(usc);
        }

        private void patienstBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridRelocationTerm3.Children.Clear();
            UserControl usc = new Patient();
            GridRelocationTerm3.Children.Add(usc);
        }

        private void settingsBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridRelocationTerm3.Children.Clear();
            UserControl usc = new Settings();
            GridRelocationTerm3.Children.Add(usc);
        }

        private void reportBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridRelocationTerm3.Children.Clear();
            UserControl usc = new Report();
            GridRelocationTerm3.Children.Add(usc);
        }

        private void relocateBtn_Click(object sender, RoutedEventArgs e)
        {
            // treba da se vrati tamo gde je usao ali posto ne znam kako se vraca nekoliko koraka u nazad daj obavestenje i vrati na pocetnu
            //GridRelocationTerm3.Children.Clear();
            //UserControl usc = new Home();
            //GridRelocationTerm3.Children.Add(usc);
            (this.Parent as Panel).Children.RemoveRange(1, 6);
        }
    }
}
