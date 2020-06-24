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
    /// Interaction logic for PagePitanjaxaml.xaml
    /// </summary>
    public partial class PagePitanjaxaml : Page
    {
        public PagePitanjaxaml()
        {
            InitializeComponent();

            tekst.Text = "Imam pitanje u vezi prehrane.\nSmeta mi gluten. Koje bi namernice trebalo da izbacim?";
        }
    }
}
