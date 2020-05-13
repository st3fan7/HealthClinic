using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace HealthClinic.Model
{
    class Oporavak : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }

        private string _prijem;
        private string _odjava;
        private string _sala;
        private string _pacijent;
        private string _status; // SLOBODAN ILI ZAUZET

        public string Prijem
        {
            get
            {
                return _prijem;
            }
            set
            {
                if (value != _prijem)
                {
                    _prijem = value;
                    OnPropertyChanged("Prijem");
                }
            }
        }

        public string Odjava
        {
            get
            {
                return _odjava;
            }
            set
            {
                if (value != _odjava)
                {
                    _odjava = value;
                    OnPropertyChanged("Odjava");
                }
            }
        }

        public string Sala
        {
            get
            {
                return _sala;
            }
            set
            {
                if (value != _sala)
                {
                    _sala = value;
                    OnPropertyChanged("Sala");
                }
            }
        }

        public string Pacijent
        {
            get
            {
                return _pacijent;
            }
            set
            {
                if (value != _pacijent)
                {
                    _pacijent = value;
                    OnPropertyChanged("Pacijent");
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
