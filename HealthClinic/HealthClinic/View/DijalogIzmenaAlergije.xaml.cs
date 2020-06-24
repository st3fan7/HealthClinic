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

namespace HealthClinic
{
    /// <summary>
    /// Interaction logic for DijalogIzmenaAlergije.xaml
    /// </summary>
    public partial class DijalogIzmenaAlergije : Window
    {
        public DijalogIzmenaAlergije()
        {
            InitializeComponent();
            /*
            if (UserControlPregled.selectedPatient != null)
            {
                foreach (String lergija in UserControlPregled.selectedPatient.Alergije)
                {
                    ListBox.Items.Add(lergija);
                }
            }
           */
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ListBox.Items.Add(NovaAlergija.Text);
            //UserControlPregled.selectedPatient.Alergije.Add(NovaAlergija.Text);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
           // UserControlPregled.selectedPatient.Alergije.Remove(ListBox.SelectedItem.ToString());
            ListBox.Items.Remove(ListBox.SelectedItem);
        }
    }
}
