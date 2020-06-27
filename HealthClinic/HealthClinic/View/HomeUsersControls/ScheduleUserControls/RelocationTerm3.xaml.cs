using Controller;
using Controller.ExaminationSurgeryControlers;
using Controller.RoomsControlers;
using Controller.UsersControlers;
using HealthClinic.View.Dialogues;
using HealthClinic.View.ViewModel;
using Model.AllActors;
using Model.Term;
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
        public static ObservableCollection<Room> RoomsComboBox { get; set; }

        public static ObservableCollection<User> DoctorsForMedicalExamination { get; set; }
        private readonly UserController userController;

        private readonly MedicalExaminationController medicalExaminationController;

        ViewTerm termForRelocation = new ViewTerm();
        ViewTerm oldTerm = new ViewTerm();

        private ObservableCollection<ViewTerm> currentTerms = new ObservableCollection<ViewTerm>();
        public RelocationTerm3(ViewTerm oldTerm, ViewTerm term,  ObservableCollection<Room> rooms)
        {
            InitializeComponent();
            dateLabel.Content = oldTerm.Date;
            timeLabel.Content = oldTerm.Time;
            roomLabel.Content = oldTerm.Room;
            doctorLabel.Content = oldTerm.Doctor;
            patientLabel.Content = oldTerm.Patient;
            termForRelocation = term;
            this.oldTerm = oldTerm;
            relocateBtn.IsEnabled = false;
            this.DataContext = this;


            RoomsComboBox = rooms;

            var app = Application.Current as App;
            userController = app.UserController;
            if (oldTerm.Task.Equals("Pregled"))
            {
                DoctorsForMedicalExamination = new ObservableCollection<User>(userController.GetAllDoctors().ToList()); // treba opste prakse
            } else
            {
                // nabavi doktore specijaliste
            }

            medicalExaminationController = app.MedicalExaminationController;



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

            MedicalExamination medicalExamination = new MedicalExamination();
            if (oldTerm.Task.Equals("Pregled"))
            {

                medicalExamination.Urgency = false;
                medicalExamination.ShortDescription = "";


                medicalExamination.Room = (Room)cmbx1.SelectedItem;



                String[] fromDateTimeParts = termForRelocation.Time.Split(' ');
                medicalExamination.FromDateTime = DateTime.Parse(fromDateTimeParts[0] + " " + fromDateTimeParts[1]);
                medicalExamination.ToDateTime = DateTime.Parse(fromDateTimeParts[3] + " " + fromDateTimeParts[4]);
                medicalExamination.Doctor = (Doctor)cmbx2.SelectedItem;

                Patient patient = (Patient)userController.GetUserByJMBG(termForRelocation.PatientJMBG);
                Console.WriteLine(patient.Jmbg);
                medicalExamination.Patient = patient;

                // provera da li je taj termin vec postoji

                foreach (MedicalExamination medicalE in medicalExaminationController.GetAllEntities())
                {
                    if (medicalE.ToDateTime.ToString() == medicalExamination.ToDateTime.ToString() && medicalE.FromDateTime.ToString() == medicalExamination.FromDateTime.ToString() && medicalE.Room.RoomID == medicalExamination.Room .RoomID &&
                        medicalE.Doctor.GetId() == medicalExamination.Doctor.GetId() && medicalE.Patient.GetId() == medicalExamination.Patient.GetId())
                    {
                        MessageBox.Show("Termin sa ovim podacima je vec popunjen! Izmenite neke podatke za premestanje!");
                        return;
                    }

                }

                MedicalExamination md = new MedicalExamination();
                foreach (MedicalExamination medicalE in medicalExaminationController.GetAllEntities())
                {
                    if (medicalE.GetId() == oldTerm.Id)
                    {
                        md = medicalE;
                        break;
                    }

                }

                md.ToDateTime = medicalExamination.ToDateTime;
                md.FromDateTime = medicalExamination.FromDateTime;
                md.Doctor = medicalExamination.Doctor;
                md.Room = medicalExamination.Room;
                md.Patient = medicalExamination.Patient;

                medicalExaminationController.UpdateEntity(md);
            }
            else
            {
                // za operaciju
            }


            if (oldTerm.Status.Equals("Zauzet"))
            {

                ViewTerm termSearch = new ViewTerm();

                foreach (ViewTerm viewTerm in Loading.currentMedicalExaminationTerms)
                {
                    if (viewTerm.Id == oldTerm.Id)
                    {
                        termSearch = viewTerm;
                        break;
                    }
                }

                Loading.currentMedicalExaminationTerms.Remove(termSearch);
            }


            GridRelocationTerm3.Children.Clear();
            UserControl usc = new SuccessfullyRelocation();
            GridRelocationTerm3.Children.Add(usc);

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
