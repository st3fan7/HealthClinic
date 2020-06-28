
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

namespace HealthClinic.Layouts
{
    /// <summary>
    /// Interaction logic for ChangeUserProfile.xaml
    /// </summary>
    public partial class ChangeUserProfile : UserControl
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

        public ChangeUserProfile()
        {
            InitializeComponent();

            this.DataContext = this;

            var app = Application.Current as App;
            userController = app.UserController;
            
            this.ChangeUsername = Views.Login.currentUser.UserName;
            this.ChangePassword = Views.Login.currentUser.Password;
            this.ChangeName = Views.Login.currentUser.Name;
            this.ChangeLastname = Views.Login.currentUser.Surname;
            this.ChangeJmbg = Views.Login.currentUser.Jmbg;
            String[] parts = Views.Login.currentUser.DateOfBirth.ToString().Split(' ');
            this.ChangeBirthDate = parts[0];
            this.ChangeBirthPlace = Views.Login.currentUser.City.Country.Name + "," + Views.Login.currentUser.City.Name + "," + Views.Login.currentUser.City.Adress;
            this.ChangeAddress = Views.Login.currentUser.City.Country.Name + "," + Views.Login.currentUser.City.Name + "," + Views.Login.currentUser.City.Adress;
            this.ChangePhoneNumber = Views.Login.currentUser.ContactNumber;
            this.ChangeEmail = Views.Login.currentUser.EMail;
        }


        public String ChangeUsername
        {
            get { return _username; }
            set { _username = value; }
        }

        public String ChangePassword
        {
            get { return _password; }
            set { _password = value; }
        }

        public String ChangeName
        {
            get { return _name; }
            set { _name = value; }
        }

        public String ChangeLastname
        {
            get { return _lastname; }
            set { _lastname = value; }
        }

        public String ChangeJmbg
        {
            get { return _jmbg; }
            set { _jmbg = value; }
        }

        public String ChangeBirthDate
        {
            get { return _birthDate; }
            set { _birthDate = value; }
        }

        public String ChangeBirthPlace
        {
            get { return _birthPlace; }
            set { _birthPlace = value; }
        }

        public String ChangeAddress
        {
            get { return _address; }
            set { _address = value; }
        }

        public String ChangePhoneNumber
        {
            get { return _phoneNumber; }
            set { _phoneNumber = value; }
        }

        public String ChangeEmail
        {
            get { return _email; }
            set { _email = value; }
        }

        private void SacuvajIzmeneButton_Click(object sender, RoutedEventArgs e)
        {
            MedicalRecord medicalRecord = new MedicalRecord();

            Console.WriteLine("ADRESA-" + this.ChangeAddress);
            String[] parts = this.ChangeAddress.Split(',');
            String countryString = parts[0];
            String cityString = parts[1];
            String addressString = parts[2];
            Country country = new Country(countryString);

            City city = new City(cityString, addressString, country);                      

            Views.Login.currentUser.UserName = this.ChangeUsername;
            Views.Login.currentUser.Password = this.ChangePassword;
            Views.Login.currentUser.Name = this.ChangeName;
            Views.Login.currentUser.Surname = this.ChangeLastname;
            Views.Login.currentUser.Jmbg = this.ChangeJmbg;
            Views.Login.currentUser.DateOfBirth = DateTime.Parse(this.ChangeBirthDate);
            Views.Login.currentUser.City = city;
            Views.Login.currentUser.ContactNumber = this.ChangePhoneNumber;
            Views.Login.currentUser.EMail = this.ChangeEmail;            

            userController.UpdateEntity(Views.Login.currentUser);

            ChangeProfileGrid.Children.Clear();
            UserControl usc = new Layouts.UserProfile();
            ChangeProfileGrid.Children.Add(usc);

        }
    }
}
