using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthClinic.Entiteti
{
    public class Lek : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }

        private string _proizvodjac;
        private string _ime;
        private bool _validiran = false;
        private string _izvestaj;

        public ObservableCollection<string> Sastav
        {
            get;
            set;
        }


        public string Ime
        {
            get
            {
                return _ime;
            }
            set
            {
                if (value != _ime)
                {
                    _ime = value;
                    OnPropertyChanged("Ime");
                    
                }
            }
        }

        public string Proizvodjac
        {
            get
            {
                return _proizvodjac;
            }
            set
            {
                if (value != _proizvodjac)
                {
                    _proizvodjac = value;
                    OnPropertyChanged("Proizvodjac");                  
                }
            }
        }

        public string Izvestaj
        {
            get
            {
                return _izvestaj;
            }
            set
            {
                if (value != _izvestaj)
                {
                    _izvestaj = value;
                    OnPropertyChanged("Izvestaj");
                }
            }
        }

        public bool Validiran
        {
            get
            {
                return _validiran;
            }
            set
            {
                if (value != _validiran)
                {
                    _validiran = value;
                    OnPropertyChanged("Validiran");
                }
            }
        }

       
    }
}
