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

namespace HealthClinic.Views
{
    /// <summary>
    /// Interaction logic for NewPasswordConfirm.xaml
    /// </summary>
    public partial class NewPasswordConfirm : UserControl
    {
        public NewPasswordConfirm()
        {
            InitializeComponent();
        }

        private void NPCUReduButton_Click(object sender, RoutedEventArgs e)
        {
            NewPasswordConfirmGrid.Children.Clear();
            UserControl usc = new Login();
            NewPasswordConfirmGrid.Children.Add(usc);
        }
    }
}
