﻿using Controller.RoomsControlers;
using HealthClinic.Entiteti;
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
    /// Interaction logic for DijalogZakazivanjeOperacije.xaml
    /// </summary>
    public partial class DijalogZakazivanjeOperacije : Window
    {
        //Pacijent pacijent = new Pacijent();
        private bool hitnost = false;
        private Room room = null;
        private readonly RoomController roomController;

        public DijalogZakazivanjeOperacije()
        {
            InitializeComponent();
            Vremena();

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
            /*
            Sala.Items.Add("O1");
            Sala.Items.Add("O2");
            Sala.Items.Add("O3");
            */

            if (UserControlPacijenti.surgery != null)
            {
                Ime.Text = UserControlPacijenti.surgery.Patient.Name;
                Prezime.Text = UserControlPacijenti.surgery.Patient.Surname;
            }
            else
            {
                Ime.Text = "";
                Prezime.Text = "";
            }

            var app = App.Current as App;
            roomController = app.RoomController;

            foreach (Room room in roomController.GetAllEntities())
            {

                if (room.TypeOfRoom.NameOfType.Equals("Soba za operacije"))
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
               // pacijent.Hitnost = "Ne";
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
            pacijent.Datum = datePicker.SelectedDate.Value.ToString("dd.MM.yyyy");
            pacijent.Vreme = ListVremena.SelectedItem.ToString();
            pacijent.Sala = Sala.SelectedItem.ToString();
            pacijent.Zadatak = "Operacija";
          

            pacijent.KratakProblem = Razlog.Text;
            
            */

            foreach (Room r in roomController.GetAllEntities())
            {
                if (Sala.SelectedItem.Equals(r.RoomID))
                {
                    room = roomController.GetEntity(r.GetId());

                }
            }

            String datum = datePicker.SelectedDate.Value.ToString("dd.MM.yyyy.");
            String vremePocetka = ListVremena.SelectedItem.ToString();
            String vremeKraja = ListVremenaKraj.SelectedItem.ToString();


            MessageBoxResult result = MessageBox.Show("Da li ste sigurni da ste dobro uneli podatke?\nAko jeste, potvrdite.", "Zakazivanje operacije", MessageBoxButton.YesNo, MessageBoxImage.Warning);
            if (result == MessageBoxResult.Yes)
            {/*
                if (UserControlPregled.selectedPatient == null)
                {
                    MainWindow.Pacijenti.dodajPacijenta(pacijent);
                }
                else
                {
                    UserControlPregled.selectedPatient = pacijent;
                }*/

                /*
                UserControlPocetna.MedicalExamination.Urgency = hitnost;
                UserControlPocetna.MedicalExamination.ShortDescription = Razlog.Text;
                UserControlPocetna.MedicalExamination.Room = room;
                UserControlPocetna.MedicalExamination.FromDateTime = DateTime.Parse(datum + " " + vremePocetka);
                UserControlPocetna.MedicalExamination.ToDateTime = DateTime.Parse(datum + " " + vremeKraja);

                UserControlPocetna.medicalExaminationController.UpdateEntity(UserControlPocetna.MedicalExamination);
                UserControlPocetna.userControlPocetna.dgrMain.Items.Refresh();
                UserControlPocetna.userControlPocetna.dgrMain.UpdateLayout();
                */

                UserControlPacijenti.surgery.Urgency = hitnost;
                UserControlPacijenti.surgery.ShortDescription = Razlog.Text;
                UserControlPacijenti.surgery.Room = room;
                UserControlPacijenti.surgery.FromDateTime = DateTime.Parse(datum + " " + vremePocetka);
                UserControlPacijenti.surgery.ToDateTime = DateTime.Parse(datum + " " + vremeKraja);

                UserControlPacijenti.surgeryController.UpdateEntity(UserControlPacijenti.surgery);


                this.Close();
            }
        }
    }


}
