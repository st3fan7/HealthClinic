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
    /// Interaction logic for AppointmentDoctor.xaml
    /// </summary>
    public partial class AppointmentDoctor : UserControl
    {
        public static int calendarButtonClickPressed = 1;
        public AppointmentDoctor()
        {
            InitializeComponent();
            calendarButtonClickPressed = 2;
        }

        //private void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    AppointmentDoctorGrid.Children.Clear();
        //    UserControl usc = new Layouts.AppointmentTerms();
        //    AppointmentDoctorGrid.Children.Add(usc);
        //}
    }
}
