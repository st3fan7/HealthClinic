                                                                                                                                         
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
using HealthClinic.Entiteti;

namespace HealthClinic
{
    /// <summary>
    /// Interaction logic for UserControlPregled.xaml
    /// </summary>
    public partial class UserControlPregled : UserControl
    {
        public ObservableCollection<Pacijent> Pacijenti
        {
            get;
            set;
        }

        public static Pacijent selectedPatient = null;

        public UserControlPregled()
        {
            InitializeComponent();
            this.DataContext = this;
            Pacijenti = UserControlPocetna.Pacijenti;
        }

        private void ListViewPregledPacijenti_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            GridPregled.Visibility = Visibility.Visible;
            selectedPatient = (Pacijent)ListViewPregledPacijenti.SelectedItem;
        }

        private void ButtonDijanoza_Click(object sender, RoutedEventArgs e)
        {
            DijalogIzmenaDijagnoze dijalogDijagnoza = new DijalogIzmenaDijagnoze();
            dijalogDijagnoza.ShowDialog();
        }

        private void ButtonIzdavanjeRecepta_Click(object sender, RoutedEventArgs e)
        {
            MainWindow._MainWindow.GridMain.Children.Add(new UserControlIzdavanjeRecepta());
        }

        private void ButtonAlergija_Click(object sender, RoutedEventArgs e)
        {
            DijalogIzmenaAlergije dijalogIzmenaAlergije = new DijalogIzmenaAlergije();
            dijalogIzmenaAlergije.ShowDialog();
        }

        private void ButtonZakaziPregled_Click(object sender, RoutedEventArgs e)
        {
            DijalogZakazivanjePregleda dijalogZakazivanjePregleda = new DijalogZakazivanjePregleda();
            dijalogZakazivanjePregleda.ShowDialog();
        }

        private void ButtonZakaziOperaciju_Click(object sender, RoutedEventArgs e)
        {
            DijalogZakazivanjeOperacije dijalogZakazivanjeOperacije = new DijalogZakazivanjeOperacije();
            dijalogZakazivanjeOperacije.ShowDialog();
        }

        private void ButtonUput_Click(object sender, RoutedEventArgs e)
        {
            DijalogIzdavanjeUputa dijalogIzdavanjeUputa = new DijalogIzdavanjeUputa();
            dijalogIzdavanjeUputa.ShowDialog();
        }
        private void ButtonBolnickoLecenje_Click(object sender, RoutedEventArgs e)
        {
            DijalogBolnickoLecenje dijalogBolnickoLecenje = new DijalogBolnickoLecenje();
            dijalogBolnickoLecenje.ShowDialog();
        }
    }
}
