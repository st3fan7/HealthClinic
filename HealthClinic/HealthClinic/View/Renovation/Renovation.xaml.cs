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
    /// Interaction logic for Renovation.xaml
    /// </summary>
    public partial class Renovation : Window
    {
        public Renovation()
        {
            InitializeComponent();
            DataPickerFromDataTime.SelectedDate = DateTime.Now.Date;
            DataPickerToDataTime.SelectedDate = DateTime.Now.Date; // Izmeni
        }

        private void Button_Click_ZakaziRenoviranje(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_PrikaziZauzecaSale(object sender, RoutedEventArgs e)
        {
            var roomOccupancy = new RoomOccupancy();
            roomOccupancy.ShowDialog();
        }

        private void Button_Click_PocetnaStrana(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

    }
}
