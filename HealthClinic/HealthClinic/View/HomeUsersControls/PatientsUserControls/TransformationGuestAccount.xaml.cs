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
    /// Interaction logic for TransformationGuestAccount.xaml
    /// </summary>
    public partial class TransformationGuestAccount : UserControl
    {
        public TransformationGuestAccount()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            GridTransformationGuestAccount.Children.Clear();
            UserControl usc = new Patient();
            GridTransformationGuestAccount.Children.Add(usc);
        }

        private void homeBtn2_Click(object sender, RoutedEventArgs e)
        {

            GridTransformationGuestAccount.Children.Clear();
            UserControl usc = new Home();
            GridTransformationGuestAccount.Children.Add(usc);
        }

        private void scheduleBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridTransformationGuestAccount.Children.Clear();
            UserControl usc = new Schedule();
            GridTransformationGuestAccount.Children.Add(usc);

        }

        private void patientsBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridTransformationGuestAccount.Children.Clear();
            UserControl usc = new Patient();
            GridTransformationGuestAccount.Children.Add(usc);
        }

        private void settingsBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridTransformationGuestAccount.Children.Clear();
            UserControl usc = new Settings();
            GridTransformationGuestAccount.Children.Add(usc);
        }

        private void reportBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridTransformationGuestAccount.Children.Clear();
            UserControl usc = new Report();
            GridTransformationGuestAccount.Children.Add(usc);
        }

        private void confirmBtn_Click(object sender, RoutedEventArgs e)
        {
            GridTransformationGuestAccount.Children.Clear();
            UserControl usc = new ConfirmPatientIdentityInTransformation();
            GridTransformationGuestAccount.Children.Add(usc);
        }

    }
}
