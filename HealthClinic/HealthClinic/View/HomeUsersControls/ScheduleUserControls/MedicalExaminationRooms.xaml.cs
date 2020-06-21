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
    /// Interaction logic for TermsForMedicalExamination.xaml
    /// </summary>
    public partial class MedicalExaminationRooms : UserControl
    {
        public static List<String> cmbxItems = new List<String>();
        //private List<Termin> trenutniTermini = new List<Termin>();
        private String selectedDateInCalendar = "";
        public int counter = 0;

        public MedicalExaminationRooms(string selectedDate)
        {
            InitializeComponent();
            dateLabel.Content = selectedDate;
            selectedDateInCalendar = selectedDate;
            this.DataContext = this;
            Console.WriteLine("vratio sam se u kons");
            counter = 0;
            fillData(DisplayType.date);
            cmbxItems.Clear();
            searchTextBox.Visibility = Visibility.Hidden;
            btnSearch.Visibility = Visibility.Visible;
            btnClose.Visibility = Visibility.Hidden;

            btnCanceling.IsEnabled = false;
            btnRelocate.IsEnabled = false;
            btnSchedule.IsEnabled = false;
        }

        private void fillData(String date)
        {
            Console.WriteLine("vratio sam se");
            cmbxItems.Clear();
            //trenutniTermini.Clear();
            String sala = "";

            if (cmbx.SelectedItem == E1)
            {
                sala = "E1";
            }
            else
            {
                sala = "E2";
            }
            //foreach (Termin termin in Loading.termini)
            //{


            //    if (date.Equals(termin.Datum) && sala.Equals(termin.Sala))
            //    {
            //        trenutniTermini.Add(termin);
            //    }
            //}

            //if (trenutniTermini.Count == 0)
            //{

            //    trenutniTermini.Add(new Termin() { Datum = dateLabel.Content.ToString(), Vreme = "08:00 - 08:30", Sala = sala, Lekar = "", Pacijent = "", Status = "Slobodan", Zadatak = "Pregled", StvaraSeKodDoktora = false });
            //    trenutniTermini.Add(new Termin() { Datum = dateLabel.Content.ToString(), Vreme = "08:30 - 09:00", Sala = sala, Lekar = "", Pacijent = "", Status = "Slobodan", Zadatak = "Pregled", StvaraSeKodDoktora = false });
            //    trenutniTermini.Add(new Termin() { Datum = dateLabel.Content.ToString(), Vreme = "09:00 - 09:30", Sala = sala, Lekar = "", Pacijent = "", Status = "Slobodan", Zadatak = "Pregled", StvaraSeKodDoktora = false });
            //    trenutniTermini.Add(new Termin() { Datum = dateLabel.Content.ToString(), Vreme = "09:30 - 10:00", Sala = sala, Lekar = "", Pacijent = "", Status = "Slobodan", Zadatak = "Pregled", StvaraSeKodDoktora = false });
            //    trenutniTermini.Add(new Termin() { Datum = dateLabel.Content.ToString(), Vreme = "10:00 - 10:30", Sala = sala, Lekar = "", Pacijent = "", Status = "Slobodan", Zadatak = "Pregled", StvaraSeKodDoktora = false });
            //    trenutniTermini.Add(new Termin() { Datum = dateLabel.Content.ToString(), Vreme = "10:30 - 11:00", Sala = sala, Lekar = "", Pacijent = "", Status = "Slobodan", Zadatak = "Pregled", StvaraSeKodDoktora = false });
            //    trenutniTermini.Add(new Termin() { Datum = dateLabel.Content.ToString(), Vreme = "11:00 - 11:30", Sala = sala, Lekar = "", Pacijent = "", Status = "Slobodan", Zadatak = "Pregled", StvaraSeKodDoktora = false });
            //    trenutniTermini.Add(new Termin() { Datum = dateLabel.Content.ToString(), Vreme = "11:30 - 12:00", Sala = sala, Lekar = "", Pacijent = "", Status = "Slobodan", Zadatak = "Pregled", StvaraSeKodDoktora = false });
            //    trenutniTermini.Add(new Termin() { Datum = dateLabel.Content.ToString(), Vreme = "12:00 - 12:30", Sala = sala, Lekar = "", Pacijent = "", Status = "Slobodan", Zadatak = "Pregled", StvaraSeKodDoktora = false });
            //    trenutniTermini.Add(new Termin() { Datum = dateLabel.Content.ToString(), Vreme = "12:30 - 13:00", Sala = sala, Lekar = "", Pacijent = "", Status = "Slobodan", Zadatak = "Pregled", StvaraSeKodDoktora = false });
            //    trenutniTermini.Add(new Termin() { Datum = dateLabel.Content.ToString(), Vreme = "13:00 - 13:30", Sala = sala, Lekar = "", Pacijent = "", Status = "Slobodan", Zadatak = "Pregled", StvaraSeKodDoktora = false });
            //    trenutniTermini.Add(new Termin() { Datum = dateLabel.Content.ToString(), Vreme = "13:30 - 14:00", Sala = sala, Lekar = "", Pacijent = "", Status = "Slobodan", Zadatak = "Pregled", StvaraSeKodDoktora = false });
            //    trenutniTermini.Add(new Termin() { Datum = dateLabel.Content.ToString(), Vreme = "14:00 - 14:30", Sala = sala, Lekar = "", Pacijent = "", Status = "Slobodan", Zadatak = "Pregled", StvaraSeKodDoktora = false });
            //    trenutniTermini.Add(new Termin() { Datum = dateLabel.Content.ToString(), Vreme = "14:30 - 15:00", Sala = sala, Lekar = "", Pacijent = "", Status = "Slobodan", Zadatak = "Pregled", StvaraSeKodDoktora = false });
            //    trenutniTermini.Add(new Termin() { Datum = dateLabel.Content.ToString(), Vreme = "15:00 - 15:30", Sala = sala, Lekar = "", Pacijent = "", Status = "Slobodan", Zadatak = "Pregled", StvaraSeKodDoktora = false });
            //    trenutniTermini.Add(new Termin() { Datum = dateLabel.Content.ToString(), Vreme = "15:30 - 16:00", Sala = sala, Lekar = "", Pacijent = "", Status = "Slobodan", Zadatak = "Pregled", StvaraSeKodDoktora = false });
            //    trenutniTermini.Add(new Termin() { Datum = dateLabel.Content.ToString(), Vreme = "16:00 - 16:30", Sala = sala, Lekar = "", Pacijent = "", Status = "Slobodan", Zadatak = "Pregled", StvaraSeKodDoktora = false });
            //    trenutniTermini.Add(new Termin() { Datum = dateLabel.Content.ToString(), Vreme = "16:30 - 17:00", Sala = sala, Lekar = "", Pacijent = "", Status = "Slobodan", Zadatak = "Pregled", StvaraSeKodDoktora = false });

            //    foreach (Termin term in trenutniTermini)
            //    {
            //        Loading.termini.Add(term);
            //    }

            //}

            //dgTerms.ItemsSource = trenutniTermini;
            //counter += 1;
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            GridMedicalExaminationRooms.Children.Clear();
            UserControl usc = new TypeOfRoom(dateLabel.Content.ToString());
            GridMedicalExaminationRooms.Children.Add(usc);


        }

        private void homeBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridMedicalExaminationRooms.Children.Clear();
            UserControl usc = new Home();
            GridMedicalExaminationRooms.Children.Add(usc);
        }

        private void scheduleBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridMedicalExaminationRooms.Children.Clear();
            UserControl usc = new Schedule();
            GridMedicalExaminationRooms.Children.Add(usc);
        }

        private void patienstBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridMedicalExaminationRooms.Children.Clear();
            UserControl usc = new Patient();
            GridMedicalExaminationRooms.Children.Add(usc);
        }

        private void settingsBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridMedicalExaminationRooms.Children.Clear();
            UserControl usc = new Settings();
            GridMedicalExaminationRooms.Children.Add(usc);
        }

        private void reportBtn_Click(object sender, RoutedEventArgs e)
        {
            GridMedicalExaminationRooms.Children.Clear();
            UserControl usc = new Report();
            GridMedicalExaminationRooms.Children.Add(usc);
        }


        private void btnSchedule_Click(object sender, RoutedEventArgs e)
        {
            //Termin term = dgTerms.SelectedItem as Termin;
            //if (term == null)
            //    return;
            //fillTermWithDataFromSelectedRow(term);

            //List<String> doctors = new List<String>();
            //foreach (Lekar l in Loading.lekari)
            //{
            //    doctors.Add(l.Doktor);
            //}

            UserControl usc = new PatientValidation(dateLabel.Content.ToString());
            dgTerms.UnselectAllCells();
            btnRelocate.IsEnabled = false;
            btnCanceling.IsEnabled = false;
            btnSchedule.IsEnabled = false;
            (this.Parent as Panel).Children.Add(usc);

        }

        private void btnRelocate_Click(object sender, RoutedEventArgs e)
        {
          
            foreach (var item in cmbx.Items)
            {
                String[] parts = item.ToString().Split(' ');
                cmbxItems.Add(parts[1]);
            }

            foreach (String item in cmbxItems)
            {
                Console.WriteLine(item);
            }

            //Termin term = dgTerms.SelectedItem as Termin;
            //if (term == null)
            //    return;
            //fillTermWithDataFromSelectedRow(term);

            UserControl usc = new RelocationTerm(dateLabel.Content.ToString());
            dgTerms.UnselectAllCells();
            btnRelocate.IsEnabled = false;
            btnCanceling.IsEnabled = false;
            btnSchedule.IsEnabled = false;
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

        private void btnCanceling_Click(object sender, RoutedEventArgs e)
        {
            //Termin term = dgTerms.SelectedItem as Termin;
            //if (term == null)
            //    return;
            //fillTermWithDataFromSelectedRow(term);

            UserControl usc = new CancelingTerm(dateLabel.Content.ToString());
            dgTerms.UnselectAllCells();
            btnRelocate.IsEnabled = false;
            btnCanceling.IsEnabled = false;
            btnSchedule.IsEnabled = false;
            (this.Parent as Panel).Children.Add(usc);
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            searchTextBox.Visibility = Visibility.Visible;
            searchTextBox.Focus();
            searchTextBox.SelectAll();
            btnSearch.Visibility = Visibility.Hidden;
            btnClose.Visibility = Visibility.Visible;
            dgTerms.UnselectAllCells();
            btnRelocate.IsEnabled = false;
            btnCanceling.IsEnabled = false;
            btnSchedule.IsEnabled = false;
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
            cmbxItems.Clear();
            if (counter < 1)
            {
                counter += 1;
            }

            else
            {
                counter += 1;
                //trenutniTermini.Clear();
                String sala = "";

                if (cmbx.SelectedItem == E1)
                {
                    sala = "E1";
                }
                else
                {
                    sala = "E2";
                }
                //foreach (Termin termin in Loading.termini)
                //{


                //    if (DisplayType.date.Equals(termin.Datum) && sala.Equals(termin.Sala))
                //    {
                //        trenutniTermini.Add(termin);
                //    }
                //}

                //if (trenutniTermini.Count == 0)
                //{


                //    trenutniTermini.Add(new Termin() { Datum = dateLabel.Content.ToString(), Vreme = "08:00 - 08:30", Sala = sala, Lekar = "", Pacijent = "", Status = "Slobodan", Zadatak = "Pregled", StvaraSeKodDoktora = false });
                //    trenutniTermini.Add(new Termin() { Datum = dateLabel.Content.ToString(), Vreme = "08:30 - 09:00", Sala = sala, Lekar = "", Pacijent = "", Status = "Slobodan", Zadatak = "Pregled", StvaraSeKodDoktora = false });
                //    trenutniTermini.Add(new Termin() { Datum = dateLabel.Content.ToString(), Vreme = "09:00 - 09:30", Sala = sala, Lekar = "", Pacijent = "", Status = "Slobodan", Zadatak = "Pregled", StvaraSeKodDoktora = false });
                //    trenutniTermini.Add(new Termin() { Datum = dateLabel.Content.ToString(), Vreme = "09:30 - 10:00", Sala = sala, Lekar = "", Pacijent = "", Status = "Slobodan", Zadatak = "Pregled", StvaraSeKodDoktora = false });
                //    trenutniTermini.Add(new Termin() { Datum = dateLabel.Content.ToString(), Vreme = "10:00 - 10:30", Sala = sala, Lekar = "", Pacijent = "", Status = "Slobodan", Zadatak = "Pregled", StvaraSeKodDoktora = false });
                //    trenutniTermini.Add(new Termin() { Datum = dateLabel.Content.ToString(), Vreme = "10:30 - 11:00", Sala = sala, Lekar = "", Pacijent = "", Status = "Slobodan", Zadatak = "Pregled", StvaraSeKodDoktora = false });
                //    trenutniTermini.Add(new Termin() { Datum = dateLabel.Content.ToString(), Vreme = "11:00 - 11:30", Sala = sala, Lekar = "", Pacijent = "", Status = "Slobodan", Zadatak = "Pregled", StvaraSeKodDoktora = false });
                //    trenutniTermini.Add(new Termin() { Datum = dateLabel.Content.ToString(), Vreme = "11:30 - 12:00", Sala = sala, Lekar = "", Pacijent = "", Status = "Slobodan", Zadatak = "Pregled", StvaraSeKodDoktora = false });
                //    trenutniTermini.Add(new Termin() { Datum = dateLabel.Content.ToString(), Vreme = "12:00 - 12:30", Sala = sala, Lekar = "", Pacijent = "", Status = "Slobodan", Zadatak = "Pregled", StvaraSeKodDoktora = false });
                //    trenutniTermini.Add(new Termin() { Datum = dateLabel.Content.ToString(), Vreme = "12:30 - 13:00", Sala = sala, Lekar = "", Pacijent = "", Status = "Slobodan", Zadatak = "Pregled", StvaraSeKodDoktora = false });
                //    trenutniTermini.Add(new Termin() { Datum = dateLabel.Content.ToString(), Vreme = "13:00 - 13:30", Sala = sala, Lekar = "", Pacijent = "", Status = "Slobodan", Zadatak = "Pregled", StvaraSeKodDoktora = false });
                //    trenutniTermini.Add(new Termin() { Datum = dateLabel.Content.ToString(), Vreme = "13:30 - 14:00", Sala = sala, Lekar = "", Pacijent = "", Status = "Slobodan", Zadatak = "Pregled", StvaraSeKodDoktora = false });
                //    trenutniTermini.Add(new Termin() { Datum = dateLabel.Content.ToString(), Vreme = "14:00 - 14:30", Sala = sala, Lekar = "", Pacijent = "", Status = "Slobodan", Zadatak = "Pregled", StvaraSeKodDoktora = false });
                //    trenutniTermini.Add(new Termin() { Datum = dateLabel.Content.ToString(), Vreme = "14:30 - 15:00", Sala = sala, Lekar = "", Pacijent = "", Status = "Slobodan", Zadatak = "Pregled", StvaraSeKodDoktora = false });
                //    trenutniTermini.Add(new Termin() { Datum = dateLabel.Content.ToString(), Vreme = "15:00 - 15:30", Sala = sala, Lekar = "", Pacijent = "", Status = "Slobodan", Zadatak = "Pregled", StvaraSeKodDoktora = false });
                //    trenutniTermini.Add(new Termin() { Datum = dateLabel.Content.ToString(), Vreme = "15:30 - 16:00", Sala = sala, Lekar = "", Pacijent = "", Status = "Slobodan", Zadatak = "Pregled", StvaraSeKodDoktora = false });
                //    trenutniTermini.Add(new Termin() { Datum = dateLabel.Content.ToString(), Vreme = "16:00 - 16:30", Sala = sala, Lekar = "", Pacijent = "", Status = "Slobodan", Zadatak = "Pregled", StvaraSeKodDoktora = false });
                //    trenutniTermini.Add(new Termin() { Datum = dateLabel.Content.ToString(), Vreme = "16:30 - 17:00", Sala = sala, Lekar = "", Pacijent = "", Status = "Slobodan", Zadatak = "Pregled", StvaraSeKodDoktora = false });

                //    foreach (Termin term in trenutniTermini)
                //    {
                //        Loading.termini.Add(term);
                //    }

                //}

                //dgTerms.ItemsSource = trenutniTermini;
                btnRelocate.IsEnabled = false;
                btnCanceling.IsEnabled = false;
                btnSchedule.IsEnabled = false;
                dgTerms.UnselectAllCells();
            }

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
            dgTerms.UnselectAllCells();
            btnRelocate.IsEnabled = false;
            btnCanceling.IsEnabled = false;
            btnSchedule.IsEnabled = false;
        }
    }
}
