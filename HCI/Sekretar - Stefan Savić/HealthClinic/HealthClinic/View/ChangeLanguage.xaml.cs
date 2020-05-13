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
    /// Interaction logic for ChangeLanguage.xaml
    /// </summary>
    public partial class ChangeLanguage : UserControl
    {
        public ChangeLanguage()
        {
            InitializeComponent();
        }
        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            GridChangeLanguage.Children.Clear();
            UserControl usc = new Settings();
            GridChangeLanguage.Children.Add(usc);
        }

        private void homeBtn2_Click(object sender, RoutedEventArgs e)
        {

            GridChangeLanguage.Children.Clear();
            UserControl usc = new Home();
            GridChangeLanguage.Children.Add(usc);
        }

        private void scheduleBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridChangeLanguage.Children.Clear();
            UserControl usc = new Schedule();
            GridChangeLanguage.Children.Add(usc);

        }

        private void patienstBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridChangeLanguage.Children.Clear();
            UserControl usc = new Patient();
            GridChangeLanguage.Children.Add(usc);
        }

        private void settingsBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridChangeLanguage.Children.Clear();
            UserControl usc = new Settings();
            GridChangeLanguage.Children.Add(usc);
        }

        private void reportBtn_Click(object sender, RoutedEventArgs e)
        {
            GridChangeLanguage.Children.Clear();
            UserControl usc = new Report();
            GridChangeLanguage.Children.Add(usc);
        }

        private void confirmBtn_Click(object sender, RoutedEventArgs e)
        {
            GridChangeLanguage.Children.Clear();
            UserControl usc = new Settings();
            GridChangeLanguage.Children.Add(usc);
        }

        private void addLanguageBtn_Click(object sender, RoutedEventArgs e)
        {
            GridChangeLanguage.Children.Clear();
            UserControl usc = new AddNewLanguage();
            GridChangeLanguage.Children.Add(usc);
        }
    }
}
