using HealthClinic.View.Dialogues;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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
    public partial class RelocationTerm3 : UserControl//, INotifyPropertyChanged
    {


        //Termin termForRelocation = new Termin();
        //Termin stari = new Termin();
        private static List<String> roomsFromCmbx = new List<String>();
        //private List<Sobe> sobe = new List<Sobe>();
        //private List<Lekar> lekari = new List<Lekar>();

        public RelocationTerm3( List<String> rooms)
        {
            InitializeComponent();
            //dateLabel.Content = stariTermin.Datum;
            //timeLabel.Content = stariTermin.Vreme;
            //roomLabel.Content = stariTermin.Sala;
            //doctorLabel.Content = stariTermin.Lekar;
            //patientLabel.Content = stariTermin.Pacijent;
            //termForRelocation = term;
            //stari = stariTermin;
            //relocateBtn.IsEnabled = false;

            //// vidi ovo za sobe da uradis kao za lekare
            //roomsFromCmbx = rooms.Distinct().ToList();


            //sobe.Clear();
            //foreach (String r in roomsFromCmbx)
            //{
            //    sobe.Add(new Sobe() { Soba = r });
            //}


            //cmbx1.ItemsSource = sobe;
            //cmbx1.DisplayMemberPath = "Soba";



            //Console.WriteLine("Poslao sam soba: " + sobe.Count);


            //Console.WriteLine("Poslao sam soba: " + sobe.Count);


            //List<String> doctors = new List<String>();
            //if(term.Zadatak == "Operacija")
            //{
            //    foreach (Lekar l in Loading.lekariSpecijaliste)
            //    {
            //        doctors.Add(l.Doktor);
            //    }
            //} else
            //{
            //    foreach (Lekar l in Loading.lekari)
            //    {
            //        doctors.Add(l.Doktor);
            //    }
            //}


            //lekari.Clear();
            //foreach (String d in doctors)
            //{
            //    Console.WriteLine("Doktor: " + d);
            //    lekari.Add(new Lekar() { Doktor = d });
            //}


            //cmbx2.ItemsSource = lekari;
            //cmbx2.DisplayMemberPath = "Doktor";

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
            UserControl usc = new PatientView();
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
            


            //termForRelocation.Sala = cmbx1.Text; // ti stavi samo slobodne sale

            //termForRelocation.Lekar = cmbx2.Text; // ti stavi samo slobodne lekare

            


            //foreach (Termin term in Loading.termini)
            //{
            //    if (term == RelocationTerm.termForCanceling)
            //    {
            //        term.Status = "Slobodan";
            //        term.Pacijent = "";
            //        if (term.StvaraSeKodDoktora == false)
            //            term.Lekar = "";
            //        else
            //            term.Sala = "";
                    
            //        break;
            //    }
            //}

           

            //foreach (Termin term in Loading.termini)
            //{
            //    Console.WriteLine(term.Sala);
            //    if(!term.Sala.Equals(""))
            //    {
                    


            //        if (term.Datum.Equals(termForRelocation.Datum) && term.Vreme.Equals(termForRelocation.Vreme) && term.Sala.Equals(termForRelocation.Sala) && term.Zadatak.Equals(termForRelocation.Zadatak) && term.Status.Equals("Slobodan"))
            //        {

                        
            //            //Console.WriteLine("Termin pre izmene: Datum: " + term.Datum + " Vreme: " + term.Vreme + " Sala: " + term.Sala + " Lekar: " + term.Lekar + " Pacijent: " + term.Pacijent + " Status: " + term.Status + " Zadatak: " + term.Zadatak);
            //            term.Lekar = termForRelocation.Lekar;
            //            term.Pacijent = termForRelocation.Pacijent;
            //            term.Status = termForRelocation.Status;
            //            SurgeryRooms sr = new SurgeryRooms(dateLabel.Content.ToString());
            //            // Console.WriteLine("Termin pre izmene: Datum: " + term.Datum + " Vreme: " + term.Vreme + " Sala: " + term.Sala + " Lekar: " + term.Lekar + " Pacijent: " + term.Pacijent + " Status: " + term.Status + " Zadatak: " + term.Zadatak);
            //            (this.Parent as Panel).Children.RemoveRange(1, 6);
            //            return;


            //        } 
            //    } else
            //    {
            //        if (term.Datum.Equals(termForRelocation.Datum) && term.Vreme.Equals(termForRelocation.Vreme) && term.Lekar.Equals(termForRelocation.Lekar) && term.Zadatak.Equals(termForRelocation.Zadatak) && term.Status.Equals("Slobodan"))
            //        {

                        
            //            //Console.WriteLine("Termin pre izmene: Datum: " + term.Datum + " Vreme: " + term.Vreme + " Sala: " + term.Sala + " Lekar: " + term.Lekar + " Pacijent: " + term.Pacijent + " Status: " + term.Status + " Zadatak: " + term.Zadatak);
            //            term.Sala = termForRelocation.Sala;
            //            term.Pacijent = termForRelocation.Pacijent;
            //            term.Status = termForRelocation.Status;
            //            SurgeryRooms sr = new SurgeryRooms(dateLabel.Content.ToString());
            //            // Console.WriteLine("Termin pre izmene: Datum: " + term.Datum + " Vreme: " + term.Vreme + " Sala: " + term.Sala + " Lekar: " + term.Lekar + " Pacijent: " + term.Pacijent + " Status: " + term.Status + " Zadatak: " + term.Zadatak);
            //            (this.Parent as Panel).Children.RemoveRange(1, 6);
            //            return;


            //        }
                   
            //    }
               
            //}
           

        }

        private void cmbx1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(!cmbx2.Text.Equals(""))
                relocateBtn.IsEnabled = true;
        }

        private void cmbx2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (!cmbx1.Text.Equals(""))
                relocateBtn.IsEnabled = true;
        }
    }
}
