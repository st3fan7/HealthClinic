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
    /// Interaction logic for ChangeTheme.xaml
    /// </summary>
    public partial class ChangeTheme : UserControl
    {
        public ChangeTheme()
        {
            InitializeComponent();
        }
        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            GridChangeTheme.Children.Clear();
            UserControl usc = new Settings();
            GridChangeTheme.Children.Add(usc);
        }

        private void homeBtn2_Click(object sender, RoutedEventArgs e)
        {

            GridChangeTheme.Children.Clear();
            UserControl usc = new Home();
            GridChangeTheme.Children.Add(usc);
        }

        private void scheduleBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridChangeTheme.Children.Clear();
            UserControl usc = new Schedule();
            GridChangeTheme.Children.Add(usc);

        }

        private void patienstBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridChangeTheme.Children.Clear();
            UserControl usc = new Patient();
            GridChangeTheme.Children.Add(usc);
        }

        private void settingsBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridChangeTheme.Children.Clear();
            UserControl usc = new Settings();
            GridChangeTheme.Children.Add(usc);
        }

        private void reportBtn_Click(object sender, RoutedEventArgs e)
        {
            GridChangeTheme.Children.Clear();
            UserControl usc = new Report();
            GridChangeTheme.Children.Add(usc);
        }

        private void confirmBtn_Click(object sender, RoutedEventArgs e)
        {
            GridChangeTheme.Children.Clear();
            UserControl usc = new Settings();
            GridChangeTheme.Children.Add(usc);
        }
        private void addThemeBtn_Click(object sender, RoutedEventArgs e)
        {
            GridChangeTheme.Children.Clear();
            UserControl usc = new AddNewTheme();
            GridChangeTheme.Children.Add(usc);
        }
    }
}
