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
    /// Interaction logic for PatientValidationForRecovery.xaml
    /// </summary>
    public partial class PatientValidationForRecovery : UserControl
    {
        //Oporavak terminUKojiSmestamOporavak = new Oporavak();
        public PatientValidationForRecovery(string selectedDate)
        {
            InitializeComponent();
            dateLabel.Content = selectedDate;
            textWarning2.Visibility = textWarningHidden;
            textWarning.Visibility = textWarningHidden;
            //terminUKojiSmestamOporavak = oporavak;
        }

        private void homeBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridPatientValidationForRecovery.Children.Clear();
            UserControl usc = new Home();
            GridPatientValidationForRecovery.Children.Add(usc);
        }

        private void scheduleBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridPatientValidationForRecovery.Children.Clear();
            UserControl usc = new Schedule();
            GridPatientValidationForRecovery.Children.Add(usc);
        }

        private void patienstBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridPatientValidationForRecovery.Children.Clear();
            UserControl usc = new PatientView();
            GridPatientValidationForRecovery.Children.Add(usc);
        }

        private void settingsBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridPatientValidationForRecovery.Children.Clear();
            UserControl usc = new Settings();
            GridPatientValidationForRecovery.Children.Add(usc);
        }

        private void reportBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridPatientValidationForRecovery.Children.Clear();
            UserControl usc = new Report();
            GridPatientValidationForRecovery.Children.Add(usc);
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
                //foreach (Pacijent pacijent in Loading.pacijenti)
                //{
                //    // ima nalog
                //    if (!pacijent.Username.Equals(""))
                //    {
                //        if (pacijent.Username.Equals(usernameTextBox.Text))
                //        {



                //            usc = new AccommodationPatient(dateLabel.Content.ToString(), terminUKojiSmestamOporavak, pacijent); // datum ne moras ovako vec datum od termina uzmi
                //            (this.Parent as Panel).Children.Add(usc);
                //            return;
                //        }
                //    }


                //    // ima guest account
                //    if (pacijent.Id.Equals(usernameTextBox.Text))
                //    {
                //        usc = new AccommodationPatient(dateLabel.Content.ToString(), terminUKojiSmestamOporavak, pacijent);
                //        (this.Parent as Panel).Children.Add(usc);
                //        return;
                //    }
                //}
                // nema nalog
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


            //UserControl usc = new AccommodationPatient(dateLabel.Content.ToString());
            //(this.Parent as Panel).Children.Add(usc);
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            (this.Parent as Panel).Children.Remove(this);
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
