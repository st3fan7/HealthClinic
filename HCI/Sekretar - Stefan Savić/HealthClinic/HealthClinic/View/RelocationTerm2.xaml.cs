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
    /// Interaction logic for RelocationTerm2.xaml
    /// </summary>
    public partial class RelocationTerm2 : UserControl
    {
        public RelocationTerm2()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            GridRelocationTerm2.Children.Clear();
            UserControl usc = new RelocationTerm();
            GridRelocationTerm2.Children.Add(usc);
        }

        private void homeBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridRelocationTerm2.Children.Clear();
            UserControl usc = new Home();
            GridRelocationTerm2.Children.Add(usc);
        }

        private void scheduleBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridRelocationTerm2.Children.Clear();
            UserControl usc = new Schedule();
            GridRelocationTerm2.Children.Add(usc);

        }

        private void patienstBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridRelocationTerm2.Children.Clear();
            UserControl usc = new Patient();
            GridRelocationTerm2.Children.Add(usc);
        }

        private void settingsBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridRelocationTerm2.Children.Clear();
            UserControl usc = new Settings();
            GridRelocationTerm2.Children.Add(usc);
        }

        private void reportBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridRelocationTerm2.Children.Clear();
            UserControl usc = new Report();
            GridRelocationTerm2.Children.Add(usc);
        }

        private void nextBtn_Click(object sender, RoutedEventArgs e)
        {
            GridRelocationTerm2.Children.Clear();
            UserControl usc = new RelocationTerm3();
            GridRelocationTerm2.Children.Add(usc);
        }
    }
}
