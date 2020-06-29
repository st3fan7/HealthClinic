using Controller.ExaminationSurgeryControlers;
using Controller.RoomsControlers;
using HealthClinic.View.Converter;
using HealthClinic.View.Dialogues;
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
    /// Interaction logic for RecoveryRooms.xaml
    /// </summary>
    public partial class RecoveryRooms : UserControl
    {

        public static ObservableCollection<Room> RoomsComboBox { get; set; }
        private readonly RoomController roomController;
        private readonly HospitalitationController hospitalitationController;

        public static ObservableCollection<ViewHospitalitation> TermsView { get; set; }
        public static ObservableCollection<ViewHospitalitation> currentTerms { get; set; }
        public static ObservableCollection<ViewHospitalitation> termsForDatagrid { get; set; }

        private ObservableCollection<ViewHospitalitation> currentTermsInRoomForRecovery = new ObservableCollection<ViewHospitalitation>();
        public int counter = 0;
        public RecoveryRooms(string selectedDate)
        {
            InitializeComponent();
            dateLabel.Content = selectedDate;
            this.DataContext = this;
            counter = 0;

            var app = Application.Current as App;
            roomController = app.RoomController;
            RoomsComboBox = new ObservableCollection<Room>(roomController.GetAllRoomForHospitalitation().ToList());

            searchTextBox.Visibility = Visibility.Hidden;
            btnSearch.Visibility = Visibility.Visible;
            btnClose.Visibility = Visibility.Hidden;
            btnAccommodate.IsEnabled = false;
            btnChange.IsEnabled = false;


            hospitalitationController = app.HospitalitationController;
            TermsView = new ObservableCollection<ViewHospitalitation>(HospitalitationConverter.ConvertHospitalitationListToHospitalitationViewList(hospitalitationController.GetAllEntities().ToList()));
            currentTerms = TermsView;

            foreach (ViewHospitalitation vt in TermsView)
                if (Loading.hospitalitationTerms.Any(p => p.Id == vt.Id) == false)
                    Loading.hospitalitationTerms.Add(vt);

            fillData(TypeOfRoom.date);
        }

        private void fillData(String date)
        {
            currentTermsInRoomForRecovery.Clear();

            Room room = RoomsComboBox.First();

            foreach (ViewHospitalitation recovery in Loading.hospitalitationTerms)
            {


                if (date.Equals(recovery.FromDateTime) && room.RoomID.Equals(recovery.Room))
                {
                    currentTermsInRoomForRecovery.Add(recovery);
                }
            }
            //Id = hospitalitation.GetId(),
            //    FromDateTime = hospitalitation.FromDateTime.ToString().Remove(hospitalitation.FromDateTime.ToString().Length - 3),
            //    ToDateTime = hospitalitation.ToDateTime.ToString().Remove(hospitalitation.ToDateTime.ToString().Length - 3),
            //    Room = hospitalitation.Room.RoomID,
            //    Doctor = hospitalitation.Doctor.Name + " " + hospitalitation.Doctor.Surname,
            //    Patient = hospitalitation.BedForLaying.Patient.Name + " " + hospitalitation.BedForLaying.Patient.Surname,
            //    Status = "Slobodan",
            //    PatientJMBG = hospitalitation.BedForLaying.Patient.Jmbg

            if (currentTermsInRoomForRecovery.Count == 0)
            {
                for (int i = 0; i < 9; i++)
                    currentTermsInRoomForRecovery.Add(new ViewHospitalitation() { FromDateTime = dateLabel.Content.ToString(), ToDateTime = "", Room = room.RoomID, Patient = "", Status = "Slobodan", Doctor="",PatientJMBG="",Id=0 });

                foreach (ViewHospitalitation o in currentTermsInRoomForRecovery)
                {
                    Loading.hospitalitationTerms.Add(o);
                }

            }

            dgTerms.ItemsSource = currentTermsInRoomForRecovery;
            counter += 1;
        }





        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            GridRecoveryRooms.Children.Clear();
            UserControl usc = new TypeOfRoom(dateLabel.Content.ToString());
            GridRecoveryRooms.Children.Add(usc);

        }

        private void homeBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridRecoveryRooms.Children.Clear();
            UserControl usc = new Home();
            GridRecoveryRooms.Children.Add(usc);
        }

        private void scheduleBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridRecoveryRooms.Children.Clear();
            UserControl usc = new Schedule();
            GridRecoveryRooms.Children.Add(usc);

        }

        private void patienstBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridRecoveryRooms.Children.Clear();
            UserControl usc = new PatientView();
            GridRecoveryRooms.Children.Add(usc);
        }

        private void settingsBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridRecoveryRooms.Children.Clear();
            UserControl usc = new Settings();
            GridRecoveryRooms.Children.Add(usc);
        }

        private void reportBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridRecoveryRooms.Children.Clear();
            UserControl usc = new Report();
            GridRecoveryRooms.Children.Add(usc);
        }


        private void btnAccommodate_Click(object sender, RoutedEventArgs e)
        {
            ViewHospitalitation hospitalitation = dgTerms.SelectedItem as ViewHospitalitation;
            if (hospitalitation == null)
                return;
            fillRecoveryWithDataFromSelectedRow(hospitalitation);

            UserControl usc = new PatientValidationForRecovery(dateLabel.Content.ToString());
            btnAccommodate.IsEnabled = false;
            btnChange.IsEnabled = false;
            dgTerms.UnselectAllCells();
            (this.Parent as Panel).Children.Add(usc);
        }

        private void btnChange_Click(object sender, RoutedEventArgs e)
        {
            ViewHospitalitation hospitalitation = dgTerms.SelectedItem as ViewHospitalitation;
            if (hospitalitation == null)
                return;
            fillRecoveryWithDataFromSelectedRow(hospitalitation);

            UserControl usc = new DataModificationInRecoveryRoom(dateLabel.Content.ToString());
            btnAccommodate.IsEnabled = false;
            btnChange.IsEnabled = false;
            dgTerms.UnselectAllCells();
            (this.Parent as Panel).Children.Add(usc);
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            searchTextBox.Visibility = Visibility.Visible;
            searchTextBox.Focus();
            searchTextBox.SelectAll();
            btnSearch.Visibility = Visibility.Hidden;
            btnClose.Visibility = Visibility.Visible;
            btnAccommodate.IsEnabled = false;
            btnChange.IsEnabled = false;
            dgTerms.UnselectAllCells();
        }

        private void dgTerms_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ViewHospitalitation hospitalitation = dgTerms.SelectedItem as ViewHospitalitation;
            if (hospitalitation == null)
                return;
            fillRecoveryWithDataFromSelectedRow(hospitalitation);
            if (hospitalitation.Status.Equals("Slobodan"))
            {
                btnAccommodate.IsEnabled = true;
                btnChange.IsEnabled = false;
            }
            else if (hospitalitation.Status.Equals("Zauzet"))
            {
                btnAccommodate.IsEnabled = false;
                btnChange.IsEnabled = true;
            }
        }

        private static void fillRecoveryWithDataFromSelectedRow(ViewHospitalitation hospitalitation)
        {
            hospitalitation.FromDateTime = Convert.ToString(hospitalitation.FromDateTime);
            hospitalitation.ToDateTime = Convert.ToString(hospitalitation.ToDateTime);
            hospitalitation.Patient = Convert.ToString(hospitalitation.Patient);
            hospitalitation.Room = Convert.ToString(hospitalitation.Room);
            hospitalitation.Status = Convert.ToString(hospitalitation.Status);
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
                counter += 1;
                currentTermsInRoomForRecovery.Clear();

                Room room = RoomsComboBox.First();

                foreach (ViewHospitalitation recovery in Loading.hospitalitationTerms)
                {
                    Console.WriteLine("From date time: " + recovery.FromDateTime);

                    if (dateLabel.Equals(recovery.FromDateTime) && room.RoomID.Equals(recovery.Room))
                    {
                        currentTermsInRoomForRecovery.Add(recovery);
                    }
                }


                if (currentTermsInRoomForRecovery.Count == 0)
                {
                    for(int i = 0; i < 9; i++)
                        currentTermsInRoomForRecovery.Add(new ViewHospitalitation() { FromDateTime = dateLabel.Content.ToString(), ToDateTime = "", Room = room.RoomID, Patient = "", Status = "Slobodan", Doctor = "", PatientJMBG = "", Id = 0 });



                    foreach (ViewHospitalitation o in currentTermsInRoomForRecovery)
                    {
                        Loading.hospitalitationTerms.Add(o);
                    }

                }

                dgTerms.ItemsSource = currentTermsInRoomForRecovery;
                btnChange.IsEnabled = false;
                btnAccommodate.IsEnabled = false;
                dgTerms.UnselectAllCells();

            }
        }
        private void searchTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            var fill = currentTermsInRoomForRecovery.Where(termin => termin.Patient.ToString().Contains(searchTextBox.Text) || termin.FromDateTime.ToString().Contains(searchTextBox.Text)
                        || termin.ToDateTime.ToString().Contains(searchTextBox.Text) || termin.Room.ToString().Contains(searchTextBox.Text) || termin.Status.ToString().Contains(searchTextBox.Text));
            dgTerms.ItemsSource = fill;

        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            searchTextBox.Text = "";
            dgTerms.ItemsSource = currentTermsInRoomForRecovery;
            searchTextBox.Visibility = Visibility.Hidden;
            btnSearch.Visibility = Visibility.Visible;
            btnClose.Visibility = Visibility.Hidden;
            btnAccommodate.IsEnabled = false;
            btnChange.IsEnabled = false;
            dgTerms.UnselectAllCells();
        }
    }
}
