using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HealthClinic.View.ViewModel
{
    public class ViewTerm
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private int id;
        private string _date;
        private string _time;
        private string _room;
        private string _doctor;
        private string _patient;
        private string _status; // SLOBODAN ILI ZAUZET
        private string _task;
        private string patientJMBG;
        private bool _makeInDoctor;

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

        public bool MakeInDoctor
        {
            get
            {
                return _makeInDoctor;
            }
            set
            {
                if (value != _makeInDoctor)
                {
                    _makeInDoctor = value;
                    OnPropertyChanged("MakeInDoctor");
                }
            }
        }

        public string Task
        {
            get
            {
                return _task;
            }
            set
            {
                if (value != _task)
                {
                    _task = value;
                    OnPropertyChanged("Task");
                }
            }
        }

        public string Date
        {
            get
            {
                return _date;
            }
            set
            {
                if (value != _date)
                {
                    _date = value;
                    OnPropertyChanged("Date");
                }
            }
        }

        public string Time
        {
            get
            {
                return _time;
            }
            set
            {
                if (value != _time)
                {
                    _time = value;
                    OnPropertyChanged("Time");
                }
            }
        }

        public string Room
        {
            get
            {
                return _room;
            }
            set
            {
                if (value != _room)
                {
                    _room = value;
                    OnPropertyChanged("Room");
                }
            }
        }

        public string Doctor
        {
            get
            {
                return _doctor;
            }
            set
            {
                if (value != _doctor)
                {
                    _doctor = value;
                    OnPropertyChanged("Doctor");
                }
            }
        }

        public string Patient
        {
            get
            {
                return _patient;
            }
            set
            {
                if (value != _patient)
                {
                    _patient = value;
                    OnPropertyChanged("Patient");
                }
            }
        }

        public string Status
        {
            get
            {
                return _status;
            }
            set
            {
                if (value != _status)
                {
                    _status = value;
                    OnPropertyChanged("Status");
                }
            }
        }

    }
}
