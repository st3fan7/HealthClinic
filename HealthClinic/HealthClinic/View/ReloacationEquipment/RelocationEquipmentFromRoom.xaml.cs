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
    /// Interaction logic for RelocationEquipmentFromRoom.xaml
    /// </summary>
    public partial class RelocationEquipmentFromRoom : Window
    {
        public RelocationEquipmentFromRoom()
        {
            InitializeComponent();
            ComboBoxEquipmentInRoom.Focus();
            ComboBoxEquipmentInRoom.SelectedItem = firstItem;
        }

        private void Button_Click_Premesti(object sender, RoutedEventArgs e)
        {
        }

        private void Button_Click_PocetnaStrana(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void EquipmentInRoom_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void EquipmentFromRoom_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
