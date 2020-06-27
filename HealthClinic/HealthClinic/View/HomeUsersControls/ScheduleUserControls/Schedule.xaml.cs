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
            textWarning.Visibility = textWarningVisible;
            datePickerSchedule.DisplayDateStart = DateTime.Now; // proceri da li treba da prikazes termine u proslosti
        }

        private void nextBtn_Click(object sender, RoutedEventArgs e)
        {
            if (datePickerSchedule.SelectedDate != null)
            {
                UserControl usc = new DisplayType(datePickerSchedule.Text);
                (this.Parent as Panel).Children.Add(usc);
            } else
            {
                textWarning.Visibility = textWarningHidden;
                
            }
            
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
            UserControl usc = new PatientView();
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

        private Visibility textWarningHidden
        {
            get { return Visibility.Visible; }
        }
        private Visibility textWarningVisible
        {
            get { return Visibility.Hidden; }
        }

        private void datePickerSchedule_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            if (datePickerSchedule.SelectedDate != null)
            {

                textWarning.Visibility = textWarningVisible;
            }
            else
            {
                textWarning.Visibility = textWarningHidden;
            }
            
        }


    }
}
