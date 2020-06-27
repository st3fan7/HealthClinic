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
    /// Interaction logic for CreatePatientAccount1.xaml
    /// </summary>
    public partial class CreatePatientAccount1 : UserControl
    {
        public CreatePatientAccount1()
        {
            InitializeComponent();
            textWarning.Visibility = Visibility.Hidden;
            textWarning2.Visibility = Visibility.Hidden;
            textWarning3.Visibility = Visibility.Hidden;
            textWarning4.Visibility = Visibility.Hidden;
            textWarning5.Visibility = Visibility.Hidden;
            textWarning6.Visibility = Visibility.Hidden;
            textWarning7.Visibility = Visibility.Hidden;
            textWarning8.Visibility = Visibility.Hidden;
            textWarning9.Visibility = Visibility.Hidden;

        }

        private void nextBtn_Click(object sender, RoutedEventArgs e)
        {
            UserControl usc = null;
            var bc = new BrushConverter();
            var thic = new ThicknessConverter();

            if (!i1.Text.Equals("") && !i2.Text.Equals("") && !i3.Text.Equals("") && !i4.Text.Equals("") && !i5.Text.Equals(""))
            {
                String nameRegex = @"[A-Z][a-zA-Z]{1,}";
                String usernameRegex = @"[a-zA-Z]{1,}";
                String addressRegex = @"[A-Z]+[a-z0-9A-Z,]+";
                String mobileRegex = @"([+][0-9]{3})?[0-9]{2,3}/[0-9]{3}-[0-9]{3,4}";
                String emailRegex = @"^([a-zA-Z0-9_\-\.]+)@([a-zA-Z0-9_\-\.]+)\.([a-zA-Z]{2,5})$";
                String passRegex = @"\S{8,22}";
                String idRegex = @"[0-9]{13}";
                Regex rg = new Regex(nameRegex);
                Regex rg2 = new Regex(mobileRegex);
                Regex rg3 = new Regex(addressRegex);
                Regex rg4 = new Regex(emailRegex);
                Regex rg5 = new Regex(passRegex);
                Regex rg6 = new Regex(usernameRegex);
                Regex rg7 = new Regex(idRegex);

                if (!rg6.Match(i1.Text).Success)
                {
                    textWarning7.Visibility = Visibility.Visible;
                    i1.BorderBrush = (Brush)bc.ConvertFrom("#FF761616");
                    i1.BorderThickness = (Thickness)thic.ConvertFrom("3");
                    nextBtn.BorderBrush = (Brush)bc.ConvertFrom("#FF761616");
                    nextBtn.BorderThickness = (Thickness)thic.ConvertFrom("3");
                    return;
                }


                if (!rg5.Match(i2.Text).Success)
                {
                    textWarning4.Visibility = Visibility.Visible;
                    i2.BorderBrush = (Brush)bc.ConvertFrom("#FF761616");
                    i2.BorderThickness = (Thickness)thic.ConvertFrom("3");
                    nextBtn.BorderBrush = (Brush)bc.ConvertFrom("#FF761616");
                    nextBtn.BorderThickness = (Thickness)thic.ConvertFrom("3");
                    return;
                }

                if (!rg.Match(i3.Text).Success)
                {
                    textWarning2.Visibility = Visibility.Visible;
                    i3.BorderBrush = (Brush)bc.ConvertFrom("#FF761616");
                    i3.BorderThickness = (Thickness)thic.ConvertFrom("3");
                    nextBtn.BorderBrush = (Brush)bc.ConvertFrom("#FF761616");
                    nextBtn.BorderThickness = (Thickness)thic.ConvertFrom("3");
                    return;
                }

                if (!rg.Match(i4.Text).Success)
                {
                    textWarning2.Visibility = Visibility.Visible;
                    i4.BorderBrush = (Brush)bc.ConvertFrom("#FF761616");
                    i4.BorderThickness = (Thickness)thic.ConvertFrom("3");
                    nextBtn.BorderBrush = (Brush)bc.ConvertFrom("#FF761616");
                    nextBtn.BorderThickness = (Thickness)thic.ConvertFrom("3");
                    return;
                }
                if (!rg7.Match(i5.Text).Success)
                {
                    textWarning8.Visibility = Visibility.Visible;
                    i5.BorderBrush = (Brush)bc.ConvertFrom("#FF761616");
                    i5.BorderThickness = (Thickness)thic.ConvertFrom("3");
                    nextBtn.BorderBrush = (Brush)bc.ConvertFrom("#FF761616");
                    nextBtn.BorderThickness = (Thickness)thic.ConvertFrom("3");
                    return;
                }
                textWarning7.Visibility = Visibility.Hidden;
                textWarning8.Visibility = Visibility.Hidden;
                textWarning4.Visibility = Visibility.Hidden;
                textWarning3.Visibility = Visibility.Hidden;
                textWarning2.Visibility = Visibility.Hidden;
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

                nextBtn.BorderBrush = Brushes.Black;
                nextBtn.BorderThickness = (Thickness)thic.ConvertFrom("1");

                //bool ima = false;
                //foreach (Pacijent pacijent in Loading.pacijenti)
                //{
                //    if (i1.Text.Equals(pacijent.Username) || i5.Text.Equals(pacijent.Id))
                //    {

                //        ima = true;

                //    }

                //}

                //if (!ima)
                //{
                //    pacijent.Username = i1.Text;
                //    pacijent.Password = i2.Text;
                //    pacijent.Name = i3.Text;
                //    pacijent.Surname = i4.Text;
                //    pacijent.Id = i5.Text;
                //    pacijent.DateOfBirth = "";
                //    pacijent.PlaceOfBirth = "";
                //    pacijent.Country = "";
                //    pacijent.Address = "";
                //    pacijent.MobilePhone = "";
                //    pacijent.Email = "";

                GridPatientAccount1.Children.Clear();
                usc = new CreatePatientAccount2();
                GridPatientAccount1.Children.Add(usc);
                //} else
                //{
                //    textWarning9.Visibility = Visibility.Visible;
                //}


            }
            else
            {

                textWarning.Visibility = Visibility.Visible;

                if (i1.Text.Equals(""))
                {
                    i1.BorderBrush = (Brush)bc.ConvertFrom("#FF761616");
                    i1.BorderThickness = (Thickness)thic.ConvertFrom("3");
                    nextBtn.BorderBrush = (Brush)bc.ConvertFrom("#FF761616");
                    nextBtn.BorderThickness = (Thickness)thic.ConvertFrom("3");
                }

                if (i2.Text.Equals(""))
                {
                    i2.BorderBrush = (Brush)bc.ConvertFrom("#FF761616");
                    i2.BorderThickness = (Thickness)thic.ConvertFrom("3");
                    nextBtn.BorderBrush = (Brush)bc.ConvertFrom("#FF761616");
                    nextBtn.BorderThickness = (Thickness)thic.ConvertFrom("3");
                }

                if (i3.Text.Equals(""))
                {
                    i3.BorderBrush = (Brush)bc.ConvertFrom("#FF761616");
                    i3.BorderThickness = (Thickness)thic.ConvertFrom("3");
                    nextBtn.BorderBrush = (Brush)bc.ConvertFrom("#FF761616");
                    nextBtn.BorderThickness = (Thickness)thic.ConvertFrom("3");
                }


                if (i4.Text.Equals(""))
                {
                    i4.BorderBrush = (Brush)bc.ConvertFrom("#FF761616");
                    i4.BorderThickness = (Thickness)thic.ConvertFrom("3");
                    nextBtn.BorderBrush = (Brush)bc.ConvertFrom("#FF761616");
                    nextBtn.BorderThickness = (Thickness)thic.ConvertFrom("3");
                }

                if (i5.Text.Equals(""))
                {
                    i5.BorderBrush = (Brush)bc.ConvertFrom("#FF761616");
                    i5.BorderThickness = (Thickness)thic.ConvertFrom("3");
                    nextBtn.BorderBrush = (Brush)bc.ConvertFrom("#FF761616");
                    nextBtn.BorderThickness = (Thickness)thic.ConvertFrom("3");
                }


            }
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            GridPatientAccount1.Children.Clear();
            UserControl usc = new PatientView();
            GridPatientAccount1.Children.Add(usc);
        }

        private void homeBtn2_Click(object sender, RoutedEventArgs e)
        {

            GridPatientAccount1.Children.Clear();
            UserControl usc = new Home();
            GridPatientAccount1.Children.Add(usc);
        }

        private void scheduleBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridPatientAccount1.Children.Clear();
            UserControl usc = new Schedule();
            GridPatientAccount1.Children.Add(usc);

        }

        private void patienstBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridPatientAccount1.Children.Clear();
            UserControl usc = new PatientView();
            GridPatientAccount1.Children.Add(usc);
        }


        private void settingsBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridPatientAccount1.Children.Clear();
            UserControl usc = new Settings();
            GridPatientAccount1.Children.Add(usc);
        }

        private void reportBtn_Click(object sender, RoutedEventArgs e)
        {
            GridPatientAccount1.Children.Clear();
            UserControl usc = new Report();
            GridPatientAccount1.Children.Add(usc);
        }
        private void i1_TextChanged(object sender, TextChangedEventArgs e)
        {
            textWarning9.Visibility = Visibility.Hidden;
            textWarning8.Visibility = Visibility.Hidden; 
            textWarning7.Visibility = Visibility.Hidden;
            textWarning5.Visibility = Visibility.Hidden;
            textWarning6.Visibility = Visibility.Hidden;
            textWarning4.Visibility = Visibility.Hidden;
            textWarning2.Visibility = Visibility.Hidden;
            textWarning3.Visibility = Visibility.Hidden;
            if (!i1.Text.Equals(""))
            {
                textWarning.Visibility = Visibility.Hidden;
                i1.BorderBrush = Brushes.Black;
                var thic = new ThicknessConverter();
                i1.BorderThickness = (Thickness)thic.ConvertFrom("1");
                nextBtn.BorderBrush = Brushes.Black;
                nextBtn.BorderThickness = (Thickness)thic.ConvertFrom("1");
            }
        }

        private void i2_TextChanged(object sender, TextChangedEventArgs e)
        {
            textWarning9.Visibility = Visibility.Hidden;
            textWarning8.Visibility = Visibility.Hidden;
            textWarning7.Visibility = Visibility.Hidden;
            textWarning5.Visibility = Visibility.Hidden;
            textWarning6.Visibility = Visibility.Hidden;
            textWarning4.Visibility = Visibility.Hidden;
            textWarning2.Visibility = Visibility.Hidden;
            textWarning3.Visibility = Visibility.Hidden;
            if (!i2.Text.Equals(""))
            {
                textWarning.Visibility = Visibility.Hidden;
                i2.BorderBrush = Brushes.Black;
                var thic = new ThicknessConverter();
                i2.BorderThickness = (Thickness)thic.ConvertFrom("1");
                nextBtn.BorderBrush = Brushes.Black;
                nextBtn.BorderThickness = (Thickness)thic.ConvertFrom("1");
            }
        }

        private void i3_TextChanged(object sender, TextChangedEventArgs e)
        {
            textWarning9.Visibility = Visibility.Hidden;
            textWarning8.Visibility = Visibility.Hidden;
            textWarning7.Visibility = Visibility.Hidden;
            textWarning5.Visibility = Visibility.Hidden;
            textWarning6.Visibility = Visibility.Hidden;
            textWarning4.Visibility = Visibility.Hidden;
            textWarning2.Visibility = Visibility.Hidden;
            textWarning3.Visibility = Visibility.Hidden;
            if (!i3.Text.Equals(""))
            {
                textWarning.Visibility = Visibility.Hidden;
                i3.BorderBrush = Brushes.Black;
                var thic = new ThicknessConverter();
                i3.BorderThickness = (Thickness)thic.ConvertFrom("1");
                nextBtn.BorderBrush = Brushes.Black;
                nextBtn.BorderThickness = (Thickness)thic.ConvertFrom("1");
            }
        }

        private void i4_TextChanged(object sender, TextChangedEventArgs e)
        {
            textWarning9.Visibility = Visibility.Hidden;
            textWarning8.Visibility = Visibility.Hidden;
            textWarning7.Visibility = Visibility.Hidden;
            textWarning5.Visibility = Visibility.Hidden;
            textWarning6.Visibility = Visibility.Hidden;
            textWarning4.Visibility = Visibility.Hidden;
            textWarning2.Visibility = Visibility.Hidden;
            textWarning3.Visibility = Visibility.Hidden;
            if (!i4.Text.Equals(""))
            {
                textWarning.Visibility = Visibility.Hidden;
                i4.BorderBrush = Brushes.Black;
                var thic = new ThicknessConverter();
                i4.BorderThickness = (Thickness)thic.ConvertFrom("1");
                nextBtn.BorderBrush = Brushes.Black;
                nextBtn.BorderThickness = (Thickness)thic.ConvertFrom("1");
            }
        }

        private void i5_TextChanged(object sender, TextChangedEventArgs e)
        {
            textWarning9.Visibility = Visibility.Hidden;
            textWarning8.Visibility = Visibility.Hidden;
            textWarning7.Visibility = Visibility.Hidden;
            textWarning5.Visibility = Visibility.Hidden;
            textWarning6.Visibility = Visibility.Hidden;
            textWarning4.Visibility = Visibility.Hidden;
            textWarning2.Visibility = Visibility.Hidden;
            textWarning3.Visibility = Visibility.Hidden;
            if (!i5.Text.Equals(""))
            {
                textWarning.Visibility = Visibility.Hidden;
                i5.BorderBrush = Brushes.Black;
                var thic = new ThicknessConverter();
                i5.BorderThickness = (Thickness)thic.ConvertFrom("1");
                nextBtn.BorderBrush = Brushes.Black;
                nextBtn.BorderThickness = (Thickness)thic.ConvertFrom("1");
            }
        }
    }
}
