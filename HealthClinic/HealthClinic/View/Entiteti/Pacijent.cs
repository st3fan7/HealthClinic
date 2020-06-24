    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace HealthClinic.Entiteti
{
    public class Pacijent : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }
        private string _datum;
        private string _ime;
        private string _prezime;
        private string _godine;
        private string _zadatak;
        private string _vreme;
        private string _sala;
        private string _hitnost;
        private string _kratakProblem;
       // private static List<string> _dijagnoza;
        private string _prosliPregled;
        private string _dijagnoza;
        private string _anamneza;

        public ObservableCollection<string> Lekovi
        {
            get;
            set;
        }

        public ObservableCollection<string> Alergije
        {
            get;
            set;
        }

        public ObservableCollection<string> Simptomi
        {
            get;
            set;
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
                    OnPropertyChanged("FullName");
                }
            }
        }

        public string Prezime
        {
            get
            {
                return _prezime;
            }
            set
            {
                if (value != _prezime)
                {
                    _prezime = value;
                    OnPropertyChanged("Prezime");
                    OnPropertyChanged("FullName");
                }
            }
        }

        public string FullName
        {
            get { return Ime + " " + Prezime; }
        }

        public string Godine
        {
            get
            {
                return _godine;
            }
            set
            {
                if (value != _godine)
                {
                    _godine = value;
                    OnPropertyChanged("Godine");
                }
            }
        }

        public string Zadatak
        {
            get
            {
                return _zadatak;
            }
            set
            {
                if (value != _zadatak)
                {
                    _zadatak = value;
                    OnPropertyChanged("Zadatak");
                }
            }
        }

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
                return _sala; ;
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

        public string Hitnost
        {
            get
            {
                return _hitnost; ;
            }
            set
            {
                if (value != _hitnost)
                {
                    _hitnost = value;
                    OnPropertyChanged("Hitnost");
                }
            }
        }

        
        public string KratakProblem
        {
            get
            {
                return _kratakProblem; ;
            }
            set
            {
                if (value != _kratakProblem)
                {
                    _kratakProblem = value;
                    OnPropertyChanged("KratakProblem");
                }
            }
        }

        public  string Dijagnoza
        {
            get
            {
                return _dijagnoza; ;
            }
            set
            {
                if (value != _dijagnoza)
                {
                    _dijagnoza = value;
                    OnPropertyChanged("Dijagnoza");
                }
            }
        }

        public string ProsliPregled
        {
            get
            {
                return _prosliPregled;
            }
            set
            {
                if (value != _prosliPregled)
                {
                    _prosliPregled = value;
                    OnPropertyChanged("ProsliPregled");
                }
            }
        }

        public string Anamenza
        {
            get
            {
                return _anamneza;
            }
            set
            {
                if (value != _anamneza)
                {
                    _anamneza = value;
                    OnPropertyChanged("Anamenza");
                }
            }
        }
    }
}
