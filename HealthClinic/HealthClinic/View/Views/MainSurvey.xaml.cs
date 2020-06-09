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
    /// Interaction logic for MainSurvey.xaml
    /// </summary>
    public partial class MainSurvey : UserControl
    {
        public MainSurvey()
        {
            InitializeComponent();
            UserControl usc = new Layouts.Survey();
            MainSurveyFrame.Content = usc;
        }

        private void ObavestenjaButton_Click(object sender, RoutedEventArgs e)
        {
            UserControl usc = new MainUserControl();
            MainSurveyGrid.Children.Clear();
            MainSurveyGrid.Children.Add(usc);
        }

        private void ZakaziTerminButton_Click(object sender, RoutedEventArgs e)
        {
            UserControl NewAppointmentsUSC = new MainNewAppointment();
            MainSurveyGrid.Children.Clear();
            MainSurveyGrid.Children.Add(NewAppointmentsUSC);

        }

        private void MojiTerminiButton_Click(object sender, RoutedEventArgs e)
        {
            UserControl ReviewAppointmentsUSC = new MainReviewAppointments();
            MainSurveyGrid.Children.Clear();
            MainSurveyGrid.Children.Add(ReviewAppointmentsUSC);
        }

        private void AnketeButton_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void TerapijaButton_Click(object sender, RoutedEventArgs e)
        {
            UserControl TherapyCalendarUSC = new MainTherapyCalendar();
            MainSurveyGrid.Children.Clear();
            MainSurveyGrid.Children.Add(TherapyCalendarUSC);
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void HomeButton_Click(object sender, RoutedEventArgs e)
        {
            UserControl HomeUSC = new Home();
            MainSurveyGrid.Children.Clear();
            MainSurveyGrid.Children.Add(HomeUSC);
        }


    }
}
