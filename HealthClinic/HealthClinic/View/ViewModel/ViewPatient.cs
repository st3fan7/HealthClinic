using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HealthClinic.View.ViewModel
{
    public class ViewPatient : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        private int id;
        private String username;
        private String password;
        private String name;
        private String surname;
        private String jmbg;
        private String dateOfBirth;
        private String contactNumber;
        private String emailAddress;
        private String city;
        private bool guestAccount;
        private String medicalRecord;

        public int Id
        {
            get { return id; }
            set
            {
                if (id != value)
                {
                    id = value;
                    OnPropertyChanged();
                }
            }
        }

        public String Username
        {
            get { return username; }
            set
            {
                if (username != value)
                {
                    username = value;
                    OnPropertyChanged();
                }
            }
        }

        public String Password
        {
            get { return password; }
            set
            {
                if (password != value)
                {
                    password = value;
                    OnPropertyChanged();
                }
            }
        }

        public String Name
        {
            get { return name; }
            set
            {
                if (name != value)
                {
                    name = value;
                    OnPropertyChanged();
                }
            }
        }

        public String Surname
        {
            get { return surname; }
            set
            {
                if (surname != value)
                {
                    surname = value;
                    OnPropertyChanged();
                }
            }
        }

        public String Jmbg
        {
            get { return jmbg; }
            set
            {
                if (jmbg != value)
                {
                    jmbg = value;
                    OnPropertyChanged();
                }
            }
        }

        public String DateOfBirth
        {
            get { return dateOfBirth; }
            set
            {
                if (dateOfBirth != value)
                {
                    dateOfBirth = value;
                    OnPropertyChanged();
                }
            }
        }

        public String ContactNumber
        {
            get { return contactNumber; }
            set
            {
                if (contactNumber != value)
                {
                    contactNumber = value;
                    OnPropertyChanged();
                }
            }
        }

        public String EmailAddress
        {
            get { return emailAddress; }
            set
            {
                if (emailAddress != value)
                {
                    emailAddress = value;
                    OnPropertyChanged();
                }
            }
        }

        public String City
        {
            get { return city; }
            set
            {
                if (city != value)
                {
                    city = value;
                    OnPropertyChanged();
                }
            }
        }

        public bool GuestAccount
        {
            get { return guestAccount; }
            set
            {
                if (guestAccount != value)
                {
                    guestAccount = value;
                    OnPropertyChanged();
                }
            }
        }

        public String MedicalRecord
        {
            get { return medicalRecord; }
            set
            {
                if (medicalRecord != value)
                {
                    medicalRecord = value;
                    OnPropertyChanged();
                }
            }
        }
    }
}
