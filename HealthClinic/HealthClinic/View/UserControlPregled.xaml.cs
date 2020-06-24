                                                                                                                                         
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
      /*
        public ObservableCollection<Pacijent> Pacijenti
        {
            get;
            set;
        }
        */

      //  public static Pacijent selectedPatient = null;


        public UserControlPregled()
        {
            InitializeComponent();
          //  this.DataContext = MainWindow.Pacijenti;
            //Pacijenti = UserControlPocetna.Pacijenti;
            _UserControlPregled = this;
            

            /*
            if (UserControlPocetna.staticPacijent != null)
            {
                ListViewPregledPacijenti.SelectedItem = UserControlPocetna.staticPacijent;
            }
            */


            if(UserControlPocetna.userControlPocetna.ToolTipButto.IsChecked == true)
            {
                ToolTipService.SetIsEnabled(buttonUput, true);
                ToolTipService.SetIsEnabled(buttonIzvesta, true);
                ToolTipService.SetIsEnabled(buttonDijagnoza, true);
            
            }
            else
            {
                ToolTipService.SetIsEnabled(buttonUput, false);
                ToolTipService.SetIsEnabled(buttonIzvesta, false);
                ToolTipService.SetIsEnabled(buttonDijagnoza, false);
            }
            
        }

        public static UserControlPregled _UserControlPregled = new UserControlPregled();

        private void ListViewPregledPacijenti_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            GridPregled.Visibility = Visibility.Visible;        
           // selectedPatient = (Pacijent)ListViewPregledPacijenti.SelectedItem;

            LekoviPregled.Items.Clear();
            ListaAlergija.Items.Clear();
           

            /*
            for (int i = 0; i < selectedPatient.Lekovi.Count; i++)
            {
                LekoviPregled.Items.Add(selectedPatient.Lekovi[i]);
            }

            for (int i = 0; i < selectedPatient.Alergije.Count; i++)
            {
                ListaAlergija.Items.Add(selectedPatient.Alergije[i]);
            }

            AnamenzaPregled.Text = selectedPatient.Anamenza;
            */

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

        private void ButtonLekovi_Click(object sender, RoutedEventArgs e)
        {
            DijalogLekoviPregled dijalogLekoviPregled = new DijalogLekoviPregled();
            dijalogLekoviPregled.ShowDialog();
        }

        private void ButtonAnamneza_Click(object sender, RoutedEventArgs e)
        {
            DijalogAnamnezaKodPregleda dijalog = new DijalogAnamnezaKodPregleda();
            dijalog.ShowDialog();
        }

        private void ButtonIzvesta_Click(object sender, RoutedEventArgs e)
        {
           /* if (selectedPatient != null)
            {
                Izvestaj izvestaj = new Izvestaj(selectedPatient);
            }
            */
        }
    }
}
