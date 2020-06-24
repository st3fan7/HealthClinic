using HealthClinic.Entiteti;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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
        /*
        public List<Pacijent> pretrazeni = new List<Pacijent>();
        
        public static ObservableCollection<Pacijent> Pacijenti
        {
            get;
            set;
        }
        */
      //  public static Pacijent staticPacijent = new Pacijent();
        public static UserControlPocetna userControlPocetna = new UserControlPocetna(); 

        public UserControlPocetna()
        {
            InitializeComponent();
        //    this.DataContext = MainWindow.Pacijenti;
            userControlPocetna = this;

            //Pacijenti Pacijenti = new Pacijenti();
            /*
              Pacijenti.Add(new Pacijent { Datum = DateTime.Now.ToString("dd.MM.yyyy"), Ime = "Petar", Prezime = "Petrovic", Godine = "60", Zadatak = "Pregled", Vreme = DateTime.Now.ToString("HH:mm"),
                  Sala = "2B", Hitnost = "Ne", KratakProblem = "Disekcija aorte. Pacijent ima problem sa kardiovaskularnim sistemom i otežano diše.", Dijagnoza="Disekcija aorte"});
              Pacijenti.Add(new Pacijent
              {
                  Datum = "21.1.2001",
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
              */

            

        }



        private void dgrPocetnaEvent(object sender, RoutedEventArgs e)
        {
            GridPocentaVidljiv.Visibility = Visibility.Visible;
        }

        private void ButtonIzvrsiPregled_Click(object sender, RoutedEventArgs e)
        {

           // staticPacijent = (Pacijent) dgrMain.SelectedItem;
            
            MainWindow._MainWindow.GridMain.Children.Clear();
            UserControl uscPregled = new UserControlPregled();
            MainWindow._MainWindow.ItemPregled.IsSelected = true;
            MainWindow._MainWindow.ItemPocetna.IsSelected = false;
            MainWindow._MainWindow.GridMain.Children.Add(uscPregled);

        }

        private void DP_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            
            //pacijent.Datum = datePicker.SelectedDate.Value.ToString("dd.MM.yyyy");
            /*
            for(int i = 0; i < MainWindow.Pacijenti.Pacijents.Count; i++)
            {
                if(MainWindow.Pacijenti.Pacijents[i].Datum == DP.SelectedDate.Value.ToString("dd.MM.yyyy"))
                {
                    pretrazeni.Add(MainWindow.Pacijenti.Pacijents[i]);
                   
                   
                }

            
            }

            dgrMain.ItemsSource = pretrazeni.ToList();
           */

        }

        private void ToolTipButto_Checked(object sender, RoutedEventArgs e)
        {
            if (ToolTipButto.IsChecked == true)
            {
                ToolTipService.SetIsEnabled(MainWindow._MainWindow.nalogItem, true);
                ToolTipService.SetIsEnabled(MainWindow._MainWindow.menuPrikazi, true);
                ToolTipService.SetIsEnabled(MainWindow._MainWindow.menuZakazi, true);
                ToolTipService.SetIsEnabled(MainWindow._MainWindow.menuObavestenja, true);
                ToolTipService.SetIsEnabled(MainWindow._MainWindow.ItemPocetna, true);
                ToolTipService.SetIsEnabled(MainWindow._MainWindow.ItemOdjava, true);
                ToolTipService.SetIsEnabled(MainWindow._MainWindow.ItemPacijenti, true);
                ToolTipService.SetIsEnabled(MainWindow._MainWindow.ItemPregled, true);
                ToolTipService.SetIsEnabled(MainWindow._MainWindow.ItemValidacijaLeka, true);
                ToolTipService.SetIsEnabled(MainWindow._MainWindow.MenuPomoc, true);
                ToolTipService.SetIsEnabled(buttonUnos, true);
                //ToolTipService.SetIsEnabled(ButtonPregled, false);


            }
            else
            {
               
            }

            
        }

        private void ToolTipButto_Unchecked(object sender, RoutedEventArgs e)
        {
           
                ToolTipService.SetIsEnabled(MainWindow._MainWindow.nalogItem, false);
                ToolTipService.SetIsEnabled(MainWindow._MainWindow.menuPrikazi, false);
                ToolTipService.SetIsEnabled(MainWindow._MainWindow.menuZakazi, false);
                ToolTipService.SetIsEnabled(MainWindow._MainWindow.menuObavestenja, false);
                ToolTipService.SetIsEnabled(MainWindow._MainWindow.ItemPocetna, false);
                ToolTipService.SetIsEnabled(MainWindow._MainWindow.ItemOdjava, false);
                ToolTipService.SetIsEnabled(MainWindow._MainWindow.ItemPacijenti, false);
                ToolTipService.SetIsEnabled(MainWindow._MainWindow.ItemPregled, false);
                ToolTipService.SetIsEnabled(MainWindow._MainWindow.ItemValidacijaLeka, false);
            ToolTipService.SetIsEnabled(MainWindow._MainWindow.MenuPomoc, false);
            ToolTipService.SetIsEnabled(buttonUnos, false);
                ToolTipService.SetIsEnabled(ButtonPregled, false);


        }

        private void ButtonUnos_Click(object sender, RoutedEventArgs e)
        {
            DijalogZakazivanjePregleda dijalogZakazivanjePregleda = new DijalogZakazivanjePregleda();
            dijalogZakazivanjePregleda.ShowDialog();
        }

        private void ComboBox_SelectionChanged(object sender, TextChangedEventArgs e)
        {

           // pretrazeni.Clear();
           /*
            if(search.Text.Equals(""))
            {
                dgrMain.ItemsSource = MainWindow.Pacijenti.Pacijents;
            } else
            {
                foreach (Pacijent pacijent in MainWindow.Pacijenti.Pacijents)
                {
                    
                    if (pacijent.Prezime.Contains(search.Text) || pacijent.Ime.Contains(search.Text) || pacijent.FullName.Contains(search.Text))
                    {                    
                        pretrazeni.Add(pacijent);
                    }
                }
            }

            dgrMain.ItemsSource = pretrazeni.ToList();
        
            */
          
        }

    }

   
}
