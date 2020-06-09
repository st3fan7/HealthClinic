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
using HealthClinic.Entiteti;

namespace HealthClinic
{
    /// <summary>
    /// Interaction logic for DijalogZakazivanjePregleda.xaml
    /// </summary>
    public partial class DijalogZakazivanjePregleda : Window
    {
        Pacijent pacijent = new Pacijent();
        public DijalogZakazivanjePregleda()
        {
            InitializeComponent();
            Vremena();

            if (UserControlPregled.selectedPatient == null)
            {
                Ime.Text = null;
                Prezime.Text = null;
                
            }else
            {
                Ime.Text = UserControlPregled.selectedPatient.Ime;
                Prezime.Text = UserControlPregled.selectedPatient.Prezime;
                
            }

            
            
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            pacijent.KratakProblem = Razlog.Text.ToString();
        }

       
        public void Vremena()
        {
            for(int i = 00; i < 24; i++)
            {
                for (int j = 00; j < 60; j+=30)
                {
                    ListVremena.Items.Add(i + ":" + j);
                    ListVremenaKraj.Items.Add(i + ":" + j);
                }
            }
        }

        private void DaChecked_Checked(object sender, RoutedEventArgs e)
        {
            if (DaChecked.IsChecked == true)
            {
                pacijent.Hitnost = "Da";
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
                pacijent.Hitnost = "Ne";
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            pacijent.Ime = Ime.Text;
            pacijent.Prezime = Prezime.Text;
            pacijent.Datum = datePicker.SelectedDate.Value.ToShortDateString();
            pacijent.Vreme = ListVremena.SelectedItem.ToString();
            pacijent.Sala = "101";
            pacijent.Zadatak = "Pregled";
           
            pacijent.Dijagnoza = "asndjas";
            UserControlPocetna.Pacijenti.Add(pacijent);
        }
    }
}
