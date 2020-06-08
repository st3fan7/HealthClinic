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
    /// Interaction logic for ConfirmPatientIdentity.xaml
    /// </summary>
    public partial class ConfirmPatientIdentity : UserControl
    {
        public ConfirmPatientIdentity()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            (this.Parent as Panel).Children.Remove(this);
        }

        private void homeBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridPatientValidation.Children.Clear();
            UserControl usc = new Home();
            GridPatientValidation.Children.Add(usc);
        }

        private void scheduleBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridPatientValidation.Children.Clear();
            UserControl usc = new Schedule();
            GridPatientValidation.Children.Add(usc);
        }

        private void patienstBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridPatientValidation.Children.Clear();
            UserControl usc = new Patient();
            GridPatientValidation.Children.Add(usc);
        }

        private void settingsBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridPatientValidation.Children.Clear();
            UserControl usc = new Settings();
            GridPatientValidation.Children.Add(usc);
        }

        private void reportBtn_Click(object sender, RoutedEventArgs e)
        {
            GridPatientValidation.Children.Clear();
            UserControl usc = new Report();
            GridPatientValidation.Children.Add(usc);
        }

        private void yesBtn_Click(object sender, RoutedEventArgs e)
        {
            // nisam povezao ovo, ovo se otvara ukoliko pacijent već ima nalog
        }

        private void noBtn_Click(object sender, RoutedEventArgs e)
        {
            (this.Parent as Panel).Children.Remove(this);
        }
    }
}
