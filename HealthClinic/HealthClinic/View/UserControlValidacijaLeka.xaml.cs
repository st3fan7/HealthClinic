using Controller.MedicamentControlers;
using HealthClinic.Entiteti;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HealthClinic
{
    /// <summary>
    /// Interaction logic for UserControlValidacijaLeka.xaml
    /// </summary>
    public partial class UserControlValidacijaLeka : UserControl
    {
        // public static Lek selectedLek = null;
        //public static Lek selectedLekUklinici = null;

        public static MedicamentController medicamentController;
        public static ValidationMedicamentController validationMedicamentController;
        public static ValidationOfMedicament validationOfMedicament = null;
        public static Medicament selectedMedicament = null;

        public UserControlValidacijaLeka()
        {
            InitializeComponent();
            userControlValidacijaLeka = this;
          //  this.DataContext = MainWindow.Lekovi;

            if (UserControlPocetna.userControlPocetna.ToolTipButto.IsChecked == true)
            {
                ToolTipService.SetIsEnabled(buttonNazad, true);
                ToolTipService.SetIsEnabled(Verifikuj, true);


            }
            else
            {
                ToolTipService.SetIsEnabled(buttonNazad, false);
                ToolTipService.SetIsEnabled(Verifikuj, false);

            }

            var app = Application.Current as App;

            medicamentController = app.MedicamentController;
            validationMedicamentController = app.ValidationOfMedicamentController;

           foreach(Medicament m in medicamentController.GetComfirmedMedicaments())
           {
               // lekoviUklinici.Items
           }

            lekoviUklinici.ItemsSource = medicamentController.GetComfirmedMedicaments();
            lekoviUklinici.DisplayMemberPath = "Name";
            

            

            foreach(Medicament m in medicamentController.GetAllEntities())
            {
                
                foreach(ValidationOfMedicament v in validationMedicamentController.validationMedicamentService.validationOfMedicamentRepository.GetMedicamentsOnValidationForDoctor(Window1.ulogovaniDoctor))
                {
                    

                    if ((m.StateOfValidation == State.OnValidation) && (v.Medicament.GetId() == m.GetId()))
                    {
                        LekoviValidacija.Items.Add(v.Medicament);
                        LekoviValidacija.DisplayMemberPath = "Name";
                    }
                }           
            }





        }

        public static UserControlValidacijaLeka userControlValidacijaLeka = new UserControlValidacijaLeka();

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            selectedMedicament = (Medicament)LekoviValidacija.SelectedItem;
            foreach(ValidationOfMedicament v in validationMedicamentController.GetAllEntities())
            {
                if(v.Medicament.GetId() == selectedMedicament.GetId())
                {
                    validationOfMedicament = v;
                }
            }

           // Console.WriteLine(validationOfMedicament.GetId() + " " + validationOfMedicament.FeedbackOfValidation.Comment + " " + validationOfMedicament.Medicament.Name);
            

            
            
            Sastav.Items.Clear();

            
            if (selectedMedicament != null)
            {
                Proizvodjac.Text = selectedMedicament.Producer;
                               
                    Sastav.Items.Add(selectedMedicament.Ingredients);
                
                
            }
            else
            {
                Proizvodjac.Text = "";
                Sastav.Items.Clear();
            }
  
        }

        private void ListViewLekoviUKlinici_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //selectedLekUklinici = (Lek)lekoviUklinici.SelectedItem;
            DijalogLekoviUklinici dijaloglekoviUklinici = new DijalogLekoviUklinici();
            dijaloglekoviUklinici.ShowDialog();
        }

        private void DaChecked_Checked(object sender, RoutedEventArgs e)
        {
            if(DaChecked.IsChecked == true)
            {
                NeChecked.IsChecked = false;
                NeChecked.IsEnabled = false;
            }
        }

        private void DaChecked_Unchecked(object sender, RoutedEventArgs e)
        {
            if (DaChecked.IsChecked == false)
            {
               // NeChecked.IsChecked = false;
                NeChecked.IsEnabled = true;
            }
        }

        private void NeChecked_Checked(object sender, RoutedEventArgs e)
        {
            if (NeChecked.IsChecked == true)
            {
                DaChecked.IsChecked = false;
                DaChecked.IsEnabled = false;
            }
        }

        private void NeChecked_Unchecked(object sender, RoutedEventArgs e)
        {
            if (NeChecked.IsChecked == false)
            {
                // NeChecked.IsChecked = false;
                DaChecked.IsEnabled = true;
            }
        }

        private void ButtonPocetna_Click(object sender, RoutedEventArgs e)
        {
            
            MessageBoxResult result = MessageBox.Show("Da li ste sigurni da želite da se vratite na početnu stranicu?", "Povratak na početnu stranicu", MessageBoxButton.YesNo);
            if(result == MessageBoxResult.Yes) 
                MainWindow._MainWindow.GridMain.Children.Add(new UserControlPocetna());
        }

        private void Verifikuj_Click(object sender, RoutedEventArgs e)
        {

            MessageBoxResult result = MessageBox.Show("Da li ste sigurni da ste dobro validirali lek?\nLek će biti dodat u listu lekova na klinici.", "Validiranje leka", MessageBoxButton.YesNo, MessageBoxImage.Question);

            /*
            if (result == MessageBoxResult.Yes)
            {

                selectedLek.Izvestaj = Izvestaj.Text;

                if (DaChecked.IsChecked == true)
                {
                    
                    selectedLek.Validiran = true;
                    lekoviUklinici.Items.Add(selectedLek);
                    lekoviUklinici.DisplayMemberPath = "Ime";
                    
                }
                else if (NeChecked.IsChecked == true)
                {
                    selectedLek.Validiran = false;
                    
                }
                else
                {
                    selectedLek.Validiran = false;
                }
              
            }
            */

            if(result == MessageBoxResult.Yes)
            {
                validationOfMedicament.FeedbackOfValidation.Comment = Izvestaj.Text;

                if(DaChecked.IsChecked == true)
                {
                    validationOfMedicament.Approved = true;
                    validationOfMedicament.Medicament.StateOfValidation = State.Confirmed;
                    medicamentController.UpdateEntity(validationOfMedicament.Medicament);
                    validationMedicamentController.UpdateEntity(validationOfMedicament);
                }
                else if(NeChecked.IsChecked == true)
                {
                    validationOfMedicament.Approved = false;
                    validationOfMedicament.Medicament.StateOfValidation = State.Rejected;
                    medicamentController.UpdateEntity(validationOfMedicament.Medicament);
                    validationMedicamentController.UpdateEntity(validationOfMedicament);
                }
            }



            
        }
    }
}
