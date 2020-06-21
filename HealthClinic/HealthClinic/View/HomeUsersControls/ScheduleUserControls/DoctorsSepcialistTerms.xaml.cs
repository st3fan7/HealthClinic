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

namespace HealthClinic.View.HomeUsersControls.ScheduleUserControls
{
    /// <summary>
    /// Interaction logic for DoctorsSepcialistTerms.xaml
    /// </summary>
    public partial class DoctorsSepcialistTerms : UserControl
    {

        public static List<String> cmbxItems = new List<String>();
        //private List<Termin> trenutniTermini = new List<Termin>();
        public int counter = 0;
        public DoctorsSepcialistTerms(string selectedDate)
        {
            InitializeComponent();
            dateLabel.Content = selectedDate;
            this.DataContext = this;
            counter = 0;
            fillData(DisplayType.date);
            cmbxItems.Clear();
            searchTextBox.Visibility = Visibility.Hidden;
            btnSearch.Visibility = Visibility.Visible;
            btnClose.Visibility = Visibility.Hidden;

            btnRelocate.IsEnabled = false;
            btnCanceling.IsEnabled = false;
            btnSchedule.IsEnabled = false;
            
        }

        private void fillData(String date)
        {
            Console.WriteLine("USAO U FILLDATA");
            //trenutniTermini.Clear();
            String doctor = "";
            //cmbx.Items.Refresh();
            if (cmbx.SelectedItem == D1)
            {
                doctor = "Ana Anić";
            } else if (cmbx.SelectedItem == D2)
            {
                doctor = "Miša Kiš";
            }
            else
            {
                doctor = "Petar Petrić";
            }
            //Console.WriteLine("Trenutni termini PRE dodavanja u njih: " + trenutniTermini.Count);
            //foreach (Termin termin in Loading.termini)
            //{


            //    if (date.Equals(termin.Datum) && doctor.Equals(termin.Lekar) && termin.Zadatak.Equals("Operacija"))
            //    {
            //        trenutniTermini.Add(termin);
            //    }
            //}
            //Console.WriteLine("Trenutni termini POSLE dodavanja u njih: " + trenutniTermini.Count);
            //foreach (Termin term in trenutniTermini)
            //{

            //    Console.WriteLine("Vreme posle dodavanja je: " + term.Vreme);
                
            //}

            //if (trenutniTermini.Count < 18)
            //{
                
            //    if (trenutniTermini.Count == 0)
            //    {

            //        // doktori specajliste - zadatak operacija
            //        trenutniTermini.Add(new Termin() { Datum = dateLabel.Content.ToString(), Vreme = "08:00 - 08:30", Sala = "", Lekar = doctor, Pacijent = "", Status = "Slobodan", Zadatak = "Operacija", StvaraSeKodDoktora = true });
            //        trenutniTermini.Add(new Termin() { Datum = dateLabel.Content.ToString(), Vreme = "08:30 - 09:00", Sala = "", Lekar = doctor, Pacijent = "", Status = "Slobodan", Zadatak = "Operacija", StvaraSeKodDoktora = true });
            //        trenutniTermini.Add(new Termin() { Datum = dateLabel.Content.ToString(), Vreme = "09:00 - 09:30", Sala = "", Lekar = doctor, Pacijent = "", Status = "Slobodan", Zadatak = "Operacija", StvaraSeKodDoktora = true });
            //        trenutniTermini.Add(new Termin() { Datum = dateLabel.Content.ToString(), Vreme = "09:30 - 10:00", Sala = "", Lekar = doctor, Pacijent = "", Status = "Slobodan", Zadatak = "Operacija", StvaraSeKodDoktora = true });
            //        trenutniTermini.Add(new Termin() { Datum = dateLabel.Content.ToString(), Vreme = "10:00 - 10:30", Sala = "", Lekar = doctor, Pacijent = "", Status = "Slobodan", Zadatak = "Operacija", StvaraSeKodDoktora = true });
            //        trenutniTermini.Add(new Termin() { Datum = dateLabel.Content.ToString(), Vreme = "10:30 - 11:00", Sala = "", Lekar = doctor, Pacijent = "", Status = "Slobodan", Zadatak = "Operacija", StvaraSeKodDoktora = true });
            //        trenutniTermini.Add(new Termin() { Datum = dateLabel.Content.ToString(), Vreme = "11:00 - 11:30", Sala = "", Lekar = doctor, Pacijent = "", Status = "Slobodan", Zadatak = "Operacija", StvaraSeKodDoktora = true });
            //        trenutniTermini.Add(new Termin() { Datum = dateLabel.Content.ToString(), Vreme = "11:30 - 12:00", Sala = "", Lekar = doctor, Pacijent = "", Status = "Slobodan", Zadatak = "Operacija", StvaraSeKodDoktora = true });
            //        trenutniTermini.Add(new Termin() { Datum = dateLabel.Content.ToString(), Vreme = "12:00 - 12:30", Sala = "", Lekar = doctor, Pacijent = "", Status = "Slobodan", Zadatak = "Operacija", StvaraSeKodDoktora = true });
            //        trenutniTermini.Add(new Termin() { Datum = dateLabel.Content.ToString(), Vreme = "12:30 - 13:00", Sala = "", Lekar = doctor, Pacijent = "", Status = "Slobodan", Zadatak = "Operacija", StvaraSeKodDoktora = true });
            //        trenutniTermini.Add(new Termin() { Datum = dateLabel.Content.ToString(), Vreme = "13:00 - 13:30", Sala = "", Lekar = doctor, Pacijent = "", Status = "Slobodan", Zadatak = "Operacija", StvaraSeKodDoktora = true });
            //        trenutniTermini.Add(new Termin() { Datum = dateLabel.Content.ToString(), Vreme = "13:30 - 14:00", Sala = "", Lekar = doctor, Pacijent = "", Status = "Slobodan", Zadatak = "Operacija", StvaraSeKodDoktora = true });
            //        trenutniTermini.Add(new Termin() { Datum = dateLabel.Content.ToString(), Vreme = "14:00 - 14:30", Sala = "", Lekar = doctor, Pacijent = "", Status = "Slobodan", Zadatak = "Operacija", StvaraSeKodDoktora = true });
            //        trenutniTermini.Add(new Termin() { Datum = dateLabel.Content.ToString(), Vreme = "14:30 - 15:00", Sala = "", Lekar = doctor, Pacijent = "", Status = "Slobodan", Zadatak = "Operacija", StvaraSeKodDoktora = true });
            //        trenutniTermini.Add(new Termin() { Datum = dateLabel.Content.ToString(), Vreme = "15:00 - 15:30", Sala = "", Lekar = doctor, Pacijent = "", Status = "Slobodan", Zadatak = "Operacija", StvaraSeKodDoktora = true });
            //        trenutniTermini.Add(new Termin() { Datum = dateLabel.Content.ToString(), Vreme = "15:30 - 16:00", Sala = "", Lekar = doctor, Pacijent = "", Status = "Slobodan", Zadatak = "Operacija", StvaraSeKodDoktora = true });
            //        trenutniTermini.Add(new Termin() { Datum = dateLabel.Content.ToString(), Vreme = "16:00 - 16:30", Sala = "", Lekar = doctor, Pacijent = "", Status = "Slobodan", Zadatak = "Operacija", StvaraSeKodDoktora = true });
            //        trenutniTermini.Add(new Termin() { Datum = dateLabel.Content.ToString(), Vreme = "16:30 - 17:00", Sala = "", Lekar = doctor, Pacijent = "", Status = "Slobodan", Zadatak = "Operacija", StvaraSeKodDoktora = true });

            //        Console.WriteLine("Treba da ispise svih 18 vremena i ovo treba da bude zadovoljeno: 18=" + trenutniTermini.Count);
            //        foreach (Termin term in trenutniTermini)
            //        {

            //            Console.WriteLine("Vreme je: " + term.Vreme);
            //            Loading.termini.Add(term);
            //        }

            //    } else
            //    {
            //        List<Termin> terminiKojiFale = new List<Termin>();
            //        List<String> vremenaKojaPostoje = new List<String>();
            //        // u trenutniTermini su mi samo zauzeti termini za izabran datum, treba da napravim ostale slobodne termine za taj datum
            //        // prolazak kroz sve termine koji postoje za sve datume, sale, lekare 
            //        foreach (Termin termin1 in Loading.termini) 
            //        {
            //            // ako trenutni termin ima isti datum kao sto je izabran na pocetku, za tog lekara i zadatak je operacija 
            //            if(termin1.Datum.Equals(dateLabel.Content.ToString()) && termin1.Lekar == doctor && termin1.Zadatak.Equals("Operacija"))
            //            {
                         
            //                vremenaKojaPostoje.Add(termin1.Vreme);

                           
            //            }

            //        }
                   

            //        List<Termin> prazniTermini = dajSveMogucePrazneTermineZaDoktoraZaJedanDan(doctor);

            //        foreach(Termin prazanTermin in prazniTermini)
            //        {
            //            bool nasao = false;
            //            foreach(String postojeceVreme in vremenaKojaPostoje)
            //            {
            //                if(prazanTermin.Vreme.Equals(postojeceVreme))
            //                {
            //                    nasao = true; // nasao sam isto vreme i ne treba da dodam
            //                }
            //            }

            //            if (!nasao)
            //            {
            //                terminiKojiFale.Add(new Termin() { Datum = dateLabel.Content.ToString(), Vreme = prazanTermin.Vreme, Sala = "", Lekar = doctor, Pacijent = "", Status = "Slobodan", Zadatak = "Operacija" });
            //            }
            //        }

            //        foreach (Termin t in terminiKojiFale)
            //        {
            //            trenutniTermini.Add(t);
            //        }
                   
            //    }
            //}

            //dgTerms.ItemsSource = trenutniTermini;

            counter += 1;
        }

        //private List<Termin> dajSveMogucePrazneTermineZaDoktoraZaJedanDan(String doctor)
        //{
        //    List<Termin> sviTerminiPoVremenu = new List<Termin>();

        //    sviTerminiPoVremenu.Add(new Termin() { Datum = dateLabel.Content.ToString(), Vreme = "08:00 - 08:30", Sala = "", Lekar = doctor, Pacijent = "", Status = "Slobodan", Zadatak = "Operacija", StvaraSeKodDoktora = true });
        //    sviTerminiPoVremenu.Add(new Termin() { Datum = dateLabel.Content.ToString(), Vreme = "08:30 - 09:00", Sala = "", Lekar = doctor, Pacijent = "", Status = "Slobodan", Zadatak = "Operacija", StvaraSeKodDoktora = true });
        //    sviTerminiPoVremenu.Add(new Termin() { Datum = dateLabel.Content.ToString(), Vreme = "09:00 - 09:30", Sala = "", Lekar = doctor, Pacijent = "", Status = "Slobodan", Zadatak = "Operacija", StvaraSeKodDoktora = true });
        //    sviTerminiPoVremenu.Add(new Termin() { Datum = dateLabel.Content.ToString(), Vreme = "09:30 - 10:00", Sala = "", Lekar = doctor, Pacijent = "", Status = "Slobodan", Zadatak = "Operacija", StvaraSeKodDoktora = true });
        //    sviTerminiPoVremenu.Add(new Termin() { Datum = dateLabel.Content.ToString(), Vreme = "10:00 - 10:30", Sala = "", Lekar = doctor, Pacijent = "", Status = "Slobodan", Zadatak = "Operacija", StvaraSeKodDoktora = true });
        //    sviTerminiPoVremenu.Add(new Termin() { Datum = dateLabel.Content.ToString(), Vreme = "10:30 - 11:00", Sala = "", Lekar = doctor, Pacijent = "", Status = "Slobodan", Zadatak = "Operacija", StvaraSeKodDoktora = true });
        //    sviTerminiPoVremenu.Add(new Termin() { Datum = dateLabel.Content.ToString(), Vreme = "11:00 - 11:30", Sala = "", Lekar = doctor, Pacijent = "", Status = "Slobodan", Zadatak = "Operacija", StvaraSeKodDoktora = true });
        //    sviTerminiPoVremenu.Add(new Termin() { Datum = dateLabel.Content.ToString(), Vreme = "11:30 - 12:00", Sala = "", Lekar = doctor, Pacijent = "", Status = "Slobodan", Zadatak = "Operacija", StvaraSeKodDoktora = true });
        //    sviTerminiPoVremenu.Add(new Termin() { Datum = dateLabel.Content.ToString(), Vreme = "12:00 - 12:30", Sala = "", Lekar = doctor, Pacijent = "", Status = "Slobodan", Zadatak = "Operacija", StvaraSeKodDoktora = true });
        //    sviTerminiPoVremenu.Add(new Termin() { Datum = dateLabel.Content.ToString(), Vreme = "12:30 - 13:00", Sala = "", Lekar = doctor, Pacijent = "", Status = "Slobodan", Zadatak = "Operacija", StvaraSeKodDoktora = true });
        //    sviTerminiPoVremenu.Add(new Termin() { Datum = dateLabel.Content.ToString(), Vreme = "13:00 - 13:30", Sala = "", Lekar = doctor, Pacijent = "", Status = "Slobodan", Zadatak = "Operacija", StvaraSeKodDoktora = true });
        //    sviTerminiPoVremenu.Add(new Termin() { Datum = dateLabel.Content.ToString(), Vreme = "13:30 - 14:00", Sala = "", Lekar = doctor, Pacijent = "", Status = "Slobodan", Zadatak = "Operacija", StvaraSeKodDoktora = true });
        //    sviTerminiPoVremenu.Add(new Termin() { Datum = dateLabel.Content.ToString(), Vreme = "14:00 - 14:30", Sala = "", Lekar = doctor, Pacijent = "", Status = "Slobodan", Zadatak = "Operacija", StvaraSeKodDoktora = true });
        //    sviTerminiPoVremenu.Add(new Termin() { Datum = dateLabel.Content.ToString(), Vreme = "14:30 - 15:00", Sala = "", Lekar = doctor, Pacijent = "", Status = "Slobodan", Zadatak = "Operacija", StvaraSeKodDoktora = true });
        //    sviTerminiPoVremenu.Add(new Termin() { Datum = dateLabel.Content.ToString(), Vreme = "15:00 - 15:30", Sala = "", Lekar = doctor, Pacijent = "", Status = "Slobodan", Zadatak = "Operacija", StvaraSeKodDoktora = true });
        //    sviTerminiPoVremenu.Add(new Termin() { Datum = dateLabel.Content.ToString(), Vreme = "15:30 - 16:00", Sala = "", Lekar = doctor, Pacijent = "", Status = "Slobodan", Zadatak = "Operacija", StvaraSeKodDoktora = true });
        //    sviTerminiPoVremenu.Add(new Termin() { Datum = dateLabel.Content.ToString(), Vreme = "16:00 - 16:30", Sala = "", Lekar = doctor, Pacijent = "", Status = "Slobodan", Zadatak = "Operacija", StvaraSeKodDoktora = true });
        //    sviTerminiPoVremenu.Add(new Termin() { Datum = dateLabel.Content.ToString(), Vreme = "16:30 - 17:00", Sala = "", Lekar = doctor, Pacijent = "", Status = "Slobodan", Zadatak = "Operacija", StvaraSeKodDoktora = true });
        //    return sviTerminiPoVremenu;
        //}
        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            GridDoctorsTerms.Children.Clear();
            UserControl usc = new TypeOfDoctors(dateLabel.Content.ToString());
            GridDoctorsTerms.Children.Add(usc);

        }

        private void homeBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridDoctorsTerms.Children.Clear();
            UserControl usc = new Home();
            GridDoctorsTerms.Children.Add(usc);
        }

        private void scheduleBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridDoctorsTerms.Children.Clear();
            UserControl usc = new Schedule();
            GridDoctorsTerms.Children.Add(usc);
        }
        private void patienstBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridDoctorsTerms.Children.Clear();
            UserControl usc = new Patient();
            GridDoctorsTerms.Children.Add(usc);
        }

        private void settingsBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridDoctorsTerms.Children.Clear();
            UserControl usc = new Settings();
            GridDoctorsTerms.Children.Add(usc);
        }

        private void reportBtn_Click(object sender, RoutedEventArgs e)
        {
            GridDoctorsTerms.Children.Clear();
            UserControl usc = new Report();
            GridDoctorsTerms.Children.Add(usc);
        }

        private void btnSchedule_Click(object sender, RoutedEventArgs e)
        {
            //Termin term = dgTerms.SelectedItem as Termin;
            //if (term == null)
            //    return;
            //fillTermWithDataFromSelectedRow(term);

            //List<String> rooms = new List<String>();
            //foreach (Sobe s in Loading.sobeZaOperaciju)
            //{
            //    rooms.Add(s.Soba);
            //}

            UserControl usc = new PatientValidation(dateLabel.Content.ToString());
            btnRelocate.IsEnabled = false;
            btnCanceling.IsEnabled = false;
            btnSchedule.IsEnabled = false;
            dgTerms.UnselectAllCells();
            (this.Parent as Panel).Children.Add(usc);

        }

        private void btnRelocate_Click(object sender, RoutedEventArgs e)
        {
            //foreach (var item in cmbx.Items)
            //{
            //    String[] parts = item.ToString().Split(' ');
            //    cmbxItems.Add(parts[1]);
            //}

            //foreach (String item in cmbxItems)
            //{
            //    Console.WriteLine(item);
            //}

            //List<String> rooms = new List<String>();
            //foreach (Sobe s in Loading.sobeZaOperaciju)
            //{
            //    rooms.Add(s.Soba);
            //}

            //Termin term = dgTerms.SelectedItem as Termin;
            //if (term == null)
            //    return;
            //fillTermWithDataFromSelectedRow(term);

            UserControl usc = new RelocationTerm(dateLabel.Content.ToString());
            btnRelocate.IsEnabled = false;
            btnCanceling.IsEnabled = false;
            btnSchedule.IsEnabled = false;
            dgTerms.UnselectAllCells();
            (this.Parent as Panel).Children.Add(usc);
        }

        private void btnCanceling_Click(object sender, RoutedEventArgs e)
        {
            //Termin term = dgTerms.SelectedItem as Termin;
            //if (term == null)
            //    return;
            //fillTermWithDataFromSelectedRow(term);

            UserControl usc = new CancelingTerm(dateLabel.Content.ToString());
            btnRelocate.IsEnabled = false;
            btnCanceling.IsEnabled = false;
            btnSchedule.IsEnabled = false;
            dgTerms.UnselectAllCells();
            (this.Parent as Panel).Children.Add(usc);
        }

        //private static void fillTermWithDataFromSelectedRow(Termin term)
        //{
        //    term.Vreme = Convert.ToString(term.Vreme);
        //    term.Sala = Convert.ToString(term.Sala);
        //    term.Lekar = Convert.ToString(term.Lekar);
        //    term.Pacijent = Convert.ToString(term.Pacijent);
        //    term.Status = Convert.ToString(term.Status);
        //    term.Datum = Convert.ToString(term.Datum);
        //    term.Zadatak = Convert.ToString(term.Zadatak);
        //}

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            searchTextBox.Visibility = Visibility.Visible;
            searchTextBox.Focus();
            searchTextBox.SelectAll();
            btnSearch.Visibility = Visibility.Hidden;
            btnClose.Visibility = Visibility.Visible;
            btnRelocate.IsEnabled = false;
            btnCanceling.IsEnabled = false;
            btnSchedule.IsEnabled = false;
            dgTerms.UnselectAllCells();
        }

        private void dgTerms_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //Termin term = dgTerms.SelectedItem as Termin;
            //if (term == null)
            //    return;
            //fillTermWithDataFromSelectedRow(term);
            //if (term.Status.Equals("Slobodan"))
            //{
            //    btnRelocate.IsEnabled = false;
            //    btnCanceling.IsEnabled = false;
            //    btnSchedule.IsEnabled = true;
            //}
            //else if (term.Status.Equals("Zauzet"))
            //{
            //    btnRelocate.IsEnabled = true;
            //    btnCanceling.IsEnabled = true;
            //    btnSchedule.IsEnabled = false;
            //}
        }

        private void cmbx_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            searchTextBox.Text = "";
            searchTextBox.Visibility = Visibility.Hidden;
            btnSearch.Visibility = Visibility.Visible;
            btnClose.Visibility = Visibility.Hidden;
            cmbx.Items.Refresh();
            //if (counter < 1)
            //{
            //    Console.WriteLine("USAO SAM U PROMENU - IF ");
            //    counter += 1;
            //}

            //else
            //{
            //    Console.WriteLine("USAO SAM U PROMENU - ELSE ");
            //    counter += 1;
            //    trenutniTermini.Clear();
            //    String doctor = "";

            //    if (cmbx.SelectedItem == D1)
            //    {
            //        doctor = "Ana Anić";
                    
            //    }
            //    else if (cmbx.SelectedItem == D2)
            //    {
            //        doctor = "Miša Kiš";
            //    }
            //    else
            //    {
            //        doctor = "Petar Petrić";
            //    }
            //    Console.WriteLine("Trenutni termini PRE dodavanja u njih: " + trenutniTermini.Count);
            //    foreach (Termin termin in Loading.termini)
            //    {


            //        if (DisplayType.date.Equals(termin.Datum) && doctor.Equals(termin.Lekar) && termin.Zadatak.Equals("Operacija"))
            //        {
            //            trenutniTermini.Add(termin);
            //        }
            //    }

            //    Console.WriteLine("Trenutni termini POSLE dodavanja u njih: " + trenutniTermini.Count);
            //    foreach (Termin term in trenutniTermini)
            //    {

            //        Console.WriteLine("Vreme posle dodavanja je: " + term.Vreme);

            //    }

            //    if (trenutniTermini.Count < 18)
            //    {

            //        if (trenutniTermini.Count == 0)
            //        {

            //            // doktori specajliste - zadatak operacija
            //            trenutniTermini.Add(new Termin() { Datum = dateLabel.Content.ToString(), Vreme = "08:00 - 08:30", Sala = "", Lekar = doctor, Pacijent = "", Status = "Slobodan", Zadatak = "Operacija", StvaraSeKodDoktora = true });
            //            trenutniTermini.Add(new Termin() { Datum = dateLabel.Content.ToString(), Vreme = "08:30 - 09:00", Sala = "", Lekar = doctor, Pacijent = "", Status = "Slobodan", Zadatak = "Operacija", StvaraSeKodDoktora = true });
            //            trenutniTermini.Add(new Termin() { Datum = dateLabel.Content.ToString(), Vreme = "09:00 - 09:30", Sala = "", Lekar = doctor, Pacijent = "", Status = "Slobodan", Zadatak = "Operacija", StvaraSeKodDoktora = true });
            //            trenutniTermini.Add(new Termin() { Datum = dateLabel.Content.ToString(), Vreme = "09:30 - 10:00", Sala = "", Lekar = doctor, Pacijent = "", Status = "Slobodan", Zadatak = "Operacija", StvaraSeKodDoktora = true });
            //            trenutniTermini.Add(new Termin() { Datum = dateLabel.Content.ToString(), Vreme = "10:00 - 10:30", Sala = "", Lekar = doctor, Pacijent = "", Status = "Slobodan", Zadatak = "Operacija", StvaraSeKodDoktora = true });
            //            trenutniTermini.Add(new Termin() { Datum = dateLabel.Content.ToString(), Vreme = "10:30 - 11:00", Sala = "", Lekar = doctor, Pacijent = "", Status = "Slobodan", Zadatak = "Operacija", StvaraSeKodDoktora = true });
            //            trenutniTermini.Add(new Termin() { Datum = dateLabel.Content.ToString(), Vreme = "11:00 - 11:30", Sala = "", Lekar = doctor, Pacijent = "", Status = "Slobodan", Zadatak = "Operacija", StvaraSeKodDoktora = true });
            //            trenutniTermini.Add(new Termin() { Datum = dateLabel.Content.ToString(), Vreme = "11:30 - 12:00", Sala = "", Lekar = doctor, Pacijent = "", Status = "Slobodan", Zadatak = "Operacija", StvaraSeKodDoktora = true });
            //            trenutniTermini.Add(new Termin() { Datum = dateLabel.Content.ToString(), Vreme = "12:00 - 12:30", Sala = "", Lekar = doctor, Pacijent = "", Status = "Slobodan", Zadatak = "Operacija", StvaraSeKodDoktora = true });
            //            trenutniTermini.Add(new Termin() { Datum = dateLabel.Content.ToString(), Vreme = "12:30 - 13:00", Sala = "", Lekar = doctor, Pacijent = "", Status = "Slobodan", Zadatak = "Operacija", StvaraSeKodDoktora = true });
            //            trenutniTermini.Add(new Termin() { Datum = dateLabel.Content.ToString(), Vreme = "13:00 - 13:30", Sala = "", Lekar = doctor, Pacijent = "", Status = "Slobodan", Zadatak = "Operacija", StvaraSeKodDoktora = true });
            //            trenutniTermini.Add(new Termin() { Datum = dateLabel.Content.ToString(), Vreme = "13:30 - 14:00", Sala = "", Lekar = doctor, Pacijent = "", Status = "Slobodan", Zadatak = "Operacija", StvaraSeKodDoktora = true });
            //            trenutniTermini.Add(new Termin() { Datum = dateLabel.Content.ToString(), Vreme = "14:00 - 14:30", Sala = "", Lekar = doctor, Pacijent = "", Status = "Slobodan", Zadatak = "Operacija", StvaraSeKodDoktora = true });
            //            trenutniTermini.Add(new Termin() { Datum = dateLabel.Content.ToString(), Vreme = "14:30 - 15:00", Sala = "", Lekar = doctor, Pacijent = "", Status = "Slobodan", Zadatak = "Operacija", StvaraSeKodDoktora = true });
            //            trenutniTermini.Add(new Termin() { Datum = dateLabel.Content.ToString(), Vreme = "15:00 - 15:30", Sala = "", Lekar = doctor, Pacijent = "", Status = "Slobodan", Zadatak = "Operacija", StvaraSeKodDoktora = true });
            //            trenutniTermini.Add(new Termin() { Datum = dateLabel.Content.ToString(), Vreme = "15:30 - 16:00", Sala = "", Lekar = doctor, Pacijent = "", Status = "Slobodan", Zadatak = "Operacija", StvaraSeKodDoktora = true });
            //            trenutniTermini.Add(new Termin() { Datum = dateLabel.Content.ToString(), Vreme = "16:00 - 16:30", Sala = "", Lekar = doctor, Pacijent = "", Status = "Slobodan", Zadatak = "Operacija", StvaraSeKodDoktora = true });
            //            trenutniTermini.Add(new Termin() { Datum = dateLabel.Content.ToString(), Vreme = "16:30 - 17:00", Sala = "", Lekar = doctor, Pacijent = "", Status = "Slobodan", Zadatak = "Operacija", StvaraSeKodDoktora = true });
            //            foreach (Termin term in trenutniTermini)
            //            {

            //                Console.WriteLine("Vreme je: " + term.Vreme);
            //                Loading.termini.Add(term);
            //            }

                        
            //        }
            //        else
            //        {
            //            List<Termin> terminiKojiFale = new List<Termin>();
            //            List<String> vremenaKojaPostoje = new List<String>();
            //            // u trenutniTermini su mi samo zauzeti termini za izabran datum, treba da napravim ostale slobodne termine za taj datum
            //            // prolazak kroz sve termine koji postoje za sve datume, sale, lekare 
            //            foreach (Termin termin1 in Loading.termini)
            //            {
            //                // ako trenutni termin ima isti datum kao sto je izabran na pocetku, za tog lekara i zadatak je operacija 
            //                if (termin1.Datum.Equals(dateLabel.Content.ToString()) && termin1.Lekar == doctor && termin1.Zadatak.Equals("Operacija"))
            //                {
                               
            //                    vremenaKojaPostoje.Add(termin1.Vreme);

                                
            //                }

            //            }

            //            List<Termin> prazniTermini = dajSveMogucePrazneTermineZaDoktoraZaJedanDan(doctor);

            //            foreach (Termin prazanTermin in prazniTermini)
            //            {
            //                bool nasao = false;
            //                foreach (String postojeceVreme in vremenaKojaPostoje)
            //                {
            //                    if (prazanTermin.Vreme.Equals(postojeceVreme))
            //                    {
            //                        nasao = true; // nasao sam isto vreme i ne treba da dodam
            //                    }
            //                }

            //                if (!nasao)
            //                {
            //                    terminiKojiFale.Add(new Termin() { Datum = dateLabel.Content.ToString(), Vreme = prazanTermin.Vreme, Sala = "", Lekar = doctor, Pacijent = "", Status = "Slobodan", Zadatak = "Operacija" });
            //                }
            //            }

            //            foreach (Termin t in terminiKojiFale)
            //            {
            //                trenutniTermini.Add(t);
            //                Loading.termini.Add(t);
            //            }

            //            dgTerms.ItemsSource = trenutniTermini;
            //            btnRelocate.IsEnabled = false;
            //            btnCanceling.IsEnabled = false;
            //            btnSchedule.IsEnabled = false;
            //            dgTerms.UnselectAllCells();
            //            return;
            //        }
                    
            //    }

            //    dgTerms.ItemsSource = trenutniTermini;
            //    btnRelocate.IsEnabled = false;
            //    btnCanceling.IsEnabled = false;
            //    btnSchedule.IsEnabled = false;
            //    dgTerms.UnselectAllCells();
            //}

        }

        private void searchTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            //var fill = trenutniTermini.Where(termin => termin.Pacijent.ToString().Contains(searchTextBox.Text) || termin.Lekar.ToString().Contains(searchTextBox.Text)
            //            || termin.Vreme.ToString().Contains(searchTextBox.Text) || termin.Sala.ToString().Contains(searchTextBox.Text) || termin.Status.ToString().Contains(searchTextBox.Text));
            //dgTerms.ItemsSource = fill;

        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            searchTextBox.Text = "";
            //dgTerms.ItemsSource = trenutniTermini;
            searchTextBox.Visibility = Visibility.Hidden;
            btnSearch.Visibility = Visibility.Visible;
            btnClose.Visibility = Visibility.Hidden;
            btnRelocate.IsEnabled = false;
            btnCanceling.IsEnabled = false;
            btnSchedule.IsEnabled = false;
            dgTerms.UnselectAllCells();
        }
    }
}
