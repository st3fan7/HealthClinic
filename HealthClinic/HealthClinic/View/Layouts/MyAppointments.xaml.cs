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
    /// Interaction logic for MyAppointments.xaml
    /// </summary>
    public partial class MyAppointments : UserControl
    {
       private int colNum = 0;
       public ObservableCollection<Model.Appointments>Pregledi
        {
            get;
            set;
        }

        public MyAppointments()
        {
            InitializeComponent();
            this.DataContext = this;
            Pregledi = new ObservableCollection<Model.Appointments>();
            Pregledi.Add(new Model.Appointments() { Datum = "07.06.2020.", Termin = "16:00-16:30", Lekar = "Pera Perić" });
            Pregledi.Add(new Model.Appointments() { Datum = "25.11.2020.", Termin = "09:00-09:30", Lekar = "Pera Perić" });
            Pregledi.Add(new Model.Appointments() { Datum = "02.03.2021.", Termin = "14:30-15:00", Lekar = "Pera Perić" });
        }

        private void generateColumns(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            colNum++;
            if (colNum == 3)
                e.Column.Width = new DataGridLength(1, DataGridLengthUnitType.Star);
        }

    }
}
