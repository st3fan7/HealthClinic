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
    /// Interaction logic for RelocationTerm2.xaml
    /// </summary>
    public partial class RelocationTerm2 : UserControl
    {
        public RelocationTerm2(string selectedDate, Termin term)
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
            UserControl usc = new Patient();
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
            Termin term = new Termin();
            term.Vreme = timeLabel.Content.ToString();
            term.Sala = roomLabel.Content.ToString();
            term.Lekar = doctorLabel.Content.ToString();
            term.Pacijent = patientLabel.Content.ToString();
            term.Status = null;

            UserControl usc = new RelocationTerm3(dateLabel.Content.ToString(), term);
            (this.Parent as Panel).Children.Add(usc);
        }
    }
}
