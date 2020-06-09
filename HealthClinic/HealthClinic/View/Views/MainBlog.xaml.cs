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
    /// Interaction logic for MainBlog.xaml
    /// </summary>
    public partial class MainBlog : UserControl
    {
        public MainBlog()
        {
            InitializeComponent();
            UserControl usc = new Layouts.Blog();
            BlogFrame.Content = usc;
        }

        private void BlogHomeButton_Click(object sender, RoutedEventArgs e)
        {
            MainBlogGrid.Children.Clear();
            UserControl usc = new Views.Home();
            MainBlogGrid.Children.Add(usc);
        }
    }
}
