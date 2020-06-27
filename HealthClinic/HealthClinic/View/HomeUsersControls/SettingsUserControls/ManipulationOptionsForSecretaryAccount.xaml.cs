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
    /// Interaction logic for ManipulationOptionsForSecretaryAccount.xaml
    /// </summary>
    public partial class ManipulationOptionsForSecretaryAccount : UserControl
    {
        public ManipulationOptionsForSecretaryAccount()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            GridManipulationOptionsForSecretaryAccount.Children.Clear();
            UserControl usc = new Settings();
            GridManipulationOptionsForSecretaryAccount.Children.Add(usc);
        }

        private void homeBtn2_Click(object sender, RoutedEventArgs e)
        {

            GridManipulationOptionsForSecretaryAccount.Children.Clear();
            UserControl usc = new Home();
            GridManipulationOptionsForSecretaryAccount.Children.Add(usc);
        }

        private void scheduleBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridManipulationOptionsForSecretaryAccount.Children.Clear();
            UserControl usc = new Schedule();
            GridManipulationOptionsForSecretaryAccount.Children.Add(usc);

        }

        private void patienstBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridManipulationOptionsForSecretaryAccount.Children.Clear();
            UserControl usc = new PatientView();
            GridManipulationOptionsForSecretaryAccount.Children.Add(usc);
        }

        private void settingsBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridManipulationOptionsForSecretaryAccount.Children.Clear();
            UserControl usc = new Settings();
            GridManipulationOptionsForSecretaryAccount.Children.Add(usc);
        }

        private void reportBtn_Click(object sender, RoutedEventArgs e)
        {
            GridManipulationOptionsForSecretaryAccount.Children.Clear();
            UserControl usc = new Report();
            GridManipulationOptionsForSecretaryAccount.Children.Add(usc);
        }

        private void viewBtn_Click(object sender, RoutedEventArgs e)
        {
            GridManipulationOptionsForSecretaryAccount.Children.Clear();
            UserControl usc = new ViewSecretaryAccount();
            GridManipulationOptionsForSecretaryAccount.Children.Add(usc);
        }

        private void changeBtn_Click(object sender, RoutedEventArgs e)
        {
            GridManipulationOptionsForSecretaryAccount.Children.Clear();
            UserControl usc = new ChangeSecretaryAccount();
            GridManipulationOptionsForSecretaryAccount.Children.Add(usc);
        }
    }
}
