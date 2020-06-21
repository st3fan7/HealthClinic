using HealthClinic.View;
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

namespace HealthClinic
{
    /// <summary>
    /// Interaction logic for UserControlForgotPassword.xaml
    /// </summary>
    public partial class UserControlForgotPassword : UserControl
    {
        public UserControlForgotPassword()
        {
            InitializeComponent();
            textWarningUsername.Visibility = textWarningHidden;
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            (this.Parent as Panel).Children.Remove(this);
        }

        private void confirmBtn_Click(object sender, RoutedEventArgs e)
        {
            //foreach(Secretary secretary in MainWindow.secreatries)
            //{
            //    if (usernameTextBox.Text.Equals(secretary.Username))
            //    {
            //        textWarningUsername.Visibility = textWarningHidden;
            //        UserControl usc = new NotificationForPassword();
            //        (this.Parent as Panel).Children.Add(usc);
            //    } else
            //    {
            //        var bc = new BrushConverter();
            //        var thic = new ThicknessConverter();
            //        textWarningUsername.Visibility = textWarningVisible;
            //        usernameTextBox.BorderBrush = (Brush)bc.ConvertFrom("#FF761616");
            //        usernameTextBox.BorderThickness = (Thickness)thic.ConvertFrom("3");
            //        confirmBtn.BorderBrush = (Brush)bc.ConvertFrom("#FF761616");
            //        confirmBtn.BorderThickness = (Thickness)thic.ConvertFrom("3");
            //    }
            //}
        }

        private Visibility textWarningVisible
        {
            get { return Visibility.Visible; }
        }
        private Visibility textWarningHidden
        {
            get { return Visibility.Hidden; }
        }

        private void usernameTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            textWarningUsername.Visibility = textWarningHidden;
            usernameTextBox.BorderBrush = Brushes.Black;
            var thic = new ThicknessConverter();
            usernameTextBox.BorderThickness = (Thickness)thic.ConvertFrom("1");
            confirmBtn.BorderBrush = Brushes.Black;
            confirmBtn.BorderThickness = (Thickness)thic.ConvertFrom("1");
        }
    }
}
