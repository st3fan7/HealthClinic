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
    /// Interaction logic for PageClanci.xaml
    /// </summary>
    public partial class PageClanci : Page
    {
        public PageClanci()
        {
            InitializeComponent();
            tekst.Text = "Brza hrana (en. fast food) je termin i vrsta hrane koja se u restoranima brze hrane, vrlo brzo priprema i " +
                "servira i usto je i jeftina pa zbog toga se naziva brza hrana," +
                " no ona se još ponekad naziva i junk food (što u hrvatskom jeziku znači hrana smeće). U svijetu su posebno pupularni " +
                "hamburgeri (kao što je Big Mac, dvostruki hamburger), mesni hamburgeri te pomfriti, to jest prženi krumpirići, ali i gazirana pića, " +
                "najčešće Coca-Cola, su popularne. U SAD-u brza hrana najpopularnija je, " +
                "osobito kod djece i tinejdžera. U brzu hranu spadaju hamburger, hot dog, brzo pripremljena piletina, gazirana pića (pripremljena uz brzu hranu) itd. ";



        }
    }
}
