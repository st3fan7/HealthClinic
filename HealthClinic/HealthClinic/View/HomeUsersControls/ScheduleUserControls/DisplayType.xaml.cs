using HealthClinic.View.HomeUsersControls.ScheduleUserControls;
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
    /// Interaction logic for DisplayType.xaml
    /// </summary>
    public partial class DisplayType : UserControl
    {
        
        public DisplayType(string selectedDate)
        {
            InitializeComponent();
            dateLabel.Content = selectedDate;
            firstRadioButton.IsChecked = true;
        }


        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            GridDisplayType.Children.Clear();
            UserControl usc = new Schedule();
            GridDisplayType.Children.Add(usc);
        }

        private void nextBtn_Click(object sender, RoutedEventArgs e)
        {

                UserControl usc = getTermTypeByCheckRadioButton();
                GridDisplayType.Children.Add(usc);
                


        }

        private UserControl getTermTypeByCheckRadioButton()
        {
            UserControl usc = null;

            if (firstRadioButton.IsChecked == true)
            {
                return usc = new TypeOfRoom(dateLabel.Content.ToString());
            }
            else
            {
                return usc = new TypeOfDoctors(dateLabel.Content.ToString());
            }
            
        }

        private void homeBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridDisplayType.Children.Clear();
            UserControl usc = new Home();
            GridDisplayType.Children.Add(usc);

        }

        private void scheduleBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridDisplayType.Children.Clear();
            UserControl usc = new Schedule();
            GridDisplayType.Children.Add(usc);
        }

        private void patienstBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridDisplayType.Children.Clear();
            UserControl usc = new Patient();
            GridDisplayType.Children.Add(usc);
        }

        private void settingsBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridDisplayType.Children.Clear();
            UserControl usc = new Settings();
            GridDisplayType.Children.Add(usc);
        }

        private void reportBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridDisplayType.Children.Clear();
            UserControl usc = new Report();
            GridDisplayType.Children.Add(usc);
        }

    }
}
