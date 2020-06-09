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
    /// Interaction logic for MainMedicalRecord.xaml
    /// </summary>
    public partial class MainMedicalRecord : UserControl
    {
        public MainMedicalRecord()
        {
            InitializeComponent();
            UserControl MedicalRecordUSC = new Layouts.MedicalRecord();
            MainMedicalRecordFrame.Content = MedicalRecordUSC;
        }

        private void MedicalRecordHomeButton_Click(object sender, RoutedEventArgs e)
        {
            MainMedicalRecordGrid.Children.Clear();
            UserControl usc = new Views.Home();
            MainMedicalRecordGrid.Children.Add(usc);
        }
    }
}
