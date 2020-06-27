﻿using HealthClinic.View.Dialogues;
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

        private ViewTerm termForCanceling = new ViewTerm();
        private ViewTerm termForRelocation = new ViewTerm();

        private static ObservableCollection<Room> roomsFromCmbx = new ObservableCollection<Room>();

        public static ObservableCollection<ViewTerm> currentTerms = new ObservableCollection<ViewTerm>();

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

            if(term.Task.Equals("Pregled"))
                roomsFromCmbx = MedicalExaminationRooms.RoomsComboBox;
            else
                roomsFromCmbx = MedicalExaminationRooms.RoomsComboBox; // KAD URADIS OPERACIJU PROMENI OVO!!!
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
            UserControl usc = new PatientView();
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
            if (datePickerSchedule.SelectedDate != null)
            {


                termForRelocation.Date = datePickerSchedule.Text;
                termForRelocation.Task = termForCanceling.Task;
                termForRelocation.Status = "Zauzet";
                termForRelocation.Patient = termForCanceling.Patient;
                termForRelocation.Time = "";
                termForRelocation.Room = "";
                termForRelocation.Id = 0; // NE TREBA OVDE ID mozda
                termForRelocation.PatientJMBG = termForCanceling.PatientJMBG;
                Console.WriteLine("Pacijent u terminu koji se premesta: " + termForRelocation.Patient);
                UserControl usc = new RelocationTerm2(dateLabel.Content.ToString(), termForRelocation, termForCanceling, roomsFromCmbx); // sad imam datum kad ce se obaviti pregled // trenutni termini su public da ne moram da saljem
                (this.Parent as Panel).Children.Add(usc);


            }
            else
            {
                textWarning.Visibility = textWarningHidden;

            }


            //currentTerms.Clear();

            //if (datePickerSchedule.SelectedDate != null)
            //{

            //    Console.WriteLine("Broj termina na pocetku: " + Loading.currentMedicalExaminationTerms.Count);
            //    foreach (ViewTerm term in Loading.currentMedicalExaminationTerms) // promeni naziv ili vidi sta ces jer nekad je operacija
            //    {

            //        if (datePickerSchedule.Text.Equals(term.Date))
            //        {
            //            currentTerms.Add(term);
            //        }
            //    }
            //    Console.WriteLine("Trenutno termina ima: " + currentTerms.Count);

            //    if (currentTerms.Count == 0)
            //    {
            //        foreach(Room room in roomsFromCmbx)
            //        {
            //            addNewTermsInDatagrid(room.RoomID);
            //        }


            //        foreach (ViewTerm vt in currentTerms)
            //            if (Loading.currentMedicalExaminationTerms.Any(p => p.Id == vt.Id) == false)
            //                Loading.currentMedicalExaminationTerms.Add(vt);

            //        Console.WriteLine("Posle pravljena praznih termina: " + currentTerms.Count);
            //        //Console.WriteLine("Svi: " + Loading.termini.Count);
            //        //Console.WriteLine("Svi: " + Loading.termini.Count);
            //    }
            //    else
            //    {
            //        foreach (Room room in roomsFromCmbx)
            //        {
            //            ObservableCollection<ViewTerm> emptyTerms = getEmptyTerms(room.RoomID);
            //            foreach (ViewTerm viewTerm in Loading.currentMedicalExaminationTerms)
            //            {
            //                if (viewTerm.Date.Equals(dateLabel.Content.ToString()) && viewTerm.Room == room.RoomID && viewTerm.Task.Equals("Pregled"))
            //                {
            //                    if (currentTerms.Count == 13) break;
            //                    foreach (ViewTerm vt in emptyTerms)
            //                    {
            //                        if (vt.Time.Equals(viewTerm.Time))
            //                        {
            //                            vt.Doctor = viewTerm.Doctor;
            //                            vt.Patient = viewTerm.Patient;
            //                            vt.Status = "Zauzet";
            //                            vt.Task = "Pregled";
            //                            vt.Id = viewTerm.Id;
            //                            break;
            //                        }
            //                    }

            //                }

            //            }
            //            Console.WriteLine("Trenutno termina ima (ako ih je na pocetku bilo vise od jedan zauzet): " + currentTerms.Count);
            //            currentTerms.Clear();
            //            currentTerms = emptyTerms;

            //            foreach (ViewTerm vt in currentTerms)
            //                if (Loading.currentMedicalExaminationTerms.Any(p => p.Id == vt.Id) == false)
            //                    Loading.currentMedicalExaminationTerms.Add(vt);
            //        }


            //    }
            //    //Console.WriteLine(trenutniTermini.Count);
            //    currentTerms.Clear();
            //    //  Console.WriteLine(trenutniTermini.Count); // obrisi kasnije to i trenutniTermini
            //    Console.WriteLine("Broj novih termina: " + Loading.currentMedicalExaminationTerms.Count);
            //    foreach (ViewTerm term in Loading.currentMedicalExaminationTerms)
            //    {
            //        if (datePickerSchedule.Text.Equals(term.Date) && term.Status == "Slobodan" && term.Task == termForCanceling.Task)
            //        {
            //            currentTerms.Add(term); // svi slobodni termini za taj datum
            //        }
            //    }

            //    //Console.WriteLine(trenutniTermini.Count);
            //    if (currentTerms.Count > 0)
            //    {
            //        termForRelocation.Date = datePickerSchedule.Text;
            //        termForRelocation.Task = termForCanceling.Task;
            //        termForRelocation.Status = "Zauzet";
            //        termForRelocation.Patient = termForCanceling.Patient;
            //        termForRelocation.Time = "";
            //        termForRelocation.Room = "";
            //        termForRelocation.Id = 0; // NE TREBA OVDE ID mozda
            //        Console.WriteLine("Pacijent u terminu koji se premesta: " +termForRelocation.Patient);
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
