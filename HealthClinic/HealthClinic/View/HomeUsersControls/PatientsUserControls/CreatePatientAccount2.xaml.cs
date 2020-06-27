using HealthClinic.View.Dialogues;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
           // pacijent = p;
            datePickerSchedule.DisplayDateEnd = DateTime.Now;
            textWarningAddress.Visibility = Visibility.Hidden;
            textWarningAddressStatePlaceOfBirth.Visibility = Visibility.Hidden;
            textWarningEmail.Visibility = Visibility.Hidden;
            textWarningPhone.Visibility = Visibility.Hidden;
            textWarning.Visibility = Visibility.Hidden;
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
            UserControl usc = new PatientView();
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
            UserControl usc = null;
            var bc = new BrushConverter();
            var thic = new ThicknessConverter();

            if (!datePickerSchedule.Text.Equals("") && !i2.Text.Equals("") && !i3.Text.Equals("") && !i4.Text.Equals("") && !i5.Text.Equals("") && !i6.Text.Equals(""))
            {
                String textWarningAddressStatePlaceOfBirthRegex = @"[A-Z][a-zA-Z,]{1,}";
                String mobileRegex = @"([+][0-9]{3})?[0-9]{2,3}/[0-9]{3}-[0-9]{3,4}";
                String emailRegex = @"^([a-zA-Z0-9_\-\.]+)@([a-zA-Z0-9_\-\.]+)\.([a-zA-Z]{2,5})$";


                Regex rg = new Regex(textWarningAddressStatePlaceOfBirthRegex);
                Regex rg2 = new Regex(mobileRegex);
                Regex rg4 = new Regex(emailRegex);



                if (!rg.Match(i2.Text).Success)
                {
                    textWarningAddressStatePlaceOfBirth.Visibility = Visibility.Visible;
                    i2.BorderBrush = (Brush)bc.ConvertFrom("#FF761616");
                    i2.BorderThickness = (Thickness)thic.ConvertFrom("3");
                    createBtn.BorderBrush = (Brush)bc.ConvertFrom("#FF761616");
                    createBtn.BorderThickness = (Thickness)thic.ConvertFrom("3");
                    return;
                }

                if (!rg.Match(i3.Text).Success)
                {
                    textWarningAddressStatePlaceOfBirth.Visibility = Visibility.Visible;
                    i3.BorderBrush = (Brush)bc.ConvertFrom("#FF761616");
                    i3.BorderThickness = (Thickness)thic.ConvertFrom("3");
                    createBtn.BorderBrush = (Brush)bc.ConvertFrom("#FF761616");
                    createBtn.BorderThickness = (Thickness)thic.ConvertFrom("3");
                    return;
                }

                if (!rg.Match(i4.Text).Success)
                {
                    textWarningAddressStatePlaceOfBirth.Visibility = Visibility.Visible;
                    i4.BorderBrush = (Brush)bc.ConvertFrom("#FF761616");
                    i4.BorderThickness = (Thickness)thic.ConvertFrom("3");
                    createBtn.BorderBrush = (Brush)bc.ConvertFrom("#FF761616");
                    createBtn.BorderThickness = (Thickness)thic.ConvertFrom("3");
                    return;
                }

                if (!rg2.Match(i5.Text).Success)
                {
                    textWarningPhone.Visibility = Visibility.Visible;
                    i5.BorderBrush = (Brush)bc.ConvertFrom("#FF761616");
                    i5.BorderThickness = (Thickness)thic.ConvertFrom("3");
                    createBtn.BorderBrush = (Brush)bc.ConvertFrom("#FF761616");
                    createBtn.BorderThickness = (Thickness)thic.ConvertFrom("3");
                    return;
                }

                if (!rg4.Match(i6.Text).Success)
                {
                    textWarningEmail.Visibility = Visibility.Visible;
                    i6.BorderBrush = (Brush)bc.ConvertFrom("#FF761616");
                    i6.BorderThickness = (Thickness)thic.ConvertFrom("3");
                    createBtn.BorderBrush = (Brush)bc.ConvertFrom("#FF761616");
                    createBtn.BorderThickness = (Thickness)thic.ConvertFrom("3");
                    return;
                }
                textWarningAddress.Visibility = Visibility.Hidden;
                textWarningAddressStatePlaceOfBirth.Visibility = Visibility.Hidden;
                textWarningEmail.Visibility = Visibility.Hidden;
                textWarningPhone.Visibility = Visibility.Hidden;
                textWarning.Visibility = Visibility.Hidden;


                //
                datePickerSchedule.BorderBrush = Brushes.Black;
                datePickerSchedule.BorderThickness = (Thickness)thic.ConvertFrom("1");
                //
                i2.BorderBrush = Brushes.Black;
                i2.BorderThickness = (Thickness)thic.ConvertFrom("1");
                i3.BorderBrush = Brushes.Black;
                i3.BorderThickness = (Thickness)thic.ConvertFrom("1");
                i4.BorderBrush = Brushes.Black;
                i4.BorderThickness = (Thickness)thic.ConvertFrom("1");
                i5.BorderBrush = Brushes.Black;
                i5.BorderThickness = (Thickness)thic.ConvertFrom("1");

                createBtn.BorderBrush = Brushes.Black;
                createBtn.BorderThickness = (Thickness)thic.ConvertFrom("1");

                //pacijent.DateOfBirth = datePickerSchedule.Text;
                //pacijent.PlaceOfBirth = i2.Text;
                //pacijent.Country = i3.Text;
                //pacijent.Address = i4.Text;
                //pacijent.MobilePhone = i5.Text;
                //pacijent.Email = i6.Text;

                //Loading.pacijenti.Add(pacijent);

                GridPatientAccount2.Children.Clear();
                usc = new PatientView();
                GridPatientAccount2.Children.Add(usc);


            }
            else
            {

                textWarning.Visibility = Visibility.Visible;

                if (datePickerSchedule.Text.Equals(""))
                {
                    datePickerSchedule.BorderBrush = (Brush)bc.ConvertFrom("#FF761616");
                    datePickerSchedule.BorderThickness = (Thickness)thic.ConvertFrom("3");
                    createBtn.BorderBrush = (Brush)bc.ConvertFrom("#FF761616");
                    createBtn.BorderThickness = (Thickness)thic.ConvertFrom("3");
                }

                if (i2.Text.Equals(""))
                {
                    i2.BorderBrush = (Brush)bc.ConvertFrom("#FF761616");
                    i2.BorderThickness = (Thickness)thic.ConvertFrom("3");
                    createBtn.BorderBrush = (Brush)bc.ConvertFrom("#FF761616");
                    createBtn.BorderThickness = (Thickness)thic.ConvertFrom("3");
                }

                if (i3.Text.Equals(""))
                {
                    i3.BorderBrush = (Brush)bc.ConvertFrom("#FF761616");
                    i3.BorderThickness = (Thickness)thic.ConvertFrom("3");
                    createBtn.BorderBrush = (Brush)bc.ConvertFrom("#FF761616");
                    createBtn.BorderThickness = (Thickness)thic.ConvertFrom("3");
                }


                if (i4.Text.Equals(""))
                {
                    i4.BorderBrush = (Brush)bc.ConvertFrom("#FF761616");
                    i4.BorderThickness = (Thickness)thic.ConvertFrom("3");
                    createBtn.BorderBrush = (Brush)bc.ConvertFrom("#FF761616");
                    createBtn.BorderThickness = (Thickness)thic.ConvertFrom("3");
                }

                if (i5.Text.Equals(""))
                {
                    i5.BorderBrush = (Brush)bc.ConvertFrom("#FF761616");
                    i5.BorderThickness = (Thickness)thic.ConvertFrom("3");
                    createBtn.BorderBrush = (Brush)bc.ConvertFrom("#FF761616");
                    createBtn.BorderThickness = (Thickness)thic.ConvertFrom("3");
                }

                if (i6.Text.Equals(""))
                {
                    i6.BorderBrush = (Brush)bc.ConvertFrom("#FF761616");
                    i6.BorderThickness = (Thickness)thic.ConvertFrom("3");
                    createBtn.BorderBrush = (Brush)bc.ConvertFrom("#FF761616");
                    createBtn.BorderThickness = (Thickness)thic.ConvertFrom("3");
                }


            }

        }

        private void i6_TextChanged(object sender, TextChangedEventArgs e)
        {
            textWarningAddress.Visibility = Visibility.Hidden;
            textWarningAddressStatePlaceOfBirth.Visibility = Visibility.Hidden;
            textWarningEmail.Visibility = Visibility.Hidden;
            textWarningPhone.Visibility = Visibility.Hidden;
            
            if (!i6.Text.Equals(""))
            {
                textWarning.Visibility = Visibility.Hidden;
                i6.BorderBrush = Brushes.Black;
                var thic = new ThicknessConverter();
                i6.BorderThickness = (Thickness)thic.ConvertFrom("1");
                createBtn.BorderBrush = Brushes.Black;
                createBtn.BorderThickness = (Thickness)thic.ConvertFrom("1");
            }
        }

        private void i5_TextChanged(object sender, TextChangedEventArgs e)
        {
            textWarningAddress.Visibility = Visibility.Hidden;
            textWarningAddressStatePlaceOfBirth.Visibility = Visibility.Hidden;
            textWarningEmail.Visibility = Visibility.Hidden;
            textWarningPhone.Visibility = Visibility.Hidden;

            if (!i5.Text.Equals(""))
            {
                textWarning.Visibility = Visibility.Hidden;
                i5.BorderBrush = Brushes.Black;
                var thic = new ThicknessConverter();
                i5.BorderThickness = (Thickness)thic.ConvertFrom("1");
                createBtn.BorderBrush = Brushes.Black;
                createBtn.BorderThickness = (Thickness)thic.ConvertFrom("1");
            }
        }

        private void i4_TextChanged(object sender, TextChangedEventArgs e)
        {
            textWarningAddress.Visibility = Visibility.Hidden;
            textWarningAddressStatePlaceOfBirth.Visibility = Visibility.Hidden;
            textWarningEmail.Visibility = Visibility.Hidden;
            textWarningPhone.Visibility = Visibility.Hidden;

            if (!i4.Text.Equals(""))
            {
                textWarning.Visibility = Visibility.Hidden;
                i4.BorderBrush = Brushes.Black;
                var thic = new ThicknessConverter();
                i4.BorderThickness = (Thickness)thic.ConvertFrom("1");
                createBtn.BorderBrush = Brushes.Black;
                createBtn.BorderThickness = (Thickness)thic.ConvertFrom("1");
            }
        }

        private void i3_TextChanged(object sender, TextChangedEventArgs e)
        {
            textWarningAddress.Visibility = Visibility.Hidden;
            textWarningAddressStatePlaceOfBirth.Visibility = Visibility.Hidden;
            textWarningEmail.Visibility = Visibility.Hidden;
            textWarningPhone.Visibility = Visibility.Hidden;

            if (!i3.Text.Equals(""))
            {
                textWarning.Visibility = Visibility.Hidden;
                i3.BorderBrush = Brushes.Black;
                var thic = new ThicknessConverter();
                i3.BorderThickness = (Thickness)thic.ConvertFrom("1");
                createBtn.BorderBrush = Brushes.Black;
                createBtn.BorderThickness = (Thickness)thic.ConvertFrom("1");
            }
        }

        private void i2_TextChanged(object sender, TextChangedEventArgs e)
        {
            textWarningAddress.Visibility = Visibility.Hidden;
            textWarningAddressStatePlaceOfBirth.Visibility = Visibility.Hidden;
            textWarningEmail.Visibility = Visibility.Hidden;
            textWarningPhone.Visibility = Visibility.Hidden;

            if (!i2.Text.Equals(""))
            {
                textWarning.Visibility = Visibility.Hidden;
                i2.BorderBrush = Brushes.Black;
                var thic = new ThicknessConverter();
                i2.BorderThickness = (Thickness)thic.ConvertFrom("1");
                createBtn.BorderBrush = Brushes.Black;
                createBtn.BorderThickness = (Thickness)thic.ConvertFrom("1");
            }
        }

        private void datePickerSchedule_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            textWarningAddress.Visibility = Visibility.Hidden;
            textWarningAddressStatePlaceOfBirth.Visibility = Visibility.Hidden;
            textWarningEmail.Visibility = Visibility.Hidden;
            textWarningPhone.Visibility = Visibility.Hidden;

            if (!datePickerSchedule.Text.Equals(""))
            {
                textWarning.Visibility = Visibility.Hidden;
                datePickerSchedule.BorderBrush = Brushes.Black;
                var thic = new ThicknessConverter();
                datePickerSchedule.BorderThickness = (Thickness)thic.ConvertFrom("1");
                createBtn.BorderBrush = Brushes.Black;
                createBtn.BorderThickness = (Thickness)thic.ConvertFrom("1");
            }
        }
    }
}
