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
    /// Interaction logic for AddNewTheme.xaml
    /// </summary>
    public partial class AddNewTheme : UserControl
    {
        public AddNewTheme()
        {
            InitializeComponent();
        }
        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            GridAddNewTheme.Children.Clear();
            UserControl usc = new ChangeTheme();
            GridAddNewTheme.Children.Add(usc);
        }

        private void homeBtn2_Click(object sender, RoutedEventArgs e)
        {

            GridAddNewTheme.Children.Clear();
            UserControl usc = new Home();
            GridAddNewTheme.Children.Add(usc);
        }

        private void scheduleBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridAddNewTheme.Children.Clear();
            UserControl usc = new Schedule();
            GridAddNewTheme.Children.Add(usc);

        }

        private void patienstBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridAddNewTheme.Children.Clear();
            UserControl usc = new Patient();
            GridAddNewTheme.Children.Add(usc);
        }

        private void settingsBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridAddNewTheme.Children.Clear();
            UserControl usc = new Settings();
            GridAddNewTheme.Children.Add(usc);
        }


        private void reportBtn_Click(object sender, RoutedEventArgs e)
        {
            GridAddNewTheme.Children.Clear();
            UserControl usc = new Report();
            GridAddNewTheme.Children.Add(usc);
        }

        private void addBtn_Click(object sender, RoutedEventArgs e)
        {
            GridAddNewTheme.Children.Clear();
            UserControl usc = new ChangeTheme();
            GridAddNewTheme.Children.Add(usc);
        }

        private void giveUpBtn_Click(object sender, RoutedEventArgs e)
        {
            GridAddNewTheme.Children.Clear();
            UserControl usc = new ChangeTheme();
            GridAddNewTheme.Children.Add(usc);
        }
    }
}
