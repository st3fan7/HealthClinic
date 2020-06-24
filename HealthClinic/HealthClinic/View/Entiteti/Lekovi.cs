using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthClinic.Entiteti
{
    public class Lekovi
    {

        public ObservableCollection<Lek> lekovi
        {
            get;
            set;
        }

        public Lekovi()
        {
            loadLekovi();

        }


        public void dodajLek(Lek lek)
        {

            lekovi.Add(lek);

        }


        public void loadLekovi()
        {
            ObservableCollection<Lek> listLekova = new ObservableCollection<Lek>();

            Lek lek1 = new Lek();
            lek1.Ime = "Brufen";
            lek1.Proizvodjac = "MedikFarm";
            lek1.Sastav = new ObservableCollection<string>();
            lek1.Sastav.Add("Kompleks");
            lek1.Sastav.Add("Kofein 5g");
            lek1.Sastav.Add("G-123");

            Lek lek2 = new Lek();
            lek2.Ime = "B-Complex";
            lek2.Proizvodjac = "Galenika";
            lek2.Sastav = new ObservableCollection<string>();
            lek2.Sastav.Add("B12");
            lek2.Sastav.Add("B6");
            lek2.Sastav.Add("B-123");

            Lek lek3 = new Lek();
            lek3.Ime = "Paracetamol";
            lek3.Proizvodjac = "InPharm";
            lek3.Sastav = new ObservableCollection<string>();
            lek3.Sastav.Add("Kompleks");
            lek3.Sastav.Add("Kofein 25g");
            lek3.Sastav.Add("I88");

            listLekova.Add(lek1);
            listLekova.Add(lek2);
            listLekova.Add(lek3);

            lekovi = listLekova;

        }








    }
}
