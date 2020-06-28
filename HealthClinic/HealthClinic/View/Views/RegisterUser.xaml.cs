using Controller.UsersControlers;
using Model.AllActors;
using Model.PatientDoctor;
using System;
using System.Collections.Generic;
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

namespace HealthClinic.Views
{
    /// <summary>
    /// Interaction logic for RegisterUser.xaml
    /// </summary>
    public partial class RegisterUser : UserControl
    {
        private String _username;
        private String _password;
        private String _name;
        private String _lastname;
        private String _jmbg;
        private String _birthDate;
        private String _birthPlace;
        private String _address;
        private String _phoneNumber;
        private String _email;

        UserController userController;

        public RegisterUser()
        {
            InitializeComponent();
            this.DataContext = this;

            var app = Application.Current as App;
            userController = app.UserController;
        }

        public String RegisterUsername
        {
            get { return _username; }
            set { _username = value; }
        }

        public String RegisterPassword
        {
            get { return _password; }
            set { _password = value; }
        }

        public String RegisterNamee
        {
            get { return _name; }
            set { _name = value; }
        }

        public String RegisterLastname
        {
            get { return _lastname; }
            set { _lastname = value; }
        }

        public String RegisterJmbg
        {
            get { return _jmbg; }
            set { _jmbg = value; }
        }

        public String RegisterBirthDate
        {
            get { return _birthDate; }
            set { _birthDate = value; }
        }

        public String RegisterBirthPlace
        {
            get { return _birthPlace; }
            set { _birthPlace = value; }
        }

        public String RegisterAddress
        {
            get { return _address; }
            set { _address = value; }
        }

        public String RegisterPhoneNumber
        {
            get { return _phoneNumber; }
            set { _phoneNumber = value; }
        }

        public String RegisterEmail
        {
            get { return _email; }
            set { _email = value; }
        }

        private void RegistracijaBackButton_Click(object sender, RoutedEventArgs e)
        {
            RegisterUserGrid.Children.Clear();
            Window window = new MainWindow();
            //RegisterUserGrid = window;
        }

        private void RegistrujSeButton_Click(object sender, RoutedEventArgs e)
        {
            MedicalRecord medicalRecord = new MedicalRecord(1);

            String[] parts = this.RegisterAddress.Split(',');
            String countryString = parts[0];
            String cityString = parts[1];
            String addressString = parts[2];
            Country country = new Country(countryString);

            City city = new City(cityString, addressString, country);            

            Patient newPatient = new Patient(this.RegisterUsername,
                                          this.RegisterPassword,
                                          this.RegisterNamee,
                                          this.RegisterLastname,
                                          this.RegisterJmbg,
                                          DateTime.Parse(this.RegisterBirthDate),
                                          this.RegisterPhoneNumber,
                                          this.RegisterEmail,
                                          city,
                                          false,
                                          medicalRecord);
            

            userController.AddEntity(newPatient);

            RegisterUserGrid.Children.Clear();
            UserControl usc = new Login();
            RegisterUserGrid.Children.Add(usc);
        }
    }
}
