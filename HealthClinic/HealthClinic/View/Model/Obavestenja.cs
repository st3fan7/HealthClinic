using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace HealthClinic.Model
{
    class Obavestenja : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }

        private string _obavestenje;
        private string _posiljalac;
        private string _datum;

        public string Obavestenje
        {
            get
            {
                return _obavestenje;
            }
            set
            {
                if (value != _obavestenje)
                {
                    _obavestenje = value;
                    OnPropertyChanged("Obavestenje");
                }
            }
        }

        public string Posiljalac
        {
            get
            {
                return _posiljalac;
            }
            set
            {
                if (value != _posiljalac)
                {
                    _posiljalac = value;
                    OnPropertyChanged("Posiljalac");
                }
            }
        }

        public string Datum
        {
            get
            {
                return _datum;
            }
            set
            {
                if (value != _datum)
                {
                    _datum = value;
                    OnPropertyChanged("Datum");
                }
            }
        }
    }
}
