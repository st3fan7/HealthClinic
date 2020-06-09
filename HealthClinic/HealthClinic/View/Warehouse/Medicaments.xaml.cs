using HealthClinic.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace HealthClinic.View
{
    /// <summary>
    /// Interaction logic for Medicaments.xaml
    /// </summary>
    public partial class Medicaments : Window
    {
        private int colNum = 0;
        public ObservableCollection<Medicament> MedicamentsList
        {
            get;
            set;
        }

        public Medicaments()
        {
            InitializeComponent();
            this.DataContext = this;
            MedicamentsList = new ObservableCollection<Medicament>();
            MedicamentsList.Add(new Medicament() { Sifra = "L212", Naziv = "Brufen", Proizvodjac = "Hemofarm", Kolicina = "10", Sastojci = "Prvi, drugi, treći, četvti, peti"});
            MedicamentsList.Add(new Medicament() { Sifra = "L132", Naziv = "Paracetamol", Proizvodjac = "Green farm", Kolicina = "32", Sastojci = "Prvi, drugi, treći" });
            MedicamentsList.Add(new Medicament() { Sifra = "L332", Naziv = "B6 Vitamin", Proizvodjac = "Hemofarm", Kolicina = "21", Sastojci = "Prvi, drugi, treći, četvrti" });
            
        }

        private void generateColumns(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            colNum++;
            if (colNum == 3)
                e.Column.Width = new DataGridLength(1, DataGridLengthUnitType.Star);
        }

        private void Button_Click_Dodaj(object sender, RoutedEventArgs e)
        {
            var addMedicament = new AddMedicament();
            addMedicament.ShowDialog();
        }

        private void Button_Click_Obrisi(object sender, RoutedEventArgs e)
        {
            var removeMedicament = new RemoveMedicament();
            removeMedicament.ShowDialog();
        }

        private void Button_Click_UnesiNoviLek(object sender, RoutedEventArgs e)
        {
            var addNewMedicament = new AddNewMedicament();
            addNewMedicament.ShowDialog();
        }

        private void Button_Click_PocetnaStrana(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
