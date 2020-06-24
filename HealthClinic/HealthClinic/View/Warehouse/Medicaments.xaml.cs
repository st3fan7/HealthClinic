using Controller;
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
    /// Interaction logic for Medicaments.xaml
    /// </summary>
    public partial class Medicaments : Window
    {
        public static RoutedCommand helpSchortcut = new RoutedCommand();

        private readonly IController<Medicament, int> medicamentController;

        public static ObservableCollection<Medicament> MedicamentsView { get; set; }

        public Medicaments()
        {
            InitializeComponent();
            this.DataContext = this;
            helpSchortcut.InputGestures.Add(new KeyGesture(Key.H, ModifierKeys.Control));
            CommandBindings.Add(new CommandBinding(helpSchortcut, ShortKey_Click));
            InputSearch.Focus();
            InputSearch.SelectAll();

            var app = Application.Current as App;

            medicamentController = app.MedicamentController;

            MedicamentsView = new ObservableCollection<Medicament>(medicamentController.GetAllEntities().ToList());          
        }

        private void Button_Click_Dodaj(object sender, RoutedEventArgs e)
        {
            var addMedicament = new AddMedicament();
            addMedicament.ShowDialog();
        }

        private void Button_Click_UnesiNoviLek(object sender, RoutedEventArgs e)
        {
            var addNewMedicament = new AddNewMedicament();
            addNewMedicament.ShowDialog();
        }

        private void Button_Click_Obrisi(object sender, RoutedEventArgs e)
        {
            
        }

        private void Button_Click_PocetnaStrana(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void ShortKey_Click(object sender, ExecutedRoutedEventArgs e)
        {
            var helpWindow = new HelpWindow();
            helpWindow.ShowDialog();
        }

        private void Search_KeyUp(object sender, KeyEventArgs e)
        {

        }
    }
}
