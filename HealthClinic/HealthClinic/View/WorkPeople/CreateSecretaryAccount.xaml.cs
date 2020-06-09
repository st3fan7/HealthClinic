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
    /// Interaction logic for CreateSecretaryAccount.xaml
    /// </summary>
    public partial class CreateSecretaryAccount : Window
    {
        public CreateSecretaryAccount()
        {
            InitializeComponent();
            firstInput.Focus();
            firstInput.SelectAll();
        }
    }
}
