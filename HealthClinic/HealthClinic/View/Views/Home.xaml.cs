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
    /// Interaction logic for Home.xaml
    /// </summary>
    public partial class Home : UserControl
    {
        private String _username;

        public Home()
        {
            InitializeComponent();
            this.DataContext = this;
            HomeUsername = Login.currentUser.Name + " " + Login.currentUser.Surname;
        }

        public String HomeUsername
        {
            get { return _username; }
            set
            {
                if (_username != value)
                {
                    _username = value;

                }
            }
        }

        private void Obavestenja_Click1(object sender, RoutedEventArgs e)
        {
            HomeGrid.Children.Clear();
            UserControl usc = new MainUserControl();
            HomeGrid.Children.Add(usc);
        }

        private void ZakaziTermin_Click(object sender, RoutedEventArgs e)
        {
            HomeGrid.Children.Clear();
            UserControl usc = new MainNewAppointment();
            HomeGrid.Children.Add(usc);
        }

        private void MojiTerminiButton_Click(object sender, RoutedEventArgs e)
        {
            HomeGrid.Children.Clear();
            UserControl usc = new MainReviewAppointments();
            HomeGrid.Children.Add(usc);
        }

        private void TerapijaButton_Click(object sender, RoutedEventArgs e)
        {
            HomeGrid.Children.Clear();
            UserControl usc = new MainTherapyCalendar();
            HomeGrid.Children.Add(usc);
        }

        private void AnketeButton_Click(object sender, RoutedEventArgs e)
        {
            HomeGrid.Children.Clear();
            UserControl usc = new MainSurvey();
            HomeGrid.Children.Add(usc);
        }

        private void ProfileButton_Click(object sender, RoutedEventArgs e)
        {
            HomeGrid.Children.Clear();
            UserControl usc = new Profile();
            HomeGrid.Children.Add(usc);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            HomeGrid.Children.Clear();
            UserControl usc = new ChangeProfile();
            HomeGrid.Children.Add(usc);
        }

        private void SignOutButton_Click(object sender, RoutedEventArgs e)
        {
            HomeGrid.Children.Clear();
            UserControl usc = new Dialogs.LogoutQuestionDialog();
            HomeGrid.Children.Add(usc);
        }

        private void MojKartonButton_Click(object sender, RoutedEventArgs e)
        {
            HomeGrid.Children.Clear();
            UserControl usc = new Views.MainMedicalRecord();
            HomeGrid.Children.Add(usc);
        }

        private void BlogButton_Click(object sender, RoutedEventArgs e)
        {
            HomeGrid.Children.Clear();
            UserControl usc = new Views.MainBlog();
            HomeGrid.Children.Add(usc);
        }
    }
}
