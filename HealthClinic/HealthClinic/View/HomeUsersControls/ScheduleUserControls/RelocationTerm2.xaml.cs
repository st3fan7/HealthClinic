using HealthClinic.View.Dialogues;
using System;
using System.Collections.Generic;
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
        //Termin stari = new Termin();
        private static int counter = 0;
        private static List<String> roomsFromCmbx = new List<String>();
        public RelocationTerm2(string selectedDate, List<String> rooms)
        {
            InitializeComponent();
            dateLabel.Content = selectedDate;
            //timeLabel.Content = stariTermin.Vreme;
            //roomLabel.Content = stariTermin.Sala;
            //doctorLabel.Content = stariTermin.Lekar;
            //patientLabel.Content = stariTermin.Pacijent;
            //termForRelocation = term; // popunio sam mu datum, status i zadatak
            //stari = stariTermin;
            textWarning.Visibility = textWarningHidden;
            counter = 0;
            roomsFromCmbx = rooms;
            textWarning.Visibility = textWarningHidden;
            //Console.WriteLine("Termin pre izmene: Datum: " + termForRelocation.Datum + " Vreme: " + termForRelocation.Vreme + " Sala: " + termForRelocation.Sala + " Lekar: " + termForRelocation.Lekar + " Pacijent: " + termForRelocation.Pacijent + " Status: " + termForRelocation.Status + " Zadatak: " + termForRelocation.Zadatak);
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

            //Console.WriteLine("Termin pre izmene: Datum: " + termForRelocation.Datum + " Vreme: " + termForRelocation.Vreme + " Sala: " + termForRelocation.Sala + " Lekar: " + termForRelocation.Lekar + " Pacijent: " + termForRelocation.Pacijent + " Status: " + termForRelocation.Status + " Zadatak: " + termForRelocation.Zadatak);
            //termForRelocation.Vreme = cmbx.Text;
                                                
            //List<String> sale = new List<String>();
            //if(termForRelocation.Zadatak == "Operacija")
            //{
            //    foreach(Sobe s in Loading.sobeZaOperaciju)
            //    {
            //        sale.Add(s.Soba);
            //    }
            //} else
            //{
            //    foreach (Sobe s in Loading.sobeZaPregled)
            //    {
            //        sale.Add(s.Soba);
            //    }
            //}

            //String novaSala;
            //foreach(String s in sale)
            //{
            //    if (!s.Equals(termForRelocation.Sala))
            //    {
            //        novaSala = s;
            //    }
            //}

            
            //foreach (Termin term in Loading.termini)
            //{
            //    String salaTerminaZaPremestanje = termForRelocation.Sala;

            //    if (term.Datum.Equals(termForRelocation.Datum) && term.Vreme.Equals(termForRelocation.Vreme) && term.Zadatak.Equals(termForRelocation.Zadatak))
            //    {
            //        if (term.Status == "Slobodan")
            //        {
            //            textWarning.Visibility = textWarningHidden;
            //            Console.WriteLine("Termin pre izmene: Datum: " + termForRelocation.Datum + " Vreme: " + termForRelocation.Vreme + " Sala: " + termForRelocation.Sala + " Lekar: " + termForRelocation.Lekar + " Pacijent: " + termForRelocation.Pacijent + " Status: " + termForRelocation.Status + " Zadatak: " + termForRelocation.Zadatak);
            //            UserControl usc = new RelocationTerm3(stari, termForRelocation, roomsFromCmbx);
            //            (this.Parent as Panel).Children.Add(usc);
            //            return;
            //        }
            //        else
            //        {
            //            textWarning.Visibility = textWarningVisible;
            //            //Console.WriteLine("To vremee je zauzeto!");
            //            //MessageBox.Show("Izabrano vreme je zauzeto!");
            //            return;
            //        }

            //    }
            //    else
            //    {
            //        textWarning.Visibility = textWarningVisible;
            //    }
            //}
                
                
            
   
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
