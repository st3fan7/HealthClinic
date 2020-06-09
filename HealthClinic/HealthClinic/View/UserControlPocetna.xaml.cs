using HealthClinic.Entiteti;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HealthClinic
{
    /// <summary>
    /// Interaction logic for UserControlPocetna.xaml
    /// </summary>
    public partial class UserControlPocetna : UserControl
    {
        //public static ObservableCollection<Pacijent> Pacijenti = new ObservableCollection<Pacijent>();
        
        public static ObservableCollection<Pacijent> Pacijenti
        {
            get;
            set;
        }

        

        public UserControlPocetna()
        {
            InitializeComponent();
            this.DataContext = this;
           Pacijenti = new ObservableCollection<Pacijent>();
          
            Pacijenti.Add(new Pacijent { Datum = DateTime.Now.ToString("dd.MM.yyyy"), Ime = "Petar", Prezime = "Petrovic", Godine = "60", Zadatak = "Pregled", Vreme = DateTime.Now.ToString("HH:mm"),
                Sala = "2B", Hitnost = "Ne", KratakProblem = "Disekcija aorte. Pacijent ima problem sa kardiovaskularnim sistemom i otežano diše.", Dijagnoza="Disekcija aorte"});
            Pacijenti.Add(new Pacijent
            {
                Datum = DateTime.Now.ToString("dd.MM.yyyy"),
                Ime = "Dusan",
                Prezime = "Svilar",
                Godine = "30",
                Zadatak = "Operacija",
                Vreme = DateTime.Now.ToString("HH:mm"),
                Sala = "1B",
                Hitnost = "Ne",
                KratakProblem = "Problem sa disanjem",
                Dijagnoza = "Ne zna se"
            });
            

        }



        private void dgrPocetnaEvent(object sender, RoutedEventArgs e)
        {
            GridPocentaVidljiv.Visibility = Visibility.Visible;
        }

        private void ButtonIzvrsiPregled_Click(object sender, RoutedEventArgs e)
        {
            
            MainWindow._MainWindow.GridMain.Children.Clear();
            UserControl uscPregled = new UserControlPregled();
            MainWindow._MainWindow.ItemPregled.IsSelected = true;
            MainWindow._MainWindow.ItemPocetna.IsSelected = false;
            MainWindow._MainWindow.GridMain.Children.Add(uscPregled);

        }

        private void DP_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }

   
}
