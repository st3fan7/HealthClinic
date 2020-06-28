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
    /// Interaction logic for UserProfile.xaml
    /// </summary>
    public partial class UserProfile : UserControl
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

        public UserProfile()
        {
            InitializeComponent();
            this.DataContext = this;

            this.ProfileUsername = Views.Login.currentUser.UserName;
            this.ProfilePassword = Views.Login.currentUser.Password;
            this.ProfileName = Views.Login.currentUser.Name;
            this.ProfileLastname = Views.Login.currentUser.Surname;
            this.ProfileJmbg = Views.Login.currentUser.Jmbg;
            String[] parts = Views.Login.currentUser.DateOfBirth.ToString().Split(' ');
            this.ProfileBirthDate = parts[0];
            this.ProfileBirthPlace = Views.Login.currentUser.City.Name + " " + Views.Login.currentUser.City.Adress + " " + Views.Login.currentUser.City.Country.Name;
            this.ProfileAddress = Views.Login.currentUser.City.Name + " " + Views.Login.currentUser.City.Adress + " " + Views.Login.currentUser.City.Country.Name;
            this.ProfilePhoneNumber = Views.Login.currentUser.ContactNumber;
            this.ProfileEmail = Views.Login.currentUser.EMail;
        }

        private void IzmenaNalogaButton_Click(object sender, RoutedEventArgs e)
        {
            UserProfileGrid.Children.Clear();
            UserControl usc = new Layouts.ChangeUserProfile();
            UserProfileGrid.Children.Add(usc);
        }

        public String ProfileUsername
        {
            get { return _username; }
            set { _username = value; }
        }

        public String ProfilePassword
        {
            get { return _password; }
            set { _password = value; }
        }

        public String ProfileName
        {
            get { return _name; }
            set { _name = value; }
        }

        public String ProfileLastname
        {
            get { return _lastname; }
            set { _lastname = value; }
        }

        public String ProfileJmbg
        {
            get { return _jmbg; }
            set { _jmbg = value; }
        }

        public String ProfileBirthDate
        {
            get { return _birthDate; }
            set { _birthDate = value; }
        }

        public String ProfileBirthPlace
        {
            get { return _birthPlace; }
            set { _birthPlace = value; }
        }

        public String ProfileAddress
        {
            get { return _address; }
            set { _address = value; }
        }

        public String ProfilePhoneNumber
        {
            get { return _phoneNumber; }
            set { _phoneNumber = value; }
        }

        public String ProfileEmail
        {
            get { return _email; }
            set { _email = value; }
        }

    }
}
