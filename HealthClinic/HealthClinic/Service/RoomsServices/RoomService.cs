/***********************************************************************
 * Module:  RoomService.cs
 * Author:  Stefan
 * Purpose: Definition of the Class Service.RoomService
 ***********************************************************************/

using System;
using System.Collections.Generic;
using Model.Term;
using Model.Manager;

namespace Service.RoomsServices
{
   public class RoomService : IService<Model.Term.Room, int>
   {
      public Model.Term.Term GetLastTermForRoom(Model.Term.Room room)
      {
         throw new NotImplementedException();
      }
      
      public void DetermineTypeOfRoom(Model.Term.TypeOfRoom typeOfRoom, String roomID)
      {
         throw new NotImplementedException();
      }
      
      public bool AddEquipmentInRoom(Model.Manager.Equipment equipment, String roomID)
      {
         throw new NotImplementedException();
      }
      
      public List<Equipment> GetEquipmentFromRoom(String roomID)
      {
         throw new NotImplementedException();
      }
      
      public List<Room> GetAllFreeRoomsByDateTime(DateTime dateTime)
      {
         throw new NotImplementedException();
      }
      
      public Boolean GetOccupancyStatus(Model.Term.Room room, DateTime time)
      {
         throw new NotImplementedException();
      }

        public Room GetEntity(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Room> GetAllEntities()
        {
            throw new NotImplementedException();
        }

        public Room AddEntity(Room entity)
        {
            throw new NotImplementedException();
        }

        public void UpdateEntity(Room entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteEntity(Room entity)
        {
            throw new NotImplementedException();
        }

        public Repository.RoomsRepository.IRoomRepository iRoomRepository;
   
   }
}