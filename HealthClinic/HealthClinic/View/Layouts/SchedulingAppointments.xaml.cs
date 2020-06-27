using Controller.ExaminationSurgeryControlers;
using Controller.UsersControlers;
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

namespace HealthClinic.Layouts
{
    /// <summary>
    /// Interaction logic for SchedulingAppointments.xaml
    /// </summary>
    public partial class SchedulingAppointments : UserControl
    {
        private int colNum = 0;
        public ObservableCollection<Model.Term> Terms { get; set; }
        public ObservableCollection<String> doctors { get; set; }
        List<Doctor> doctorsFromFile = new List<Doctor>();
        MedicalExaminationController medicalExaminationController;
        WorkingTimeForDoctorController workingTimeForDoctorController;
        public static Doctor selectedDoctor;

        //private readonly IController<User, int> userController;


        public SchedulingAppointments()
        {
            InitializeComponent();
            this.DataContext = this;
            Terms = new ObservableCollection<Model.Term>();
            Doctors = new ObservableCollection<String>();

            var app = Application.Current as App;
            UserController userController = app.UserController;
            medicalExaminationController = app.MedicalExaminationController;
            workingTimeForDoctorController = app.WorkingTimeForDoctorController;

            doctorsFromFile = userController.GetAllDoctors();
            foreach (Doctor d in doctorsFromFile)
            {
                Doctors.Add(d.Id + " Dr " + d.Name + " " + d.Surname);
            }

            //Terms.Add(new Model.Term() { Termin = "09:30-10:00" });
            //Terms.Add(new Model.Term() { Termin = "10:30-11:00" });
            //Terms.Add(new Model.Term() { Termin = "12:30-13:00" });
        }


        public ObservableCollection<String> Doctors
        {
            get { return doctors; }
            set
            {
                if (doctors != value)
                {
                    doctors = value;
                    OnPropertyChanged();
                }
            }
        }


        private void generateColumns(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            colNum++;
            if (colNum == 3)
                e.Column.Width = new DataGridLength(1, DataGridLengthUnitType.Star);
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void findDoctor()
        {
            if (NewMedicalExaminationComboBox.SelectedItem == null)
                return;
            String doctorString = NewMedicalExaminationComboBox.SelectedItem.ToString();
            String[] parts = doctorString.Split(' ');
            String doctorsId = parts[0];

            foreach (Doctor doctor in doctorsFromFile)
                if (doctor.Id.ToString() == doctorsId)
                {
                    selectedDoctor = doctor;
                }
            Console.WriteLine(selectedDoctor.Name);
        }

        private DateTime findStartDateTime()
        {
            var cellInfo = NewMedicalExaminationTable.SelectedCells[0];
            var fullTerm = (cellInfo.Column.GetCellContent(cellInfo.Item) as TextBlock).Text;
            String[] parts = fullTerm.Split('-');
            String startTime = parts[0];
            String startDate = NewMedicalExaminationDatePicker.SelectedDate.ToString();
            String[] dateParts = startDate.Split(' ');
            startDate = dateParts[0];
            Console.WriteLine(startDate + " " + startTime);
            DateTime startDateTime = DateTime.Parse(startDate + " " + startTime);
            return startDateTime;
        }

        private DateTime findEndDateTime()
        {
            var cellInfo = NewMedicalExaminationTable.SelectedCells[0];
            var fullTerm = (cellInfo.Column.GetCellContent(cellInfo.Item) as TextBlock).Text;
            String[] parts = fullTerm.Split('-');
            String endTime = parts[1];
            String endDate = NewMedicalExaminationDatePicker.SelectedDate.ToString();
            String[] dateParts = endDate.Split(' ');
            endDate = dateParts[0];
            DateTime endDateTime = DateTime.Parse(endDate + " " + endTime);
            return endDateTime;
        }

        private void OKButton_Click(object sender, RoutedEventArgs e)
        {

            MedicalExamination medicalExamination = new MedicalExamination(false, "/", new Room(1), selectedDoctor, new Patient(1), findStartDateTime(), findEndDateTime());
            medicalExaminationController.AddEntity(medicalExamination);

            UserControl MyAppointmentsUSC = new Layouts.MyAppointments();
            SchedulingAppointmentGrid.Children.Clear();
            SchedulingAppointmentGrid.Children.Add(MyAppointmentsUSC);
        }

        private void NewMedicalExaminationComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //WorkingTimeForDoctor workingTimeForSelectedDoctor = findWorkingTimeForSelectedDoctor(selectedDoctor);
            findDoctor();
            List<String> workingTermsForDoctor = findWorkingTermsForDoctor();
            foreach (String s in workingTermsForDoctor)
            {
                Terms.Add(new Model.Term() { Termin = s });
                Console.WriteLine("***" + s + "***");
            }
        }

        private List<String> findWorkingTermsForDoctor()
        {
            WorkingTimeForDoctor workingTimeForSelectedDoctor = findWorkingTimeForSelectedDoctor(selectedDoctor);

            // pocetno radno vreme 12.12.2020. 09:00:00 AM
            String[] startParts = workingTimeForSelectedDoctor.FromDateTime.ToString().Split(' ');
            String[] startTimeParts = startParts[1].Split(':'); //podeli 09:00:00 po ":"
            int start;
            if (startParts[2] == "PM" || (startParts[1] + " " + startParts[2]) == "12:00:00 AM")
            {
                start = int.Parse(startTimeParts[0]) + 12;
            }
            else
            {
                start = int.Parse(startTimeParts[0]);
            }

            String[] endParts = workingTimeForSelectedDoctor.ToDateTime.ToString().Split(' ');
            String[] endTimeParts = endParts[1].Split(':');
            int end;
            if (endParts[2] == "PM" || (endParts[1] + " " + endParts[2]) == "12:00:00 AM")
            {
                end = int.Parse(endTimeParts[0]) + 12;
            }
            else
            {
                end = int.Parse(endTimeParts[0]);
            }

            List<String> workingTermsForDoctor = new List<String>();
            if (start > end)
                end = end + 24;
            for(int i = start; i<end; i++)
            {
                if (i == 24)
                {
                    end = end - 24;
                    for (int m = 0; m < end; m++)
                    {
                        int x = m + 1;
                        workingTermsForDoctor.Add(m + ":00:00" + "-" + x + ":00:00");
                    }
                    break;
                }
                int n = i + 1;
                workingTermsForDoctor.Add(i + ":00:00" + "-" + n + ":00:00");
                if(i == 23)
                {
                    end = end - 24;
                    for (int m = 0; m < end; m++)
                    {
                        int x = m + 1;
                        workingTermsForDoctor.Add(m + ":00:00" + "-" + x + ":00:00");
                    }
                    break;
                }
            }
            return workingTermsForDoctor;
        }

        private WorkingTimeForDoctor findWorkingTimeForSelectedDoctor(Doctor selectedDoctor)
        {
            DateTime date = DateTime.Parse(NewMedicalExaminationDatePicker.SelectedDate.ToString());
            DayOfWeek day = date.DayOfWeek;
            return workingTimeForDoctorController.GetWorkTimeForDoctorByDoctorAndDay(selectedDoctor, day);
        }

    }
}
