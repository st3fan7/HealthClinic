using Controller.ExaminationSurgeryControlers;
using Controller.UsersControlers;
using HealthClinic.Entiteti;
using HealthClinic.View.Converter;
using HealthClinic.View.ViewModel;
using Model.AllActors;
using Model.Term;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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
    /// Interaction logic for UserControlPocetna.xaml
    /// </summary>
    public partial class UserControlPocetna : UserControl
    {
        /*
        public List<Pacijent> pretrazeni = new List<Pacijent>();
        
        public static ObservableCollection<Pacijent> Pacijenti
        {
            get;
            set;
        }
        */
        //  public static Pacijent staticPacijent = new Pacijent();


        public static MedicalExaminationController medicalExaminationController;
        private readonly UserController userController;
        public static UserControlPocetna userControlPocetna = new UserControlPocetna();
        public static ViewMedicalExamination viewMedicalExamination = null;
        public static Patient staticPatient = new Patient();
        public static MedicalExamination MedicalExamination = null;


        public UserControlPocetna()
        {
            InitializeComponent();
        //    this.DataContext = MainWindow.Pacijenti;
            userControlPocetna = this;
           
            
            var app = App.Current as App;
            medicalExaminationController = app.MedicalExaminationController;
            userController = app.UserController;

            MainWindow.ViewMedicalExaminations = new ObservableCollection<ViewMedicalExamination>(MedicalExaminationConverter.ConvertMEListToMEViewList(
               this.getAllMedicalExByDoctor(Window1.ulogovaniDoctor).ToList()));


            

            this.DataContext = MainWindow.ViewMedicalExaminations;


            dgrMain.ItemsSource = MainWindow.ViewMedicalExaminations;

             

        }



        private void dgrPocetnaEvent(object sender, RoutedEventArgs e)
        {
            GridPocentaVidljiv.Visibility = Visibility.Visible;
            viewMedicalExamination = (ViewMedicalExamination)dgrMain.SelectedItem;
            MedicalExamination = medicalExaminationController.GetEntity(viewMedicalExamination.Id);
            
            staticPatient = (Patient)userController.GetEntity(MedicalExamination.Patient.Id);
           

        }

        private List<MedicalExamination> getAllMedicalExByDoctor(Doctor doctor)
        {
            List<MedicalExamination> lista = new List<MedicalExamination>();
            foreach(MedicalExamination m in medicalExaminationController.GetAllEntities())
            {
                if (m.Doctor.GetId().Equals(doctor.GetId()))
                {
                    lista.Add(m);
                }
            }

            return lista;
        }

        private void ButtonIzvrsiPregled_Click(object sender, RoutedEventArgs e)
        {

            // staticPacijent = (Pacijent) dgrMain.SelectedItem;
           

            MainWindow._MainWindow.GridMain.Children.Clear();
            UserControl uscPregled = new UserControlPregled();
            MainWindow._MainWindow.ItemPregled.IsSelected = true;
            MainWindow._MainWindow.ItemPocetna.IsSelected = false;
            MainWindow._MainWindow.GridMain.Children.Add(uscPregled);

        }

        private void DP_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            
            //pacijent.Datum = datePicker.SelectedDate.Value.ToString("dd.MM.yyyy");
            /*
            for(int i = 0; i < MainWindow.Pacijenti.Pacijents.Count; i++)
            {
                if(MainWindow.Pacijenti.Pacijents[i].Datum == DP.SelectedDate.Value.ToString("dd.MM.yyyy"))
                {
                    pretrazeni.Add(MainWindow.Pacijenti.Pacijents[i]);
                   
                   
                }

            
            }

            dgrMain.ItemsSource = pretrazeni.ToList();
           */

        }

        private void ToolTipButto_Checked(object sender, RoutedEventArgs e)
        {
            if (ToolTipButto.IsChecked == true)
            {
                ToolTipService.SetIsEnabled(MainWindow._MainWindow.nalogItem, true);
                ToolTipService.SetIsEnabled(MainWindow._MainWindow.menuPrikazi, true);
                ToolTipService.SetIsEnabled(MainWindow._MainWindow.menuZakazi, true);
                ToolTipService.SetIsEnabled(MainWindow._MainWindow.menuObavestenja, true);
                ToolTipService.SetIsEnabled(MainWindow._MainWindow.ItemPocetna, true);
                ToolTipService.SetIsEnabled(MainWindow._MainWindow.ItemOdjava, true);
                ToolTipService.SetIsEnabled(MainWindow._MainWindow.ItemPacijenti, true);
                ToolTipService.SetIsEnabled(MainWindow._MainWindow.ItemPregled, true);
                ToolTipService.SetIsEnabled(MainWindow._MainWindow.ItemValidacijaLeka, true);
                ToolTipService.SetIsEnabled(MainWindow._MainWindow.MenuPomoc, true);
                ToolTipService.SetIsEnabled(buttonUnos, true);
                //ToolTipService.SetIsEnabled(ButtonPregled, false);


            }
            else
            {
               
            }

            
        }

        private void ToolTipButto_Unchecked(object sender, RoutedEventArgs e)
        {
           
                ToolTipService.SetIsEnabled(MainWindow._MainWindow.nalogItem, false);
                ToolTipService.SetIsEnabled(MainWindow._MainWindow.menuPrikazi, false);
                ToolTipService.SetIsEnabled(MainWindow._MainWindow.menuZakazi, false);
                ToolTipService.SetIsEnabled(MainWindow._MainWindow.menuObavestenja, false);
                ToolTipService.SetIsEnabled(MainWindow._MainWindow.ItemPocetna, false);
                ToolTipService.SetIsEnabled(MainWindow._MainWindow.ItemOdjava, false);
                ToolTipService.SetIsEnabled(MainWindow._MainWindow.ItemPacijenti, false);
                ToolTipService.SetIsEnabled(MainWindow._MainWindow.ItemPregled, false);
                ToolTipService.SetIsEnabled(MainWindow._MainWindow.ItemValidacijaLeka, false);
            ToolTipService.SetIsEnabled(MainWindow._MainWindow.MenuPomoc, false);
            ToolTipService.SetIsEnabled(buttonUnos, false);
                ToolTipService.SetIsEnabled(ButtonPregled, false);


        }

        private void ButtonUnos_Click(object sender, RoutedEventArgs e)
        {
            DijalogZakazivanjePregleda dijalogZakazivanjePregleda = new DijalogZakazivanjePregleda();
            dijalogZakazivanjePregleda.ShowDialog();
        }

        private void ComboBox_SelectionChanged(object sender, TextChangedEventArgs e)
        {

           // pretrazeni.Clear();
           /*
            if(search.Text.Equals(""))
            {
                dgrMain.ItemsSource = MainWindow.Pacijenti.Pacijents;
            } else
            {
                foreach (Pacijent pacijent in MainWindow.Pacijenti.Pacijents)
                {
                    
                    if (pacijent.Prezime.Contains(search.Text) || pacijent.Ime.Contains(search.Text) || pacijent.FullName.Contains(search.Text))
                    {                    
                        pretrazeni.Add(pacijent);
                    }
                }
            }

            dgrMain.ItemsSource = pretrazeni.ToList();
        
            */
          
        }

    }

   
}
