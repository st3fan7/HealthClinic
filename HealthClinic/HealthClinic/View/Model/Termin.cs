using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace HealthClinic.Model
{
    public class Termin : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }

        private string _vreme;
        private string _sala;
        private string _lekar;
        private string _pacijent;
        private string _status; // SLOBODAN ILI ZAUZET

        public string Vreme
        {
            get
            {
                return _vreme;
            }
            set
            {
                if (value != _vreme)
                {
                    _vreme = value;
                    OnPropertyChanged("Vreme");
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

        public string Lekar
        {
            get
            {
                return _lekar;
            }
            set
            {
                if (value != _lekar)
                {
                    _lekar = value;
                    OnPropertyChanged("Lekar");
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
