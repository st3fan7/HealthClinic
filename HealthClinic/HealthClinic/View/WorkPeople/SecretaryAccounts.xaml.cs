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
using System.Windows.Shapes;

namespace HealthClinic.View.WorkPeople
{
    /// <summary>
    /// Interaction logic for SecretaryAccounts.xaml
    /// </summary>
    public partial class SecretaryAccounts : Window
    {
        public SecretaryAccounts()
        {
            InitializeComponent();
        }

        private void Button_Click_KreirajNoviNalog(object sender, RoutedEventArgs e)
        {
            var createSecretaryAccount = new CreateSecretaryAccount();
            createSecretaryAccount.ShowDialog();
        }

        private void Button_Click_IzmeniNalog(object sender, RoutedEventArgs e)
        {
            var updateSecretaryAccountFirst = new UpdateSecretaryAccountFirst();
            updateSecretaryAccountFirst.ShowDialog();
        }

        private void Button_Click_ObrisiNalog(object sender, RoutedEventArgs e)
        {
            var deleteSecretaryAccount = new DeleteSecretaryAccount();
            deleteSecretaryAccount.ShowDialog();
        }

        private void Button_Click_PocetnaStrana(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
