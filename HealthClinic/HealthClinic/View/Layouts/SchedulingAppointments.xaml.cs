using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for SchedulingAppointments.xaml
    /// </summary>
    public partial class SchedulingAppointments : UserControl
    {

        private int colNum = 0;
        public ObservableCollection<Model.Term> Termini
        {
            get;
            set;
        }

        public SchedulingAppointments()
        {
            InitializeComponent();
            this.DataContext = this;
            Termini = new ObservableCollection<Model.Term>();
            Termini.Add(new Model.Term() { Termin = "16:00-16:30" });
            Termini.Add(new Model.Term() { Termin = "09:00-09:30" });
            Termini.Add(new Model.Term() { Termin = "14:30-15:00" });
            Termini.Add(new Model.Term() { Termin = "14:30-15:00" });
            Termini.Add(new Model.Term() { Termin = "14:30-15:00" });
            Termini.Add(new Model.Term() { Termin = "14:30-15:00" });
            Termini.Add(new Model.Term() { Termin = "14:30-15:00" });
        }

        private void generateColumns(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            colNum++;
            if (colNum == 3)
                e.Column.Width = new DataGridLength(1, DataGridLengthUnitType.Star);
        }

    }
}
