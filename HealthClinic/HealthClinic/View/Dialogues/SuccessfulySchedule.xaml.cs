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
    /// Interaction logic for SuccessfulySchedule.xaml
    /// </summary>
    public partial class SuccessfulySchedule : UserControl
    {
        public SuccessfulySchedule()
        {
            InitializeComponent();
        }

        private void okBtn_Click(object sender, RoutedEventArgs e)
        {
            GridHome.Children.Clear();
            UserControl usc = new Home();
            GridHome.Children.Add(usc);
        }
    }
}
