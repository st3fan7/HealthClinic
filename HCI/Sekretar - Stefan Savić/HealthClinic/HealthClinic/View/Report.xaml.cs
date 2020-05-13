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
    /// Interaction logic for Report.xaml
    /// </summary>
    public partial class Report : UserControl
    {
        public Report()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            GridReport.Children.Clear();
            UserControl usc = new Home();
            GridReport.Children.Add(usc);
        }

        private void homeBtn2_Click(object sender, RoutedEventArgs e)
        {

            GridReport.Children.Clear();
            UserControl usc = new Home();
            GridReport.Children.Add(usc);
        }

        private void scheduleBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridReport.Children.Clear();
            UserControl usc = new Schedule();
            GridReport.Children.Add(usc);

        }

        private void patienstBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridReport.Children.Clear();
            UserControl usc = new Patient();
            GridReport.Children.Add(usc);
        }

        private void settingsBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridReport.Children.Clear();
            UserControl usc = new Settings();
            GridReport.Children.Add(usc);
        }

        private void nextBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
