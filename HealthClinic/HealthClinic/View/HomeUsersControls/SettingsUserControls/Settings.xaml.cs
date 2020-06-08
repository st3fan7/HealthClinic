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
    /// Interaction logic for Settings.xaml
    /// </summary>
    public partial class Settings : UserControl
    {
        public Settings()
        {
            //ChangeLanguage cl = new ChangeLanguage();
            //if(cl.firstRadioButton.IsChecked == true)
            //{
            //    Properties.Settings.Default.languageCode = "en-US";
            //} else
            //{
            //    Properties.Settings.Default.languageCode = "sr-Latn-RS";
            //}
            InitializeComponent();
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            GridSettings.Children.Clear();
            UserControl usc = new Home();
            GridSettings.Children.Add(usc);
        }

        private void homeBtn2_Click(object sender, RoutedEventArgs e)
        {

            GridSettings.Children.Clear();
            UserControl usc = new Home();
            GridSettings.Children.Add(usc);
        }

        private void scheduleBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridSettings.Children.Clear();
            UserControl usc = new Schedule();
            GridSettings.Children.Add(usc);

        }

        private void patienstBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridSettings.Children.Clear();
            UserControl usc = new Patient();
            GridSettings.Children.Add(usc);
        }


        private void reportBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridSettings.Children.Clear();
            UserControl usc = new Report();
            GridSettings.Children.Add(usc);
        }

        private void secretaryAccountBtn_Click(object sender, RoutedEventArgs e)
        {
            GridSettings.Children.Clear();
            UserControl usc = new ManipulationOptionsForSecretaryAccount();
            GridSettings.Children.Add(usc);
        }

        private void languageBtn_Click(object sender, RoutedEventArgs e)
        {
            GridSettings.Children.Clear();
            UserControl usc = new ChangeLanguage();
            GridSettings.Children.Add(usc);
        }

        private void themeBtn_Click(object sender, RoutedEventArgs e)
        {
            GridSettings.Children.Clear();
            UserControl usc = new ChangeTheme();
            GridSettings.Children.Add(usc);
        }
    }

   
}
