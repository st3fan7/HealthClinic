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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HealthClinic.View
{
    /// <summary>
    /// Interaction logic for DataAccommodationInRecoveryRoom.xaml
    /// </summary>
    public partial class DataModificationInRecoveryRoom : UserControl
    {
        public DataModificationInRecoveryRoom()
        {
            InitializeComponent();
        }

        private void changeBtn_Click(object sender, RoutedEventArgs e)
        {
            GridDataModification.Children.Clear();
            UserControl usc = new RecoveryRooms();
            GridDataModification.Children.Add(usc);
        }


        private void homeBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridDataModification.Children.Clear();
            UserControl usc = new Home();
            GridDataModification.Children.Add(usc);
        }

        private void scheduleBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridDataModification.Children.Clear();
            UserControl usc = new Schedule();
            GridDataModification.Children.Add(usc);

        }
        private void patienstBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridDataModification.Children.Clear();
            UserControl usc = new Patient();
            GridDataModification.Children.Add(usc);
        }


        private void settingsBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridDataModification.Children.Clear();
            UserControl usc = new Settings();
            GridDataModification.Children.Add(usc);
        }

        private void reportBtn_Click(object sender, RoutedEventArgs e)
        {
            GridDataModification.Children.Clear();
            UserControl usc = new Report();
            GridDataModification.Children.Add(usc);
        }
        private void giveUpBtn_Click(object sender, RoutedEventArgs e)
        {
            GridDataModification.Children.Clear();
            UserControl usc = new RecoveryRooms();
            GridDataModification.Children.Add(usc);
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            GridDataModification.Children.Clear();
            UserControl usc = new RecoveryRooms();
            GridDataModification.Children.Add(usc);
        }
    }
}
