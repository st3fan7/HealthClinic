using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HealthClinic.View.ViewModel
{
    public class ViewWorkingTimeForDoctor : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private int id;
        private String doctor;
        private String monday;
        private String tuesday;
        private String wednesday;
        private String thursday;
        private String friday;
        private String saturday;
        private String sunday;

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
        public String Monday
        {
            get { return monday; }
            set
            {
                if (monday != value)
                {
                    monday = value;
                    OnPropertyChanged();
                }
            }
        }
        public String Tuesday
        {
            get { return tuesday; }
            set
            {
                if (tuesday != value)
                {
                    tuesday = value;
                    OnPropertyChanged();
                }
            }
        }
        public String Wednesday
        {
            get { return wednesday; }
            set
            {
                if (wednesday != value)
                {
                    wednesday = value;
                    OnPropertyChanged();
                }
            }
        }
        public String Thursday
        {
            get { return thursday; }
            set
            {
                if (thursday != value)
                {
                    thursday = value;
                    OnPropertyChanged();
                }
            }
        }
        public String Friday
        {
            get { return friday; }
            set
            {
                if (friday != value)
                {
                    friday = value;
                    OnPropertyChanged();
                }
            }
        }
        public String Saturday
        {
            get { return saturday; }
            set
            {
                if (saturday != value)
                {
                    saturday = value;
                    OnPropertyChanged();
                }
            }
        }
        public String Sunday
        {
            get { return sunday; }
            set
            {
                if (sunday != value)
                {
                    sunday = value;
                    OnPropertyChanged();
                }
            }
        }
    }
}
