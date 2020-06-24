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
using System.Windows.Shapes;

namespace HealthClinic
{
    /// <summary>
    /// Interaction logic for DijalogLekoviUklinici.xaml
    /// </summary>
    public partial class DijalogLekoviUklinici : Window
    {
        public DijalogLekoviUklinici()
        {
            InitializeComponent();

            /*
            for (int i = 0; i < UserControlValidacijaLeka.selectedLekUklinici.Sastav.Count; i++)
            {
                Sastav.Items.Add(UserControlValidacijaLeka.selectedLekUklinici.Sastav[i]);
            }

            Izvestaj.Text = UserControlValidacijaLeka.selectedLekUklinici.Izvestaj;
            */
            DaCheck.IsChecked = true;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

     
    }
}
