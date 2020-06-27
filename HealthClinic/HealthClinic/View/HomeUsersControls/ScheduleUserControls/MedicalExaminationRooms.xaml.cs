using Controller;
using Controller.RoomsControlers;
using Controller.UsersControlers;
using HealthClinic.View.Converter;
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
    /// Interaction logic for TermsForMedicalExamination.xaml
    /// </summary>
    public partial class MedicalExaminationRooms : UserControl
    {
        public int counter = 0;

        public static ObservableCollection<Room> RoomsComboBox { get; set; }
        private readonly RoomController roomController;

        public static ObservableCollection<User> DoctorsForMedicalExamination { get; set; }
        private readonly UserController userController;

        private readonly IController<MedicalExamination, int> medicalExaminationController;
        public static ObservableCollection<ViewTerm> TermsView { get; set; }
        public static ObservableCollection<ViewTerm> currentTerms { get; set; }
        public static ObservableCollection<ViewTerm> termsForDatagrid { get; set; }

        public MedicalExaminationRooms(string selectedDate)
        {
            InitializeComponent();
            dateLabel.Content = selectedDate;
            this.DataContext = this;
            counter = 0;

            var app = Application.Current as App;
            roomController = app.RoomController;
            RoomsComboBox = new ObservableCollection<Room>(roomController.GetAllRoomForMedicalExamination().ToList()); //GetAllRoomForMedicalExamination

            userController = app.UserController;
            DoctorsForMedicalExamination = new ObservableCollection<User>(userController.GetAllDoctors().ToList()); // treba opste prakse



            searchTextBox.Visibility = Visibility.Hidden;
            btnSearch.Visibility = Visibility.Visible;
            btnClose.Visibility = Visibility.Hidden;

            btnCanceling.IsEnabled = false;
            btnRelocate.IsEnabled = false;
            btnSchedule.IsEnabled = false;


            medicalExaminationController = app.MedicalExaminationController;
            TermsView = new ObservableCollection<ViewTerm>(MedicalExaminationConverter.ConvertMedicalExaminationListToSurgeryViewList(medicalExaminationController.GetAllEntities().ToList()));
            currentTerms = TermsView;

            foreach (ViewTerm vt in TermsView)
            {
                Console.WriteLine(vt.Time);
                Loading.currentMedicalExaminationTerms.Add(vt);
            }
            foreach (ViewTerm vt in Loading.currentMedicalExaminationTerms)
            {
                Console.WriteLine("Datum: " + vt.Date + " Doktor: " + vt.Doctor + " Pacijent: " + vt.Patient + " Sala: " + vt.Room + " Zadatak: " + vt.Task + " Vreme: " + vt.Time + " Status: " + vt.Status);
            }
            fillData(DisplayType.date);
        }

        private void fillData(String date)
        {
            currentTerms.Clear();

            Room room = RoomsComboBox.First();//(Room)roomCmbx.SelectedItem;

            foreach (ViewTerm viewTerm in Loading.currentMedicalExaminationTerms)
                if (date.Equals(viewTerm.Date) && room.RoomID.Equals(viewTerm.Room) && viewTerm.Task.Equals("Pregled"))
                    currentTerms.Add(viewTerm);


            if (currentTerms.Count < 14)
            {
                if (currentTerms.Count == 0)
                {
                    addNewTermsInDatagrid(room.RoomID);

                    foreach (ViewTerm term in currentTerms)
                        Loading.currentMedicalExaminationTerms.Add(term);

                }
                else
                {

                    ObservableCollection<ViewTerm> emptyTerms = getEmptyTerms(room.RoomID);
                    foreach (ViewTerm viewTerm in Loading.currentMedicalExaminationTerms)
                    {
                        if (viewTerm.Date.Equals(dateLabel.Content.ToString()) && viewTerm.Room == room.RoomID && viewTerm.Task.Equals("Pregled"))
                        {
                            if (currentTerms.Count == 13) break;
                            foreach (ViewTerm vt in emptyTerms)
                            {
                                if (vt.Time.Equals(viewTerm.Time))
                                {
                                    vt.Doctor = viewTerm.Doctor;
                                    vt.Patient = viewTerm.Patient;
                                    vt.Status = "Zauzet";
                                    vt.Task = "Pregled";
                                    break;
                                }
                            }
                            
                        }

                    }
                    currentTerms.Clear();
                    currentTerms = emptyTerms;
                }
            }

            dgTerms.ItemsSource = currentTerms;
            counter += 1;
        }

        private ObservableCollection<ViewTerm> getEmptyTerms(String room)
        {
            ObservableCollection<ViewTerm> terms = new ObservableCollection<ViewTerm>();
            String[] dateParts = dateLabel.Content.ToString().Split('.');

            int j = 7;
            for (int i = 0; i < 13; i++)
            {
                DateTime fromDateTime = new DateTime(int.Parse(dateParts[2]), int.Parse(dateParts[1]), int.Parse(dateParts[0]), j++, 0, 0);
                DateTime toDateTime = fromDateTime.AddHours(1);
                //String[] fromDateTimeParts = fromDateTime.ToString().Split(' ');
                //String[] toDateTimeParts = toDateTime.ToString().Split(' ');
                terms.Add(new ViewTerm() { Date = dateLabel.Content.ToString(), Time = fromDateTime + " - " + toDateTime, Room = room, Doctor = "", Patient = "", Status = "Slobodan", Task = "Pregled", MakeInDoctor = false });
            }
            return terms;
        }

        private void addNewTermsInDatagrid(String room)
        {
            String[] dateParts = dateLabel.Content.ToString().Split('.');
            Console.WriteLine(dateParts[0]);
            Console.WriteLine(dateParts[1]);
            Console.WriteLine(dateParts[2]);
            int j = 7;
            for (int i = 0; i < 13; i++)
            {
                DateTime fromDateTime = new DateTime(int.Parse(dateParts[2]), int.Parse(dateParts[1]), int.Parse(dateParts[0]), j++, 0, 0);
                DateTime toDateTime = fromDateTime.AddHours(1);
                //String[] fromDateTimeParts = fromDateTime.ToString().Split(' ');
                //String[] toDateTimeParts = toDateTime.ToString().Split(' ');
                currentTerms.Add(new ViewTerm() { Date = dateLabel.Content.ToString(), Time = fromDateTime + " - " + toDateTime, Room = room, Doctor = "", Patient = "", Status = "Slobodan", Task = "Pregled", MakeInDoctor = false });
            }

        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            GridMedicalExaminationRooms.Children.Clear();
            UserControl usc = new TypeOfRoom(dateLabel.Content.ToString());
            GridMedicalExaminationRooms.Children.Add(usc);


        }

        private void homeBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridMedicalExaminationRooms.Children.Clear();
            UserControl usc = new Home();
            GridMedicalExaminationRooms.Children.Add(usc);
        }

        private void scheduleBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridMedicalExaminationRooms.Children.Clear();
            UserControl usc = new Schedule();
            GridMedicalExaminationRooms.Children.Add(usc);
        }

        private void patienstBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridMedicalExaminationRooms.Children.Clear();
            UserControl usc = new PatientView();
            GridMedicalExaminationRooms.Children.Add(usc);
        }

        private void settingsBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridMedicalExaminationRooms.Children.Clear();
            UserControl usc = new Settings();
            GridMedicalExaminationRooms.Children.Add(usc);
        }

        private void reportBtn_Click(object sender, RoutedEventArgs e)
        {
            GridMedicalExaminationRooms.Children.Clear();
            UserControl usc = new Report();
            GridMedicalExaminationRooms.Children.Add(usc);
        }


        private void btnSchedule_Click(object sender, RoutedEventArgs e)
        {
            ViewTerm term = dgTerms.SelectedItem as ViewTerm;
            if (term == null)
                return;
            fillTermWithDataFromSelectedRow(term);

            // NABAVI SVE OBICNE DOKTORE jesam

            //List<String> doctors = new List<String>();
            //foreach (Lekar l in Loading.lekari)
            //{
            //    doctors.Add(l.Doktor);
            //}

            UserControl usc = new PatientValidation(dateLabel.Content.ToString(), term);
            dgTerms.UnselectAllCells();
            btnRelocate.IsEnabled = false;
            btnCanceling.IsEnabled = false;
            btnSchedule.IsEnabled = false;
            (this.Parent as Panel).Children.Add(usc);

        }

        private void btnRelocate_Click(object sender, RoutedEventArgs e)
        {

            foreach (Room room in RoomsComboBox)
            {
                Console.WriteLine(room.RoomID);
            }

            ViewTerm term = dgTerms.SelectedItem as ViewTerm;
            if (term == null)
                return;
            fillTermWithDataFromSelectedRow(term);

            UserControl usc = new RelocationTerm(dateLabel.Content.ToString(), term);
            dgTerms.UnselectAllCells();
            btnRelocate.IsEnabled = false;
            btnCanceling.IsEnabled = false;
            btnSchedule.IsEnabled = false;
            (this.Parent as Panel).Children.Add(usc);
        }

        private static void fillTermWithDataFromSelectedRow(ViewTerm term)
        {
            term.Time = Convert.ToString(term.Time);
            term.Room = Convert.ToString(term.Room);
            term.Doctor = Convert.ToString(term.Doctor);
            term.Patient = Convert.ToString(term.Patient);
            term.Status = Convert.ToString(term.Status);
            term.Date = Convert.ToString(term.Date);
            term.Task = Convert.ToString(term.Task);
            //term.MakeInDoctor = Convert.ToBoolean(term.MakeInDoctor);
        }

        private void btnCanceling_Click(object sender, RoutedEventArgs e)
        {
            ViewTerm term = dgTerms.SelectedItem as ViewTerm;
            if (term == null)
                return;
            fillTermWithDataFromSelectedRow(term);

            UserControl usc = new CancelingTerm(dateLabel.Content.ToString());
            dgTerms.UnselectAllCells();
            btnRelocate.IsEnabled = false;
            btnCanceling.IsEnabled = false;
            btnSchedule.IsEnabled = false;
            (this.Parent as Panel).Children.Add(usc);
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            searchTextBox.Visibility = Visibility.Visible;
            searchTextBox.Focus();
            searchTextBox.SelectAll();
            btnSearch.Visibility = Visibility.Hidden;
            btnClose.Visibility = Visibility.Visible;
            dgTerms.UnselectAllCells();
            btnRelocate.IsEnabled = false;
            btnCanceling.IsEnabled = false;
            btnSchedule.IsEnabled = false;
        }

        private void dgTerms_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ViewTerm term = dgTerms.SelectedItem as ViewTerm;
            if (term == null)
                return;
            fillTermWithDataFromSelectedRow(term);
            if (term.Status.Equals("Slobodan"))
            {
                btnRelocate.IsEnabled = false;
                btnCanceling.IsEnabled = false;
                btnSchedule.IsEnabled = true;
            }
            else if (term.Status.Equals("Zauzet"))
            {
                btnRelocate.IsEnabled = true;
                btnCanceling.IsEnabled = true;
                btnSchedule.IsEnabled = false;
            }
        }

        private void cmbx_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            searchTextBox.Text = "";
            searchTextBox.Visibility = Visibility.Hidden;
            btnSearch.Visibility = Visibility.Visible;
            btnClose.Visibility = Visibility.Hidden;
            if (counter < 1)
            {
                counter += 1;
            }
            else
            {
                currentTerms.Clear();
                Room room = (Room)roomCmbx.SelectedItem;
                Console.WriteLine("Soba prikaz: " + room.RoomID);
                counter += 1;
                foreach (ViewTerm viewTerm in Loading.currentMedicalExaminationTerms)
                    if (dateLabel.Content.Equals(viewTerm.Date) && room.RoomID.Equals(viewTerm.Room) && viewTerm.Task.Equals("Pregled"))
                        currentTerms.Add(viewTerm);


                if (currentTerms.Count < 14)
                {
                    if (currentTerms.Count == 0)
                    {
                        addNewTermsInDatagrid(room.RoomID);

                        foreach (ViewTerm term in currentTerms)
                            Loading.currentMedicalExaminationTerms.Add(term);

                    }
                    else
                    {

                        ObservableCollection<ViewTerm> emptyTerms = getEmptyTerms(room.RoomID);
                        foreach (ViewTerm viewTerm in Loading.currentMedicalExaminationTerms)
                        {
                            if (viewTerm.Date.Equals(dateLabel.Content.ToString()) && viewTerm.Room == room.RoomID && viewTerm.Task.Equals("Pregled"))
                            {
                                if (currentTerms.Count == 13) break;
                                foreach (ViewTerm vt in emptyTerms)
                                {
                                    if (vt.Time.Equals(viewTerm.Time))
                                    {
                                        vt.Doctor = viewTerm.Doctor;
                                        vt.Patient = viewTerm.Patient;
                                        vt.Status = "Zauzet";
                                        vt.Task = "Pregled";
                                        break;
                                    }
                                }

                            }

                        }
                        currentTerms.Clear();
                        currentTerms = emptyTerms;
                    }
                }
                dgTerms.ItemsSource = currentTerms;
                btnRelocate.IsEnabled = false;
                btnCanceling.IsEnabled = false;
                btnSchedule.IsEnabled = false;
                dgTerms.UnselectAllCells();

            }


            

        }
        private void searchTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            var fill = currentTerms.Where(term => term.Patient.ToString().Contains(searchTextBox.Text) || term.Doctor.ToString().Contains(searchTextBox.Text)
                        || term.Time.ToString().Contains(searchTextBox.Text) || term.Room.ToString().Contains(searchTextBox.Text) || term.Status.ToString().Contains(searchTextBox.Text));
            dgTerms.ItemsSource = fill;

        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            searchTextBox.Text = "";
            dgTerms.ItemsSource = currentTerms;
            searchTextBox.Visibility = Visibility.Hidden;
            btnSearch.Visibility = Visibility.Visible;
            btnClose.Visibility = Visibility.Hidden;
            dgTerms.UnselectAllCells();
            btnRelocate.IsEnabled = false;
            btnCanceling.IsEnabled = false;
            btnSchedule.IsEnabled = false;
        }
    }
}
