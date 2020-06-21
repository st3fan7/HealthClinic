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
    /// Interaction logic for AccommodationPatient.xaml
    /// </summary>
    public partial class AccommodationPatient : UserControl
    {
        //Oporavak oporavakKojegMenjam = new Oporavak();
        //Pacijent pacijentKojegZelimoDaSmestimoNaOporavak = new Pacijent();
        public AccommodationPatient(string selectedDate)
        {
            InitializeComponent();
            dateLabel.Content = selectedDate;
            //oporavakKojegMenjam = oporavak;
            //l11.Content = oporavak.Prijem;
            //l22.Content = oporavak.Sala;
            //pacijentKojegZelimoDaSmestimoNaOporavak = pacijent;
            //nameLabel2.Content = pacijent.Name;
            //lastNameLabel2.Content = pacijent.Surname;
            //jmbgLabel2.Content = pacijent.Id;
        }

        private void homeBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridAccommodationPatient.Children.Clear();
            UserControl usc = new Home();
            GridAccommodationPatient.Children.Add(usc);
        }

        private void scheduleBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridAccommodationPatient.Children.Clear();
            UserControl usc = new Schedule();
            GridAccommodationPatient.Children.Add(usc);
        }

        private void patienstBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridAccommodationPatient.Children.Clear();
            UserControl usc = new Patient();
            GridAccommodationPatient.Children.Add(usc);
        }

        private void settingsBtn_Click(object sender, RoutedEventArgs e)
        {
            GridAccommodationPatient.Children.Clear();
            UserControl usc = new Settings();
            GridAccommodationPatient.Children.Add(usc);
        }

        private void reportBtn_Click(object sender, RoutedEventArgs e)
        {
            GridAccommodationPatient.Children.Clear();
            UserControl usc = new Report();
            GridAccommodationPatient.Children.Add(usc);
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            (this.Parent as Panel).Children.Remove(this);
        }

        private void yesBtn_Click(object sender, RoutedEventArgs e)
        {
            //foreach(Oporavak o in Loading.oporavci)
            //{
            //    if(o == oporavakKojegMenjam)
            //    {
            //        o.Pacijent = pacijentKojegZelimoDaSmestimoNaOporavak.Name + " " + pacijentKojegZelimoDaSmestimoNaOporavak.Surname;
            //        o.Status = "Zauzet";
            //    }
            //}
            (this.Parent as Panel).Children.RemoveRange(1, 6);
        }

    }
}
