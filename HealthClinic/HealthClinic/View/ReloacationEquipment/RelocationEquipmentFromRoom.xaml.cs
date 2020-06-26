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
    /// Interaction logic for RelocationEquipmentFromRoom.xaml
    /// </summary>
    public partial class RelocationEquipmentFromRoom : Window
    {
        private readonly RoomController roomController;

        public static ObservableCollection<ViewInventaryRoom> InRoomView { get; set; }
        public static ObservableCollection<ViewInventaryRoom> FromRoomView { get; set; }
        public static ObservableCollection<Room> RoomsView { get; set; }
        private Room inRoom;
        private Room fromRoom;

        public RelocationEquipmentFromRoom()
        {
            InitializeComponent();
            this.DataContext = this;

            var app = Application.Current as App;
            roomController = app.RoomController;

            inRoom = (Room)ComboBoxInRoom.SelectedItem;
            fromRoom = (Room)ComboBoxfromRoom.SelectedItem;

            inRoom = GetFirstRoom(roomController.GetAllEntities().ToList());
            fromRoom = GetFirstRoom(roomController.GetAllEntities().ToList());

            RoomsView = new ObservableCollection<Room>(roomController.GetAllEntities().ToList());
            InRoomView = new ObservableCollection<ViewInventaryRoom>(InventaryRoomConverter.ConvertInventaryRoomListToInventaryRoomViewList(inRoom.Equipment));
            FromRoomView = new ObservableCollection<ViewInventaryRoom>(InventaryRoomConverter.ConvertInventaryRoomListToInventaryRoomViewList(fromRoom.Equipment));
        }

        private Room GetFirstRoom(List<Room> rooms)
        {
            foreach (Room room in rooms)
                return room;
            return null;
        }
        /*private List<InventaryRoom> GetInventaryForRoom(Room room) // napisi u controleru
        {
            foreach (Room oneRoom in roomController.GetAllEntities())
                if (oneRoom.RoomID == room.RoomID)
                    return oneRoom.Equipment;
            return null;
        }*/

        private void Button_Click_Premesti(object sender, RoutedEventArgs e)
        {
            if (inRoom.RoomID == fromRoom.RoomID)
            {
                MessageBox.Show("Ne možete premeštati opremu u istoj sali", "Greška", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            try
            {
                int.Parse(InputAmountOfEquipment.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Morate uneti broj za količinu", "Greška", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            foreach (ViewInventaryRoom equipmentForRelocate in FromRoomView)
            {
                if (equipmentForRelocate.Name.Equals(InputNameOfEquipment.Text))
                {
                    if (equipmentForRelocate.Quantity < int.Parse(InputAmountOfEquipment.Text))
                    {
                        MessageBox.Show("Ne postoji dovoljna količina opreme koju želite da premestite", "Greška", MessageBoxButton.OK, MessageBoxImage.Error);
                        return;
                    }

                    foreach (ViewInventaryRoom equipmentInRoom in InRoomView)
                    {
                        if (equipmentInRoom.Name.Equals(InputNameOfEquipment.Text))
                        {
                            equipmentForRelocate.Quantity -= int.Parse(InputAmountOfEquipment.Text);
                            equipmentInRoom.Quantity += int.Parse(InputAmountOfEquipment.Text);
                            MessageBox.Show("Uspešno ste premestili opremu", "Obaveštenje", MessageBoxButton.OK, MessageBoxImage.Information);
                            return;
                        }
                    } // Ako se premesta oprema koja ne postoji u prvoj sali
                    equipmentForRelocate.Quantity -= int.Parse(InputAmountOfEquipment.Text);
                    InRoomView.Add(new ViewInventaryRoom() { Name = equipmentForRelocate.Name, Quantity = int.Parse(InputAmountOfEquipment.Text) });
                    MessageBox.Show("Uspešno ste premestili opremu", "Obaveštenje", MessageBoxButton.OK, MessageBoxImage.Information);
                    return;
                }
            }
            MessageBox.Show("Ne postoji oprema koju želite da premestite", "Greška", MessageBoxButton.OK, MessageBoxImage.Error);
            return;
        }

        private void Button_Click_PocetnaStrana(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void EquipmentInRoom_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            InRoomView.Clear();
            inRoom = (Room)ComboBoxInRoom.SelectedItem;
            foreach(InventaryRoom equipment in inRoom.Equipment)
                InRoomView.Add(InventaryRoomConverter.ConvertInventaryRoomToInventaryRoomView(equipment));
        }

        private void EquipmentFromRoom_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            FromRoomView.Clear();
            fromRoom = (Room)ComboBoxfromRoom.SelectedItem;
            foreach (InventaryRoom equipment in fromRoom.Equipment)
                FromRoomView.Add(InventaryRoomConverter.ConvertInventaryRoomToInventaryRoomView(equipment));
        }

    }
}
