using Controller.UsersControlers;
using HealthClinic.View.Dialogues;
using Model.AllActors;
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
        Patient patient = new Patient();

        private readonly UserController userController;

        public FillDataForTransformation(Patient p)
        {
            InitializeComponent();
            patient = p;
            textWarning.Visibility = Visibility.Hidden;
            warningUserName.Visibility = Visibility.Hidden;
            warningForPassword.Visibility = Visibility.Hidden;
            textWarningAddressStatePlaceOfBirth.Visibility = Visibility.Hidden;
            textWarningEmail.Visibility = Visibility.Hidden;
            textWarning9.Visibility = Visibility.Hidden;

            var app = Application.Current as App;
            userController = app.UserController;
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
            UserControl usc = new PatientView();
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

            if (!i1.Text.Equals("") && !i2.Text.Equals("") && !i3.Text.Equals("") && !i4.Text.Equals("") && !i5.Text.Equals("") && !i6.Text.Equals("") )
            {
                String textWarningAddressStatePlaceOfBirthRegex = @"[A-Z][a-zA-Z,]{1,}";
                String emailRegex = @"^([a-zA-Z0-9_\-\.]+)@([a-zA-Z0-9_\-\.]+)\.([a-zA-Z]{2,5})$";
                String usernameRegex = @"[a-zA-Z]{1,}";
                String passRegex = @"\S{3,22}";


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

                if (!rg.Match(i3.Text).Success)
                {
                    textWarningAddressStatePlaceOfBirth.Visibility = Visibility.Visible;
                    i3.BorderBrush = (Brush)bc.ConvertFrom("#FF761616");
                    i3.BorderThickness = (Thickness)thic.ConvertFrom("3");
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
                i3.BorderBrush = Brushes.Black;
                i3.BorderThickness = (Thickness)thic.ConvertFrom("1");
                i4.BorderBrush = Brushes.Black;
                i4.BorderThickness = (Thickness)thic.ConvertFrom("1");
                i5.BorderBrush = Brushes.Black;
                i5.BorderThickness = (Thickness)thic.ConvertFrom("1");
                i6.BorderBrush = Brushes.Black;
                i6.BorderThickness = (Thickness)thic.ConvertFrom("1");

                trasnformBtn.BorderBrush = Brushes.Black;
                trasnformBtn.BorderThickness = (Thickness)thic.ConvertFrom("1");

                patient.UserName = i1.Text;
                patient.Password = i2.Text;
                patient.City.Name = i3.Text;
                patient.City.Adress = i4.Text;
                patient.City.Country.Name = i5.Text;
                patient.EMail = i6.Text;
                patient.GuestAccount = false;

                userController.UpdateEntity(patient);

                GridFillDataForTransformation.Children.Clear();
                usc = new PatientView();
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

                if (i3.Text.Equals(""))
                {
                    i3.BorderBrush = (Brush)bc.ConvertFrom("#FF761616");
                    i3.BorderThickness = (Thickness)thic.ConvertFrom("3");
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

        private void i3_TextChanged(object sender, TextChangedEventArgs e)
        {
            textWarning9.Visibility = Visibility.Hidden;
            warningUserName.Visibility = Visibility.Hidden;
            warningForPassword.Visibility = Visibility.Hidden;
            textWarningAddressStatePlaceOfBirth.Visibility = Visibility.Hidden;
            textWarningEmail.Visibility = Visibility.Hidden;
            if (!i3.Text.Equals(""))
            {
                textWarning.Visibility = Visibility.Hidden;
                i3.BorderBrush = Brushes.Black;
                var thic = new ThicknessConverter();
                i3.BorderThickness = (Thickness)thic.ConvertFrom("1");
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
