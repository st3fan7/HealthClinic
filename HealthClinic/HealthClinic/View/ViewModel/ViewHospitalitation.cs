using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HealthClinic.View.ViewModel
{
    public class ViewHospitalitation
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private int id;
        private string room;
        private string patient;
        private string doctor;
        private string bedForLaying;
        private string fromDateTime;
        private string toDateTime;
        private string status; // SLOBODAN ILI ZAUZET
        private string patientJMBG;

        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                if (value != id)
                {
                    id = value;
                    OnPropertyChanged("Id");
                }
            }
        }

        public string Room
        {
            get
            {
                return room;
            }
            set
            {
                if (value != room)
                {
                    room = value;
                    OnPropertyChanged("Room");
                }
            }
        }

        public string Patient
        {
            get
            {
                return patient;
            }
            set
            {
                if (value != patient)
                {
                    patient = value;
                    OnPropertyChanged("Patient");
                }
            }
        }

        public string Doctor
        {
            get
            {
                return doctor;
            }
            set
            {
                if (value != doctor)
                {
                    doctor = value;
                    OnPropertyChanged("Doctor");
                }
            }
        }

        public string BedForLaying
        {
            get
            {
                return bedForLaying;
            }
            set
            {
                if (value != bedForLaying)
                {
                    bedForLaying = value;
                    OnPropertyChanged("BedForLaying");
                }
            }
        }

        public string FromDateTime
        {
            get
            {
                return fromDateTime;
            }
            set
            {
                if (value != fromDateTime)
                {
                    fromDateTime = value;
                    OnPropertyChanged("FromDateTime");
                }
            }
        }

        public string ToDateTime
        {
            get
            {
                return toDateTime;
            }
            set
            {
                if (value != toDateTime)
                {
                    toDateTime = value;
                    OnPropertyChanged("ToDateTime");
                }
            }
        }

        public string Status
        {
            get
            {
                return status;
            }
            set
            {
                if (value != status)
                {
                    status = value;
                    OnPropertyChanged("Status");
                }
            }
        }

        public string PatientJMBG
        {
            get
            {
                return patientJMBG;
            }
            set
            {
                if (value != patientJMBG)
                {
                    patientJMBG = value;
                    OnPropertyChanged("PatientJMBG");
                }
            }
        }

    }
}
