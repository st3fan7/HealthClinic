using Controller;
using Controller.UsersControlers;
using HealthClinic.View.Dialogues;
using HealthClinic.View.ViewModel;
using Model.AllActors;
using Model.PatientDoctor;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Interaction logic for GuestAcconut.xaml
    /// </summary>
    public partial class GuestAccount : UserControl
    {
        //Termin terminKojiSeZakazuje = new Termin();
        //private static List<String> doctorsFromCmbx = new List<String>();
        ObservableCollection<User> doctorsFromCmbx = new ObservableCollection<User>();
        ViewTerm termForSchedule = new ViewTerm();

        private readonly UserController userController;
        public GuestAccount(string selectedDate, string enteredData, ViewTerm term)
        {

            InitializeComponent();
            textWarning.Visibility = textWarningHidden;
            textWarning2.Visibility = Visibility.Hidden;
            textWarning3.Visibility = Visibility.Hidden;
            textWarning4.Visibility = Visibility.Hidden;
            textWarning5.Visibility = Visibility.Hidden;
            textWarning6.Visibility = Visibility.Hidden;
            datePickerSchedule.DisplayDateEnd = DateTime.Now;
            //terminKojiSeZakazuje = term;
            dateLabel.Content = selectedDate;
            inputLabel.Content = enteredData;
            doctorsFromCmbx = MedicalExaminationRooms.DoctorsForMedicalExamination;

            termForSchedule = term;

            var app = Application.Current as App;
            userController = app.UserController;
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            (this.Parent as Panel).Children.Remove(this);
        }

        private void homeBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridGuestAccount.Children.Clear();
            UserControl usc = new Home();
            GridGuestAccount.Children.Add(usc);
        }

        private void scheduleBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridGuestAccount.Children.Clear();
            UserControl usc = new Schedule();
            GridGuestAccount.Children.Add(usc);
        }

        private void patienstBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridGuestAccount.Children.Clear();
            UserControl usc = new PatientView();
            GridGuestAccount.Children.Add(usc);
        }

        private void settingsBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridGuestAccount.Children.Clear();
            UserControl usc = new Settings();
            GridGuestAccount.Children.Add(usc);
        }

        private void reportBtn_Click(object sender, RoutedEventArgs e)
        {
            GridGuestAccount.Children.Clear();
            UserControl usc = new Report();
            GridGuestAccount.Children.Add(usc);
        }

        private void createBtn_Click(object sender, RoutedEventArgs e)
        {
            var bc = new BrushConverter();
            var thic = new ThicknessConverter();

            if (!nameInput.Text.Equals("") && !surnameInput.Text.Equals("") && !idInput.Text.Equals("") && !datePickerSchedule.Text.Equals("") && !mobileInput.Text.Equals(""))
            {
                String nameRegex = @"[A-Z]+[a-z]+";
                String mobileRegex = @"([+][0-9]{3})?[0-9]{2,3}/[0-9]{3}-[0-9]{3,4}";
                String idRegex = @"[0-9]{13}";
                Regex rg = new Regex(nameRegex);
                Regex rg2 = new Regex(mobileRegex);
                Regex rg3 = new Regex(idRegex);

                if (!rg.Match(nameInput.Text).Success)
                {
                    textWarning2.Visibility = Visibility.Visible;
                    nameInput.BorderBrush = (Brush)bc.ConvertFrom("#FF761616");
                    nameInput.BorderThickness = (Thickness)thic.ConvertFrom("3");
                    createBtn.BorderBrush = (Brush)bc.ConvertFrom("#FF761616");
                    createBtn.BorderThickness = (Thickness)thic.ConvertFrom("3");
                    return;
                }

                if (!rg.Match(surnameInput.Text).Success)
                {
                    textWarning2.Visibility = Visibility.Visible;
                    surnameInput.BorderBrush = (Brush)bc.ConvertFrom("#FF761616");
                    surnameInput.BorderThickness = (Thickness)thic.ConvertFrom("3");
                    createBtn.BorderBrush = (Brush)bc.ConvertFrom("#FF761616");
                    createBtn.BorderThickness = (Thickness)thic.ConvertFrom("3");
                    return;
                }

                if (!rg3.Match(idInput.Text).Success)
                {
                    textWarning4.Visibility = Visibility.Visible;
                    idInput.BorderBrush = (Brush)bc.ConvertFrom("#FF761616");
                    idInput.BorderThickness = (Thickness)thic.ConvertFrom("3");
                    createBtn.BorderBrush = (Brush)bc.ConvertFrom("#FF761616");
                    createBtn.BorderThickness = (Thickness)thic.ConvertFrom("3");
                    return;
                }

                if (!rg2.Match(mobileInput.Text).Success)
                {
                    textWarning3.Visibility = Visibility.Visible;
                    mobileInput.BorderBrush = (Brush)bc.ConvertFrom("#FF761616");
                    mobileInput.BorderThickness = (Thickness)thic.ConvertFrom("3");
                    createBtn.BorderBrush = (Brush)bc.ConvertFrom("#FF761616");
                    createBtn.BorderThickness = (Thickness)thic.ConvertFrom("3");
                    return;
                }


                textWarning6.Visibility = Visibility.Hidden;
                textWarning5.Visibility = Visibility.Hidden;
                textWarning4.Visibility = Visibility.Hidden;
                textWarning3.Visibility = Visibility.Hidden;
                textWarning2.Visibility = Visibility.Hidden;
                textWarning.Visibility = Visibility.Hidden;

                datePickerSchedule.BorderBrush = Brushes.Black;
                datePickerSchedule.BorderThickness = (Thickness)thic.ConvertFrom("1");
                idInput.BorderBrush = Brushes.Black;
                idInput.BorderThickness = (Thickness)thic.ConvertFrom("1");
                mobileInput.BorderBrush = Brushes.Black;
                mobileInput.BorderThickness = (Thickness)thic.ConvertFrom("1");
                datePickerSchedule.BorderBrush = Brushes.Black;
                datePickerSchedule.BorderThickness = (Thickness)thic.ConvertFrom("1");
                nameInput.BorderBrush = Brushes.Black;
                nameInput.BorderThickness = (Thickness)thic.ConvertFrom("1");
                surnameInput.BorderBrush = Brushes.Black;
                surnameInput.BorderThickness = (Thickness)thic.ConvertFrom("1");
                createBtn.BorderBrush = Brushes.Black;
                createBtn.BorderThickness = (Thickness)thic.ConvertFrom("1");
                

                Patient patient = new Patient();
                patient.UserName = "";
                patient.Password = "";
                patient.Name = nameInput.Text;
                patient.Surname = surnameInput.Text;

                Patient patientForCheck = (Patient)userController.GetUserByJMBG(idInput.Text);
                if (patientForCheck != null)
                {
                    textWarning6.Visibility = Visibility.Visible;
                    idInput.BorderBrush = (Brush)bc.ConvertFrom("#FF761616");
                    idInput.BorderThickness = (Thickness)thic.ConvertFrom("3");
                    createBtn.BorderBrush = (Brush)bc.ConvertFrom("#FF761616");
                    createBtn.BorderThickness = (Thickness)thic.ConvertFrom("3");
                    return;
                }

                patient.Jmbg = idInput.Text;
                String[] dateParts = datePickerSchedule.Text.Split(' ');
                patient.DateOfBirth = DateTime.Parse(dateParts[0]);

                patient.ContactNumber = mobileInput.Text;
                patient.EMail = "";

                patient.City = new City("", "", new Country(""));
                patient.GuestAccount = true;
                patient.MedicalRecord = new MedicalRecord();

                userController.AddEntity(patient);

                UserControl usc = new ScheduleTerm(dateLabel.Content.ToString(), termForSchedule, patient);
                (this.Parent as Panel).Children.Add(usc);
            }
            else
            {
               
                textWarning.Visibility = textWarningVisible;

                if (datePickerSchedule.Text.Equals(""))
                {
                    datePickerSchedule.BorderBrush = (Brush)bc.ConvertFrom("#FF761616");
                    datePickerSchedule.BorderThickness = (Thickness)thic.ConvertFrom("3");
                    createBtn.BorderBrush = (Brush)bc.ConvertFrom("#FF761616");
                    createBtn.BorderThickness = (Thickness)thic.ConvertFrom("3");
                }

                if (nameInput.Text.Equals(""))
                {
                    nameInput.BorderBrush = (Brush)bc.ConvertFrom("#FF761616");
                    nameInput.BorderThickness = (Thickness)thic.ConvertFrom("3");
                    createBtn.BorderBrush = (Brush)bc.ConvertFrom("#FF761616");
                    createBtn.BorderThickness = (Thickness)thic.ConvertFrom("3");
                }

                if (surnameInput.Text.Equals(""))
                {
                    surnameInput.BorderBrush = (Brush)bc.ConvertFrom("#FF761616");
                    surnameInput.BorderThickness = (Thickness)thic.ConvertFrom("3");
                    createBtn.BorderBrush = (Brush)bc.ConvertFrom("#FF761616");
                    createBtn.BorderThickness = (Thickness)thic.ConvertFrom("3");
                }

                if (idInput.Text.Equals(""))
                {
                    idInput.BorderBrush = (Brush)bc.ConvertFrom("#FF761616");
                    idInput.BorderThickness = (Thickness)thic.ConvertFrom("3");
                    createBtn.BorderBrush = (Brush)bc.ConvertFrom("#FF761616");
                    createBtn.BorderThickness = (Thickness)thic.ConvertFrom("3");
                }

                if (mobileInput.Text.Equals(""))
                {
                    mobileInput.BorderBrush = (Brush)bc.ConvertFrom("#FF761616");
                    mobileInput.BorderThickness = (Thickness)thic.ConvertFrom("3");
                    createBtn.BorderBrush = (Brush)bc.ConvertFrom("#FF761616");
                    createBtn.BorderThickness = (Thickness)thic.ConvertFrom("3");
                }
            }


        }

        private Visibility textWarningHidden
        {
            get { return Visibility.Hidden; }
        }
        private Visibility textWarningVisible
        {
            get { return Visibility.Visible; }
        }

        private void nameInput_TextChanged(object sender, TextChangedEventArgs e)
        {
            textWarning6.Visibility = Visibility.Hidden;
            textWarning5.Visibility = Visibility.Hidden;
            textWarning4.Visibility = Visibility.Hidden;
            textWarning2.Visibility = Visibility.Hidden;
            textWarning3.Visibility = Visibility.Hidden;
            if (!nameInput.Text.Equals(""))
            {
                textWarning.Visibility = textWarningHidden;
                nameInput.BorderBrush = Brushes.Black;
                var thic = new ThicknessConverter();
                nameInput.BorderThickness = (Thickness)thic.ConvertFrom("1");
                createBtn.BorderBrush = Brushes.Black;
                createBtn.BorderThickness = (Thickness)thic.ConvertFrom("1");
            }

        }

        private void surnameInput_TextChanged(object sender, TextChangedEventArgs e)
        {
            textWarning6.Visibility = Visibility.Hidden;
            textWarning5.Visibility = Visibility.Hidden;
            textWarning4.Visibility = Visibility.Hidden;
            textWarning2.Visibility = Visibility.Hidden;
            textWarning3.Visibility = Visibility.Hidden;
            if (!surnameInput.Text.Equals(""))
            {

                textWarning.Visibility = textWarningHidden;

                surnameInput.BorderBrush = Brushes.Black;
                var thic = new ThicknessConverter();
                surnameInput.BorderThickness = (Thickness)thic.ConvertFrom("1");
                createBtn.BorderBrush = Brushes.Black;
                createBtn.BorderThickness = (Thickness)thic.ConvertFrom("1");
            }

        }

        private void idInput_TextChanged(object sender, TextChangedEventArgs e)
        {
            textWarning6.Visibility = Visibility.Hidden;
            textWarning5.Visibility = Visibility.Hidden;
            textWarning4.Visibility = Visibility.Hidden;
            textWarning2.Visibility = Visibility.Hidden;
            textWarning3.Visibility = Visibility.Hidden;
            if (!idInput.Text.Equals(""))
            {
                textWarning.Visibility = textWarningHidden;
                idInput.BorderBrush = Brushes.Black;
                var thic = new ThicknessConverter();
                idInput.BorderThickness = (Thickness)thic.ConvertFrom("1");
                createBtn.BorderBrush = Brushes.Black;
                createBtn.BorderThickness = (Thickness)thic.ConvertFrom("1");
            }

        }

        private void mobileInput_TextChanged(object sender, TextChangedEventArgs e)
        {
            textWarning6.Visibility = Visibility.Hidden;
            textWarning5.Visibility = Visibility.Hidden;
            textWarning4.Visibility = Visibility.Hidden;
            textWarning2.Visibility = Visibility.Hidden;
            textWarning3.Visibility = Visibility.Hidden;
            if (!mobileInput.Text.Equals("")) 
            {
                textWarning.Visibility = textWarningHidden;
                mobileInput.BorderBrush = Brushes.Black;
                var thic = new ThicknessConverter();
                mobileInput.BorderThickness = (Thickness)thic.ConvertFrom("1");
                createBtn.BorderBrush = Brushes.Black;
                createBtn.BorderThickness = (Thickness)thic.ConvertFrom("1");
            }
        }

        private void datePickerSchedule_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            textWarning6.Visibility = Visibility.Hidden;
            textWarning5.Visibility = Visibility.Hidden;
            textWarning4.Visibility = Visibility.Hidden;
            textWarning2.Visibility = Visibility.Hidden;
            textWarning3.Visibility = Visibility.Hidden;

            if (!datePickerSchedule.Text.Equals(""))
            {
                textWarning.Visibility = Visibility.Hidden;
                datePickerSchedule.BorderBrush = Brushes.Black;
                var thic = new ThicknessConverter();
                datePickerSchedule.BorderThickness = (Thickness)thic.ConvertFrom("1");
                createBtn.BorderBrush = Brushes.Black;
                createBtn.BorderThickness = (Thickness)thic.ConvertFrom("1");
            }
        }
    }
}
