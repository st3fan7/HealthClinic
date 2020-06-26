using Controller.MedicamentControlers;
using Controller.UsersControlers;
using HealthClinic.View.Converter;
using HealthClinic.View.ViewModel;
using Model.AllActors;
using Model.DoctorMenager;
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
using System.Windows.Shapes;

namespace HealthClinic.View
{
    /// <summary>
    /// Interaction logic for AddNewMedicament.xaml
    /// </summary>
    public partial class AddNewMedicament : Window
    {
        private readonly ValidationMedicamentController validationMedicamentController;
        private readonly MedicamentController medicamentController;
        private readonly UserController userController;
        public static ObservableCollection<ViewMedicamentOnValidation> MedicamentsOnValidationView { get; set; }
        public static ObservableCollection<Doctor> DoctorsView { get; set; }

        public AddNewMedicament()
        {
            InitializeComponent();
            this.DataContext = this;

            var app = Application.Current as App;
            validationMedicamentController = app.ValidationOfMedicamentController;
            medicamentController = app.MedicamentController;
            userController = app.UserController;

            MedicamentsOnValidationView = new ObservableCollection<ViewMedicamentOnValidation>(MedicamentOnValidationConverter.ConvertMedicamentListToMedicamentViewList(
                validationMedicamentController.GetAllEntities().ToList()));

            DoctorsView = new ObservableCollection<Doctor>(userController.GetAllDoctors());
        }

        private void AddValidMedicament(ValidationOfMedicament medicamentOnValidation) // Napraviti u servisu
        {
            medicamentController.AddEntity(medicamentOnValidation.Medicament);
        }

        private void Button_Click_PosaljiLekaru(object sender, RoutedEventArgs e)
        {
            if (InputNameOfMedicament.Text.Equals("") || InputProducerOfMedicament.Text.Equals("") ||
                 InputCodeOfMedicament.Text.Equals("") || InputIngredientsOfMedicament.Text.Equals(""))
            {
                MessageBox.Show("Morate popuniti sva polja", "Greška", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            try
            {
                int.Parse(InputAmountOfMedicament.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Morate uneti broj za količinu", "Greška", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (medicamentController.ExistMedicamentWithCode(InputCodeOfMedicament.Text))
            {
                MessageBox.Show("Lek sa šifrom koju ste uneli već postoji", "Greška", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            else
            {
                medicamentController.AddEntity(new Medicament(InputCodeOfMedicament.Text, InputNameOfMedicament.Text, InputProducerOfMedicament.Text,
                    State.OnValidation, int.Parse(InputAmountOfMedicament.Text), InputIngredientsOfMedicament.Text));
                MedicamentsOnValidationView.Add(MedicamentOnValidationConverter.ConvertMedicamentToMedicamentView(
                    validationMedicamentController.AddEntity( new ValidationOfMedicament(false,
                    medicamentController.GetMedicamentByCode(InputCodeOfMedicament.Text), 
                    new FeedbackOfValidation(""), (Doctor)ComboBoxDoctors.SelectedItem))));                
                MessageBox.Show("Usepešno ste poslali lek na validaciju", "Obaveštenje", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void Button_Click_Odustani(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
