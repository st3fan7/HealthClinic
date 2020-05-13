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
    /// Interaction logic for ChangePatientAccount.xaml
    /// </summary>
    public partial class ChangePatientAccount : UserControl
    {
        public ChangePatientAccount()
        {
            InitializeComponent();
        }

        private void homeBtn2_Click(object sender, RoutedEventArgs e)
        {

            GridChangePatientAccount.Children.Clear();
            UserControl usc = new Home();
            GridChangePatientAccount.Children.Add(usc);
        }

        private void scheduleBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridChangePatientAccount.Children.Clear();
            UserControl usc = new Schedule();
            GridChangePatientAccount.Children.Add(usc);

        }

        private void patienstBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridChangePatientAccount.Children.Clear();
            UserControl usc = new Patient();
            GridChangePatientAccount.Children.Add(usc);
        }

        private void settingsBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridChangePatientAccount.Children.Clear();
            UserControl usc = new Settings();
            GridChangePatientAccount.Children.Add(usc);
        }

        private void reportBtn_Click(object sender, RoutedEventArgs e)
        {
            GridChangePatientAccount.Children.Clear();
            UserControl usc = new Report();
            GridChangePatientAccount.Children.Add(usc);
        }


        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            GridChangePatientAccount.Children.Clear();
            UserControl usc = new ManipulationOptions();
            GridChangePatientAccount.Children.Add(usc);
        }

        private void changeBtn_Click(object sender, RoutedEventArgs e)
        {
            GridChangePatientAccount.Children.Clear();
            UserControl usc = new ManipulationOptions();
            GridChangePatientAccount.Children.Add(usc);
        }
    }
}
