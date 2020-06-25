using HealthClinic.View.ViewModel;
using Model.Term;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthClinic.View.Converter
{
    class RoomConverter : AbstractConverter
    {
        public static ViewRoom ConvertRoomToRoomView(Room room)
        {
            return new ViewRoom
            {
                Id = room.GetId(),
                RoomID = room.RoomID,
                TypeOfRoom = room.TypeOfRoom.NameOfType,
                Equipment = EquipmentToString(room.Equipment)
            };
        }

        public static IList<ViewRoom> ConvertRoomListToRoomtViewList(IList<Room> equipments)
            => ConvertEntityListToViewList(equipments, ConvertRoomToRoomView);

        private static String EquipmentToString(List<Model.Manager.Equipment> equipmentInRoom)
        {
            String ret = "";
            foreach (Model.Manager.Equipment equipment in equipmentInRoom)
                ret += equipment.Name + " - " + equipment.Amount.ToString() + ", ";      
            return ret.Substring(0, ret.Length - 2);
        }
    }
}
