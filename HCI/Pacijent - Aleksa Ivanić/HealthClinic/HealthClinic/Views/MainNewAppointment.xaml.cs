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
    /// Interaction logic for MainNewAppointment.xaml
    /// </summary>
    public partial class MainNewAppointment : UserControl
    {
        //UserControl NotificationsUSC = new Layouts.Notifications();
        UserControl AppointmentCalendarUSC = new Layouts.AppointmentCalendar();
        UserControl AppointmentDoctorUSC = new Layouts.AppointmentDoctor();
        UserControl AppointmentTermsUSC = new Layouts.AppointmentTerms();

        public MainNewAppointment()
        {
            InitializeComponent();
            //UserControl AppointmentCalendarUSC = new Layouts.AppointmentCalendar();
            MainAppointmentFrame.Content = AppointmentCalendarUSC;
        }

        private void ObavestenjeButton_Click(object sender, RoutedEventArgs e)
        {
            MainNewAppointmentGrid.Children.Clear();
            UserControl usc = new MainUserControl();
            MainNewAppointmentGrid.Children.Add(usc);

        }

        private void MojiTerminiButton_Click(object sender, RoutedEventArgs e)
        {
            UserControl ReviewAppointmentsUSC = new MainReviewAppointments();
            MainNewAppointmentGrid.Children.Clear();
            MainNewAppointmentGrid.Children.Add(ReviewAppointmentsUSC);

        }

        private void AnketeButton_Click(object sender, RoutedEventArgs e)
        {
            UserControl SurveyUSC = new MainSurvey();
            MainNewAppointmentGrid.Children.Clear();
            MainNewAppointmentGrid.Children.Add(SurveyUSC);
        }

        private void TerapijaButton_Click(object sender, RoutedEventArgs e)
        {
            UserControl TherapyCalendarUSC = new MainTherapyCalendar();
            MainNewAppointmentGrid.Children.Clear();
            MainNewAppointmentGrid.Children.Add(TherapyCalendarUSC);
        }

        private void BackButtonNA_Click(object sender, RoutedEventArgs e)
        {
            if (MainAppointmentFrame.Content == AppointmentCalendarUSC)
            {
                
            }
            else if (MainAppointmentFrame.Content == AppointmentDoctorUSC)
            {
                MainAppointmentFrame.Content = AppointmentCalendarUSC;
            }
            else if (MainAppointmentFrame.Content == AppointmentTermsUSC)
            {
                MainAppointmentFrame.Content = AppointmentDoctorUSC;
            }

        }

        private void OKButtonNA_Click(object sender, RoutedEventArgs e)
        {
            //UserControl AppointmentCalendarUSC = new Layouts.AppointmentCalendar();
            //UserControl AppointmentDoctorUSC = new Layouts.AppointmentDoctor();
            //UserControl AppointmentTermsUSC = new Layouts.AppointmentTerms();

            if (MainAppointmentFrame.Content == AppointmentCalendarUSC)
            {
                MainAppointmentFrame.Content = AppointmentDoctorUSC;
            }
            else if (MainAppointmentFrame.Content == AppointmentDoctorUSC)
            {
                MainAppointmentFrame.Content = AppointmentTermsUSC;
            }
        }

    }
}
