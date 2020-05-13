﻿using System;
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
    /// Interaction logic for ViewPatientAccount.xaml
    /// </summary>
    public partial class ViewPatientAccount : UserControl
    {
        public ViewPatientAccount()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            GridViewPatientAccount.Children.Clear();
            UserControl usc = new ManipulationOptions();
            GridViewPatientAccount.Children.Add(usc);
        }

        private void homeBtn2_Click(object sender, RoutedEventArgs e)
        {

            GridViewPatientAccount.Children.Clear();
            UserControl usc = new Home();
            GridViewPatientAccount.Children.Add(usc);
        }

        private void scheduleBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridViewPatientAccount.Children.Clear();
            UserControl usc = new Schedule();
            GridViewPatientAccount.Children.Add(usc);

        }

        private void patienstBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridViewPatientAccount.Children.Clear();
            UserControl usc = new Patient();
            GridViewPatientAccount.Children.Add(usc);
        }

        private void settingsBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridViewPatientAccount.Children.Clear();
            UserControl usc = new Settings();
            GridViewPatientAccount.Children.Add(usc);
        }

        private void reportBtn2_Click(object sender, RoutedEventArgs e)
        {
            GridViewPatientAccount.Children.Clear();
            UserControl usc = new Report();
            GridViewPatientAccount.Children.Add(usc);
        }

        private void okBtn_Click(object sender, RoutedEventArgs e)
        {
            GridViewPatientAccount.Children.Clear();
            UserControl usc = new ManipulationOptions();
            GridViewPatientAccount.Children.Add(usc);
        }
    }
}
