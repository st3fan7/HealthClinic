using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HealthClinic.Entiteti
{
    public class Pacijenti 
    {

       

       /* public static ObservableCollection<Pacijent> Pacijents
        {
            get;
            set;
        }
        */

        
        public  ObservableCollection<Pacijent> Pacijents
        {
            get;
            set;
        }



        public Pacijenti()
        {
            loadPacijents();
            //Pacijents = new ObservableCollection<Pacijent>();
            
            
        }

       
        public void dodajPacijenta(Pacijent pacijent)
        {
            
            Pacijents.Add(pacijent);   
           
        }

        public void loadPacijents()
        {
            ObservableCollection<Pacijent> pacijents = new ObservableCollection<Pacijent>();
            Pacijent pacijent1 = new Pacijent();
            pacijent1.Datum = DateTime.Now.ToString("dd.MM.yyyy");
            pacijent1.Ime = "Petar";
            pacijent1.Prezime = "Petrovic";
            pacijent1.Godine = "60";
            pacijent1.Zadatak = "Pregled";
            pacijent1.Vreme = DateTime.Now.ToString("HH:mm");
            pacijent1.Dijagnoza = "Disekcija aorte";
            pacijent1.Sala = "2B";
            pacijent1.Hitnost = "Ne";
            pacijent1.KratakProblem = "Disekcija aorte. Pacijent ima problem sa kardiovaskularnim sistemom i otežano diše.";
            pacijent1.ProsliPregled = "21.1.2018";
            pacijent1.Lekovi = new ObservableCollection<string>();
            pacijent1.Lekovi.Add("Bromazepan");
            pacijent1.Lekovi.Add("Bromazepan2");
            pacijent1.Alergije = new ObservableCollection<string>();
            pacijent1.Alergije.Add("Polen");
            pacijent1.Simptomi = new ObservableCollection<string>();
           

            Pacijent pacijent2 = new Pacijent();

            pacijent2.Datum = "21.01.2019";
            pacijent2.Ime = "Dusan";
            pacijent2.Prezime = "Svilar";
            pacijent2.Godine = "30";
            pacijent2.Zadatak = "Operacija";
            pacijent2.Vreme = DateTime.Now.ToString("HH:mm");
            pacijent2.Sala = "1B";
            pacijent2.Hitnost = "Ne";
            pacijent2.KratakProblem = "Problem sa disanjem";
            pacijent2.Dijagnoza = "Ne zna se";
            pacijent2.Lekovi = new ObservableCollection<string>();
            pacijent2.Lekovi.Add("Andol");
            pacijent2.Alergije = new ObservableCollection<string>();
            pacijent2.Simptomi = new ObservableCollection<string>();

            pacijents.Add(pacijent1);
            pacijents.Add(pacijent2);
            
            
            //OnPropertyChanged("pacijents");
            Pacijents = pacijents;

        }



    }
}
