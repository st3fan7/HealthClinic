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

        public static ObservableCollection<User> Doctors { get; set; }
        private readonly UserController userController;

        private readonly MedicalExaminationController medicalExaminationController;
        private readonly SurgeryController surgeryController;

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
                Doctors = MedicalExaminationRooms.DoctorsForMedicalExamination;
            else
                Doctors = SurgeryRooms.DoctorsForSurgery;


            medicalExaminationController = app.MedicalExaminationController;
            surgeryController = app.SurgeryController;


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
            Surgery surgery = new Surgery();

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

                        foreach (MedicalExamination medicalExaminationForDoctor in medicalExaminationController.GetAllMedicalExaminationsByRoom(medicalExamination.Room))
                        {
                            if (medicalExaminationForDoctor.FromDateTime.Equals(medicalExaminationFromFile.FromDateTime))
                            {
                                MessageBox.Show("Izabrana sala je već zauzeta za ovaj datum i vreme!");
                                return;
                            }
                        }


                        break;
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
                surgery.Urgency = false;
                surgery.ShortDescription = "";


                surgery.Room = (Room)cmbx1.SelectedItem;



                String[] fromDateTimeParts = termForRelocation.Time.Split(' ');
                surgery.FromDateTime = DateTime.Parse(fromDateTimeParts[0] + " " + fromDateTimeParts[1]);
                surgery.ToDateTime = DateTime.Parse(fromDateTimeParts[3] + " " + fromDateTimeParts[4]);
                surgery.DoctorSpecialist = (Doctor)cmbx2.SelectedItem;

                Patient patient = (Patient)userController.GetUserByJMBG(termForRelocation.PatientJMBG);
               
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

                        foreach (Surgery surgeryForDoctor in surgeryController.GetAllSurgeryByPatient(surgery.Patient))
                        {
                            if (surgeryForDoctor.FromDateTime.Equals(surgeryFromFile.FromDateTime))
                            {
                                MessageBox.Show("Izabran pacijent već ima zakazan termin za ovaj datum i vreme!");
                                return;
                            }
                        }

                        foreach (Surgery surgeryForDoctor in surgeryController.GetAllSurgeryByRoom(surgery.Room))
                        {
                            if (surgeryForDoctor.FromDateTime.Equals(surgeryFromFile.FromDateTime))
                            {
                                MessageBox.Show("Izabrana sala je već zauzeta za ovaj datum i vreme!");
                                return;
                            }
                        }


                        break;
                    }
                }

                Surgery surgeryForRel = new Surgery();
                foreach (Surgery sur in surgeryController.GetAllEntities())
                {
                    if (sur.GetId() == oldTerm.Id)
                    {
                        surgeryForRel = sur;
                        break;
                    }

                }

                surgeryForRel.ToDateTime = surgery.ToDateTime;
                surgeryForRel.FromDateTime = surgery.FromDateTime;
                surgeryForRel.DoctorSpecialist = surgery.DoctorSpecialist;
                surgeryForRel.Room = surgery.Room;
                surgeryForRel.Patient = surgery.Patient;

                surgeryController.UpdateEntity(surgeryForRel);
            }


            if (oldTerm.Status.Equals("Zauzet"))
            {
                ViewTerm termSearch = new ViewTerm();

                if (oldTerm.Task.Equals("Pregled"))
                {
                    foreach (ViewTerm viewTerm in Loading.currentMedicalExaminationTerms)
                    {
                        if (viewTerm.Id == oldTerm.Id)
                        {
                            termSearch = viewTerm;
                            break;
                        }
                    }

                    Loading.currentMedicalExaminationTerms.Remove(termSearch);
                } else
                {
                    foreach (ViewTerm viewTerm in Loading.currentSurgeryTerms)
                    {
                        if (viewTerm.Id == oldTerm.Id)
                        {
                            termSearch = viewTerm;
                            break;
                        }
                    }

                    Loading.currentSurgeryTerms.Remove(termSearch);
                }
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
