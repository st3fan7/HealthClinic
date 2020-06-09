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

namespace HealthClinic.Layouts
{
    /// <summary>
    /// Interaction logic for MedicalRecord.xaml
    /// </summary>
    public partial class MedicalRecord : UserControl
    {
        public MedicalRecord()
        {
            InitializeComponent();
        }

        private void IstorijaLecenjaButton_Click(object sender, RoutedEventArgs e)
        {
            MedicalRecordGrid.Children.Clear();
            UserControl TreatmentHistoryUSC = new TreatmentHistory();
            MedicalRecordGrid.Children.Add(TreatmentHistoryUSC);
        }
    }
}
