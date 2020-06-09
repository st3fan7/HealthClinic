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
    /// Interaction logic for ChangeProfile.xaml
    /// </summary>
    public partial class ChangeProfile : UserControl
    {
        public ChangeProfile()
        {
            InitializeComponent();
            UserControl ChangeProfileUSC = new Layouts.ChangeUserProfile();
            ChangeProfileFrame.Content = ChangeProfileUSC;
        }

        private void ChangeProfileHome_Click(object sender, RoutedEventArgs e)
        {
            ChangeProfileGrid.Children.Clear();
            UserControl usc = new Views.Home();
            ChangeProfileGrid.Children.Add(usc);
        }
    }
}
