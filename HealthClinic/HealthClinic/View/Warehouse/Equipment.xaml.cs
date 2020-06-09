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
    /// Interaction logic for Equipment.xaml
    /// </summary>
    public partial class Equipment : Window
    {
        public Equipment()
        {
            InitializeComponent();
        }

        private void Button_Click_Dodaj(object sender, RoutedEventArgs e)
        {
            var addEquipment = new AddEquipment();
            addEquipment.ShowDialog();
        }

        private void Button_Click_Obrisi(object sender, RoutedEventArgs e)
        {
            var removeEquipment = new RemoveEquipment();
            removeEquipment.ShowDialog();
        }

        private void Button_Click_UnesiNovuOpremu(object sender, RoutedEventArgs e)
        {
            var addNewEquipment = new AddNewEquipment();
            addNewEquipment.ShowDialog();
        }

        private void Button_Click_PocetnaStrana(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
