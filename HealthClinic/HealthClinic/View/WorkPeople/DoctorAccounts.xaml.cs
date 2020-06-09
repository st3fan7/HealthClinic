using HealthClinic.View.WorkPeople;
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

namespace HealthClinic.View
{
    /// <summary>
    /// Interaction logic for DoctorAccounts.xaml
    /// </summary>
    public partial class DoctorAccounts : Window
    {
        public DoctorAccounts()
        {
            InitializeComponent();
        }

        private void Button_Click_PocetnaStrana(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_KreirajNoviNalog(object sender, RoutedEventArgs e)
        {
            var createDoctorAccount = new CreateDoctorAccount();
            createDoctorAccount.ShowDialog();
        }

        private void Button_Click_ObrisiNalog(object sender, RoutedEventArgs e)
        {
            var deleteDoctorAccount = new DeleteDoctorAccount();
            deleteDoctorAccount.ShowDialog();
        }

        private void Button_Click_IzmeniNalog(object sender, RoutedEventArgs e)
        {
            var updateDoctorAccountFirst = new UpdateDoctorAccountFirst();
            updateDoctorAccountFirst.ShowDialog();
        }
    }
}
