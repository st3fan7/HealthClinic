using HealthClinic.Entiteti;
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
    /// Interaction logic for UserControlValidacijaLeka.xaml
    /// </summary>
    public partial class UserControlValidacijaLeka : UserControl
    {
       // public static Lek selectedLek = null;
        //public static Lek selectedLekUklinici = null;

        public UserControlValidacijaLeka()
        {
            InitializeComponent();
            userControlValidacijaLeka = this;
          //  this.DataContext = MainWindow.Lekovi;

            if (UserControlPocetna.userControlPocetna.ToolTipButto.IsChecked == true)
            {
                ToolTipService.SetIsEnabled(buttonNazad, true);
                ToolTipService.SetIsEnabled(Verifikuj, true);


            }
            else
            {
                ToolTipService.SetIsEnabled(buttonNazad, false);
                ToolTipService.SetIsEnabled(Verifikuj, false);

            }

        }

        public static UserControlValidacijaLeka userControlValidacijaLeka = new UserControlValidacijaLeka();

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            //selectedLek = (Lek)LekoviValidacija.SelectedItem;
            Sastav.Items.Clear();

            /*
            if (selectedLek != null)
            {
                Proizvodjac.Text = selectedLek.Proizvodjac;
                
                foreach(String sastav in selectedLek.Sastav)
                {
                    Sastav.Items.Add(sastav);
                }
                
            }
            else
            {
                Proizvodjac.Text = "";
                Sastav.Items.Clear();
            }
            */
           



        }

        private void ListViewLekoviUKlinici_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //selectedLekUklinici = (Lek)lekoviUklinici.SelectedItem;
            DijalogLekoviUklinici dijaloglekoviUklinici = new DijalogLekoviUklinici();
            dijaloglekoviUklinici.ShowDialog();
        }

        private void DaChecked_Checked(object sender, RoutedEventArgs e)
        {
            if(DaChecked.IsChecked == true)
            {
                NeChecked.IsChecked = false;
                NeChecked.IsEnabled = false;
            }
        }

        private void DaChecked_Unchecked(object sender, RoutedEventArgs e)
        {
            if (DaChecked.IsChecked == false)
            {
               // NeChecked.IsChecked = false;
                NeChecked.IsEnabled = true;
            }
        }

        private void NeChecked_Checked(object sender, RoutedEventArgs e)
        {
            if (NeChecked.IsChecked == true)
            {
                DaChecked.IsChecked = false;
                DaChecked.IsEnabled = false;
            }
        }

        private void NeChecked_Unchecked(object sender, RoutedEventArgs e)
        {
            if (NeChecked.IsChecked == false)
            {
                // NeChecked.IsChecked = false;
                DaChecked.IsEnabled = true;
            }
        }

        private void ButtonPocetna_Click(object sender, RoutedEventArgs e)
        {
            
            MessageBoxResult result = MessageBox.Show("Da li ste sigurni da želite da se vratite na početnu stranicu?", "Povratak na početnu stranicu", MessageBoxButton.YesNo);
            if(result == MessageBoxResult.Yes) 
                MainWindow._MainWindow.GridMain.Children.Add(new UserControlPocetna());
        }

        private void Verifikuj_Click(object sender, RoutedEventArgs e)
        {

            MessageBoxResult result = MessageBox.Show("Da li ste sigurni da ste dobro validirali lek?\nLek će biti dodat u listu lekova na klinici.", "Validiranje leka", MessageBoxButton.YesNo, MessageBoxImage.Question);

            /*
            if (result == MessageBoxResult.Yes)
            {

                selectedLek.Izvestaj = Izvestaj.Text;

                if (DaChecked.IsChecked == true)
                {
                    
                    selectedLek.Validiran = true;
                    lekoviUklinici.Items.Add(selectedLek);
                    lekoviUklinici.DisplayMemberPath = "Ime";
                    
                }
                else if (NeChecked.IsChecked == true)
                {
                    selectedLek.Validiran = false;
                    
                }
                else
                {
                    selectedLek.Validiran = false;
                }
              
            }
            */



            
        }
    }
}
