using Controller.RoomsControlers;
using HealthClinic.View.Converter;
using HealthClinic.View.ViewModel;
using Model.Manager;
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
using System.Windows.Shapes;

namespace HealthClinic.View
{
    /// <summary>
    /// Interaction logic for RelocationEquipmentFromWarehouse.xaml
    /// </summary>
    public partial class RelocationEquipmentFromWarehouse : Window
    {
        private readonly RoomController roomController;
        private readonly EquipmentController equipmentController;
        private readonly InventaryRoomController inventaryRoomController;

        public static ObservableCollection<ViewInventaryRoom> InRoomView { get; set; }
        public static ObservableCollection<ViewEquipment> WarehouseView { get; set; }
        public static ObservableCollection<Room> RoomsView { get; set; }
        private Room inRoom;
        private Equipment warehouseEquipment;

        public RelocationEquipmentFromWarehouse()
        {
            InitializeComponent();
            this.DataContext = this;

            var app = Application.Current as App;
            roomController = app.RoomController;
            equipmentController = app.EquipmentController;
            inventaryRoomController = app.InventaryRoomController;

            inRoom = (Room)ComboBoxInRoom.SelectedItem;

            inRoom = roomController.GetFirstRoom(roomController.GetAllEntities().ToList());

            RoomsView = new ObservableCollection<Room>(roomController.GetAllEntities().ToList());
            InRoomView = new ObservableCollection<ViewInventaryRoom>(InventaryRoomConverter.ConvertInventaryRoomListToInventaryRoomViewList(inRoom.Equipment));
            WarehouseView = new ObservableCollection<ViewEquipment>(EquipmentConverter.ConvertEquipmnetListToEquipmentViewList(
                equipmentController.GetAllEntities().ToList()));
        }

        private void Button_Click_Premesti(object sender, RoutedEventArgs e)
        {
        }

        private void Button_Click_PocetnaStrana(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void EquipmentInRoom_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            InRoomView.Clear();
            inRoom = (Room)ComboBoxInRoom.SelectedItem;
            foreach (InventaryRoom equipment in inRoom.Equipment)
                InRoomView.Add(InventaryRoomConverter.ConvertInventaryRoomToInventaryRoomView(equipment));
        }
    }
}
