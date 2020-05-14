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
    /// Interaction logic for MainTherapyCalendar.xaml
    /// </summary>
    public partial class MainTherapyCalendar : UserControl
    {
        public MainTherapyCalendar()
        {
            InitializeComponent();
        }

        private void ObavestenjaButton_Click(object sender, RoutedEventArgs e)
        {
            UserControl usc = new MainUserControl();
            MainTherapyCalendarGrid.Children.Clear();
            MainTherapyCalendarGrid.Children.Add(usc);
        }

        private void ZakaziTerminButton_Click(object sender, RoutedEventArgs e)
        {
            UserControl NewAppointmentsUSC = new MainNewAppointment();
            MainTherapyCalendarGrid.Children.Clear();
            MainTherapyCalendarGrid.Children.Add(NewAppointmentsUSC);

        }

        private void MojiTerminiButton_Click(object sender, RoutedEventArgs e)
        {
            UserControl ReviewAppointmentsUSC = new MainReviewAppointments();
            MainTherapyCalendarGrid.Children.Clear();
            MainTherapyCalendarGrid.Children.Add(ReviewAppointmentsUSC);
        }

        private void AnketeButton_Click(object sender, RoutedEventArgs e)
        {
            UserControl SurveyUSC = new Views.MainSurvey();
            MainTherapyCalendarGrid.Children.Clear();
            MainTherapyCalendarGrid.Children.Add(SurveyUSC);
        }

        private void TerapijaButton_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void HomeButton_Click(object sender, RoutedEventArgs e)
        {
            UserControl HomeUSC = new Home();
            MainTherapyCalendarGrid.Children.Clear();
            MainTherapyCalendarGrid.Children.Add(HomeUSC);
        }
    }
}
