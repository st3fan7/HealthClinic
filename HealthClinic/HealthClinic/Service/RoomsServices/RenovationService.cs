/***********************************************************************
 * Module:  RenovationService.cs
 * Author:  Stefan
 * Purpose: Definition of the Class Service.RenovationService
 ***********************************************************************/

using Model.Manager;
using Model.Term;
using Repository.RoomsRepository;
using System;
using System.Collections.Generic;

namespace Service.RoomsServices
{
    public class RenovationService : IService<Renovation, int>
    {
        public IRenovationRepository renovationRepository;
        public RoomService roomService;

        public RenovationService(IRenovationRepository renovationRepository, RoomService roomService)
        {
            this.renovationRepository = renovationRepository;
            this.roomService = roomService;
        }

        public Renovation SeparateOnTwoParts(Renovation renovation)
        {
            foreach(Room room in roomService.GetAllEntities())
                if (room.RoomID.Equals(renovation.Room.RoomID))
                {
                    Room secondPartOfRoom = renovation.Room;
                    secondPartOfRoom.RoomID.Replace("a", "b");
                    secondPartOfRoom.Equipment.Clear();
                    roomService.AddEntity(secondPartOfRoom);
                    return renovationRepository.AddEntity(new Renovation(renovation.DescriptionOfRenovation, secondPartOfRoom,
                        renovation.FromDateTime, renovation.ToDateTime));                   
                }
            return null;
        }

        public Renovation ConnectTwoParts(Renovation renovation)
        {
            foreach (Room room in roomService.GetAllEntities())
                if (room.RoomID.Equals(renovation.Room.RoomID))
                {
                    Room connectedRoom = roomService.GetRoomByRoomID(renovation.Room.RoomID);
                    Room secondPartOfRoom = roomService.GetRoomByRoomID(renovation.Room.RoomID.Replace("a","b"));
                    foreach(InventaryRoom equipment in roomService.GetEquipmentForRoom(secondPartOfRoom))
                        roomService.AddEquipmentInRoom(equipment, connectedRoom.RoomID);
                    roomService.DeleteEntity(secondPartOfRoom);
                    renovation.Room = connectedRoom;
                    return renovation;
                }
            return null;
        }

        public bool IsRoomFreeForRenovation(Room room, DateTime term)
        {
            if (room.ToDateTime > term)
                return false;
            return true;
        }

        public Room FindSecondPart(Room room)
        {
            foreach(Room oneRoom in roomService.GetAllEntities())
                if (room.RoomID.Replace("a", "b").Equals(oneRoom.RoomID))
                    return room;
            return null;
        }

        public Renovation GetEntity(int id)
        {
            return renovationRepository.GetEntity(id);
        }

        public IEnumerable<Renovation> GetAllEntities()
        {
            return renovationRepository.GetAllEntities();
        }

        public Renovation AddEntity(Renovation entity)
        {
            return renovationRepository.AddEntity(entity);
        }

        public void UpdateEntity(Renovation entity)
        {
            renovationRepository.UpdateEntity(entity);
        }

        public void DeleteEntity(Renovation entity)
        {
            renovationRepository.DeleteEntity(entity);
        }

    }
}