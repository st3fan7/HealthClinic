using Controller.UsersControlers;
using HealthClinic.View.Converter;
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
using System.Windows.Shapes;

namespace HealthClinic.View
{
    /// <summary>
    /// Interaction logic for ChangeWorkinTimeForDoctor.xaml
    /// </summary>
    public partial class ChangeWorkinTimeForDoctor : Window
    {
        private readonly WorkingTimeForDoctorController workingTimeForDoctorController;
        private readonly UserController userController;

        public static ObservableCollection<Doctor> DoctorsView { get; set; }

        public ChangeWorkinTimeForDoctor()
        {
            InitializeComponent();
            this.DataContext = this;
            TimePickerStartWorkingTime.SelectedTime = DateTime.Now.Date;
            TimePickerEndWorkingTime.SelectedTime = DateTime.Now.Date;


            var app = Application.Current as App;
            workingTimeForDoctorController = app.WorkingTimeForDoctorController;
            userController = app.UserController;

            DoctorsView = new ObservableCollection<Doctor>(userController.GetAllDoctors());
            
        }

        private void Button_Click_Potvrdi(object sender, RoutedEventArgs e)
        {
            Doctor selectedDoctor = (Doctor)ComboBoxDoctors.SelectedItem;
            String selectedDay = ComboBoxDaysOfTheWeek.SelectedItem.ToString().Substring(38);
            DateTime startWorkingTime = DateTime.Parse(TimePickerStartWorkingTime.SelectedTime.ToString());
            DateTime endWorkingTime = DateTime.Parse(TimePickerEndWorkingTime.SelectedTime.ToString());
            bool doctorDoesntWork = CheckBoxDoctorDontWork.IsChecked == true;

            WorkingTimeForDoctor workingTimeForDoctorForOneDay = null;

            if (selectedDay.Equals("Ponedeljak"))
            {
                workingTimeForDoctorForOneDay = GetWorkTimeForDoctorByDoctorAndDay(selectedDoctor, DayOfWeek.Monday); // iz cont
                ChangeWorkTime(workingTimeForDoctorForOneDay, doctorDoesntWork, startWorkingTime, endWorkingTime);               
            }
            else if (selectedDay.Equals("Utorak"))
            {
                workingTimeForDoctorForOneDay = GetWorkTimeForDoctorByDoctorAndDay(selectedDoctor, DayOfWeek.Tuesday); // iz cont
                ChangeWorkTime(workingTimeForDoctorForOneDay, doctorDoesntWork, startWorkingTime, endWorkingTime);
            }
            else if (selectedDay.Equals("Sreda"))
            {
                workingTimeForDoctorForOneDay = GetWorkTimeForDoctorByDoctorAndDay(selectedDoctor, DayOfWeek.Wednesday); // iz cont
                ChangeWorkTime(workingTimeForDoctorForOneDay, doctorDoesntWork, startWorkingTime, endWorkingTime);
            }
            else if (selectedDay.Equals("Četvrtak"))
            {
                workingTimeForDoctorForOneDay = GetWorkTimeForDoctorByDoctorAndDay(selectedDoctor, DayOfWeek.Thursday); // iz cont
                ChangeWorkTime(workingTimeForDoctorForOneDay, doctorDoesntWork, startWorkingTime, endWorkingTime);
            }
            else if (selectedDay.Equals("Petak"))
            {
                workingTimeForDoctorForOneDay = GetWorkTimeForDoctorByDoctorAndDay(selectedDoctor, DayOfWeek.Friday); // iz cont
                ChangeWorkTime(workingTimeForDoctorForOneDay, doctorDoesntWork, startWorkingTime, endWorkingTime);
            }
            else if (selectedDay.Equals("Subota"))
            {
                workingTimeForDoctorForOneDay = GetWorkTimeForDoctorByDoctorAndDay(selectedDoctor, DayOfWeek.Saturday); // iz cont
                ChangeWorkTime(workingTimeForDoctorForOneDay, doctorDoesntWork, startWorkingTime, endWorkingTime);
            }
            else if (selectedDay.Equals("Nedelja"))
            {
                workingTimeForDoctorForOneDay = GetWorkTimeForDoctorByDoctorAndDay(selectedDoctor, DayOfWeek.Sunday); // iz cont
                ChangeWorkTime(workingTimeForDoctorForOneDay, doctorDoesntWork, startWorkingTime, endWorkingTime);
            }           
        }

        private List<WorkingTimeForDoctor> GetWorkTimeForDoctor(Doctor doctor) // Napisi u servisu
        {
            List<WorkingTimeForDoctor> workingTimeForDoctor = new List<WorkingTimeForDoctor>();
            foreach (WorkingTimeForDoctor workingTime in workingTimeForDoctorController.GetAllEntities())
                if (workingTime.Doctor.GetId() == doctor.GetId())
                    workingTimeForDoctor.Add(workingTime);
            return workingTimeForDoctor;
        }

        private WorkingTimeForDoctor GetWorkTimeForDoctorByDay(DayOfWeek day) // Napisi u servisu
        {
            foreach (WorkingTimeForDoctor workingTime in workingTimeForDoctorController.GetAllEntities())
                if (workingTime.Day.Equals(day))
                    return workingTime;
            return null;
        }

        private WorkingTimeForDoctor GetWorkTimeForDoctorByDoctorAndDay(Doctor doctor, DayOfWeek day) // Napisi u servisu
        {
            foreach (WorkingTimeForDoctor workingTime in workingTimeForDoctorController.GetAllEntities())
                if (workingTime.Doctor.Id == doctor.Id && workingTime.Day.ToString().Equals(day.ToString()))
                    return workingTime;
            return null;
        }

        private void ChangeWorkTime(WorkingTimeForDoctor workingTimeForDoctorForOneDay,bool doctorDoesntWork,
            DateTime startWorkingTime, DateTime endWorkingTime)
        {
            if (doctorDoesntWork)
            {
                DoctorDoesntWork(workingTimeForDoctorForOneDay);
                return;
            }
            workingTimeForDoctorForOneDay.DoesWork = true;
            workingTimeForDoctorForOneDay.FromDateTime = startWorkingTime;
            workingTimeForDoctorForOneDay.ToDateTime = endWorkingTime;
            AddToDataGridView(workingTimeForDoctorForOneDay);
            workingTimeForDoctorController.UpdateEntity(workingTimeForDoctorForOneDay);
            this.Close();
            MessageBox.Show("Uspešno ste promenili radno vreme lekara", "Obaveštenje", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void DoctorDoesntWork(WorkingTimeForDoctor workingTimeForDoctorForOneDay) 
        {
            workingTimeForDoctorForOneDay.DoesWork = false;
            AddToDataGridView(workingTimeForDoctorForOneDay);
            workingTimeForDoctorController.UpdateEntity(workingTimeForDoctorForOneDay);
            this.Close();
            MessageBox.Show("Uspešno ste promenili radno vreme lekara", "Obaveštenje", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void AddToDataGridView(WorkingTimeForDoctor workingTime)
        {
            foreach (ViewWorkingTimeForDoctor workingTimeView in WorkingTimeForDoctors.WorkingTimeForDoctorView)
                if (workingTimeView.Id == workingTime.GetId())
                    if (workingTime.DoesWork == false)
                        workingTimeView.WorkingTime = "Ne radi";
                    else
                        workingTimeView.WorkingTime = workingTime.FromDateTime.ToString("HH:mm") + " - " + workingTime.ToDateTime.ToString("HH:mm");                    
        }

        private void Button_Click_Odustani(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
