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
    /// Interaction logic for Home.xaml
    /// </summary>
    public partial class Home : Window
    {
        public Home()
        {
            InitializeComponent();
            Date.Text = DateTime.Now.ToShortDateString(); ;
            Time.Text = DateTime.Now.ToString("HH:mm");
        }

        private void Button_Click_Magacin(object sender, RoutedEventArgs e)
        {
            var warehouse = new Warehouse();
            warehouse.Show();
        }

        private void Button_Click_OdjaviSe(object sender, RoutedEventArgs e)
        {
            var mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void Buttom_Click_Sale(object sender, RoutedEventArgs e)
        {
            var rooms = new Rooms();
            rooms.Show();
        }

        private void Button_Click_NaloziZaposlenih(object sender, RoutedEventArgs e)
        {
            var workPeople = new WorkPeople();
            workPeople.Show();
        }

        private void Button_Click_PremestanjeOpreme(object sender, RoutedEventArgs e)
        {
            var relocateOfEquipment = new RelocateOfEquipment();
            relocateOfEquipment.Show();
        }

        private void Button_Click_Renoviranje(object sender, RoutedEventArgs e)
        {
            var renovation = new Renovation();
            renovation.Show();
        }

        private void Button_Click_RadnoVremeLekara(object sender, RoutedEventArgs e)
        {
            var workingTimeForDoctors = new WorkingTimeForDoctors();
            workingTimeForDoctors.Show();
        }
    }
}
