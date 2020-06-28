using Controller.RoomsControlers;
using Controller.UsersControlers;
using Model.AllActors;
using Model.Term;
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
using System.Windows.Shapes;

namespace HealthClinic
{
    /// <summary>
    /// Interaction logic for DijalogIzdavanjeUputa.xaml
    /// </summary>
    public partial class DijalogIzdavanjeUputa : Window
    {
        public static SpetialitationController spetialitationController;
        public static UserController userController;
        public static Model.Doctor.Specialitation specialitation = null;
        public static Doctor selectedDoctor = null;
        private bool hitnost = false;
        private Room room = null;
        private readonly RoomController roomController;

        public DijalogIzdavanjeUputa()
        {
            InitializeComponent();
            Vremena();
            /*
            Specijalizacija.Items.Add("Kardiohirurg");
            Specijalizacija.Items.Add("Hirurg");
            Specijalizacija.Items.Add("Pedijatar");
            Specijalizacija.Items.Add("Urolog");

            ListaLekara.Items.Add("dr. Nikola Nikolić");
            ListaLekara.Items.Add("dr. Stefan Stefanović");
            ListaLekara.Items.Add("dr. Predrag Kon");
            */
            /*
            if (UserControlPregled.selectedPatient != null)
            {
                Ime.Text = UserControlPregled.selectedPatient.Ime;
                Prezime.Text = UserControlPregled.selectedPatient.Prezime;
            }
            */

            var app = Application.Current as App;
            spetialitationController = app.SpetialitationController;
            userController = app.UserController;


            foreach(Model.Doctor.Specialitation s in spetialitationController.GetAllEntities())
            {
                Specijalizacija.Items.Add(s);
                Specijalizacija.DisplayMemberPath = "SpecialitationForDoctor";
            }

            if(UserControlPocetna.MedicalExamination != null)
            {
                Ime.Text = UserControlPocetna.MedicalExamination.Patient.Name;
                Prezime.Text = UserControlPocetna.MedicalExamination.Patient.Surname;
            }
            else
            {
                Ime.Text = "";
                Prezime.Text = "";
            }

            roomController = app.RoomController;
            foreach (Room room in roomController.GetAllEntities())
            {

                if (room.TypeOfRoom.NameOfType.Equals("Soba za preglede"))
                {
                    Sala.Items.Add(room.RoomID);
                }

            }



        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }


        public void Vremena()
        {
            for (int i = 00; i < 24; i++)
            {
                for (int j = 00; j < 60; j += 30)
                {
                    ListVremena.Items.Add(i + ":" + j);
                    ListVremenaKraj.Items.Add(i + ":" + j);
                }
            }
        }

        private void DaChecked_Checked(object sender, RoutedEventArgs e)
        {
            if (DaChecked.IsChecked == true)
            {
                hitnost = true;
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

        private void Specijalizacija_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            specialitation = (Model.Doctor.Specialitation)Specijalizacija.SelectedItem;

            ListaLekara.Items.Clear();

            foreach(Doctor d in userController.GetAllDoctors())
            {
                if (d.Specialitation.GetId() == specialitation.GetId())
                {
                    ListaLekara.Items.Add(d);
                    //ListaLekara.DisplayMemberPath = "Name";
                }
            }


           

        }

        private void ListaLekara_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            selectedDoctor = (Doctor)ListaLekara.SelectedItem;
            Console.WriteLine(selectedDoctor.Name);

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            foreach (Room r in roomController.GetAllEntities())
            {
                if (Sala.SelectedItem.Equals(r.RoomID))
                {
                    room = roomController.GetEntity(r.GetId());

                }
            }

            String datum = DatePicker.SelectedDate.Value.ToString("dd.MM.yyyy.");
            String vremePocetka = ListVremena.SelectedItem.ToString();
            String vremeKraja = ListVremenaKraj.SelectedItem.ToString();






            MessageBoxResult result = MessageBox.Show("Da li ste sigurni da ste dobro uneli podatke?\nAko jeste, potvrdite.", "Zakazivanje pregleda", MessageBoxButton.YesNo, MessageBoxImage.Warning);
            if (result == MessageBoxResult.Yes)
            {
                UserControlPocetna.MedicalExamination.Urgency = hitnost;
                UserControlPocetna.MedicalExamination.ShortDescription = Razlog.Text;
                UserControlPocetna.MedicalExamination.Room = room;
                UserControlPocetna.MedicalExamination.FromDateTime = DateTime.Parse(datum + " " + vremePocetka);
                UserControlPocetna.MedicalExamination.ToDateTime = DateTime.Parse(datum + " " + vremeKraja);
                UserControlPocetna.MedicalExamination.Doctor = selectedDoctor;

                UserControlPocetna.medicalExaminationController.UpdateEntity(UserControlPocetna.MedicalExamination);
                UserControlPocetna.userControlPocetna.dgrMain.Items.Refresh();
                UserControlPocetna.userControlPocetna.dgrMain.UpdateLayout();






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
                this.Close();
            }
        }
    }
}
