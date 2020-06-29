using Controller;
using Controller.ExaminationSurgeryControlers;
using Controller.UsersControlers;
using HealthClinic.View.Dialogues;
using HealthClinic.View.ViewModel;
using Model.AllActors;
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
    /// Interaction logic for ScheduleTerm.xaml
    /// </summary>
    public partial class ScheduleTerm : UserControl
    {

        Patient patient = new Patient();

        ViewTerm termForSchedule = new ViewTerm();

        private readonly MedicalExaminationController medicalExaminationController;
        private readonly SurgeryController surgeryController;
        public static ObservableCollection<User> Doctors{ get; set; }

        public ScheduleTerm(string selectedDate, ViewTerm term, Patient patient)
        {
            InitializeComponent();
            this.DataContext = this;
            dateLabel.Content = selectedDate;
            termForSchedule = term;
            l11.Content = term.Time;
            l22.Content = term.Task;
            l33.Content = patient.Name + " " + patient.Surname; 
            this.patient = patient;
            confirmBtn.IsEnabled = false;

            var app = Application.Current as App;
            medicalExaminationController = app.MedicalExaminationController;

            surgeryController = app.SurgeryController;


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


            if (!termForSchedule.Room.Equals(""))
            {
                l44.Content = term.Room;
                l4.Visibility = Visibility.Visible;

                cmbxDoctor.Visibility = Visibility.Visible;
                cmbxDoctor.IsHitTestVisible = true;
                cmbxDoctor.Focusable = true;
                label3.Visibility = Visibility.Visible;

                if (term.Task.Equals("Operacija"))
                     Doctors = SurgeryRooms.DoctorsForSurgery; 
                else
                    Doctors = MedicalExaminationRooms.DoctorsForMedicalExamination; 

            }


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
            UserControl usc = new PatientView();
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
            if (termForSchedule.Task.Equals("Operacija"))
            {
                Surgery surgery = new Surgery();
                surgery.Urgency = false;
                surgery.ShortDescription = "";

                foreach (Room room in SurgeryRooms.RoomsComboBox)
                    if (room.RoomID.Equals(termForSchedule.Room))
                        surgery.Room = room;

                String[] fromDateTimeParts = termForSchedule.Time.Split(' ');
                surgery.FromDateTime = DateTime.Parse(fromDateTimeParts[0] + " " + fromDateTimeParts[1]);
                surgery.ToDateTime = DateTime.Parse(fromDateTimeParts[3] + " " + fromDateTimeParts[4]);
                surgery.DoctorSpecialist = (Doctor)cmbxDoctor.SelectedItem;
                surgery.Patient = patient;
                foreach (Surgery surgeryFromFile in surgeryController.GetAllEntities())
                {
                    
                    if (surgeryFromFile.FromDateTime.Equals(surgery.FromDateTime))
                    {
                        
                        foreach (Surgery surgeryForDoctor in surgeryController.GetAllSurgeryByDoctor(surgery.DoctorSpecialist))
                        {
                            if (surgeryForDoctor.FromDateTime.Equals(surgeryFromFile.FromDateTime))
                            {
                                MessageBox.Show("Izabran doktor je već zauzet za ovaj datum i vreme!");
                                return;
                            }
                        }

                        foreach (Surgery surgeryForDoctor in surgeryController.GetAllSurgeryByPatient(surgery.patient))
                        {
                            if (surgeryForDoctor.FromDateTime.Equals(surgeryFromFile.FromDateTime))
                            {
                                MessageBox.Show("Izabran pacijent već ima zakazan termin za ovaj datum i vreme!");
                                return;
                            }
                        }


                        break;
                    }
                }

                surgeryController.AddEntity(surgery);
            } else
            {
                MedicalExamination medicalExamination = new MedicalExamination();
                medicalExamination.Urgency = false;
                medicalExamination.ShortDescription = "";

                foreach (Room room in MedicalExaminationRooms.RoomsComboBox)
                    if (room.RoomID.Equals(termForSchedule.Room))
                        medicalExamination.Room = room;

                String[] fromDateTimeParts = termForSchedule.Time.Split(' ');
                medicalExamination.FromDateTime = DateTime.Parse(fromDateTimeParts[0] + " " + fromDateTimeParts[1]);
                medicalExamination.ToDateTime = DateTime.Parse(fromDateTimeParts[3] + " " + fromDateTimeParts[4]);
                medicalExamination.Doctor = (Doctor)cmbxDoctor.SelectedItem;
                medicalExamination.Patient = patient;

                foreach (MedicalExamination medicalExaminationFromFile in medicalExaminationController.GetAllEntities())
                {

                    if (medicalExaminationFromFile.FromDateTime.Equals(medicalExamination.FromDateTime))
                    {

                        foreach (MedicalExamination medicalExaminationForDoctor in medicalExaminationController.GetAllMedicalExaminationsByDoctor(medicalExamination.Doctor))
                        {
                            if (medicalExaminationForDoctor.FromDateTime.Equals(medicalExaminationFromFile.FromDateTime))
                            {
                                MessageBox.Show("Izabran doktor je već zauzet za ovaj datum i vreme!");
                                return;
                            }
                        }

                        foreach (MedicalExamination medicalExaminationForDoctor in medicalExaminationController.GetAllMedicalExaminationsByPatient(medicalExamination.Patient))
                        {
                            if (medicalExaminationForDoctor.FromDateTime.Equals(medicalExaminationFromFile.FromDateTime))
                            {
                                MessageBox.Show("Izabran pacijent već ima zakazan termin za ovaj datum i vreme!");
                                return;
                            }
                        }


                        break;
                    }
                }

                medicalExaminationController.AddEntity(medicalExamination);
            }


            GridScheduleTerm.Children.Clear();
            UserControl usc = new SuccessfulySchedule();
            GridScheduleTerm.Children.Add(usc);
            return;
        }

        private void cmbxDoctor_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(cmbxDoctor.Text != null)
                confirmBtn.IsEnabled = true;        
        }

        private void cmbxRoom_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cmbxRoom.Text != null)
                confirmBtn.IsEnabled = true;
        }
    }
}
