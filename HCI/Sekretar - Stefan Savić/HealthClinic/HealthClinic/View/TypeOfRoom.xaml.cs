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
    /// Interaction logic for TypeOfRoomxaml.xaml
    /// </summary>
    public partial class TypeOfRoom : UserControl
    {
        bool[] array;
        public TypeOfRoom()
        {
            InitializeComponent();
            Schedule s = new Schedule();
            datumLabel.Content = s.datePickerSchedule.DisplayDate; // treba da povuces datum i prikazes
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            GridTypeOfRoom.Children.Clear();
            UserControl usc = new DisplayType();
            GridTypeOfRoom.Children.Add(usc);
        }

        private void nextBtn_Click(object sender, RoutedEventArgs e)
        {
            if (array[0] == true)
            {
                GridTypeOfRoom.Children.Clear();
                UserControl usc = new SurgeryRooms();
                GridTypeOfRoom.Children.Add(usc);
            }
            else if (array[1] == true)
            {
                GridTypeOfRoom.Children.Clear();
                UserControl usc = new MedicalExaminationRooms();
                GridTypeOfRoom.Children.Add(usc);
            }
            else
            {
                GridTypeOfRoom.Children.Clear();
                UserControl usc = new RecoveryRooms();
                GridTypeOfRoom.Children.Add(usc);
            }
        }

        private void homeBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridTypeOfRoom.Children.Clear();
            UserControl usc = new Home();
            GridTypeOfRoom.Children.Add(usc);
        }

        private void scheduleBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridTypeOfRoom.Children.Clear();
            UserControl usc = new Schedule();
            GridTypeOfRoom.Children.Add(usc);
        }

        private void patienstBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridTypeOfRoom.Children.Clear();
            UserControl usc = new Patient();
            GridTypeOfRoom.Children.Add(usc);
        }

        private void settingsBtn_Click(object sender, RoutedEventArgs e)
        {
            GridTypeOfRoom.Children.Clear();
            UserControl usc = new Settings();
            GridTypeOfRoom.Children.Add(usc);
        }

        private void reportBtn_Click(object sender, RoutedEventArgs e)
        {
            GridTypeOfRoom.Children.Clear();
            UserControl usc = new Report();
            GridTypeOfRoom.Children.Add(usc);
        }

        private void one_Checked(object sender, RoutedEventArgs e)
        {
            // ako je cekiran onda mozes da kliknes dugme i ovde otvoris prozor koji ti treba
            nextBtn.IsEnabled = true;
            array = new bool[] { true, false, false };
        }

        private void two_Checked(object sender, RoutedEventArgs e)
        {
            nextBtn.IsEnabled = true;
            array = new bool[] { false, true, false };
        }

        private void three_Checked(object sender, RoutedEventArgs e)
        {
            nextBtn.IsEnabled = true;
            array = new bool[] { false, false, true };
        }
    }
}
