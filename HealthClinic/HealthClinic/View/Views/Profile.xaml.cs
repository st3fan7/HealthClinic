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
    /// Interaction logic for Profile.xaml
    /// </summary>
    public partial class Profile : UserControl
    {
        public Profile()
        {
            InitializeComponent();
            UserControl ProfileUSC = new Layouts.UserProfile();
            ProfileFrame.Content = ProfileUSC;
        }

        private void ProfileHomeButton_Click(object sender, RoutedEventArgs e)
        {
            MainProfileGrid.Children.Clear();
            UserControl usc = new Views.Home();
            MainProfileGrid.Children.Add(usc);
        }
    }
}
