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
    /// Interaction logic for AccountManipulation.xaml
    /// </summary>
    public partial class AccountManipulation : UserControl
    {
        public AccountManipulation()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            GridAccountManipulation.Children.Clear();
            UserControl usc = new Patient();
            GridAccountManipulation.Children.Add(usc);
        }

        private void homeBtn2_Click(object sender, RoutedEventArgs e)
        {

            GridAccountManipulation.Children.Clear();
            UserControl usc = new Home();
            GridAccountManipulation.Children.Add(usc);
        }

        private void scheduleBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridAccountManipulation.Children.Clear();
            UserControl usc = new Schedule();
            GridAccountManipulation.Children.Add(usc);

        }

        private void patienstBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridAccountManipulation.Children.Clear();
            UserControl usc = new Patient();
            GridAccountManipulation.Children.Add(usc);
        }


        private void settingsBtn_Click(object sender, RoutedEventArgs e)
        {
            GridAccountManipulation.Children.Clear();
            UserControl usc = new Settings();
            GridAccountManipulation.Children.Add(usc);
        }

        private void reportBtn_Click(object sender, RoutedEventArgs e)
        {
            GridAccountManipulation.Children.Clear();
            UserControl usc = new Report();
            GridAccountManipulation.Children.Add(usc);
        }

        private void confirmBtn_Click(object sender, RoutedEventArgs e)
        {
            GridAccountManipulation.Children.Clear();
            UserControl usc = new ConfirmPatientIdentityInManipulation();
            GridAccountManipulation.Children.Add(usc);
        }
    }
}
