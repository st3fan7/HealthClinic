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
using System.Windows.Shapes;

namespace HealthClinic.View
{
    /// <summary>
    /// Interaction logic for Renovation.xaml
    /// </summary>
    public partial class Renovation : Window
    {
        public Renovation()
        {
            InitializeComponent();
            firstField.Focus();
            firstField.SelectedItem = firstItem;
        }

        private void Button_Click_PrikaziZauzecaSale(object sender, RoutedEventArgs e)
        {
            var roomOccupancy = new RoomOccupancy();
            roomOccupancy.ShowDialog();
        }

        private void Button_Click_PocetnaStrana(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

    }
}
