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

namespace HealthClinic.Dialogs
{
    /// <summary>
    /// Interaction logic for LogoutQuestionDialog.xaml
    /// </summary>
    public partial class LogoutQuestionDialog : UserControl
    {
        public LogoutQuestionDialog()
        {
            InitializeComponent();
        }

        private void LogOutDA_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }

        private void LogOutNE_Click(object sender, RoutedEventArgs e)
        {
            LogOutGrid.Children.Clear();
            UserControl usc = new Views.Home();
            LogOutGrid.Children.Add(usc);
        }
    }
}
