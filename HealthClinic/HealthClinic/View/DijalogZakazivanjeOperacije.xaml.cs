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
using System.Windows.Shapes;

namespace HealthClinic
{
    /// <summary>
    /// Interaction logic for DijalogZakazivanjeOperacije.xaml
    /// </summary>
    public partial class DijalogZakazivanjeOperacije : Window
    {
        //Pacijent pacijent = new Pacijent();

        public DijalogZakazivanjeOperacije()
        {
            InitializeComponent();
            Vremena();

            /*
            if (UserControlPregled.selectedPatient == null)
            {
                Ime.Text = null;
                Prezime.Text = null;
                pacijent.ProsliPregled = "";
                pacijent.Lekovi = new ObservableCollection<string>();
                pacijent.Alergije = new ObservableCollection<string>();
                pacijent.Simptomi = new ObservableCollection<string>();
                pacijent.Dijagnoza = "";



            }
            else
            {
                pacijent = UserControlPregled.selectedPatient;


                Ime.Text = UserControlPregled.selectedPatient.Ime;
                Prezime.Text = UserControlPregled.selectedPatient.Prezime;
                pacijent.ProsliPregled = UserControlPregled.selectedPatient.Datum;
                pacijent.Dijagnoza = UserControlPregled.selectedPatient.Dijagnoza;

            }
            */
            Sala.Items.Add("O1");
            Sala.Items.Add("O2");
            Sala.Items.Add("O3");
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        public void Vremena()
        {
            for (int i = 00; i < 24; i++)
            {
                for (int j = 00; j < 60; j += 30)
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
                //pacijent.Hitnost = "Da";
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
               // pacijent.Hitnost = "Ne";
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
            /*
            pacijent.Ime = Ime.Text;
            pacijent.Prezime = Prezime.Text;
            pacijent.Datum = datePicker.SelectedDate.Value.ToString("dd.MM.yyyy");
            pacijent.Vreme = ListVremena.SelectedItem.ToString();
            pacijent.Sala = Sala.SelectedItem.ToString();
            pacijent.Zadatak = "Operacija";
          

            pacijent.KratakProblem = Razlog.Text;
            
            */


            MessageBoxResult result = MessageBox.Show("Da li ste sigurni da ste dobro uneli podatke?\nAko jeste, potvrdite.", "Zakazivanje operacije", MessageBoxButton.YesNo, MessageBoxImage.Warning);
            if (result == MessageBoxResult.Yes)
            {/*
                if (UserControlPregled.selectedPatient == null)
                {
                    MainWindow.Pacijenti.dodajPacijenta(pacijent);
                }
                else
                {
                    UserControlPregled.selectedPatient = pacijent;
                }*/
                this.Close();
            }
        }
    }


}
