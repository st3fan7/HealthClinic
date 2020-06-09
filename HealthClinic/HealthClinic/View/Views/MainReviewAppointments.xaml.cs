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
    /// Interaction logic for MainReviewAppointments.xaml
    /// </summary>
    public partial class MainReviewAppointments : UserControl
    {

        public MainReviewAppointments()
        {
            UserControl MyAppointmentsUSC = new Layouts.MyAppointments();
            InitializeComponent();
            MainReviewAppointmentFrame.Content = MyAppointmentsUSC;
        }

        private void ObavestenjaButton_Click(object sender, RoutedEventArgs e)
        {
            UserControl usc = new MainUserControl();
            MainReviewAppointmentGrid.Children.Clear();
            MainReviewAppointmentGrid.Children.Add(usc);
        }

        private void ZakaziTerminButton_Click(object sender, RoutedEventArgs e)
        {
            UserControl NewAppointmentsUSC = new MainNewAppointment();
            MainReviewAppointmentGrid.Children.Clear();
            MainReviewAppointmentGrid.Children.Add(NewAppointmentsUSC);

        }

        private void AnketeButton_Click(object sender, RoutedEventArgs e)
        {
            UserControl SurveyUSC = new Views.MainSurvey();
            MainReviewAppointmentGrid.Children.Clear();
            MainReviewAppointmentGrid.Children.Add(SurveyUSC);
        }

        private void TerapijaButton_Click(object sender, RoutedEventArgs e)
        {
            UserControl TherapyCalendarUSC = new MainTherapyCalendar();
            MainReviewAppointmentGrid.Children.Clear();
            MainReviewAppointmentGrid.Children.Add(TherapyCalendarUSC);
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void HomeButton_Click(object sender, RoutedEventArgs e)
        {
            UserControl HomeUSC = new Home();
            MainReviewAppointmentGrid.Children.Clear();
            MainReviewAppointmentGrid.Children.Add(HomeUSC);
        }
    }
}
