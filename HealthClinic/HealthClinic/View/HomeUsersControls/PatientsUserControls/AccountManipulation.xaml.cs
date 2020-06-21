using HealthClinic.View.Dialogues;
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
    /// Interaction logic for AccountManipulation.xaml
    /// </summary>
    public partial class AccountManipulation : UserControl
    {
        public AccountManipulation()
        {
            InitializeComponent();
            textWarning2.Visibility = textWarningHidden;
            textWarning.Visibility = textWarningHidden;
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            GridAccountManipulation.Children.Clear();
            UserControl usc = new Patient();
            GridAccountManipulation.Children.Add(usc);
        }

        private void homeBtn2_Click(object sender, RoutedEventArgs e)
        {

            GridAccountManipulation.Children.Clear();
            UserControl usc = new Home();
            GridAccountManipulation.Children.Add(usc);
        }

        private void scheduleBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridAccountManipulation.Children.Clear();
            UserControl usc = new Schedule();
            GridAccountManipulation.Children.Add(usc);

        }

        private void patienstBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridAccountManipulation.Children.Clear();
            UserControl usc = new Patient();
            GridAccountManipulation.Children.Add(usc);
        }


        private void settingsBtn_Click(object sender, RoutedEventArgs e)
        {
            GridAccountManipulation.Children.Clear();
            UserControl usc = new Settings();
            GridAccountManipulation.Children.Add(usc);
        }

        private void reportBtn_Click(object sender, RoutedEventArgs e)
        {
            GridAccountManipulation.Children.Clear();
            UserControl usc = new Report();
            GridAccountManipulation.Children.Add(usc);
        }

        private void confirmBtn_Click(object sender, RoutedEventArgs e)
        {
            //if (!usernameTextBox.Text.Equals(""))
            //{
            //    textWarning.Visibility = textWarningHidden;
            //    textWarning2.Visibility = textWarningHidden;
            //    usernameTextBox.BorderBrush = Brushes.Black;
            //    var thic = new ThicknessConverter();
            //    usernameTextBox.BorderThickness = (Thickness)thic.ConvertFrom("1");
            //    confirmBtn.BorderBrush = Brushes.Black;
            //    confirmBtn.BorderThickness = (Thickness)thic.ConvertFrom("1");

            //    UserControl usc = null;
            //    foreach (Pacijent pacijent in Loading.pacijenti)
            //    {
            //        // ima nalog
            //        if (pacijent.Username != null)
            //        {
            //            if (pacijent.Username.Equals(usernameTextBox.Text))
            //            {



            //                GridAccountManipulation.Children.Clear();
            //                 usc = new ConfirmPatientIdentityInManipulation(pacijent);
            //                GridAccountManipulation.Children.Add(usc);
            //                return;
            //            }
            //        }


            //        // ima guest account
            //        if (pacijent.Id.Equals(usernameTextBox.Text))
            //        {
            //            GridAccountManipulation.Children.Clear();
            //             usc = new ConfirmPatientIdentityInManipulation(pacijent);
            //            GridAccountManipulation.Children.Add(usc);
            //            return;
            //        }
            //    }
            //    // nema nalog
            //    textWarning2.Visibility = textWarningVisible;
            //    textWarning.Visibility = textWarningHidden;
            //}
            //else
            //{
            //    var bc = new BrushConverter();
            //    var thic = new ThicknessConverter();
            //    usernameTextBox.BorderBrush = (Brush)bc.ConvertFrom("#FF761616");
            //    usernameTextBox.BorderThickness = (Thickness)thic.ConvertFrom("3");
            //    confirmBtn.BorderBrush = (Brush)bc.ConvertFrom("#FF761616");
            //    confirmBtn.BorderThickness = (Thickness)thic.ConvertFrom("3");
            //    textWarning.Visibility = textWarningVisible;
            //    textWarning2.Visibility = textWarningHidden;
            //}
            ////

            // logika je gore
            GridAccountManipulation.Children.Clear();
            UserControl usc = new ConfirmPatientIdentityInManipulation();
            GridAccountManipulation.Children.Add(usc);
        }

        private Visibility textWarningHidden
        {
            get { return Visibility.Hidden; }
        }
        private Visibility textWarningVisible
        {
            get { return Visibility.Visible; }
        }
        private void usernameTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            textWarning2.Visibility = textWarningHidden;
            if (!usernameTextBox.Text.Equals(""))
            {
                textWarning.Visibility = textWarningHidden;
                usernameTextBox.BorderBrush = Brushes.Black;
                var thic = new ThicknessConverter();
                usernameTextBox.BorderThickness = (Thickness)thic.ConvertFrom("1");
                confirmBtn.BorderBrush = Brushes.Black;
                confirmBtn.BorderThickness = (Thickness)thic.ConvertFrom("1");
            }
        }
    }
}
