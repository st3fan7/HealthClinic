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

namespace HealthClinic.View.Dialogues
{
    /// <summary>
    /// Interaction logic for LogoutDialog.xaml
    /// </summary>
    public partial class LogoutDialog : UserControl
    {
        public LogoutDialog()
        {
            InitializeComponent();
        }

        private void noBtn_Click(object sender, RoutedEventArgs e)
        {

            GridHome.Children.Clear();
            UserControl usc = new Home();
            GridHome.Children.Add(usc);
        }

        private void yesBtn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            mw.Show();
            Window.GetWindow(this).Close();
        }
    }
}
