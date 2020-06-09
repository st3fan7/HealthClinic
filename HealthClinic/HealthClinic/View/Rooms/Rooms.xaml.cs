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
    /// Interaction logic for Rooms.xaml
    /// </summary>
    public partial class Rooms : Window
    {
        public Rooms()
        {
            InitializeComponent();
        }

        private void Button_Click_PocetnaStrana(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_IzmeniTipSale(object sender, RoutedEventArgs e)
        {
            var determinateTypeOfRoom = new DeterminateTypeOfRoom();
            determinateTypeOfRoom.ShowDialog();
        }

        private void Button_Click_ObrisiSalu(object sender, RoutedEventArgs e)
        {
            var removeRoom = new RemoveRoom();
            removeRoom.ShowDialog();
        }

        private void Button_Click_DodajSalu(object sender, RoutedEventArgs e)
        {
            var addRoom = new AddRoom();
            addRoom.ShowDialog();
        }
    }
}
