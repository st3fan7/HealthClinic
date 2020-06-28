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
    /// Interaction logic for UserControlPacijenti.xaml
    /// </summary>
    /// 
    
   



    public partial class UserControlPacijenti : UserControl
    {
        //public ObservableCollection<Pacijent> Pacijenti
        //{
        //   get;
        //   set;
        //        }
        private readonly UserController userController;
        public static ViewSurgery viewSurgery = null;
        public static Patient staticPatient = new Patient();
        public static Surgery surgery = null;
        public static SurgeryController surgeryController;
        public static ObservableCollection<View.ViewModel.ViewSurgery> ViewSurgeries { get; set; }


        public UserControlPacijenti()
        {
            InitializeComponent();
            //this.DataContext = this;
            //          this.DataContext = MainWindow.Pacijenti;
            //Pacijenti = UserControlPocetna.Pacijenti;

            var app = App.Current as App;
            userController = app.UserController;
            surgeryController = app.SurgeryController;
            ViewSurgeries = new ObservableCollection<ViewSurgery>(SurgeryConverter.ConvertMEListToMEViewList(
              surgeryController.GetAllSurgeryByDoctor(Window1.ulogovaniDoctor).ToList()));

            this.DataContext = ViewSurgeries;
            pacijentiDgr.ItemsSource = ViewSurgeries;




        }

        private void ButtonPocetna_Click(object sender, RoutedEventArgs e)
        {
            MainWindow._MainWindow.GridMain.Children.Add(new UserControlPocetna());
        }

        private void PacijentiDgr_SelectionChanged(object sender, RoutedEventArgs e)
        {
            viewSurgery = (ViewSurgery)pacijentiDgr.SelectedItem;
            surgery = surgeryController.GetEntity(viewSurgery.Id);

            staticPatient = (Patient)userController.GetEntity(surgery.Patient.Id);

            

        }
    }
}
