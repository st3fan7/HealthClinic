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
    /// Interaction logic for ScheduleTerm.xaml
    /// </summary>
    public partial class ScheduleTerm : UserControl
    {
        //Termin terminKojiSeZakazuje = new Termin();
        //Pacijent pacijentKomeSeZakazujeTermin = new Pacijent();
        //private List<Lekar> lekari = new List<Lekar>();
        //private List<Sobe> sobe = new List<Sobe>();
        private static List<String> doctorsFromCmbx = new List<String>();
        public ScheduleTerm(string selectedDate, List<String> doctors)
        {
            InitializeComponent();
            dateLabel.Content = selectedDate;
            //terminKojiSeZakazuje = term;
            //l11.Content = term.Vreme;
            //l22.Content = term.Zadatak;
            //l33.Content = pacijent.Name + " " + pacijent.Surname; 
            //pacijentKomeSeZakazujeTermin = pacijent;
            confirmBtn.IsEnabled = false;
            doctorsFromCmbx = doctors.Distinct().ToList();

            l4.Visibility = Visibility.Hidden;
            l5.Visibility = Visibility.Hidden;

        
            cmbxRoom.IsHitTestVisible = false;
            cmbxRoom.Focusable = false;
            cmbxRoom.Visibility = Visibility.Hidden;
            label4.Visibility = Visibility.Hidden;
            label3.Visibility = Visibility.Hidden;

            cmbxDoctor.IsHitTestVisible = false;
            cmbxDoctor.Focusable = false;
            cmbxDoctor.Visibility = Visibility.Hidden;


            //if (!terminKojiSeZakazuje.Sala.Equals(""))
            //{
            //    l44.Content = term.Sala;
            //    l4.Visibility = Visibility.Visible;

            //    // ako sala postoji treba doktor da se bira
            //    cmbxDoctor.Visibility = Visibility.Visible;
            //    cmbxDoctor.IsHitTestVisible = true;
            //    cmbxDoctor.Focusable = true;
            //    label3.Visibility = Visibility.Visible;

            //    List<String> lekariKojePunim = new List<String>();
            //    if (term.Zadatak == "Operacija")
            //    {
            //        foreach (Lekar d in Loading.lekariSpecijaliste)
            //        {
            //            lekariKojePunim.Add(d.Doktor);
            //        }
            //    }
            //    else
            //    {
            //        foreach (Lekar d in Loading.lekari)
            //        {
            //            lekariKojePunim.Add(d.Doktor);
            //        }
            //    }

            //    lekari.Clear();
            //    foreach (String d in lekariKojePunim)
            //    {
            //        Console.WriteLine("Doktor: " + d);
            //        lekari.Add(new Lekar() { Doktor = d });
            //    }


            //    cmbxDoctor.ItemsSource = lekari;
            //    cmbxDoctor.DisplayMemberPath = "Doktor";

                //Console.WriteLine("Poslao sam doktora: " + lekari.Count);

            //}
            //else
            //{
            //    // imamo doktora
            //    l44.Content = term.Lekar;
            //    l5.Visibility = Visibility.Visible;
            //    cmbxRoom.Visibility = Visibility.Visible;
            //    cmbxRoom.IsHitTestVisible = true;
            //    cmbxRoom.Focusable = true;
            //    label4.Visibility = Visibility.Visible;

            //    List<String> sobeKojimaSePuni = new List<String>();
            //    if(term.Zadatak == "Operacija")
            //    {
            //        foreach (Sobe s in Loading.sobeZaOperaciju)
            //        {
            //            sobeKojimaSePuni.Add(s.Soba);
            //        }
            //    } else
            //    {
            //        foreach (Sobe s in Loading.sobeZaPregled)
            //        {
            //            sobeKojimaSePuni.Add(s.Soba);
            //        }
            //    }
                

            //    sobe.Clear();
            //    foreach (String r in sobeKojimaSePuni)
            //    {
            //        sobe.Add(new Sobe() { Soba = r });
            //    }


            //    cmbxRoom.ItemsSource = sobe;
            //    cmbxRoom.DisplayMemberPath = "Soba";



            //    Console.WriteLine("Poslao sam soba: " + sobe.Count);

            //}


        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            (this.Parent as Panel).Children.RemoveRange(2, 3);
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

        private void settingsBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridScheduleTerm.Children.Clear();
            UserControl usc = new Settings();
            GridScheduleTerm.Children.Add(usc);
        }

        private void reportBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridScheduleTerm.Children.Clear();
            UserControl usc = new Report();
            GridScheduleTerm.Children.Add(usc);
        }

        private void confirmBtn_Click(object sender, RoutedEventArgs e)
        {
            // treba da se uradi update termina


            //Console.WriteLine("Termin pre izmene: Datum: " + terminKojiSeZakazuje.Datum + " Vreme: " + terminKojiSeZakazuje.Vreme + " Sala: " + terminKojiSeZakazuje.Sala + " Lekar: " + terminKojiSeZakazuje.Lekar + " Pacijent: " + terminKojiSeZakazuje.Pacijent + " Status: " + terminKojiSeZakazuje.Status + " Zadatak: " + terminKojiSeZakazuje.Zadatak);
            //foreach (Termin term in Loading.termini)
            //{
            //    if (term == terminKojiSeZakazuje)
            //    {
            //        Console.WriteLine("Isti je");
            //        if (!terminKojiSeZakazuje.Sala.Equals(""))
            //        {
            //            term.Sala = terminKojiSeZakazuje.Sala;
            //            term.Status = "Zauzet";
            //            term.Pacijent = pacijentKomeSeZakazujeTermin.Name + " " + pacijentKomeSeZakazujeTermin.Surname;
            //            term.Lekar = cmbxDoctor.Text;
            //        }
            //        else
            //        {
            //            term.Lekar = terminKojiSeZakazuje.Lekar;
            //            term.Status = "Zauzet";
            //            term.Pacijent = pacijentKomeSeZakazujeTermin.Name + " " + pacijentKomeSeZakazujeTermin.Surname;
            //            term.Sala = cmbxRoom.Text;
            //        }
                    
                    
            //        (this.Parent as Panel).Children.RemoveRange(1, 6);
            //        return;
            //    }
            //}


           
        }

        private void cmbxDoctor_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(cmbxDoctor.Text != null)
            {
                confirmBtn.IsEnabled = true;
            }
            
        }

        private void cmbxRoom_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cmbxRoom.Text != null)
            {
                confirmBtn.IsEnabled = true;
            }
        }
    }
}
