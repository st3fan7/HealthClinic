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

namespace HealthClinic
{
    /// <summary>
    /// Interaction logic for UserControlBlog.xaml
    /// </summary>
    public partial class UserControlBlog : UserControl
    {
        public UserControlBlog()
        {
            InitializeComponent();
        }

        private void ButtonNazad_Click(object sender, RoutedEventArgs e)
        {
          
            (this.Parent as Grid).Children.Remove(this);
        }

        private void ButtonClanci_Click(object sender, RoutedEventArgs e)
        {

            BlogFrame.Content = new PageClanci();
        }

        private void ButtonDodaj_Click(object sender, RoutedEventArgs e)
        {

            BlogFrame.Content = new PageDodajClanak();
        }

        private void ButtonPitanje_Click(object sender, RoutedEventArgs e)
        {

            BlogFrame.Content = new PagePitanjaxaml();
        }

    }
}
