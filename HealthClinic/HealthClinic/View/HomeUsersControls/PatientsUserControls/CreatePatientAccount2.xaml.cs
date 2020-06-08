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
    /// Interaction logic for CreatePatientAccount2.xaml
    /// </summary>
    public partial class CreatePatientAccount2 : UserControl
    {
        public CreatePatientAccount2()
        {
            InitializeComponent();
        }


        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            GridPatientAccount2.Children.Clear();
            UserControl usc = new CreatePatientAccount1();
            GridPatientAccount2.Children.Add(usc);
        }

        private void homeBtn2_Click(object sender, RoutedEventArgs e)
        {

            GridPatientAccount2.Children.Clear();
            UserControl usc = new Home();
            GridPatientAccount2.Children.Add(usc);
        }

        private void scheduleBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridPatientAccount2.Children.Clear();
            UserControl usc = new Schedule();
            GridPatientAccount2.Children.Add(usc);

        }

        private void patienstBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridPatientAccount2.Children.Clear();
            UserControl usc = new Patient();
            GridPatientAccount2.Children.Add(usc);
        }


        private void settingsBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridPatientAccount2.Children.Clear();
            UserControl usc = new Settings();
            GridPatientAccount2.Children.Add(usc);
        }

        private void reportBtn_Click(object sender, RoutedEventArgs e)
        {
            GridPatientAccount2.Children.Clear();
            UserControl usc = new Report();
            GridPatientAccount2.Children.Add(usc);
        }

        private void createBtn_Click(object sender, RoutedEventArgs e)
        {
            GridPatientAccount2.Children.Clear();
            UserControl usc = new Patient();
            GridPatientAccount2.Children.Add(usc);
        }
    }
}
