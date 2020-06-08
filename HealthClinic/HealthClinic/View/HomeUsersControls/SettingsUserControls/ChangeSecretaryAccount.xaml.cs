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
    /// Interaction logic for ChangeSecretaryAccount.xaml
    /// </summary>
    public partial class ChangeSecretaryAccount : UserControl
    {
        public ChangeSecretaryAccount()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            GridChangeSecretaryAccount.Children.Clear();
            UserControl usc = new ManipulationOptionsForSecretaryAccount();
            GridChangeSecretaryAccount.Children.Add(usc);
        }

        private void homeBtn2_Click(object sender, RoutedEventArgs e)
        {

            GridChangeSecretaryAccount.Children.Clear();
            UserControl usc = new Home();
            GridChangeSecretaryAccount.Children.Add(usc);
        }

        private void scheduleBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridChangeSecretaryAccount.Children.Clear();
            UserControl usc = new Schedule();
            GridChangeSecretaryAccount.Children.Add(usc);

        }

        private void patienstBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridChangeSecretaryAccount.Children.Clear();
            UserControl usc = new Patient();
            GridChangeSecretaryAccount.Children.Add(usc);
        }

        private void settingsBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridChangeSecretaryAccount.Children.Clear();
            UserControl usc = new Settings();
            GridChangeSecretaryAccount.Children.Add(usc);
        }

        private void reportBtn_Click(object sender, RoutedEventArgs e)
        {
            GridChangeSecretaryAccount.Children.Clear();
            UserControl usc = new Report();
            GridChangeSecretaryAccount.Children.Add(usc);
        }

        private void changeBtn_Click(object sender, RoutedEventArgs e)
        {
            GridChangeSecretaryAccount.Children.Clear();
            UserControl usc = new ManipulationOptionsForSecretaryAccount();
            GridChangeSecretaryAccount.Children.Add(usc);
        }

        
    }
}
