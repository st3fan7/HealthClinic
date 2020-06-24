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
using System.Windows.Shapes;

namespace HealthClinic
{
    /// <summary>
    /// Interaction logic for DijalogIzdavanjeUputa.xaml
    /// </summary>
    public partial class DijalogIzdavanjeUputa : Window
    {
        public DijalogIzdavanjeUputa()
        {
            InitializeComponent();
            Vremena();

            Specijalizacija.Items.Add("Kardiohirurg");
            Specijalizacija.Items.Add("Hirurg");
            Specijalizacija.Items.Add("Pedijatar");
            Specijalizacija.Items.Add("Urolog");

            ListaLekara.Items.Add("dr. Nikola Nikolić");
            ListaLekara.Items.Add("dr. Stefan Stefanović");
            ListaLekara.Items.Add("dr. Predrag Kon");
            /*
            if (UserControlPregled.selectedPatient != null)
            {
                Ime.Text = UserControlPregled.selectedPatient.Ime;
                Prezime.Text = UserControlPregled.selectedPatient.Prezime;
            }
            */
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
