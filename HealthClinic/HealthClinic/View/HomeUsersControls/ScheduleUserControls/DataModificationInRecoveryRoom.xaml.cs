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
        public DataModificationInRecoveryRoom(string selectedDate)
        {
            InitializeComponent();
            dateLabel.Content = selectedDate;
            datePickerSchedule.DisplayDateStart = DateTime.Now;
            textWarning.Visibility = textWarningHidden;
        }

        private void changeBtn_Click(object sender, RoutedEventArgs e)
        {
            if (datePickerSchedule.SelectedDate != null)
            {
                (this.Parent as Panel).Children.RemoveRange(1, 6);
            }
            else
            {
                textWarning.Visibility = textWarningVisible;
            }
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
            (this.Parent as Panel).Children.Remove(this);
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            (this.Parent as Panel).Children.Remove(this);
        }

        private Visibility textWarningHidden
        {
            get { return Visibility.Hidden; }
        }
        private Visibility textWarningVisible
        {
            get { return Visibility.Visible; }
        }

        private void datePickerSchedule_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            if (datePickerSchedule.SelectedDate != null)
            {

                textWarning.Visibility = textWarningHidden;
            }
            else
            {
                textWarning.Visibility = textWarningVisible;
            }

        }
    }
}
