using System;
using System.Collections.Generic;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            _MainWindow = this;
            ItemPocetna.IsSelected = true;
            

        }

        public static MainWindow _MainWindow = new MainWindow();

        public static UserControl usc = null;

        private void ScrollViewer_Scroll(object sender, System.Windows.Controls.Primitives.ScrollEventArgs e)
        {

        }

        private void ButtonCloseTB_Click(object sender, RoutedEventArgs e)
        {
            ButtonOpenTB.Visibility = Visibility.Visible;
            ButtonCloseTB.Visibility = Visibility.Collapsed;
            
        }

        private void ButtonOpenTB_Click(object sender, RoutedEventArgs e)
        {
            ButtonOpenTB.Visibility = Visibility.Collapsed;
            ButtonCloseTB.Visibility = Visibility.Visible;

        }

        private void AddPresetButton_Click(object sender, RoutedEventArgs e)
        {
            var addButton = sender as FrameworkElement;
            if (addButton != null)
            {
                addButton.ContextMenu.IsOpen = true;
            }
        }

        private void ListViewMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
            GridMain.Children.Clear();

          
            switch (((ListViewItem)((ListView)sender).SelectedItem).Name)
            {
                case "ItemPocetna":
                    usc = new UserControlPocetna();
                    GridMain.Children.Add(usc);
                    break;
                case "ItemPregled":
                    usc = new UserControlPregled();
                    GridMain.Children.Add(usc);
                    break;
                case "ItemPacijenti":
                    usc = new UserControlPacijenti();
                    GridMain.Children.Add(usc);
                    break;
                case "ItemValidacijaLeka":
                    usc = new UserControlValidacijaLeka();
                    GridMain.Children.Add(usc);
                    break;
                case "ItemOdjava":
                    var LogOut = new Window1();
                    LogOut.Show();
                    this.Hide();                                   
                    break;
                                  
                default:
                    
                    break;
            }
        }

        private void MenuPocetna_Click(object sender, RoutedEventArgs e)
        {
            UserControl uscP = new UserControlPocetna();
            if(usc != uscP)
            {
                GridMain.Children.Clear();
                ItemPocetna.IsSelected = true;
                ItemPacijenti.IsSelected = false;
                ItemPregled.IsSelected = false;
                ItemValidacijaLeka.IsSelected = false;
                GridMain.Children.Add(uscP);

            }

           
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);

            Application.Current.Shutdown();
        }

        private void MenuPregled_Click(object sender, RoutedEventArgs e)
        {
            UserControl uscPr = new UserControlPregled();
            if (usc != uscPr)
            {
                GridMain.Children.Clear();
                ItemPregled.IsSelected = true;
                ItemPocetna.IsSelected = false;
                ItemPacijenti.IsSelected = false;
                ItemValidacijaLeka.IsSelected = false;
                GridMain.Children.Add(uscPr);

            }

        }

        private void MenuPacijenti_Click(object sender, RoutedEventArgs e)
        {
            UserControl uscPa = new UserControlPacijenti();
            if (usc != uscPa)
            {
                GridMain.Children.Clear();
                ItemPacijenti.IsSelected = true;
                ItemPregled.IsSelected = false;
                ItemPocetna.IsSelected = false;
                ItemValidacijaLeka.IsSelected = false;
                GridMain.Children.Add(uscPa);

            }

        }

       private void MenuValidacijaLeka_Click(object sender, RoutedEventArgs e)
        {
            UserControl uscV = new UserControlValidacijaLeka();
            if (usc != uscV)
            {
                GridMain.Children.Clear();
                ItemValidacijaLeka.IsSelected = true;
                ItemPacijenti.IsSelected = false;
                ItemPregled.IsSelected = false;
                ItemPocetna.IsSelected = false;
                GridMain.Children.Add(uscV);

            }
        }

        private void MenuItemNalog_Click(object sender, RoutedEventArgs e)
        {

            UserControl uscN = new UserControlNalog();
            if (usc != uscN)
            {
                //GridMain.Children.Clear();
                //ItemPocetna.IsSelected = false;
                //ItemValidacijaLeka.IsSelected = false;
                //ItemPacijenti.IsSelected = false;
                //ItemPregled.IsSelected = false;
              
                GridMain.Children.Add(uscN);

            }
        }

        private void MenuItemObavestenja_Click(object sender, RoutedEventArgs e)
        {
            DijalogObavestenja dijalogObavestenja = new DijalogObavestenja();
            dijalogObavestenja.ShowDialog();
        }

        private void MenuZakaziPregled_Click(object sender, RoutedEventArgs e)
        {
            DijalogZakazivanjePregleda dijalogZakazivanjePregleda = new DijalogZakazivanjePregleda();
            dijalogZakazivanjePregleda.ShowDialog();
        }

        private void MenuOperacija_Click(object sender, RoutedEventArgs e)
        {
            DijalogZakazivanjeOperacije dijalogZakazivanjeOperacije = new DijalogZakazivanjeOperacije();
            dijalogZakazivanjeOperacije.ShowDialog();
        }

        private void MenuUput_Click(object sender, RoutedEventArgs e)
        {
            DijalogIzdavanjeUputa dijalogIzdavanjeUputa = new DijalogIzdavanjeUputa();
            dijalogIzdavanjeUputa.ShowDialog();
        }

        

        private void MenuBolnickoLecenje_Click(object sender, RoutedEventArgs e)
        {
            DijalogBolnickoLecenje dijalogBolnickoLecenje = new DijalogBolnickoLecenje();
            dijalogBolnickoLecenje.ShowDialog();
        }
    }
}
