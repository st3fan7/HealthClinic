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
    /// Interaction logic for DeactivationPatientAccount.xaml
    /// </summary>
    public partial class DeactivationPatientAccount : UserControl
    {
        public DeactivationPatientAccount()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            GridDeactivationPatientAccount.Children.Clear();
            UserControl usc = new ManipulationOptions();
            GridDeactivationPatientAccount.Children.Add(usc);
        }

        private void homeBtn2_Click(object sender, RoutedEventArgs e)
        {

            GridDeactivationPatientAccount.Children.Clear();
            UserControl usc = new Home();
            GridDeactivationPatientAccount.Children.Add(usc);
        }

        private void scheduleBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridDeactivationPatientAccount.Children.Clear();
            UserControl usc = new Schedule();
            GridDeactivationPatientAccount.Children.Add(usc);

        }

        private void patienstBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridDeactivationPatientAccount.Children.Clear();
            UserControl usc = new Patient();
            GridDeactivationPatientAccount.Children.Add(usc);
        }

        private void settingsBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridDeactivationPatientAccount.Children.Clear();
            UserControl usc = new Settings();
            GridDeactivationPatientAccount.Children.Add(usc);
        }

        private void reportBtn_Click(object sender, RoutedEventArgs e)
        {
            GridDeactivationPatientAccount.Children.Clear();
            UserControl usc = new Report();
            GridDeactivationPatientAccount.Children.Add(usc);
        }

        private void confirmBtn_Click(object sender, RoutedEventArgs e)
        {
            GridDeactivationPatientAccount.Children.Clear();
            UserControl usc = new ManipulationOptions();
            GridDeactivationPatientAccount.Children.Add(usc);
        }

        private void giveUpBtn_Click(object sender, RoutedEventArgs e)
        {
            GridDeactivationPatientAccount.Children.Clear();
            UserControl usc = new ManipulationOptions();
            GridDeactivationPatientAccount.Children.Add(usc);
        }
    }
}
