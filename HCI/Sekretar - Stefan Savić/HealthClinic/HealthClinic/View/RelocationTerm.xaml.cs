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
    /// Interaction logic for RelocationTerm.xaml
    /// </summary>
    public partial class RelocationTerm : UserControl
    {
        public RelocationTerm()
        {
            InitializeComponent();
        }

        private void homeBtn2_Click(object sender, RoutedEventArgs e)
        {

            GridRelocationTerm.Children.Clear();
            UserControl usc = new Home();
            GridRelocationTerm.Children.Add(usc);
        }

        private void scheduleBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridRelocationTerm.Children.Clear();
            UserControl usc = new Schedule();
            GridRelocationTerm.Children.Add(usc);

        }

        private void patienstBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridRelocationTerm.Children.Clear();
            UserControl usc = new Patient();
            GridRelocationTerm.Children.Add(usc);
        }

        private void settingsBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridRelocationTerm.Children.Clear();
            UserControl usc = new Settings();
            GridRelocationTerm.Children.Add(usc);
        }

        private void reportBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridRelocationTerm.Children.Clear();
            UserControl usc = new Report();
            GridRelocationTerm.Children.Add(usc);
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            // U zavisnosti iz kog prozora se kliknulo na premestanje tamo ce se vratiti
            GridRelocationTerm.Children.Clear();
            UserControl usc = new SurgeryRooms();
            GridRelocationTerm.Children.Add(usc);
        }

        private void nextBtn_Click(object sender, RoutedEventArgs e)
        {
            GridRelocationTerm.Children.Clear();
            UserControl usc = new RelocationTerm2();
            GridRelocationTerm.Children.Add(usc);
        }
    }
}
