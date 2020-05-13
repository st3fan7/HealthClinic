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
    /// Interaction logic for ConfirmPatientIdentityInTransformation.xaml
    /// </summary>
    public partial class ConfirmPatientIdentityInTransformation : UserControl
    {
        public ConfirmPatientIdentityInTransformation()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            GridPatientValidationInTransformation.Children.Clear();
            UserControl usc = new TransformationGuestAccount();
            GridPatientValidationInTransformation.Children.Add(usc);
        }

        private void homeBtn2_Click(object sender, RoutedEventArgs e)
        {

            GridPatientValidationInTransformation.Children.Clear();
            UserControl usc = new Home();
            GridPatientValidationInTransformation.Children.Add(usc);
        }

        private void scheduleBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridPatientValidationInTransformation.Children.Clear();
            UserControl usc = new Schedule();
            GridPatientValidationInTransformation.Children.Add(usc);

        }

        private void patientsBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridPatientValidationInTransformation.Children.Clear();
            UserControl usc = new Patient();
            GridPatientValidationInTransformation.Children.Add(usc);
        }

        private void settingsBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridPatientValidationInTransformation.Children.Clear();
            UserControl usc = new Settings();
            GridPatientValidationInTransformation.Children.Add(usc);
        }

        private void reportBtn_Click(object sender, RoutedEventArgs e)
        {
            GridPatientValidationInTransformation.Children.Clear();
            UserControl usc = new Report();
            GridPatientValidationInTransformation.Children.Add(usc);
        }

        private void yesBtn_Click(object sender, RoutedEventArgs e)
        {
            GridPatientValidationInTransformation.Children.Clear();
            UserControl usc = new FillDataForTransformation();
            GridPatientValidationInTransformation.Children.Add(usc);
        }

        private void noBtn_Click(object sender, RoutedEventArgs e)
        {
            GridPatientValidationInTransformation.Children.Clear();
            UserControl usc = new TransformationGuestAccount();
            GridPatientValidationInTransformation.Children.Add(usc);
        }
    }
}
