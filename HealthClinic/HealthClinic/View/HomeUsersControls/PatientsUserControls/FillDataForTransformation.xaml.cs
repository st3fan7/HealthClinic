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
    /// Interaction logic for FillDataForTransformation.xaml
    /// </summary>
    public partial class FillDataForTransformation : UserControl
    {
        public FillDataForTransformation()
        {
            InitializeComponent();
           // pacijent = p;
            datePickerSchedule.DisplayDateEnd = DateTime.Now;
            textWarning.Visibility = Visibility.Hidden;
            warningUserName.Visibility = Visibility.Hidden;
            warningForPassword.Visibility = Visibility.Hidden;
            textWarningAddressStatePlaceOfBirth.Visibility = Visibility.Hidden;
            textWarningEmail.Visibility = Visibility.Hidden;
            textWarning9.Visibility = Visibility.Hidden;
        }
        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            GridFillDataForTransformation.Children.Clear();
            UserControl usc = new TransformationGuestAccount();
            GridFillDataForTransformation.Children.Add(usc);
        }

        private void homeBtn2_Click(object sender, RoutedEventArgs e)
        {

            GridFillDataForTransformation.Children.Clear();
            UserControl usc = new Home();
            GridFillDataForTransformation.Children.Add(usc);
        }

        private void scheduleBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridFillDataForTransformation.Children.Clear();
            UserControl usc = new Schedule();
            GridFillDataForTransformation.Children.Add(usc);

        }

        private void patienstBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridFillDataForTransformation.Children.Clear();
            UserControl usc = new Patient();
            GridFillDataForTransformation.Children.Add(usc);
        }

        private void settingsBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridFillDataForTransformation.Children.Clear();
            UserControl usc = new Settings();
            GridFillDataForTransformation.Children.Add(usc);
        }

        private void reportBtn_Click(object sender, RoutedEventArgs e)
        {
            GridFillDataForTransformation.Children.Clear();
            UserControl usc = new Report();
            GridFillDataForTransformation.Children.Add(usc);
        }

        private void trasnformBtn_Click(object sender, RoutedEventArgs e)
        {
            UserControl usc = null;
            var bc = new BrushConverter();
            var thic = new ThicknessConverter();

            if (!datePickerSchedule.Text.Equals("") && !i2.Text.Equals("") && !i1.Text.Equals("") && !i4.Text.Equals("") && !i5.Text.Equals("") && !i6.Text.Equals("") )
            {
                String textWarningAddressStatePlaceOfBirthRegex = @"[A-Z][a-zA-Z,]{1,}";
                String emailRegex = @"^([a-zA-Z0-9_\-\.]+)@([a-zA-Z0-9_\-\.]+)\.([a-zA-Z]{2,5})$";
                String usernameRegex = @"[a-zA-Z]{1,}";
                String passRegex = @"\S{8,22}";


                Regex rg = new Regex(textWarningAddressStatePlaceOfBirthRegex);
                Regex rg2 = new Regex(usernameRegex);
                Regex rg3 = new Regex(passRegex);
                Regex rg4 = new Regex(emailRegex);

                if (!rg2.Match(i1.Text).Success)
                {
                    warningUserName.Visibility = Visibility.Visible;
                    i1.BorderBrush = (Brush)bc.ConvertFrom("#FF761616");
                    i1.BorderThickness = (Thickness)thic.ConvertFrom("3");
                    trasnformBtn.BorderBrush = (Brush)bc.ConvertFrom("#FF761616");
                    trasnformBtn.BorderThickness = (Thickness)thic.ConvertFrom("3");
                    return;
                }

                if (!rg3.Match(i2.Text).Success)
                {
                    warningForPassword.Visibility = Visibility.Visible;
                    i2.BorderBrush = (Brush)bc.ConvertFrom("#FF761616");
                    i2.BorderThickness = (Thickness)thic.ConvertFrom("3");
                    trasnformBtn.BorderBrush = (Brush)bc.ConvertFrom("#FF761616");
                    trasnformBtn.BorderThickness = (Thickness)thic.ConvertFrom("3");
                    return;
                }


                if (!rg.Match(i4.Text).Success)
                {
                    textWarningAddressStatePlaceOfBirth.Visibility = Visibility.Visible;
                    i4.BorderBrush = (Brush)bc.ConvertFrom("#FF761616");
                    i4.BorderThickness = (Thickness)thic.ConvertFrom("3");
                    trasnformBtn.BorderBrush = (Brush)bc.ConvertFrom("#FF761616");
                    trasnformBtn.BorderThickness = (Thickness)thic.ConvertFrom("3");
                    return;
                }

                if (!rg.Match(i5.Text).Success)
                {
                    textWarningAddressStatePlaceOfBirth.Visibility = Visibility.Visible;
                    i5.BorderBrush = (Brush)bc.ConvertFrom("#FF761616");
                    i5.BorderThickness = (Thickness)thic.ConvertFrom("3");
                    trasnformBtn.BorderBrush = (Brush)bc.ConvertFrom("#FF761616");
                    trasnformBtn.BorderThickness = (Thickness)thic.ConvertFrom("3");
                    return;
                }

                if (!rg4.Match(i6.Text).Success)
                {
                    textWarningEmail.Visibility = Visibility.Visible;
                    i6.BorderBrush = (Brush)bc.ConvertFrom("#FF761616");
                    i6.BorderThickness = (Thickness)thic.ConvertFrom("3");
                    trasnformBtn.BorderBrush = (Brush)bc.ConvertFrom("#FF761616");
                    trasnformBtn.BorderThickness = (Thickness)thic.ConvertFrom("3");
                    return;
                }
                //textWarning.Visibility = Visibility.Hidden;
                warningUserName.Visibility = Visibility.Hidden;
                warningForPassword.Visibility = Visibility.Hidden;
                textWarningAddressStatePlaceOfBirth.Visibility = Visibility.Hidden;
                textWarningEmail.Visibility = Visibility.Hidden;

                i1.BorderBrush = Brushes.Black;
                i1.BorderThickness = (Thickness)thic.ConvertFrom("1");
                i2.BorderBrush = Brushes.Black;
                i2.BorderThickness = (Thickness)thic.ConvertFrom("1");
                datePickerSchedule.BorderBrush = Brushes.Black;
                datePickerSchedule.BorderThickness = (Thickness)thic.ConvertFrom("1");
                i4.BorderBrush = Brushes.Black;
                i4.BorderThickness = (Thickness)thic.ConvertFrom("1");
                i5.BorderBrush = Brushes.Black;
                i5.BorderThickness = (Thickness)thic.ConvertFrom("1");
                i6.BorderBrush = Brushes.Black;
                i6.BorderThickness = (Thickness)thic.ConvertFrom("1");

                trasnformBtn.BorderBrush = Brushes.Black;
                trasnformBtn.BorderThickness = (Thickness)thic.ConvertFrom("1");

                //foreach (Pacijent p in Loading.pacijenti)
                //{
                //    if (i1.Text.Equals(p.Username))
                //    {
                //        Console.WriteLine("usao");
                //        textWarning9.Visibility = Visibility.Visible; // pacijent vec postoji
                //        return;
                //    }
                //    if (p == pacijent)
                //    {
                //        Console.WriteLine("Isto su");

                //        p.Username = i1.Text;
                //        p.Password = i2.Text;
                //        p.DateOfBirth = dateOfBirthLabel.Content.ToString();
                //        p.PlaceOfBirth = i4.Text;
                //        p.Country = i5.Text;
                //        p.Email = i6.Text;
                //        p.GuestAccount = false;
                //    }
                //}

                GridFillDataForTransformation.Children.Clear();
                usc = new Patient();
                GridFillDataForTransformation.Children.Add(usc);
                return;


            }
            else
            {

                textWarning.Visibility = Visibility.Visible;

                if (i1.Text.Equals(""))
                {
                    i1.BorderBrush = (Brush)bc.ConvertFrom("#FF761616");
                    i1.BorderThickness = (Thickness)thic.ConvertFrom("3");
                    trasnformBtn.BorderBrush = (Brush)bc.ConvertFrom("#FF761616");
                    trasnformBtn.BorderThickness = (Thickness)thic.ConvertFrom("3");
                }

                if (i2.Text.Equals(""))
                {
                    i2.BorderBrush = (Brush)bc.ConvertFrom("#FF761616");
                    i2.BorderThickness = (Thickness)thic.ConvertFrom("3");
                    trasnformBtn.BorderBrush = (Brush)bc.ConvertFrom("#FF761616");
                    trasnformBtn.BorderThickness = (Thickness)thic.ConvertFrom("3");
                }

                if (datePickerSchedule.Text.Equals(""))
                {
                    datePickerSchedule.BorderBrush = (Brush)bc.ConvertFrom("#FF761616");
                    datePickerSchedule.BorderThickness = (Thickness)thic.ConvertFrom("3");
                    trasnformBtn.BorderBrush = (Brush)bc.ConvertFrom("#FF761616");
                    trasnformBtn.BorderThickness = (Thickness)thic.ConvertFrom("3");
                }

                if (i4.Text.Equals(""))
                {
                    i4.BorderBrush = (Brush)bc.ConvertFrom("#FF761616");
                    i4.BorderThickness = (Thickness)thic.ConvertFrom("3");
                    trasnformBtn.BorderBrush = (Brush)bc.ConvertFrom("#FF761616");
                    trasnformBtn.BorderThickness = (Thickness)thic.ConvertFrom("3");
                }

                if (i5.Text.Equals(""))
                {
                    i5.BorderBrush = (Brush)bc.ConvertFrom("#FF761616");
                    i5.BorderThickness = (Thickness)thic.ConvertFrom("3");
                    trasnformBtn.BorderBrush = (Brush)bc.ConvertFrom("#FF761616");
                    trasnformBtn.BorderThickness = (Thickness)thic.ConvertFrom("3");
                }

                if (i6.Text.Equals(""))
                {
                    i6.BorderBrush = (Brush)bc.ConvertFrom("#FF761616");
                    i6.BorderThickness = (Thickness)thic.ConvertFrom("3");
                    trasnformBtn.BorderBrush = (Brush)bc.ConvertFrom("#FF761616");
                    trasnformBtn.BorderThickness = (Thickness)thic.ConvertFrom("3");
                }


            }

        }

        private void i1_TextChanged(object sender, TextChangedEventArgs e)
        {
            textWarning9.Visibility = Visibility.Hidden;
            warningUserName.Visibility = Visibility.Hidden;
            warningForPassword.Visibility = Visibility.Hidden;
            textWarningAddressStatePlaceOfBirth.Visibility = Visibility.Hidden;
            textWarningEmail.Visibility = Visibility.Hidden;
            if (!i1.Text.Equals(""))
            {
                textWarning.Visibility = Visibility.Hidden;
                i1.BorderBrush = Brushes.Black;
                var thic = new ThicknessConverter();
                i1.BorderThickness = (Thickness)thic.ConvertFrom("1");
                trasnformBtn.BorderBrush = Brushes.Black;
                trasnformBtn.BorderThickness = (Thickness)thic.ConvertFrom("1");
            }
        }

        private void i2_TextChanged(object sender, TextChangedEventArgs e)
        {
            textWarning9.Visibility = Visibility.Hidden;
            warningUserName.Visibility = Visibility.Hidden;
            warningForPassword.Visibility = Visibility.Hidden;
            textWarningAddressStatePlaceOfBirth.Visibility = Visibility.Hidden;
            textWarningEmail.Visibility = Visibility.Hidden;
            if (!i2.Text.Equals(""))
            {
                textWarning.Visibility = Visibility.Hidden;
                i2.BorderBrush = Brushes.Black;
                var thic = new ThicknessConverter();
                i2.BorderThickness = (Thickness)thic.ConvertFrom("1");
                trasnformBtn.BorderBrush = Brushes.Black;
                trasnformBtn.BorderThickness = (Thickness)thic.ConvertFrom("1");
            }
        }

        private void datePickerSchedule_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            textWarning9.Visibility = Visibility.Hidden;
            warningUserName.Visibility = Visibility.Hidden;
            warningForPassword.Visibility = Visibility.Hidden;
            textWarningAddressStatePlaceOfBirth.Visibility = Visibility.Hidden;
            textWarningEmail.Visibility = Visibility.Hidden;

            if (!datePickerSchedule.Text.Equals(""))
            {
                textWarning.Visibility = Visibility.Hidden;
                datePickerSchedule.BorderBrush = Brushes.Black;
                var thic = new ThicknessConverter();
                datePickerSchedule.BorderThickness = (Thickness)thic.ConvertFrom("1");
                trasnformBtn.BorderBrush = Brushes.Black;
                trasnformBtn.BorderThickness = (Thickness)thic.ConvertFrom("1");
            }
        }

        private void i4_TextChanged(object sender, TextChangedEventArgs e)
        {
            textWarning9.Visibility = Visibility.Hidden;
            warningUserName.Visibility = Visibility.Hidden;
            warningForPassword.Visibility = Visibility.Hidden;
            textWarningAddressStatePlaceOfBirth.Visibility = Visibility.Hidden;
            textWarningEmail.Visibility = Visibility.Hidden;
            if (!i4.Text.Equals(""))
            {
                textWarning.Visibility = Visibility.Hidden;
                i4.BorderBrush = Brushes.Black;
                var thic = new ThicknessConverter();
                i4.BorderThickness = (Thickness)thic.ConvertFrom("1");
                trasnformBtn.BorderBrush = Brushes.Black;
                trasnformBtn.BorderThickness = (Thickness)thic.ConvertFrom("1");
            }
        }

        private void i5_TextChanged(object sender, TextChangedEventArgs e)
        {
            textWarning9.Visibility = Visibility.Hidden;
            warningUserName.Visibility = Visibility.Hidden;
            warningForPassword.Visibility = Visibility.Hidden;
            textWarningAddressStatePlaceOfBirth.Visibility = Visibility.Hidden;
            textWarningEmail.Visibility = Visibility.Hidden;
            if (!i5.Text.Equals(""))
            {
                textWarning.Visibility = Visibility.Hidden;
                i5.BorderBrush = Brushes.Black;
                var thic = new ThicknessConverter();
                i5.BorderThickness = (Thickness)thic.ConvertFrom("1");
                trasnformBtn.BorderBrush = Brushes.Black;
                trasnformBtn.BorderThickness = (Thickness)thic.ConvertFrom("1");
            }
        }

        private void i6_TextChanged(object sender, TextChangedEventArgs e)
        {
            textWarning9.Visibility = Visibility.Hidden;
            warningUserName.Visibility = Visibility.Hidden;
            warningForPassword.Visibility = Visibility.Hidden;
            textWarningAddressStatePlaceOfBirth.Visibility = Visibility.Hidden;
            textWarningEmail.Visibility = Visibility.Hidden;
            if (!i6.Text.Equals(""))
            {
                textWarning.Visibility = Visibility.Hidden;
                i6.BorderBrush = Brushes.Black;
                var thic = new ThicknessConverter();
                i6.BorderThickness = (Thickness)thic.ConvertFrom("1");
                trasnformBtn.BorderBrush = Brushes.Black;
                trasnformBtn.BorderThickness = (Thickness)thic.ConvertFrom("1");
            }
        }
    }
}
