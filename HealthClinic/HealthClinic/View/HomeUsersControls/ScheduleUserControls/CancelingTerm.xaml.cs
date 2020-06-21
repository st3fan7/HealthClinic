using HealthClinic.View.Dialogues;
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
    /// Interaction logic for CancelingTerm.xaml
    /// </summary>
    public partial class CancelingTerm : UserControl
    {
        //public static Termin termForCanceling = new Termin();
        public CancelingTerm(string selectedDate)
        {
            InitializeComponent();
            dateLabel.Content = selectedDate;
            //timeLabel.Content = term.Vreme;
            //roomLabel.Content = term.Sala;
            //doctorLabel.Content = term.Lekar;
            //patientLabel.Content = term.Pacijent;
            //termForCanceling = term;
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            (this.Parent as Panel).Children.Remove(this);
        }

        private void homeBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridScheduleTerm.Children.Clear();
            UserControl usc = new Home();
            GridScheduleTerm.Children.Add(usc);
        }

        private void scheduleBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridScheduleTerm.Children.Clear();
            UserControl usc = new Schedule();
            GridScheduleTerm.Children.Add(usc);

        }

        private void patienstBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridScheduleTerm.Children.Clear();
            UserControl usc = new Patient();
            GridScheduleTerm.Children.Add(usc);
        }

        private void settingsBtn_Click(object sender, RoutedEventArgs e)
        {
            GridScheduleTerm.Children.Clear();
            UserControl usc = new Settings();
            GridScheduleTerm.Children.Add(usc);
        }

        private void reportBtn_Click(object sender, RoutedEventArgs e)
        {
            GridScheduleTerm.Children.Clear();
            UserControl usc = new Report();
            GridScheduleTerm.Children.Add(usc);
        }

        private void confirmBtn_Click(object sender, RoutedEventArgs e)
        {

            //foreach (Termin term in Loading.termini)
            //{
            //    if (term == termForCanceling)
            //    {
            //        term.Status = "Slobodan";
            //        term.Pacijent = "";
            //        if (term.StvaraSeKodDoktora == false)
            //            term.Lekar = "";
            //        else
            //            term.Sala = "";

                    (this.Parent as Panel).Children.RemoveRange(1, 6);
            //        return;
            //    }
            //}
        }

        private void giveUpBtn_Click(object sender, RoutedEventArgs e)
        {
            (this.Parent as Panel).Children.Remove(this);
        }

        
    }
}
