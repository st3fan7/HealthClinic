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

namespace HealthClinic.View
{
    /// <summary>
    /// Interaction logic for AddNewMedicament.xaml
    /// </summary>
    public partial class AddNewMedicament : Window
    {
        public AddNewMedicament()
        {
            InitializeComponent();
            ComboBoxDoctors.Focus();
            ComboBoxDoctors.SelectedItem = firstItem;
        }

        private void Button_Click_PosaljiLekaru(object sender, RoutedEventArgs e)
        {
            
        }

        private void Button_Click_Odustani(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
