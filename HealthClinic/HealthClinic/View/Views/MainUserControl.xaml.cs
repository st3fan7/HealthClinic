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
    /// Interaction logic for MainUserControl.xaml
    /// </summary>
    public partial class MainUserControl : UserControl
    {
        public MainUserControl()
        {
            InitializeComponent();
            UserControl NotificationsUSC = new Layouts.Notifications();
            MainUSCFrame.Content = NotificationsUSC;
        }

        private void ObavestenjaButton_Click(object sender, RoutedEventArgs e)
        {
            UserControl NotificationsUSC = new Layouts.Notifications();
            MainUSCFrame.Content = NotificationsUSC;
        }

        private void ZakaziTerminButton_Click(object sender, RoutedEventArgs e)
        {
            UserControl NewAppointmentsUSC = new MainNewAppointment();
            MainUSCGrid.Children.Clear();
            MainUSCGrid.Children.Add(NewAppointmentsUSC);

        }

        private void MojiTerminiButton_Click(object sender, RoutedEventArgs e)
        {
            UserControl ReviewAppointmentsUSC = new MainReviewAppointments();
            MainUSCGrid.Children.Clear();
            MainUSCGrid.Children.Add(ReviewAppointmentsUSC);
        }

        private void AnketeButton_Click(object sender, RoutedEventArgs e)
        {
            UserControl SurveyUSC = new Views.MainSurvey();
            MainUSCGrid.Children.Clear();
            MainUSCGrid.Children.Add(SurveyUSC);
        }

        private void TerapijaButton_Click(object sender, RoutedEventArgs e)
        {
            UserControl TherapyCalendarUSC = new MainTherapyCalendar();
            MainUSCGrid.Children.Clear();
            MainUSCGrid.Children.Add(TherapyCalendarUSC);
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void HomeButton_Click(object sender, RoutedEventArgs e)
        {
            UserControl HomeUSC = new Home();
            MainUSCGrid.Children.Clear();
            MainUSCGrid.Children.Add(HomeUSC);
        }


    }
}
