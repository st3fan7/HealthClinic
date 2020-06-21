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
    /// Interaction logic for ChangePatientAccount.xaml
    /// </summary>
    public partial class ChangePatientAccount : UserControl
    {
        public ChangePatientAccount()
        {
            InitializeComponent();
            //pacijent = p;
            textWarning.Visibility = Visibility.Hidden;
            textWarning2.Visibility = Visibility.Hidden;
            textWarning3.Visibility = Visibility.Hidden;
            textWarning4.Visibility = Visibility.Hidden;
            textWarning5.Visibility = Visibility.Hidden;
            textWarning6.Visibility = Visibility.Hidden;

            //if(pacijent.GuestAccount == false)
            //{
            //    i1.Text = p.Password;
            //    i1.CaretIndex = p.Password.Length;
            //    i1.ScrollToHorizontalOffset(double.MaxValue);

            //    i4.Text = p.Country;
            //    i4.CaretIndex = p.Country.Length;
            //    i4.ScrollToHorizontalOffset(double.MaxValue);


            //    i7.Text = p.Email;
            //    i7.CaretIndex = p.Email.Length;
            //    i7.ScrollToHorizontalOffset(double.MaxValue);
            //}



            //i2.Text = p.Name;
            //i2.CaretIndex = p.Name.Length;
            //i2.ScrollToHorizontalOffset(double.MaxValue);

            //i3.Text = p.Surname;
            //i3.CaretIndex = p.Surname.Length;
            //i3.ScrollToHorizontalOffset(double.MaxValue);

            //i5.Text = p.Address;
            //i5.CaretIndex = p.Address.Length;
            //i5.ScrollToHorizontalOffset(double.MaxValue);

            //i6.Text = p.MobilePhone;
            //i6.CaretIndex = p.MobilePhone.Length;
            //i6.ScrollToHorizontalOffset(double.MaxValue);

        }

        public void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.Text = string.Empty;
            tb.GotFocus -= TextBox_GotFocus;
        }

        private void homeBtn2_Click(object sender, RoutedEventArgs e)
        {

            GridChangePatientAccount.Children.Clear();
            UserControl usc = new Home();
            GridChangePatientAccount.Children.Add(usc);
        }

        private void scheduleBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridChangePatientAccount.Children.Clear();
            UserControl usc = new Schedule();
            GridChangePatientAccount.Children.Add(usc);

        }

        private void patienstBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridChangePatientAccount.Children.Clear();
            UserControl usc = new Patient();
            GridChangePatientAccount.Children.Add(usc);
        }

        private void settingsBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridChangePatientAccount.Children.Clear();
            UserControl usc = new Settings();
            GridChangePatientAccount.Children.Add(usc);
        }

        private void reportBtn_Click(object sender, RoutedEventArgs e)
        {
            GridChangePatientAccount.Children.Clear();
            UserControl usc = new Report();
            GridChangePatientAccount.Children.Add(usc);
        }


        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            GridChangePatientAccount.Children.Clear();
            UserControl usc = new ManipulationOptions();
            GridChangePatientAccount.Children.Add(usc);
        }

        private void changeBtn_Click(object sender, RoutedEventArgs e)
        {
            //GridChangePatientAccount.Children.Clear();
            //UserControl usc = new ManipulationOptions(null);
            //GridChangePatientAccount.Children.Add(usc);
            UserControl usc = null;
            var bc = new BrushConverter();
            var thic = new ThicknessConverter();
            //if(pacijent.GuestAccount == false)
            //{
            //    if (!i1.Text.Equals("") && !i2.Text.Equals("") && !i3.Text.Equals("") && !i4.Text.Equals("") && !i5.Text.Equals("") && !i6.Text.Equals("") && !i7.Text.Equals(""))
            //    {
            //        String nameRegex = @"[A-Z][a-zA-Z]{1,}";
            //        String addressRegex = @"[A-Z]+[a-z0-9A-Z,]+";
            //        String mobileRegex = @"([+][0-9]{3})?[0-9]{2,3}/[0-9]{3}-[0-9]{3,4}";
            //        String emailRegex = @"^([a-zA-Z0-9_\-\.]+)@([a-zA-Z0-9_\-\.]+)\.([a-zA-Z]{2,5})$";
            //        String passRegex = @"\S{8,22}";
            //        Regex rg = new Regex(nameRegex);
            //        Regex rg2 = new Regex(mobileRegex);
            //        Regex rg3 = new Regex(addressRegex);
            //        Regex rg4 = new Regex(emailRegex);
            //        Regex rg5 = new Regex(passRegex);

            //        if (!rg5.Match(i1.Text).Success)
            //        {
            //            textWarning4.Visibility = Visibility.Visible;
            //            i1.BorderBrush = (Brush)bc.ConvertFrom("#FF761616");
            //            i1.BorderThickness = (Thickness)thic.ConvertFrom("3");
            //            changeBtn.BorderBrush = (Brush)bc.ConvertFrom("#FF761616");
            //            changeBtn.BorderThickness = (Thickness)thic.ConvertFrom("3");
            //            return;
            //        }

            //        if (!rg.Match(i2.Text).Success)
            //        {
            //            Console.WriteLine("Usao");
            //            textWarning2.Visibility = Visibility.Visible;
            //            i2.BorderBrush = (Brush)bc.ConvertFrom("#FF761616");
            //            i2.BorderThickness = (Thickness)thic.ConvertFrom("3");
            //            changeBtn.BorderBrush = (Brush)bc.ConvertFrom("#FF761616");
            //            changeBtn.BorderThickness = (Thickness)thic.ConvertFrom("3");
            //            return;
            //        }

            //        if (!rg.Match(i3.Text).Success)
            //        {
            //            textWarning2.Visibility = Visibility.Visible;
            //            i3.BorderBrush = (Brush)bc.ConvertFrom("#FF761616");
            //            i3.BorderThickness = (Thickness)thic.ConvertFrom("3");
            //            changeBtn.BorderBrush = (Brush)bc.ConvertFrom("#FF761616");
            //            changeBtn.BorderThickness = (Thickness)thic.ConvertFrom("3");
            //            return;
            //        }
            //        if (!rg.Match(i4.Text).Success)
            //        {
            //            textWarning2.Visibility = Visibility.Visible;
            //            i4.BorderBrush = (Brush)bc.ConvertFrom("#FF761616");
            //            i4.BorderThickness = (Thickness)thic.ConvertFrom("3");
            //            changeBtn.BorderBrush = (Brush)bc.ConvertFrom("#FF761616");
            //            changeBtn.BorderThickness = (Thickness)thic.ConvertFrom("3");
            //            return;
            //        }
            //        if (!rg3.Match(i5.Text).Success)
            //        {
            //            textWarning5.Visibility = Visibility.Visible;
            //            i5.BorderBrush = (Brush)bc.ConvertFrom("#FF761616");
            //            i5.BorderThickness = (Thickness)thic.ConvertFrom("3");
            //            changeBtn.BorderBrush = (Brush)bc.ConvertFrom("#FF761616");
            //            changeBtn.BorderThickness = (Thickness)thic.ConvertFrom("3");
            //            return;
            //        }

            //        if (!rg2.Match(i6.Text).Success)
            //        {
            //            textWarning3.Visibility = Visibility.Visible;
            //            i6.BorderBrush = (Brush)bc.ConvertFrom("#FF761616");
            //            i6.BorderThickness = (Thickness)thic.ConvertFrom("3");
            //            changeBtn.BorderBrush = (Brush)bc.ConvertFrom("#FF761616");
            //            changeBtn.BorderThickness = (Thickness)thic.ConvertFrom("3");
            //            return;
            //        }

            //        if (!rg4.Match(i7.Text).Success)
            //        {
            //            textWarning6.Visibility = Visibility.Visible;
            //            i7.BorderBrush = (Brush)bc.ConvertFrom("#FF761616");
            //            i7.BorderThickness = (Thickness)thic.ConvertFrom("3");
            //            changeBtn.BorderBrush = (Brush)bc.ConvertFrom("#FF761616");
            //            changeBtn.BorderThickness = (Thickness)thic.ConvertFrom("3");
            //            return;
            //        }



            //        textWarning4.Visibility = Visibility.Hidden;
            //        textWarning3.Visibility = Visibility.Hidden;
            //        textWarning2.Visibility = Visibility.Hidden;
            //        i1.BorderBrush = Brushes.Black;
            //        i1.BorderThickness = (Thickness)thic.ConvertFrom("1");
            //        i2.BorderBrush = Brushes.Black;
            //        i2.BorderThickness = (Thickness)thic.ConvertFrom("1");
            //        i3.BorderBrush = Brushes.Black;
            //        i3.BorderThickness = (Thickness)thic.ConvertFrom("1");
            //        i4.BorderBrush = Brushes.Black;
            //        i4.BorderThickness = (Thickness)thic.ConvertFrom("1");
            //        i5.BorderBrush = Brushes.Black;
            //        i5.BorderThickness = (Thickness)thic.ConvertFrom("1");
            //        i6.BorderBrush = Brushes.Black;
            //        i6.BorderThickness = (Thickness)thic.ConvertFrom("1");
            //        i7.BorderBrush = Brushes.Black;
            //        i7.BorderThickness = (Thickness)thic.ConvertFrom("1");

            //        changeBtn.BorderBrush = Brushes.Black;
            //        changeBtn.BorderThickness = (Thickness)thic.ConvertFrom("1");


            //        pacijent.Password = i1.Text;
            //        pacijent.Name = i2.Text;
            //        pacijent.Surname = i3.Text;
            //        pacijent.Country = i4.Text;
            //        pacijent.Address = i5.Text;
            //        pacijent.MobilePhone = i6.Text;
            //        pacijent.Email = i7.Text;


            //        usc = new ManipulationOptions(pacijent);
            //        GridChangePatientAccount.Children.Add(usc);
            //    }
            //    else
            //    {

            //        textWarning.Visibility = Visibility.Visible;

            //        if (i1.Text.Equals(""))
            //        {
            //            i1.BorderBrush = (Brush)bc.ConvertFrom("#FF761616");
            //            i1.BorderThickness = (Thickness)thic.ConvertFrom("3");
            //            changeBtn.BorderBrush = (Brush)bc.ConvertFrom("#FF761616");
            //            changeBtn.BorderThickness = (Thickness)thic.ConvertFrom("3");
            //        }

            //        if (i2.Text.Equals(""))
            //        {
            //            i2.BorderBrush = (Brush)bc.ConvertFrom("#FF761616");
            //            i2.BorderThickness = (Thickness)thic.ConvertFrom("3");
            //            changeBtn.BorderBrush = (Brush)bc.ConvertFrom("#FF761616");
            //            changeBtn.BorderThickness = (Thickness)thic.ConvertFrom("3");
            //        }

            //        if (i3.Text.Equals(""))
            //        {
            //            i3.BorderBrush = (Brush)bc.ConvertFrom("#FF761616");
            //            i3.BorderThickness = (Thickness)thic.ConvertFrom("3");
            //            changeBtn.BorderBrush = (Brush)bc.ConvertFrom("#FF761616");
            //            changeBtn.BorderThickness = (Thickness)thic.ConvertFrom("3");
            //        }


            //        if (i4.Text.Equals(""))
            //        {
            //            i4.BorderBrush = (Brush)bc.ConvertFrom("#FF761616");
            //            i4.BorderThickness = (Thickness)thic.ConvertFrom("3");
            //            changeBtn.BorderBrush = (Brush)bc.ConvertFrom("#FF761616");
            //            changeBtn.BorderThickness = (Thickness)thic.ConvertFrom("3");
            //        }

            //        if (i5.Text.Equals(""))
            //        {
            //            i5.BorderBrush = (Brush)bc.ConvertFrom("#FF761616");
            //            i5.BorderThickness = (Thickness)thic.ConvertFrom("3");
            //            changeBtn.BorderBrush = (Brush)bc.ConvertFrom("#FF761616");
            //            changeBtn.BorderThickness = (Thickness)thic.ConvertFrom("3");
            //        }

            //        if (i6.Text.Equals(""))
            //        {
            //            i6.BorderBrush = (Brush)bc.ConvertFrom("#FF761616");
            //            i6.BorderThickness = (Thickness)thic.ConvertFrom("3");
            //            changeBtn.BorderBrush = (Brush)bc.ConvertFrom("#FF761616");
            //            changeBtn.BorderThickness = (Thickness)thic.ConvertFrom("3");
            //        }


            //        if (i7.Text.Equals(""))
            //        {
            //            i7.BorderBrush = (Brush)bc.ConvertFrom("#FF761616");
            //            i7.BorderThickness = (Thickness)thic.ConvertFrom("3");
            //            changeBtn.BorderBrush = (Brush)bc.ConvertFrom("#FF761616");
            //            changeBtn.BorderThickness = (Thickness)thic.ConvertFrom("3");
            //        }


            //    }
            //} else
            //{
            //    // GUEST ACCOUNT
            //    i1.IsReadOnly = true;
            //    i4.IsReadOnly = true;
            //    i7.IsReadOnly = true;

            //    if ( !i2.Text.Equals("") && !i3.Text.Equals("") &&  !i5.Text.Equals("") && !i6.Text.Equals(""))
            //    {
            //        String nameRegex = @"[A-Z][a-zA-Z]{1,}";
            //        String addressRegex = @"[A-Z]+[a-z0-9A-Z,]+";
            //        String mobileRegex = @"([+][0-9]{3})?[0-9]{2,3}/[0-9]{3}-[0-9]{3,4}";
            //        Regex rg = new Regex(nameRegex);
            //        Regex rg2 = new Regex(mobileRegex);
            //        Regex rg3 = new Regex(addressRegex);



            //        if (!rg.Match(i2.Text).Success)
            //        {
            //            Console.WriteLine("Usao");
            //            textWarning2.Visibility = Visibility.Visible;
            //            i2.BorderBrush = (Brush)bc.ConvertFrom("#FF761616");
            //            i2.BorderThickness = (Thickness)thic.ConvertFrom("3");
            //            changeBtn.BorderBrush = (Brush)bc.ConvertFrom("#FF761616");
            //            changeBtn.BorderThickness = (Thickness)thic.ConvertFrom("3");
            //            return;
            //        }

            //        if (!rg.Match(i3.Text).Success)
            //        {
            //            textWarning2.Visibility = Visibility.Visible;
            //            i3.BorderBrush = (Brush)bc.ConvertFrom("#FF761616");
            //            i3.BorderThickness = (Thickness)thic.ConvertFrom("3");
            //            changeBtn.BorderBrush = (Brush)bc.ConvertFrom("#FF761616");
            //            changeBtn.BorderThickness = (Thickness)thic.ConvertFrom("3");
            //            return;
            //        }

            //        if (!rg3.Match(i5.Text).Success)
            //        {
            //            textWarning5.Visibility = Visibility.Visible;
            //            i5.BorderBrush = (Brush)bc.ConvertFrom("#FF761616");
            //            i5.BorderThickness = (Thickness)thic.ConvertFrom("3");
            //            changeBtn.BorderBrush = (Brush)bc.ConvertFrom("#FF761616");
            //            changeBtn.BorderThickness = (Thickness)thic.ConvertFrom("3");
            //            return;
            //        }

            //        if (!rg2.Match(i6.Text).Success)
            //        {
            //            textWarning3.Visibility = Visibility.Visible;
            //            i6.BorderBrush = (Brush)bc.ConvertFrom("#FF761616");
            //            i6.BorderThickness = (Thickness)thic.ConvertFrom("3");
            //            changeBtn.BorderBrush = (Brush)bc.ConvertFrom("#FF761616");
            //            changeBtn.BorderThickness = (Thickness)thic.ConvertFrom("3");
            //            return;
            //        }



            //        textWarning3.Visibility = Visibility.Hidden;
            //        textWarning2.Visibility = Visibility.Hidden;
            //        i2.BorderBrush = Brushes.Black;
            //        i2.BorderThickness = (Thickness)thic.ConvertFrom("1");
            //        i3.BorderBrush = Brushes.Black;
            //        i3.BorderThickness = (Thickness)thic.ConvertFrom("1");
            //        i5.BorderBrush = Brushes.Black;
            //        i5.BorderThickness = (Thickness)thic.ConvertFrom("1");
            //        i6.BorderBrush = Brushes.Black;
            //        i6.BorderThickness = (Thickness)thic.ConvertFrom("1");


            //        changeBtn.BorderBrush = Brushes.Black;
            //        changeBtn.BorderThickness = (Thickness)thic.ConvertFrom("1");


            //        pacijent.Name = i2.Text;
            //        pacijent.Surname = i3.Text;
            //        pacijent.Address = i5.Text;
            //        pacijent.MobilePhone = i6.Text;

            usc = new ManipulationOptions();
            GridChangePatientAccount.Children.Add(usc);
            //    }
            //    else
            //    {

            //        textWarning.Visibility = Visibility.Visible;


            //        if (i2.Text.Equals(""))
            //        {
            //            i2.BorderBrush = (Brush)bc.ConvertFrom("#FF761616");
            //            i2.BorderThickness = (Thickness)thic.ConvertFrom("3");
            //            changeBtn.BorderBrush = (Brush)bc.ConvertFrom("#FF761616");
            //            changeBtn.BorderThickness = (Thickness)thic.ConvertFrom("3");
            //        }

            //        if (i3.Text.Equals(""))
            //        {
            //            i3.BorderBrush = (Brush)bc.ConvertFrom("#FF761616");
            //            i3.BorderThickness = (Thickness)thic.ConvertFrom("3");
            //            changeBtn.BorderBrush = (Brush)bc.ConvertFrom("#FF761616");
            //            changeBtn.BorderThickness = (Thickness)thic.ConvertFrom("3");
            //        }


            //        if (i5.Text.Equals(""))
            //        {
            //            i5.BorderBrush = (Brush)bc.ConvertFrom("#FF761616");
            //            i5.BorderThickness = (Thickness)thic.ConvertFrom("3");
            //            changeBtn.BorderBrush = (Brush)bc.ConvertFrom("#FF761616");
            //            changeBtn.BorderThickness = (Thickness)thic.ConvertFrom("3");
            //        }

            //        if (i6.Text.Equals(""))
            //        {
            //            i6.BorderBrush = (Brush)bc.ConvertFrom("#FF761616");
            //            i6.BorderThickness = (Thickness)thic.ConvertFrom("3");
            //            changeBtn.BorderBrush = (Brush)bc.ConvertFrom("#FF761616");
            //            changeBtn.BorderThickness = (Thickness)thic.ConvertFrom("3");
            //        }


            //    }
            //}


        }

        private void i1_TextChanged(object sender, TextChangedEventArgs e)
        {
            //if(pacijent.GuestAccount == true)
            //{
            //    if (!i1.Text.Equals(""))
            //    {
            //        i1.Text = "";
            //    }
            //}

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
                changeBtn.BorderBrush = Brushes.Black;
                changeBtn.BorderThickness = (Thickness)thic.ConvertFrom("1");
            }
        }

        private void i2_TextChanged(object sender, TextChangedEventArgs e)
        {
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
                changeBtn.BorderBrush = Brushes.Black;
                changeBtn.BorderThickness = (Thickness)thic.ConvertFrom("1");
            }
        }

        private void i3_TextChanged(object sender, TextChangedEventArgs e)
        {
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
                changeBtn.BorderBrush = Brushes.Black;
                changeBtn.BorderThickness = (Thickness)thic.ConvertFrom("1");
            }
        }

        private void i4_TextChanged(object sender, TextChangedEventArgs e)
        {

            //if (pacijent.GuestAccount == true)
            //{
            //    if (!i4.Text.Equals(""))
            //    {
            //        i4.Text = "";
            //    }
            //}
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
                changeBtn.BorderBrush = Brushes.Black;
                changeBtn.BorderThickness = (Thickness)thic.ConvertFrom("1");
            }
        }

        private void i5_TextChanged(object sender, TextChangedEventArgs e)
        {
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
                changeBtn.BorderBrush = Brushes.Black;
                changeBtn.BorderThickness = (Thickness)thic.ConvertFrom("1");
            }
        }

        private void i6_TextChanged(object sender, TextChangedEventArgs e)
        {
            textWarning5.Visibility = Visibility.Hidden;
            textWarning6.Visibility = Visibility.Hidden;
            textWarning4.Visibility = Visibility.Hidden;
            textWarning2.Visibility = Visibility.Hidden;
            textWarning3.Visibility = Visibility.Hidden;
            if (!i6.Text.Equals(""))
            {
                textWarning.Visibility = Visibility.Hidden;
                i6.BorderBrush = Brushes.Black;
                var thic = new ThicknessConverter();
                i6.BorderThickness = (Thickness)thic.ConvertFrom("1");
                changeBtn.BorderBrush = Brushes.Black;
                changeBtn.BorderThickness = (Thickness)thic.ConvertFrom("1");
            }
        }

        private void i7_TextChanged(object sender, TextChangedEventArgs e)
        {
            //if (pacijent.GuestAccount == true)
            //{
            //    if (!i7.Text.Equals(""))
            //    {
            //        i7.Text = "";
            //    }
            //}
            textWarning5.Visibility = Visibility.Hidden;
            textWarning6.Visibility = Visibility.Hidden;
            textWarning4.Visibility = Visibility.Hidden;
            textWarning2.Visibility = Visibility.Hidden;
            textWarning3.Visibility = Visibility.Hidden;
            if (!i7.Text.Equals(""))
            {
                textWarning.Visibility = Visibility.Hidden;
                i7.BorderBrush = Brushes.Black;
                var thic = new ThicknessConverter();
                i7.BorderThickness = (Thickness)thic.ConvertFrom("1");
                changeBtn.BorderBrush = Brushes.Black;
                changeBtn.BorderThickness = (Thickness)thic.ConvertFrom("1");
            }

        }
    }
}
