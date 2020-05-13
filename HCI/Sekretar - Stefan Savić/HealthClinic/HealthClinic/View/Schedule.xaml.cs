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
    /// Interaction logic for Schedule.xaml
    /// </summary>
    public partial class Schedule : UserControl
    {
        public Schedule()
        {
            InitializeComponent();
        }

        private void daljeBtn_Click(object sender, RoutedEventArgs e)
        {
            GridSchedule.Children.Clear();
            UserControl usc = new DisplayType();
            GridSchedule.Children.Add(usc);
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            GridSchedule.Children.Clear();
            UserControl usc = new Home();
            GridSchedule.Children.Add(usc);
        }

        private void homeBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridSchedule.Children.Clear();
            UserControl usc = new Home();
            GridSchedule.Children.Add(usc);
        }

        private void patienstBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridSchedule.Children.Clear();
            UserControl usc = new Patient();
            GridSchedule.Children.Add(usc);
        }

        private void settingsBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridSchedule.Children.Clear();
            UserControl usc = new Settings();
            GridSchedule.Children.Add(usc);
        }

        private void reportBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridSchedule.Children.Clear();
            UserControl usc = new Report();
            GridSchedule.Children.Add(usc);
        }

        private void datePickerSchedule_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            daljeBtn.IsEnabled = true;
        }
    }
}
