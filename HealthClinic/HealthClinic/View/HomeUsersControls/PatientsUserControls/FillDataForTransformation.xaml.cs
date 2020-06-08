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
    /// Interaction logic for FillDataForTransformation.xaml
    /// </summary>
    public partial class FillDataForTransformation : UserControl
    {
        public FillDataForTransformation()
        {
            InitializeComponent();
        }
        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            GridFillDataForTransformation.Children.Clear();
            UserControl usc = new TransformationGuestAccount();
            GridFillDataForTransformation.Children.Add(usc);
        }

        private void homeBtn2_Click(object sender, RoutedEventArgs e)
        {

            GridFillDataForTransformation.Children.Clear();
            UserControl usc = new Home();
            GridFillDataForTransformation.Children.Add(usc);
        }

        private void scheduleBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridFillDataForTransformation.Children.Clear();
            UserControl usc = new Schedule();
            GridFillDataForTransformation.Children.Add(usc);

        }

        private void patienstBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridFillDataForTransformation.Children.Clear();
            UserControl usc = new Patient();
            GridFillDataForTransformation.Children.Add(usc);
        }

        private void settingsBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridFillDataForTransformation.Children.Clear();
            UserControl usc = new Settings();
            GridFillDataForTransformation.Children.Add(usc);
        }

        private void reportBtn_Click(object sender, RoutedEventArgs e)
        {
            GridFillDataForTransformation.Children.Clear();
            UserControl usc = new Report();
            GridFillDataForTransformation.Children.Add(usc);
        }

        private void trasnformBtn_Click(object sender, RoutedEventArgs e)
        {
            GridFillDataForTransformation.Children.Clear();
            UserControl usc = new Patient();
            GridFillDataForTransformation.Children.Add(usc);
        }
    }
}
