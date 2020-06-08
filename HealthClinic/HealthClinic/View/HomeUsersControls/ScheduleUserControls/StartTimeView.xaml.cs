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
    /// Interaction logic for StartTimeView.xaml
    /// </summary>
    public partial class StartTimeView : UserControl
    {
        public StartTimeView(string selectedDate)
        {
            InitializeComponent();
            textWarning.Visibility = textWarningVisible;
            dateLabel.Content = selectedDate;
        }
        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            GridStartTimeView.Children.Clear();
            UserControl usc = new DisplayType(dateLabel.Content.ToString());
            GridStartTimeView.Children.Add(usc);
        }

        private void homeBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridStartTimeView.Children.Clear();
            UserControl usc = new Home();
            GridStartTimeView.Children.Add(usc);

        }

        private void scheduleBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridStartTimeView.Children.Clear();
            UserControl usc = new Schedule();
            GridStartTimeView.Children.Add(usc);
        }

        private void patienstBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridStartTimeView.Children.Clear();
            UserControl usc = new Patient();
            GridStartTimeView.Children.Add(usc);
        }

        private void settingsBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridStartTimeView.Children.Clear();
            UserControl usc = new Settings();
            GridStartTimeView.Children.Add(usc);
        }

        private void reportBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridStartTimeView.Children.Clear();
            UserControl usc = new Report();
            GridStartTimeView.Children.Add(usc);
        }

        private void nextBtn_Click(object sender, RoutedEventArgs e)
        {
            if (timePicker.SelectedTime != null)
            {
                GridStartTimeView.Children.Clear();
                UserControl usc = new StartTimeTerms(dateLabel.Content.ToString()/*, timePicker.Text*/);
                GridStartTimeView.Children.Add(usc);
            }
            else
            {
                textWarning.Visibility = textWarningHidden;
            }
        }

        private Visibility textWarningHidden
        {
            get { return Visibility.Visible; }
        }
        private Visibility textWarningVisible
        {
            get { return Visibility.Hidden; }
        }

        private void PresetTimePicker_SelectedTimeChanged(object sender, RoutedPropertyChangedEventArgs<DateTime?> e)
        {
            if (timePicker.SelectedTime != null)
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
