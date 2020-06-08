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
    /// Interaction logic for CreatePatientAccount1.xaml
    /// </summary>
    public partial class CreatePatientAccount1 : UserControl
    {
        public CreatePatientAccount1()
        {
            InitializeComponent();
        }

        private void nextBtn_Click(object sender, RoutedEventArgs e)
        {
            GridPatientAccount1.Children.Clear();
            UserControl usc = new CreatePatientAccount2();
            GridPatientAccount1.Children.Add(usc);
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            GridPatientAccount1.Children.Clear();
            UserControl usc = new Patient();
            GridPatientAccount1.Children.Add(usc);
        }

        private void homeBtn2_Click(object sender, RoutedEventArgs e)
        {

            GridPatientAccount1.Children.Clear();
            UserControl usc = new Home();
            GridPatientAccount1.Children.Add(usc);
        }

        private void scheduleBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridPatientAccount1.Children.Clear();
            UserControl usc = new Schedule();
            GridPatientAccount1.Children.Add(usc);

        }

        private void patienstBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridPatientAccount1.Children.Clear();
            UserControl usc = new Patient();
            GridPatientAccount1.Children.Add(usc);
        }


        private void settingsBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridPatientAccount1.Children.Clear();
            UserControl usc = new Settings();
            GridPatientAccount1.Children.Add(usc);
        }

        private void reportBtn_Click(object sender, RoutedEventArgs e)
        {
            GridPatientAccount1.Children.Clear();
            UserControl usc = new Report();
            GridPatientAccount1.Children.Add(usc);
        }

    }
}
