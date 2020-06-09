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
    /// Interaction logic for UpdateDoctorAccount.xaml
    /// </summary>
    public partial class UpdateDoctorAccount : Window
    {
        public UpdateDoctorAccount()
        {
            InitializeComponent();
            firstInput.Focus();
            firstInput.SelectAll();
        }

    }
}
