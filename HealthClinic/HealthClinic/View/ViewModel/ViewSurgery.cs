using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HealthClinic.View.ViewModel
{
    public class ViewSurgery : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private bool urgency;
        private String shortDescription;
        private int id;
        private String room;
        private String doctor;
        public String patient;
        public String date;
        public String time;

        public bool Urgency
        {
            get { return urgency; }
            set
            {
                if (urgency != value)
                {
                    urgency = value;
                    OnPropertyChanged();
                }
            }
        }

        public String ShortDescription
        {
            get { return shortDescription; }
            set
            {
                if (shortDescription != value)
                {
                    shortDescription = value;
                    OnPropertyChanged();
                }
            }
        }

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

        public String Room
        {
            get { return room; }
            set
            {
                if (room != value)
                {
                    room = value;
                    OnPropertyChanged();
                }
            }
        }

        public String Doctor
        {
            get { return doctor; }
            set
            {
                if (doctor != value)
                {
                    doctor = value;
                    OnPropertyChanged();
                }
            }
        }

        public String Patient
        {
            get { return patient; }
            set
            {
                if (patient != value)
                {
                    patient = value;
                    OnPropertyChanged();
                }
            }
        }

        public String Date
        {
            get { return date; }
            set
            {
                if (date != value)
                {
                    date = value;
                    OnPropertyChanged();
                }
            }
        }

        public String Time
        {
            get { return time; }
            set
            {
                if (time != value)
                {
                    time = value;
                    OnPropertyChanged();
                }
            }
        }

    }
}
