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
    /// Interaction logic for Patient.xaml
    /// </summary>
    public partial class Patient : UserControl
    {
        public Patient()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            GridPatients.Children.Clear();
            UserControl usc = new Home();
            GridPatients.Children.Add(usc);
        }

        private void homeBtn2_Click(object sender, RoutedEventArgs e)
        {

            GridPatients.Children.Clear();
            UserControl usc = new Home();
            GridPatients.Children.Add(usc);
        }

        private void scheduleBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridPatients.Children.Clear();
            UserControl usc = new Schedule();
            GridPatients.Children.Add(usc);

        }

        private void settingsBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridPatients.Children.Clear();
            UserControl usc = new Settings();
            GridPatients.Children.Add(usc);
        }

        private void reportBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridPatients.Children.Clear();
            UserControl usc = new Report();
            GridPatients.Children.Add(usc);
        }

        private void createBtn_Click(object sender, RoutedEventArgs e)
        {
            GridPatients.Children.Clear();
            UserControl usc = new CreatePatientAccount1();
            GridPatients.Children.Add(usc);
        }

        private void manipulationBtn_Click(object sender, RoutedEventArgs e)
        {
            GridPatients.Children.Clear();
            UserControl usc = new AccountManipulation();
            GridPatients.Children.Add(usc);
        }

        private void transformBtn_Click(object sender, RoutedEventArgs e)
        {
            GridPatients.Children.Clear();
            UserControl usc = new TransformationGuestAccount();
            GridPatients.Children.Add(usc);
        }
    }
}
