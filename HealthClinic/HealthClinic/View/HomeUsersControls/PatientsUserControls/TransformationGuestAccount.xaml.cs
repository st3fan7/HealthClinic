using Controller.UsersControlers;
using HealthClinic.View.Dialogues;
using Model.AllActors;
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
        private readonly UserController userController;

        public TransformationGuestAccount()
        {
            InitializeComponent();
            textWarning2.Visibility = textWarningHidden;
            textWarning.Visibility = textWarningHidden;

            var app = Application.Current as App;
            userController = app.UserController;
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            GridTransformationGuestAccount.Children.Clear();
            UserControl usc = new PatientView();
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
            UserControl usc = new PatientView();
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
            if (!usernameTextBox.Text.Equals(""))
            {
                textWarning.Visibility = textWarningHidden;
                textWarning2.Visibility = textWarningHidden;
                usernameTextBox.BorderBrush = Brushes.Black;
                var thic = new ThicknessConverter();
                usernameTextBox.BorderThickness = (Thickness)thic.ConvertFrom("1");
                confirmBtn.BorderBrush = Brushes.Black;
                confirmBtn.BorderThickness = (Thickness)thic.ConvertFrom("1");

                UserControl usc = null;
                Patient patient;
                try
                {
                    patient = (Patient)userController.GetUserByJMBG(usernameTextBox.Text);
                }
                catch (InvalidCastException e1)
                {
                    Console.WriteLine(e1);
                    return;
                }

                
                // ima guest account
                if (patient != null && patient.GuestAccount == true) 
                {
                    GridTransformationGuestAccount.Children.Clear();
                    usc = new ConfirmPatientIdentityInTransformation(patient);
                    GridTransformationGuestAccount.Children.Add(usc);
                    return;
                }

                textWarning2.Visibility = textWarningVisible;
                textWarning.Visibility = textWarningHidden;
            }
            else
            {
                var bc = new BrushConverter();
                var thic = new ThicknessConverter();
                usernameTextBox.BorderBrush = (Brush)bc.ConvertFrom("#FF761616");
                usernameTextBox.BorderThickness = (Thickness)thic.ConvertFrom("3");
                confirmBtn.BorderBrush = (Brush)bc.ConvertFrom("#FF761616");
                confirmBtn.BorderThickness = (Thickness)thic.ConvertFrom("3");
                textWarning.Visibility = textWarningVisible;
                textWarning2.Visibility = textWarningHidden;
            }

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
