using Controller;
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

        private readonly IController<MedicalExamination, int> medicalExaminationController;
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

                // ako sala postoji treba doktor da se bira
                cmbxDoctor.Visibility = Visibility.Visible;
                cmbxDoctor.IsHitTestVisible = true;
                cmbxDoctor.Focusable = true;
                label3.Visibility = Visibility.Visible;

                List<String> lekariKojePunim = new List<String>();
                if (term.Task == "Operacija")
                {
                    //NABAVI SVE LEKARE SPECIJALISTE
                    // Doctors = MedicalExaminationRooms.DoctorsForMedicalExamination; // MORA DA SE PROSLEDJUJE ILI NEKAKO DA VIDIS DA LI JE OPERACIJA ILI PREGLED

                }
                else
                {
                    // NABAVI SVE LEKARE OPSTE PRAKSE
                    Doctors = MedicalExaminationRooms.DoctorsForMedicalExamination; // KAKO ZNAM KOJI SU DOKTORI?
                    foreach(Doctor d in Doctors)
                    {
                        Console.WriteLine(d.Name);
                    }
                }


            }
            //else
            //{
            //    // imamo doktora
            //    l44.Content = term.Lekar;
            //    l5.Visibility = Visibility.Visible;
            //    cmbxRoom.Visibility = Visibility.Visible;
            //    cmbxRoom.IsHitTestVisible = true;
            //    cmbxRoom.Focusable = true;
            //    label4.Visibility = Visibility.Visible;

            //    List<String> sobeKojimaSePuni = new List<String>();
            //    if(term.Zadatak == "Operacija")
            //    {
            //        foreach (Sobe s in Loading.sobeZaOperaciju)
            //        {
            //            sobeKojimaSePuni.Add(s.Soba);
            //        }
            //    } else
            //    {
            //        foreach (Sobe s in Loading.sobeZaPregled)
            //        {
            //            sobeKojimaSePuni.Add(s.Soba);
            //        }
            //    }


            //    sobe.Clear();
            //    foreach (String r in sobeKojimaSePuni)
            //    {
            //        sobe.Add(new Sobe() { Soba = r });
            //    }


            //    cmbxRoom.ItemsSource = sobe;
            //    cmbxRoom.DisplayMemberPath = "Soba";



            //    Console.WriteLine("Poslao sam soba: " + sobe.Count);

            //}


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

            MedicalExamination medicalExamination = new MedicalExamination();
            medicalExamination.Urgency = false;
            medicalExamination.ShortDescription = "Upala grla";
            
            foreach(Room room in MedicalExaminationRooms.RoomsComboBox)
                if (room.RoomID.Equals(termForSchedule.Room))
                    medicalExamination.Room = room;

            String[] fromDateTimeParts = termForSchedule.Time.Split(' ');
            medicalExamination.FromDateTime = DateTime.Parse(fromDateTimeParts[0] + " " + fromDateTimeParts[1]);
            medicalExamination.ToDateTime = DateTime.Parse(fromDateTimeParts[3] + " " + fromDateTimeParts[4]);
            medicalExamination.Doctor = (Doctor)cmbxDoctor.SelectedItem;
            medicalExamination.Patient = patient;
            medicalExaminationController.AddEntity(medicalExamination);

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
