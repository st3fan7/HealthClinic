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
    /// Interaction logic for SearchInRecoveryRooms.xaml
    /// </summary>
    public partial class SearchInRecoveryRooms : UserControl
    {

        public SearchInRecoveryRooms(string selectedDate)
        {
            InitializeComponent();
            dateLabel.Content = selectedDate;
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            (this.Parent as Panel).Children.Remove(this);
        }

        private void homeBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridSearchInRecoveryRooms.Children.Clear();
            UserControl usc = new Home();
            GridSearchInRecoveryRooms.Children.Add(usc);
        }

        private void scheduleBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridSearchInRecoveryRooms.Children.Clear();
            UserControl usc = new Schedule();
            GridSearchInRecoveryRooms.Children.Add(usc);

        }

        private void patienstBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridSearchInRecoveryRooms.Children.Clear();
            UserControl usc = new Patient();
            GridSearchInRecoveryRooms.Children.Add(usc);
        }

        private void settingsBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridSearchInRecoveryRooms.Children.Clear();
            UserControl usc = new Settings();
            GridSearchInRecoveryRooms.Children.Add(usc);
        }

        private void reportBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridSearchInRecoveryRooms.Children.Clear();
            UserControl usc = new Report();
            GridSearchInRecoveryRooms.Children.Add(usc);
        }


        private void searchBtn_Click(object sender, RoutedEventArgs e)
        {
            UserControl usc = new SearchResult(dateLabel.Content.ToString());
            (this.Parent as Panel).Children.Add(usc);
        }
    }
}
