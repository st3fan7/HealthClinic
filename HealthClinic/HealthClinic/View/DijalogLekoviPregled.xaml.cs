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
    /// Interaction logic for DijalogLekoviPregled.xaml
    /// </summary>
    public partial class DijalogLekoviPregled : Window
    {
        public DijalogLekoviPregled()
        {
            InitializeComponent();
            /*
            if(UserControlPregled.selectedPatient != null)
            {
                foreach (String lek in UserControlPregled.selectedPatient.Lekovi)
                {
                    ListBox.Items.Add(lek);
                }
            }
            */
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ListBox.Items.Add(NovLek.Text);
           // UserControlPregled.selectedPatient.Lekovi.Add(NovLek.Text);
        }

        private void ButtonObrisi_Click(object sender, RoutedEventArgs e)
        {
            //UserControlPregled.selectedPatient.Lekovi.Remove(ListBox.SelectedItem.ToString());
            ListBox.Items.Remove(ListBox.SelectedItem);
        }
    }
}
