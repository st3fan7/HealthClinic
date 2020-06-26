using HealthClinic.View.Dialogues;
using HealthClinic.View.ViewModel;
using Model.Term;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for RelocationTerm.xaml
    /// </summary>
    public partial class RelocationTerm : UserControl
    {
        //public static List<Termin> trenutniTermini = new List<Termin>(); // da vidim iz relocation2
        //Termin termForRelocation = new Termin();
        //public static Termin termForCanceling = new Termin();
        private ViewTerm termForCanceling = new ViewTerm();

        private static ObservableCollection<Room> roomsFromCmbx = new ObservableCollection<Room>();

        public RelocationTerm()
        {

        }
        public RelocationTerm(string selectedDate, ViewTerm term)
        {
            
            InitializeComponent();
            datePickerSchedule.DisplayDateStart = DateTime.Now;
            textWarning.Visibility = textWarningVisible;
            dateLabel.Content = selectedDate;
            timeLabel.Content = term.Time;
            roomLabel.Content = term.Room;
            doctorLabel.Content = term.Doctor;
            patientLabel.Content = term.Patient;
            termForCanceling = term;
            roomsFromCmbx = MedicalExaminationRooms.RoomsComboBox;
           // Console.WriteLine("Termin pre izmene: Datum: " + RelocationTerm.termForCanceling.Datum + " Vreme: " + RelocationTerm.termForCanceling.Vreme + " Sala: " + RelocationTerm.termForCanceling.Sala + " Lekar: " + RelocationTerm.termForCanceling.Lekar + " Pacijent: " + RelocationTerm.termForCanceling.Pacijent + " Status: " + RelocationTerm.termForCanceling.Status + " Zadatak: " + RelocationTerm.termForCanceling.Zadatak);
        }

        private void homeBtn2_Click(object sender, RoutedEventArgs e)
        {

            GridRelocationTerm.Children.Clear();
            UserControl usc = new Home();
            GridRelocationTerm.Children.Add(usc);
        }

        private void scheduleBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridRelocationTerm.Children.Clear();
            UserControl usc = new Schedule();
            GridRelocationTerm.Children.Add(usc);

        }

        private void patienstBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridRelocationTerm.Children.Clear();
            UserControl usc = new Patient();
            GridRelocationTerm.Children.Add(usc);
        }

        private void settingsBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridRelocationTerm.Children.Clear();
            UserControl usc = new Settings();
            GridRelocationTerm.Children.Add(usc);
        }

        private void reportBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridRelocationTerm.Children.Clear();
            UserControl usc = new Report();
            GridRelocationTerm.Children.Add(usc);
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            (this.Parent as Panel).Children.Remove(this);
        }

        private void nextBtn_Click(object sender, RoutedEventArgs e)
        {
            //trenutniTermini.Clear();

            //if (datePickerSchedule.SelectedDate != null)
            //{
            //    //Termin term = new Termin();
            //    //term.Vreme = timeLabel.Content.ToString();
            //    //term.Sala = roomLabel.Content.ToString();
            //    //term.Lekar = doctorLabel.Content.ToString();
            //    //term.Pacijent = patientLabel.Content.ToString();
            //    //term.Status = null;


            //    foreach (Termin termin in Loading.termini)
            //    {


            //        if (datePickerSchedule.Text.Equals(termin.Datum))
            //        {
            //            trenutniTermini.Add(termin);
            //        }
            //    }

            //    if (trenutniTermini.Count == 0)
            //    {

            //        foreach (String room in roomsFromCmbx)
            //        {
            //            Console.WriteLine("Soba je: " + room);
            //            Console.WriteLine("Zadatak je: " + termForCanceling.Zadatak);
            //            trenutniTermini.Add(new Termin() { Datum = datePickerSchedule.Text, Vreme = "08:00 - 08:30", Sala = room, Lekar = "", Pacijent = "", Status = "Slobodan", Zadatak = termForCanceling.Zadatak });
            //            trenutniTermini.Add(new Termin() { Datum = datePickerSchedule.Text, Vreme = "08:30 - 09:00", Sala = room, Lekar = "", Pacijent = "", Status = "Slobodan", Zadatak = termForCanceling.Zadatak });
            //            trenutniTermini.Add(new Termin() { Datum = datePickerSchedule.Text, Vreme = "09:00 - 09:30", Sala = room, Lekar = "", Pacijent = "", Status = "Slobodan", Zadatak = termForCanceling.Zadatak });
            //            trenutniTermini.Add(new Termin() { Datum = datePickerSchedule.Text, Vreme = "09:30 - 10:00", Sala = room, Lekar = "", Pacijent = "", Status = "Slobodan", Zadatak = termForCanceling.Zadatak });
            //            trenutniTermini.Add(new Termin() { Datum = datePickerSchedule.Text, Vreme = "10:00 - 10:30", Sala = room, Lekar = "", Pacijent = "", Status = "Slobodan", Zadatak = termForCanceling.Zadatak });
            //            trenutniTermini.Add(new Termin() { Datum = datePickerSchedule.Text, Vreme = "10:30 - 11:00", Sala = room, Lekar = "", Pacijent = "", Status = "Slobodan", Zadatak = termForCanceling.Zadatak });
            //            trenutniTermini.Add(new Termin() { Datum = datePickerSchedule.Text, Vreme = "11:00 - 11:30", Sala = room, Lekar = "", Pacijent = "", Status = "Slobodan", Zadatak = termForCanceling.Zadatak });
            //            trenutniTermini.Add(new Termin() { Datum = datePickerSchedule.Text, Vreme = "11:30 - 12:00", Sala = room, Lekar = "", Pacijent = "", Status = "Slobodan", Zadatak = termForCanceling.Zadatak });
            //            trenutniTermini.Add(new Termin() { Datum = datePickerSchedule.Text, Vreme = "12:00 - 12:30", Sala = room, Lekar = "", Pacijent = "", Status = "Slobodan", Zadatak = termForCanceling.Zadatak });
            //            trenutniTermini.Add(new Termin() { Datum = datePickerSchedule.Text, Vreme = "12:30 - 13:00", Sala = room, Lekar = "", Pacijent = "", Status = "Slobodan", Zadatak = termForCanceling.Zadatak });
            //            trenutniTermini.Add(new Termin() { Datum = datePickerSchedule.Text, Vreme = "13:00 - 13:30", Sala = room, Lekar = "", Pacijent = "", Status = "Slobodan", Zadatak = termForCanceling.Zadatak });
            //            trenutniTermini.Add(new Termin() { Datum = datePickerSchedule.Text, Vreme = "13:30 - 14:00", Sala = room, Lekar = "", Pacijent = "", Status = "Slobodan", Zadatak = termForCanceling.Zadatak });
            //            trenutniTermini.Add(new Termin() { Datum = datePickerSchedule.Text, Vreme = "14:00 - 14:30", Sala = room, Lekar = "", Pacijent = "", Status = "Slobodan", Zadatak = termForCanceling.Zadatak });
            //            trenutniTermini.Add(new Termin() { Datum = datePickerSchedule.Text, Vreme = "14:30 - 15:00", Sala = room, Lekar = "", Pacijent = "", Status = "Slobodan", Zadatak = termForCanceling.Zadatak });
            //            trenutniTermini.Add(new Termin() { Datum = datePickerSchedule.Text, Vreme = "15:00 - 15:30", Sala = room, Lekar = "", Pacijent = "", Status = "Slobodan", Zadatak = termForCanceling.Zadatak });
            //            trenutniTermini.Add(new Termin() { Datum = datePickerSchedule.Text, Vreme = "15:30 - 16:00", Sala = room, Lekar = "", Pacijent = "", Status = "Slobodan", Zadatak = termForCanceling.Zadatak });
            //            trenutniTermini.Add(new Termin() { Datum = datePickerSchedule.Text, Vreme = "16:00 - 16:30", Sala = room, Lekar = "", Pacijent = "", Status = "Slobodan", Zadatak = termForCanceling.Zadatak });
            //            trenutniTermini.Add(new Termin() { Datum = datePickerSchedule.Text, Vreme = "16:30 - 17:00", Sala = room, Lekar = "", Pacijent = "", Status = "Slobodan", Zadatak = termForCanceling.Zadatak });

            //        }
            //        // pravljenje slobodnih termina za taj datum // vidi da li je operacija u pitanju ili sta vec


            //        //Console.WriteLine("Svi: " + Loading.termini.Count);
            //        foreach (Termin term in trenutniTermini)
            //        {
            //            Loading.termini.Add(term);
            //        }
            //        //Console.WriteLine("Svi: " + Loading.termini.Count);
            //    }
            //    //Console.WriteLine(trenutniTermini.Count);
            //    trenutniTermini.Clear();
            //  //  Console.WriteLine(trenutniTermini.Count); // obrisi kasnije to i trenutniTermini

            //    foreach (Termin term in Loading.termini)
            //    {
            //        if (datePickerSchedule.Text.Equals(term.Datum) && term.Status == "Slobodan" && term.Zadatak == termForCanceling.Zadatak)
            //        {
            //            trenutniTermini.Add(term); // svi slobodni termini za taj datum
            //        }
            //    }
            //    //Console.WriteLine(trenutniTermini.Count);
            //    if (trenutniTermini.Count > 0)
            //    {
            //        termForRelocation.Datum = datePickerSchedule.Text;
            //        termForRelocation.Zadatak = termForCanceling.Zadatak;
            //        termForRelocation.Status = "Zauzet";
            //        termForRelocation.Pacijent = termForCanceling.Pacijent;
            //        termForRelocation.Vreme = "";
            //        termForRelocation.Sala = "";
            //       // Console.WriteLine(termForRelocation.Pacijent);
            //        UserControl usc = new RelocationTerm2(dateLabel.Content.ToString(), termForRelocation, termForCanceling, roomsFromCmbx); // sad imam datum kad ce se obaviti pregled // trenutni termini su public da ne moram da saljem
            //        (this.Parent as Panel).Children.Add(usc);
            //    }
                
            //}
            //else
            //{
            //    textWarning.Visibility = textWarningHidden;

            //}
        }



        private Visibility textWarningHidden
        {
            get { return Visibility.Visible; }
        }
        private Visibility textWarningVisible
        {
            get { return Visibility.Hidden; }
        }

        private void datePickerSchedule_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            if (datePickerSchedule.SelectedDate != null)
            {

                textWarning.Visibility = textWarningVisible;
            }
            else
            {
                textWarning.Visibility = textWarningHidden;
            }

        }
    }
}
