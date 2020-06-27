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
        public int i = 0;

        public MainNewAppointment()
        {
            InitializeComponent();
            //UserControl AppointmentCalendarUSC = new Layouts.AppointmentCalendar();
            //UserControl usc = new Layouts.SchedulingAppointments();
            //UserControl usc = new Layouts.AppointmentSelectMode();
            //MainAppointmentFrame.Content = usc;
            //MainAppointmentFrame.Content = AppointmentCalendarUSC;
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
            //if (MainAppointmentFrame.Content == AppointmentCalendarUSC)
            //{

            //}
            //else if (MainAppointmentFrame.Content == AppointmentDoctorUSC)
            //{
            //    MainAppointmentFrame.Content = AppointmentCalendarUSC;
            //}
            //else if (MainAppointmentFrame.Content == AppointmentTermsUSC)
            //{
            //    MainAppointmentFrame.Content = AppointmentDoctorUSC;
            //}

        }
        
        
           


        private void OKButtonNA_Click(object sender, RoutedEventArgs e)
        {
            //////UserControl AppointmentCalendarUSC = new Layouts.AppointmentCalendar();
            //////UserControl AppointmentDoctorUSC = new Layouts.AppointmentDoctor();
            //////UserControl AppointmentTermsUSC = new Layouts.AppointmentTerms();

            //if (MainAppointmentFrame.Content == AppointmentCalendarUSC)
            //{
            //    MainAppointmentFrame.Content = AppointmentDoctorUSC;
            //}
            //else if (MainAppointmentFrame.Content == AppointmentDoctorUSC)
            //{
            //    MainAppointmentFrame.Content = AppointmentTermsUSC;
            //}
            
            UserControl SchedulingAppointmentsUSC = new Layouts.SchedulingAppointments();
            UserControl AppointmentRecommendationUSC = new Layouts.AppointmentRecommendation();
            UserControl AppointmentFoundUSC = new Layouts.AppointmentsFound();
            //if (MainAppointmentFrame.Content == SchedulingAppointmentsUSC && IzaberiteTerminRB.IsChecked == true)
            //{
            //    //UserControl AppointmentFoundUSC = new Layouts.AppointmentsFound();
            //    MainAppointmentFrame.Content = AppointmentFoundUSC;
            //}
            //else if (MainAppointmentFrame.Content == AppointmentRecommendationUSC && PreporukaTerminaRB.IsChecked == true)
            //{
            //    //UserControl AppointmentFoundUSC = new Layouts.AppointmentsFound();
            //    MainAppointmentFrame.Content = AppointmentFoundUSC;
            //}
            //else
            //{

            if (IzaberiteTerminRB.IsChecked == true )
            {
                if (i == 1)
                {
                    UserControl MyAppointmentsUSC = new Layouts.MyAppointments();
                    MainAppointmentFrame.Content = MyAppointmentsUSC;
                    i += 1;
                    return;
                }
                else if (i == 2)
                {
                    UserControl NAQuestionDialogUSC = new Dialogs.NewAppointmentQuestionDialog();
                    MainAppointmentFrame.Content = NAQuestionDialogUSC;
                    i += 1;
                }
                else if (i == 3)
                {
                    UserControl NAConfirmDialogUSC = new Dialogs.NewAppointmentConfirmDialog();
                    MainAppointmentFrame.Content = NAConfirmDialogUSC;
                    i += 1;
                }
                else if (i == 4)
                {
                    MainNewAppointmentGrid.Children.Clear();
                    UserControl MyTermsUSC = new Views.MainReviewAppointments();
                    MainNewAppointmentGrid.Children.Add(MyTermsUSC);

                }
                else if (i == 0)
                {
                    MainAppointmentMessageFrame.Content = SchedulingAppointmentsUSC;
                    i += 1;
                }
            }
            else if (PreporukaTerminaRB.IsChecked == true)
            {
                if (i == 1)
                {
                    MainAppointmentFrame.Content = AppointmentFoundUSC;
                    i += 1;
                }
                else if (i == 2)
                {
                    UserControl NAQuestionDialogUSC = new Dialogs.NewAppointmentQuestionDialog();
                    MainAppointmentFrame.Content = NAQuestionDialogUSC;
                    i += 1;
                }
                else if (i == 3)
                {
                    UserControl NAConfirmDialogUSC = new Dialogs.NewAppointmentConfirmDialog();
                    MainAppointmentFrame.Content = NAConfirmDialogUSC;
                    i += 1;
                }
                else if (i == 4)
                {
                    MainNewAppointmentGrid.Children.Clear();
                    UserControl MyTermsUSC = new Views.MainReviewAppointments();
                    MainNewAppointmentGrid.Children.Add(MyTermsUSC);
                }
                else if (i == 0)
                {
                    MainAppointmentFrame.Content = AppointmentRecommendationUSC;
                    i += 1;
                }

                //MainAppointmentFrame.Content = AppointmentRecommendationUSC;

            }

            //}
            //else
            //{
            //    if (MainAppointmentFrame.Content == SchedulingAppointmentsUSC && IzaberiteTerminRB.IsChecked == true)
            //    {
            //        //UserControl AppointmentFoundUSC = new Layouts.AppointmentsFound();
            //        MainAppointmentFrame.Content = AppointmentFoundUSC;
            //    }
            //    else if (MainAppointmentFrame.Content == AppointmentRecommendationUSC && PreporukaTerminaRB.IsChecked == true)
            //    {
            //        //UserControl AppointmentFoundUSC = new Layouts.AppointmentsFound();
            //        MainAppointmentFrame.Content = AppointmentFoundUSC;
            //    }
            //}

            //if(MainAppointmentFrame.Content == null)






        }

        private void NewAppointmentHome_Click(object sender, RoutedEventArgs e)
        {
            MainNewAppointmentGrid.Children.Clear();
            UserControl usc = new Views.Home();
            MainNewAppointmentGrid.Children.Add(usc);
        }
    }
}
