using Controller.RoomsControlers;
using HealthClinic.View.Converter;
using HealthClinic.View.ViewModel;
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
    /// Interaction logic for Renovation.xaml
    /// </summary>
    public partial class Renovation : Window
    {
        private readonly RenovationController renovationController;
        private readonly RoomController roomController;

        public static ObservableCollection<ViewRenovation> RenovationView { get; set; }
        public static ObservableCollection<Room> RoomsView { get; set; }

        public Renovation()
        {
            InitializeComponent();
            this.DataContext = this;
            DataPickerFromDataTime.SelectedDate = DateTime.Now.Date;
            DataPickerToDataTime.SelectedDate = DateTime.Now.Date; // Izmeni

            var app = Application.Current as App;
            renovationController = app.RenovationController;
            roomController = app.RoomController;

            RoomsView = new ObservableCollection<Room>(roomController.GetAllEntities().ToList());
            RenovationView = new ObservableCollection<ViewRenovation>(RenovationConverter.ConvertRenovationListToRenovationViewList(
                renovationController.GetAllEntities().ToList()));
        }

        private bool ExistTwoParts(Room roomForRenovation)
        {
            foreach (Room room in roomController.GetAllEntities())
                if (room.RoomID.Equals(roomForRenovation.RoomID.Replace("a", "b")))
                    return true;
            return false;
        }

        private Room[] separateOnTwoParts(Room roomForRenovation)
        {
            Room[] rooms = new Room[2];
            rooms[0] = roomForRenovation;
            rooms[1] = new Room(roomForRenovation.RoomID.Replace("a", "b"),
                new TypeOfRoom(roomForRenovation.TypeOfRoom.ToString()), roomForRenovation.Equipment);
            return rooms;
        }

        private Room ConnectTwoParts(Room firstPartOfRoom, Room secondPartOfRoom)
        {
            return firstPartOfRoom;
        }

        private bool ExistRenovation(Room roomForRenovation)
        {
            foreach (Model.Term.Renovation oneRenovation in renovationController.GetAllEntities())
                if (oneRenovation.Room.GetId() == roomForRenovation.GetId())
                    return true;
            return false;
        }

        private void Button_Click_ZakaziRenoviranje(object sender, RoutedEventArgs e)
        {
            Room roomForRenovation = (Room)ComboBoxRooms.SelectedItem;
            if (ComboBoxSeparateOnTwoParts.SelectedItem.ToString().Substring(38).Equals("Da") && ComboBoxConnectTwoParts.SelectedItem.ToString().Substring(38).Equals("Ne"))
            {
                if (ExistTwoParts(roomForRenovation))
                {
                    MessageBox.Show("Sala je već podeljena na dva dela", "Neuspešno renoviranje", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
                roomForRenovation.TypeOfRoom.NameOfType = ComboBoxTypeOfRoom.SelectedItem.ToString().Substring(38);
                Room[] twoParts = separateOnTwoParts(roomForRenovation);
                RenovationView.Add(RenovationConverter.ConvertRenovationToRenovationView(
                    renovationController.AddEntity(new Model.Term.Renovation(InputTextDescription.Text, roomForRenovation,
                    (DateTime)DataPickerFromDataTime.SelectedDate, (DateTime)DataPickerToDataTime.SelectedDate))));
                MessageBox.Show("Uspešno ste zakazali renoviranje sale", "Obaveštenje", MessageBoxButton.OK, MessageBoxImage.Information);
                return;
            }
            if (ComboBoxSeparateOnTwoParts.SelectedItem.ToString().Substring(38).Equals("Ne") && ComboBoxConnectTwoParts.SelectedItem.ToString().Substring(38).Equals("Da"))
            {
                if (!ExistTwoParts(roomForRenovation))
                {
                    MessageBox.Show("Sala ne može da se spoji jer nema dva dela", "Neuspešno renoviranje", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
                    ConnectTwoParts(roomForRenovation, roomForRenovation);
                    MessageBox.Show("Uspešno ste zakazali renoviranje sale", "Obaveštenje", MessageBoxButton.OK, MessageBoxImage.Information);
                    return;
            }
            if (ExistRenovation(roomForRenovation))
            {
                MessageBox.Show("Već je zakazano renoviranje za izabranu salu", "Neuspešno renoviranje", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }                  
            RenovationView.Add(RenovationConverter.ConvertRenovationToRenovationView(
                 renovationController.AddEntity(new Model.Term.Renovation(InputTextDescription.Text, roomForRenovation,
                 (DateTime) DataPickerFromDataTime.SelectedDate, (DateTime) DataPickerToDataTime.SelectedDate))));
            MessageBox.Show("Uspešno ste zakazali renoviranje sale", "Obaveštenje", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Button_Click_PrikaziZauzecaSale(object sender, RoutedEventArgs e)
        {
            var roomOccupancy = new RoomOccupancy();
            roomOccupancy.ShowDialog();
        }

        private void Button_Click_PocetnaStrana(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

    }
}
