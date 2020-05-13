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

namespace HealthClinic.View
{
    /// <summary>
    /// Interaction logic for DisplayType.xaml
    /// </summary>
    public partial class DisplayType : UserControl
    {
        bool[] array;
        public DisplayType()
        {
            InitializeComponent();
            Schedule s = new Schedule();
            datumLabel.Content = s.datePickerSchedule.DisplayDate; // treba da povuces datum i prikazes


        // ovo ne ide ovde, ostavio sam da ne zaboravim  
        //    private bool[] _modeArray = new bool[] { true, false, false };
        //public bool[] ModeArray
        //{
        //    get { return _modeArray; }
        //}
        //public int SelectedMode
        //{
        //    get { return Array.IndexOf(_modeArray, true); }
        //}
    }


        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            GridDisplayType.Children.Clear();
            UserControl usc = new Schedule();
            GridDisplayType.Children.Add(usc);
        }

        private void nextBtn_Click(object sender, RoutedEventArgs e)
        {
            GridDisplayType.Children.Clear();

            if (array[0] == true)
            {           
                UserControl usc = new TypeOfRoom();
                GridDisplayType.Children.Add(usc);
            } 
            else if (array[1] == true)
            {
                UserControl usc = new DoctorsTerm();
                GridDisplayType.Children.Add(usc);
            } 
            else
            {
                UserControl usc = new StartTimeView();
                GridDisplayType.Children.Add(usc);
            }
        }

        private void homeBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridDisplayType.Children.Clear();
            UserControl usc = new Home();
            GridDisplayType.Children.Add(usc);

        }

        private void scheduleBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridDisplayType.Children.Clear();
            UserControl usc = new Schedule();
            GridDisplayType.Children.Add(usc);
        }

        private void patienstBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridDisplayType.Children.Clear();
            UserControl usc = new Patient();
            GridDisplayType.Children.Add(usc);
        }

        private void settingsBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridDisplayType.Children.Clear();
            UserControl usc = new Settings();
            GridDisplayType.Children.Add(usc);
        }

        private void reportBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridDisplayType.Children.Clear();
            UserControl usc = new Report();
            GridDisplayType.Children.Add(usc);
        }

        private void one_Checked(object sender, RoutedEventArgs e)
        {
            // ako je cekiran onda mozes da kliknes dugme i ovde otvoris prozor koji ti treba
            nextBtn.IsEnabled = true;
            array = new bool[] { true, false, false };
        }

        private void two_Checked(object sender, RoutedEventArgs e)
        {
            nextBtn.IsEnabled = true;
            array = new bool[] { false, true, false }; 
        }

        private void three_Checked(object sender, RoutedEventArgs e)
        {
            nextBtn.IsEnabled = true;
            array = new bool[] { false, false, true };
        }
    }
}
