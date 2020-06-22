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

namespace HealthClinic.View.Account
{
    /// <summary>
    /// Interaction logic for UpdateAccount.xaml
    /// </summary>
    public partial class UpdateAccount : Window
    {
        public UpdateAccount()
        {
            InitializeComponent();
            InputName.Focus();
            InputName.SelectAll();
        }
        private void Button_Click_Potvrdi(object sender, RoutedEventArgs e)
        {
            // Izvrsi izmene naloga
            var account = new Account();
            account.ShowDialog();
            this.Close();
        }

        private void Button_Click_Odustani(object sender, RoutedEventArgs e)
        {
            var account = new Account();
            account.ShowDialog();
            this.Close();
        }
    }
}
