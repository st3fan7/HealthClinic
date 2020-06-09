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
    /// Interaction logic for UserControlNalog.xaml
    /// </summary>
    public partial class UserControlNalog : UserControl
    {
        public UserControlNalog()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Na MainWindow sam namestio grid(nazvao sam ga GridMain) preko celog ekrana(izuzev linije menija i toolbar-a)
            //Novi user control, sto mi predstvalja celu novu funkcionalnost, dodajem na taj GridMain, na nacin ispod (linija 33)
            //Da li postoji nacin da od tog children-a, pristupim parent-u? Time bih dobio pristup prethodno dodatoj stranici na GridMain
            MainWindow._MainWindow.GridMain.Children.Add(new UserControlPocetna());
        }
    }
}
