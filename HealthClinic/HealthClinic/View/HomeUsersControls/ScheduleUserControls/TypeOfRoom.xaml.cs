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
        public TypeOfRoom(string selectedDate)
        {
            InitializeComponent();
            dateLabel.Content = selectedDate;
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            GridTypeOfRoom.Children.Clear();
            UserControl usc = new DisplayType(dateLabel.Content.ToString());
            GridTypeOfRoom.Children.Add(usc);
        }

        private void nextBtn_Click(object sender, RoutedEventArgs e)
        {
            GridTypeOfRoom.Children.Clear();
            UserControl usc = getTypeOfRoomsByCheckRadioButton();
            GridTypeOfRoom.Children.Add(usc);
        }

        private UserControl getTypeOfRoomsByCheckRadioButton()
        {
            UserControl usc = null;

            if (firstRadioButton.IsChecked == true)
            {
                return usc = new SurgeryRooms(dateLabel.Content.ToString());

            }
            else if (secondRadioButton.IsChecked == true)
            {
                return usc = new MedicalExaminationRooms();
            }
            else
            {
                return usc = new RecoveryRooms(dateLabel.Content.ToString());
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
            UserControl usc = new PatientView();
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

    }
}
