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
    /// Interaction logic for DijalogIzmenaDijagnoze.xaml
    /// </summary>
    public partial class DijalogIzmenaDijagnoze : Window
    {
        public DijalogIzmenaDijagnoze()
        {
            InitializeComponent();

           // if(UserControlPregled.selectedPatient != null)
            //ListBox.Items.Add(UserControlPregled.selectedPatient.Dijagnoza);
        }

        private void ButtonObrisi_Click(object sender, RoutedEventArgs e)
        {
            ListBox.Items.Remove(ListBox.SelectedItem);
        }

        private void ButtonDodaj_Click(object sender, RoutedEventArgs e)
        {
            ListBox.Items.Add(NovaDijagnoza.Text);
            //UserControlPregled.selectedPatient.Dijagnoza = (NovaDijagnoza.Text);
        }

    }
}
