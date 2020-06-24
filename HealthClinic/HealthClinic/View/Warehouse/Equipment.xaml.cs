using Controller;
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
    /// Interaction logic for Equipment.xaml
    /// </summary>
    public partial class Equipment : Window
    {
        public static RoutedCommand helpSchortcut = new RoutedCommand();

        private readonly IController<Model.Manager.Equipment, int> equipmentController;

        public static ObservableCollection<Model.Manager.Equipment> EquipmentView { get; set; }

        public Equipment()
        {
            InitializeComponent();
            this.DataContext = this;
            helpSchortcut.InputGestures.Add(new KeyGesture(Key.H, ModifierKeys.Control));
            CommandBindings.Add(new CommandBinding(helpSchortcut, ShortKey_Click));
            InputSearch.Focus();
            InputSearch.SelectAll();

            var app = Application.Current as App;

            equipmentController = app.EquipmentController;

            EquipmentView = new ObservableCollection<Model.Manager.Equipment>(equipmentController.GetAllEntities().ToList());
        }

        private void Button_Click_Dodaj(object sender, RoutedEventArgs e)
        {
            var addEquipment = new AddEquipment();
            addEquipment.ShowDialog();
        }

        private void Button_Click_UnesiNovuOpremu(object sender, RoutedEventArgs e)
        {
            var addNewEquipment = new AddNewEquipment();
            addNewEquipment.ShowDialog();
        }

        private void Button_Click_Obrisi(object sender, RoutedEventArgs e)
        {
            Model.Manager.Equipment selectedEquipment = (Model.Manager.Equipment)DataGridEquipment.SelectedItem;
            if (MessageBox.Show("Da li ste sigurni da želite da obrišete lek?", "Pitanje", MessageBoxButton.YesNo, MessageBoxImage.Question)
                == MessageBoxResult.Yes)
            {
                equipmentController.DeleteEntity(selectedEquipment);
                EquipmentView.Remove(selectedEquipment);
                MessageBox.Show("Uspešno ste obrisali lek", "Obaveštenje", MessageBoxButton.OK, MessageBoxImage.Information);
            }                     
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
            var filtered = EquipmentView.Where(equipment => equipment.Code.StartsWith(InputSearch.Text)
            || equipment.Name.StartsWith(InputSearch.Text) || equipment.TypeOfEquipment.StartsWith(InputSearch.Text) 
            || equipment.Amount.ToString().StartsWith(InputSearch.Text));
            DataGridEquipment.ItemsSource = filtered;
        }
    }
}
