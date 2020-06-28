using Controller.ExaminationSurgeryControlers;
using Controller.RoomsControlers;
using HealthClinic.Entiteti;
using Model.Doctor;
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
using System.Windows.Shapes;

namespace HealthClinic
{
    /// <summary>
    /// Interaction logic for DijalogBolnickoLecenje.xaml
    /// </summary>
    public partial class DijalogBolnickoLecenje : Window
    {
        //Pacijent pacijent = new Pacijent();
        private bool hitnost = false;
        private Room room = null;
        private readonly RoomController roomController;
        private static HospitalitationController hospitalitationController;

        public DijalogBolnickoLecenje()
        {
            InitializeComponent();

            //Sala.Items.Add("S1");
            //Sala.Items.Add("S404");

            /*
            if (UserControlPregled.selectedPatient == null)
            {
                Ime.Text = null;
                Prezime.Text = null;
                pacijent.ProsliPregled = "";
                pacijent.Lekovi = new ObservableCollection<string>();
                pacijent.Alergije = new ObservableCollection<string>();
                pacijent.Simptomi = new ObservableCollection<string>();
                pacijent.Dijagnoza = "";


            }
            else
            {
                pacijent = UserControlPregled.selectedPatient;


                Ime.Text = UserControlPregled.selectedPatient.Ime;
                Prezime.Text = UserControlPregled.selectedPatient.Prezime;
                pacijent.ProsliPregled = UserControlPregled.selectedPatient.Datum;
                pacijent.Dijagnoza = UserControlPregled.selectedPatient.Dijagnoza;

            }
            */

            var app = App.Current as App;
            roomController = app.RoomController;
            hospitalitationController = app.HospitalitationController;

            foreach (Room room in roomController.GetAllEntities())
            {

                if (room.TypeOfRoom.NameOfType.Equals("Bolnička soba"))
                {
                    Sala.Items.Add(room.RoomID);
                }

            }

            if (UserControlPocetna.MedicalExamination != null)
            {
                Ime.Text = UserControlPocetna.MedicalExamination.Patient.Name;
                Prezime.Text = UserControlPocetna.MedicalExamination.Patient.Surname;
            }
            else
            {
                Ime.Text = "";
                Prezime.Text = "";
            }


        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void DaChecked_Checked(object sender, RoutedEventArgs e)
        {
            if (DaChecked.IsChecked == true)
            {
                hitnost = true;
                //pacijent.Hitnost = "Da";
                NeChecked.IsChecked = false;
                NeChecked.IsEnabled = false;
            }
        }

        private void DaChecked_Unchecked(object sender, RoutedEventArgs e)
        {
            if (DaChecked.IsChecked == false)
            {
                // NeChecked.IsChecked = false;
                NeChecked.IsEnabled = true;
            }
        }

        private void NeChecked_Checked(object sender, RoutedEventArgs e)
        {
            if (NeChecked.IsChecked == true)
            {
                hitnost = false;
              //  pacijent.Hitnost = "Ne";
                DaChecked.IsChecked = false;
                DaChecked.IsEnabled = false;
            }
        }

        private void NeChecked_Unchecked(object sender, RoutedEventArgs e)
        {
            if (NeChecked.IsChecked == false)
            {
                // NeChecked.IsChecked = false;
                DaChecked.IsEnabled = true;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            /*
            pacijent.Ime = Ime.Text;
            pacijent.Prezime = Prezime.Text;
            pacijent.Datum = DatePicker1.SelectedDate.Value.ToString("dd.MM.yyyy");
            pacijent.Vreme = null;
            pacijent.Sala = Sala.SelectedItem.ToString();
            pacijent.Zadatak = "Bolničko lečenje";
            

            pacijent.KratakProblem = Razlog.Text;
           

    */
            foreach (Room r in roomController.GetAllEntities())
            {
                if (Sala.SelectedItem.Equals(r.RoomID))
                {
                    room = roomController.GetEntity(r.GetId());

                }
            }


            MessageBoxResult result = MessageBox.Show("Da li ste sigurni da ste dobro uneli podatke?\nAko jeste, potvrdite.", "Otvaranje bolničkog lečenja", MessageBoxButton.YesNo, MessageBoxImage.Warning);
            if (result == MessageBoxResult.Yes)
            {
                /*
                if (UserControlPregled.selectedPatient == null)
                {
                    MainWindow.Pacijenti.dodajPacijenta(pacijent);
                }
                else
                {
                    UserControlPregled.selectedPatient = pacijent;
                }
                */
                //MainWindow.Pacijenti.dodajPacijenta(pacijent);

                hospitalitationController.AddEntity(new Hospitalitation(hitnost, Razlog.Text, room, Window1.ulogovaniDoctor, new Bed(), 
                    DatePicker1.SelectedDate.Value, DatePicker2.SelectedDate.Value));

             







                this.Close();
            }
        }
    }
}
