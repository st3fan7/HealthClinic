using HealthClinic.View.ViewModel;
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
using System.Windows.Shapes;

namespace HealthClinic.View.Dialogues
{
    /// <summary>
    /// Interaction logic for Loading.xaml
    /// </summary>
    public partial class Loading : Window
    {
        //public static List<Termin> termini = new List<Termin>();
        //public static List<Oporavak> oporavci = new List<Oporavak>();
        //public static List<Pacijent> pacijenti = new List<Pacijent>();
        //public static readonly List<Lekar> lekari = new List<Lekar>();
        //public static readonly List<Lekar> lekariSpecijaliste = new List<Lekar>();
        //public static readonly List<Sobe> sobeZaPregled = new List<Sobe>();
        //public static readonly List<Sobe> sobeZaOperaciju = new List<Sobe>();
        //public static readonly List<Sobe> sobeZaOporavak = new List<Sobe>();

        public static ObservableCollection<ViewTerm> currentMedicalExaminationTerms = new ObservableCollection<ViewTerm>();
        public static ObservableCollection<ViewTerm> currentSurgeryTerms = new ObservableCollection<ViewTerm>();

        System.Windows.Threading.DispatcherTimer dispatcherTimer = new System.Windows.Threading.DispatcherTimer();
        public Loading()
        {
            InitializeComponent();

            dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);
            dispatcherTimer.Interval = new TimeSpan(0, 0, 2);
            dispatcherTimer.Start();

            //fillTerm();
            //fillPatients();
            //fillDoctor();
            //fillDoctorSpecialist();
            //fillRoomsForSurgery();
            //fillRoomsForMedicalExamination();
            //fillRoomsForRecovery();
        }

        //public Loading(string ld)
        //{
        //    List<Termin> ternutniTermini = new List<Termin>();
        //    foreach(Termin term in termini)
        //    {
        //        ternutniTermini.Add(term);
        //    }
        //}

        //private void fillRoomsForSurgery()
        //{
        //    sobeZaOperaciju.Add(new Sobe() { Soba = "O1" });
        //    sobeZaOperaciju.Add(new Sobe() { Soba = "O2" });
        //}
        //private void fillRoomsForRecovery()
        //{
        //    sobeZaOporavak.Add(new Sobe() { Soba = "R1" });
        //    sobeZaOporavak.Add(new Sobe() { Soba = "R2" });
        //}

        //private void fillRoomsForMedicalExamination()
        //{
        //    sobeZaPregled.Add(new Sobe() { Soba = "E1" });
        //    sobeZaPregled.Add(new Sobe() { Soba = "E2" });
        //}

        //private void fillPatients() {
        //    pacijenti.Add(new Pacijent("pera", "123123123", "Pera", "Perić", "12121987435012", "12/12/1987", "Novi Sad", "Republika Srbija", "Niš, Jelička 5", "062/147-741", "pera@gmail.com", false));
        //    pacijenti.Add(new Pacijent("lana", "123123123", "Lana", "Lanić", "14071999568923", "12/12/1987", "Novi Sad", "Republika Srbija", "Niš, Jelička 6", "062/258-852", "lana@gmail.com", false));
        //    pacijenti.Add(new Pacijent("maja", "123123123", "Maja", "Majić", "1208975152634", "12/12/1987", "Novi Sad", "Republika Srbija", "Niš, Jelička 7", "062/369-963", "maja@gmail.com", false));
        //    pacijenti.Add(new Pacijent("", "", "Luka", "Lukić", "05052000568923", "", "", "", "Niš, Niška 8", "062/123-456", "", true));
        //    pacijenti.Add(new Pacijent("", "", "Miša", "Mišić", "0303997124578", "", "", "", "Niš, Niška 9", "062/456-741", "", true));
        //}

        //private void fillDoctor()
        //{
        //    lekari.Add(new Lekar() { Doktor = "Mira Mirić" });
        //    lekari.Add(new Lekar() { Doktor = "Sonja Sonjić" });
        //    lekari.Add(new Lekar() { Doktor = "Mina Minić" });
        //}

        //private void fillDoctorSpecialist()
        //{
        //    lekariSpecijaliste.Add(new Lekar() { Doktor = "Ana Anić" });
        //    lekariSpecijaliste.Add(new Lekar() { Doktor = "Miša Kiš" });
        //    lekariSpecijaliste.Add(new Lekar() { Doktor = "Petar Petrić" });
        //}



        //private void fillTerm()
        //{
        //    termini.Add(new Termin() { Zadatak = "Operacija", Datum = "6/18/2020", Vreme = "08:00 - 08:30", Sala = "O1", Lekar = "Ana Anić", Pacijent = "Petar Perić", Status = "Zauzet" });
        //    termini.Add(new Termin() { Zadatak = "Operacija", Datum = "6/18/2020", Vreme = "08:30 - 09:00", Sala = "O1", Lekar = "Ana Anić", Pacijent = "Miša Mišić", Status = "Zauzet" });
        //    termini.Add(new Termin() { Zadatak = "Operacija", Datum = "6/18/2020", Vreme = "09:00 - 09:30", Sala = "O1", Lekar = "", Pacijent = "", Status = "Slobodan" });
        //    termini.Add(new Termin() { Zadatak = "Operacija", Datum = "6/18/2020", Vreme = "09:30 - 10:00", Sala = "O1", Lekar = "", Pacijent = "", Status = "Slobodan" });
        //    termini.Add(new Termin() { Zadatak = "Operacija", Datum = "6/18/2020", Vreme = "10:00 - 10:30", Sala = "O1", Lekar = "Miša Kiš", Pacijent = "Jovan Jović", Status = "Zauzet" });
        //    termini.Add(new Termin() { Zadatak = "Operacija", Datum = "6/18/2020", Vreme = "10:30 - 11:00", Sala = "O1", Lekar = "", Pacijent = "", Status = "Slobodan" });
        //    termini.Add(new Termin() { Zadatak = "Operacija", Datum = "6/18/2020", Vreme = "11:00 - 11:30", Sala = "O1", Lekar = "Miša Kiš", Pacijent = "Nikola Nikić", Status = "Zauzet" });
        //    termini.Add(new Termin() { Zadatak = "Operacija", Datum = "6/18/2020", Vreme = "11:30 - 12:00", Sala = "O1", Lekar = "", Pacijent = "", Status = "Slobodan" });
        //    termini.Add(new Termin() { Zadatak = "Operacija", Datum = "6/18/2020", Vreme = "12:00 - 12:30", Sala = "O1", Lekar = "", Pacijent = "", Status = "Slobodan" });
        //    termini.Add(new Termin() { Zadatak = "Operacija", Datum = "6/18/2020", Vreme = "12:30 - 13:00", Sala = "O1", Lekar = "", Pacijent = "", Status = "Slobodan" });
        //    termini.Add(new Termin() { Zadatak = "Operacija", Datum = "6/18/2020", Vreme = "13:00 - 13:30", Sala = "O1", Lekar = "", Pacijent = "", Status = "Slobodan" });
        //    termini.Add(new Termin() { Zadatak = "Operacija", Datum = "6/18/2020", Vreme = "13:30 - 14:00", Sala = "O1", Lekar = "", Pacijent = "", Status = "Slobodan" });
        //    termini.Add(new Termin() { Zadatak = "Operacija", Datum = "6/18/2020", Vreme = "14:00 - 14:30", Sala = "O1", Lekar = "", Pacijent = "", Status = "Slobodan" });
        //    termini.Add(new Termin() { Zadatak = "Operacija", Datum = "6/18/2020", Vreme = "14:30 - 15:00", Sala = "O1", Lekar = "", Pacijent = "", Status = "Slobodan" });
        //    termini.Add(new Termin() { Zadatak = "Operacija", Datum = "6/18/2020", Vreme = "15:00 - 15:30", Sala = "O1", Lekar = "", Pacijent = "", Status = "Slobodan" });
        //    termini.Add(new Termin() { Zadatak = "Operacija", Datum = "6/18/2020", Vreme = "15:30 - 16:00", Sala = "O1", Lekar = "", Pacijent = "", Status = "Slobodan" });
        //    termini.Add(new Termin() { Zadatak = "Operacija", Datum = "6/18/2020", Vreme = "16:00 - 16:30", Sala = "O1", Lekar = "", Pacijent = "", Status = "Slobodan" });
        //    termini.Add(new Termin() { Zadatak = "Operacija", Datum = "6/18/2020", Vreme = "16:30 - 17:00", Sala = "O1", Lekar = "", Pacijent = "", Status = "Slobodan" });

        //    termini.Add(new Termin() { Zadatak = "Pregled", Datum = "6/17/2020", Vreme = "08:00 - 08:30", Sala = "O1", Lekar = "Ana Anić", Pacijent = "Stevan Stević", Status = "Zauzet" });
        //    termini.Add(new Termin() { Zadatak = "Pregled", Datum = "6/17/2020", Vreme = "08:30 - 09:00", Sala = "O1", Lekar = "Ana Anić", Pacijent = "Jovan Jović", Status = "Zauzet" });
        //    termini.Add(new Termin() { Zadatak = "Pregled", Datum = "6/17/2020", Vreme = "09:00 - 09:30", Sala = "O1", Lekar = "", Pacijent = "", Status = "Slobodan" });
        //    termini.Add(new Termin() { Zadatak = "Pregled", Datum = "6/17/2020", Vreme = "09:30 - 10:00", Sala = "O1", Lekar = "", Pacijent = "", Status = "Slobodan" });
        //    termini.Add(new Termin() { Zadatak = "Pregled", Datum = "6/17/2020", Vreme = "10:00 - 10:30", Sala = "O1", Lekar = "Miša Kiš", Pacijent = "Lana Lanić", Status = "Zauzet" });
        //    termini.Add(new Termin() { Zadatak = "Pregled", Datum = "6/17/2020", Vreme = "10:30 - 11:00", Sala = "O1", Lekar = "", Pacijent = "", Status = "Slobodan" });
        //    termini.Add(new Termin() { Zadatak = "Pregled", Datum = "6/17/2020", Vreme = "11:00 - 11:30", Sala = "O1", Lekar = "Miša Kiš", Pacijent = "Jelena Jelić", Status = "Zauzet" });
        //    termini.Add(new Termin() { Zadatak = "Pregled", Datum = "6/17/2020", Vreme = "11:30 - 12:00", Sala = "O1", Lekar = "", Pacijent = "", Status = "Slobodan" });
        //    termini.Add(new Termin() { Zadatak = "Pregled", Datum = "6/17/2020", Vreme = "12:00 - 12:30", Sala = "O1", Lekar = "", Pacijent = "", Status = "Slobodan" });
        //    termini.Add(new Termin() { Zadatak = "Pregled", Datum = "6/17/2020", Vreme = "12:30 - 13:00", Sala = "O1", Lekar = "", Pacijent = "", Status = "Slobodan" });
        //    termini.Add(new Termin() { Zadatak = "Pregled", Datum = "6/17/2020", Vreme = "13:00 - 13:30", Sala = "O1", Lekar = "", Pacijent = "", Status = "Slobodan" });
        //    termini.Add(new Termin() { Zadatak = "Pregled", Datum = "6/17/2020", Vreme = "13:30 - 14:00", Sala = "O1", Lekar = "", Pacijent = "", Status = "Slobodan" });
        //    termini.Add(new Termin() { Zadatak = "Pregled", Datum = "6/17/2020", Vreme = "14:00 - 14:30", Sala = "O1", Lekar = "", Pacijent = "", Status = "Slobodan" });
        //    termini.Add(new Termin() { Zadatak = "Pregled", Datum = "6/17/2020", Vreme = "14:30 - 15:00", Sala = "O1", Lekar = "", Pacijent = "", Status = "Slobodan" });
        //    termini.Add(new Termin() { Zadatak = "Pregled", Datum = "6/17/2020", Vreme = "15:00 - 15:30", Sala = "O1", Lekar = "", Pacijent = "", Status = "Slobodan" });
        //    termini.Add(new Termin() { Zadatak = "Pregled", Datum = "6/17/2020", Vreme = "15:30 - 16:00", Sala = "O1", Lekar = "", Pacijent = "", Status = "Slobodan" });
        //    termini.Add(new Termin() { Zadatak = "Pregled", Datum = "6/17/2020", Vreme = "16:00 - 16:30", Sala = "O1", Lekar = "", Pacijent = "", Status = "Slobodan" });
        //    termini.Add(new Termin() { Zadatak = "Pregled", Datum = "6/17/2020", Vreme = "16:30 - 17:00", Sala = "O1", Lekar = "", Pacijent = "", Status = "Slobodan" });


        //}

        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            MainWindow w = new MainWindow();
            this.Hide();
            w.Show();

            dispatcherTimer.Stop();
        }

    }
}
