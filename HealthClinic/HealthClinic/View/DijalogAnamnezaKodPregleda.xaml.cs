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
    /// Interaction logic for DijalogAnamnezaKodPregleda.xaml
    /// </summary>
    public partial class DijalogAnamnezaKodPregleda : Window
    {
      //  public static List<string> simpomi = new List<string>();

        public DijalogAnamnezaKodPregleda()
        {
            InitializeComponent();


            /*
            if (UserControlPregled.selectedPatient != null)
            {
                AnamenzaUnos.Text = UserControlPregled.selectedPatient.Anamenza;

                foreach (String simpotm in UserControlPregled.selectedPatient.Simptomi)
                {
                    ListBox.Items.Add(simpotm);
                }
            }
            else
            {
                AnamenzaUnos.Text = "";
            }
            */

            if(UserControlPregled.medicalRecord != null)
            {
                AnamenzaUnos.Text = UserControlPregled.medicalRecord.Anamnesis.Description;
               
            }
            else
            {
                AnamenzaUnos.Text = "";
               
            }
            

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void ButtonPotvda_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Da li ste sigurni da želite da sačuvate unete izmene?", "Klikom na potrvdu, potvrđujete unete izmene", MessageBoxButton.YesNo);
            if (result == MessageBoxResult.Yes)
            {
                //UserControlPregled.selectedPatient.Anamenza = AnamenzaUnos.Text;
                this.Close();
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //simpomi.Add(NovSimptom.Text);
            ListBox.Items.Add(NovSimptom.Text);
            //UserControlPregled.selectedPatient.Simptomi.Add(NovSimptom.Text);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
           // UserControlPregled.selectedPatient.Simptomi.Remove(ListBox.SelectedItem.ToString());
            ListBox.Items.Remove(ListBox.SelectedItem);
        }
    }
}
