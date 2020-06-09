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

namespace HealthClinic.Layouts
{
    /// <summary>
    /// Interaction logic for UserProfile.xaml
    /// </summary>
    public partial class UserProfile : UserControl
    {
        public UserProfile()
        {
            InitializeComponent();
        }

        private void IzmenaNalogaButton_Click(object sender, RoutedEventArgs e)
        {
            UserProfileGrid.Children.Clear();
            UserControl usc = new Layouts.ChangeUserProfile();
            UserProfileGrid.Children.Add(usc);
        }
    }
}
