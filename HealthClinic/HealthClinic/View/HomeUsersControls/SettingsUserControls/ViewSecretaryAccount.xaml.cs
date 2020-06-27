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
    /// Interaction logic for ViewSecretaryAccount.xaml
    /// </summary>
    public partial class ViewSecretaryAccount : UserControl
    {
        public ViewSecretaryAccount()
        {
            InitializeComponent();

            //Secretary secretary = MainWindow.secreatries.First();
            //usernameLabel.Content = secretary.Username;
            //passwordLabel.Content = secretary.Password;
            //nameLabel.Content = secretary.Name;
            //lastNameLabel.Content = secretary.Surname;
            //jmbgLabel.Content = secretary.Id;
            //dateOfBirthLabel.Content = secretary.DateOfBirth;
            //placeOfBirthLabel.Content = secretary.PlaceOfBirth;
            //countryLabel.Content = secretary.Country;
            //addressLabel.Content = secretary.Address;
            //phoneLabel.Content = secretary.MobilePhone;
            //emailLabel.Content = secretary.Email;
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            GridViewSecretaryAccount.Children.Clear();
            UserControl usc = new ManipulationOptionsForSecretaryAccount();
            GridViewSecretaryAccount.Children.Add(usc);
        }

        private void homeBtn2_Click(object sender, RoutedEventArgs e)
        {

            GridViewSecretaryAccount.Children.Clear();
            UserControl usc = new Home();
            GridViewSecretaryAccount.Children.Add(usc);
        }

        private void scheduleBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridViewSecretaryAccount.Children.Clear();
            UserControl usc = new Schedule();
            GridViewSecretaryAccount.Children.Add(usc);

        }

        private void patienstBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridViewSecretaryAccount.Children.Clear();
            UserControl usc = new PatientView();
            GridViewSecretaryAccount.Children.Add(usc);
        }

        private void settingsBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridViewSecretaryAccount.Children.Clear();
            UserControl usc = new Settings();
            GridViewSecretaryAccount.Children.Add(usc);
        }

        private void reportBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridViewSecretaryAccount.Children.Clear();
            UserControl usc = new Report();
            GridViewSecretaryAccount.Children.Add(usc);
        }

        private void okBtn_Click(object sender, RoutedEventArgs e)
        {
            GridViewSecretaryAccount.Children.Clear();
            UserControl usc = new ManipulationOptionsForSecretaryAccount();
            GridViewSecretaryAccount.Children.Add(usc);
        }
    }
}
