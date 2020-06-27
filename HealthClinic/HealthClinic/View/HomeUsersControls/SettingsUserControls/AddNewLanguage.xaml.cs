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
    /// Interaction logic for AddNewLanguage.xaml
    /// </summary>
    public partial class AddNewLanguage : UserControl
    {
        public AddNewLanguage()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            GridAddNewLanguage.Children.Clear();
            UserControl usc = new ChangeLanguage();
            GridAddNewLanguage.Children.Add(usc);
        }

        private void homeBtn2_Click(object sender, RoutedEventArgs e)
        {

            GridAddNewLanguage.Children.Clear();
            UserControl usc = new Home();
            GridAddNewLanguage.Children.Add(usc);
        }

        private void scheduleBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridAddNewLanguage.Children.Clear();
            UserControl usc = new Schedule();
            GridAddNewLanguage.Children.Add(usc);

        }

        private void patienstBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridAddNewLanguage.Children.Clear();
            UserControl usc = new PatientView();
            GridAddNewLanguage.Children.Add(usc);
        }


        private void reportBtn_Click(object sender, RoutedEventArgs e)
        {
            GridAddNewLanguage.Children.Clear();
            UserControl usc = new Report();
            GridAddNewLanguage.Children.Add(usc);
        }

        private void settingsBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridAddNewLanguage.Children.Clear();
            UserControl usc = new Settings();
            GridAddNewLanguage.Children.Add(usc);
        }


        private void addBtn_Click(object sender, RoutedEventArgs e)
        {
            GridAddNewLanguage.Children.Clear();
            UserControl usc = new ChangeLanguage();
            GridAddNewLanguage.Children.Add(usc);
        }

        private void giveUpBtn_Click(object sender, RoutedEventArgs e)
        {
            GridAddNewLanguage.Children.Clear();
            UserControl usc = new ChangeLanguage();
            GridAddNewLanguage.Children.Add(usc);
        }
    }
}
