using Controller;
using Model.DoctorMenager;
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
using System.Windows.Shapes;

namespace HealthClinic.View
{
    /// <summary>
    /// Interaction logic for AddMedicament.xaml
    /// </summary>
    public partial class AddMedicament : Window
    {
        private readonly IController<Medicament, int> medicamentController;

        public AddMedicament()
        {
            InitializeComponent();
            InputCodeOfMedicament.Focus();
            InputCodeOfMedicament.SelectAll();

            var app = Application.Current as App;
            medicamentController = app.MedicamentController;
        }

        private void Button_Click_Potvrdi(object sender, RoutedEventArgs e)
        {
            String code = InputCodeOfMedicament.Text;
            //String kolicina = InputAmountOfMedicament.Text;    

            //medicamentController.AddEntity(new Medicament(2, code, "nameeee", "prozvssd", 5));   
        }

        private void Button_Click_Odustani(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
