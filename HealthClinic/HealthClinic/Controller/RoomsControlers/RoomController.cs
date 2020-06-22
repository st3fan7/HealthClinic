/***********************************************************************
 * Module:  RoomService.cs
 * Author:  Stefan
 * Purpose: Definition of the Class Service.RoomService
 ***********************************************************************/

using Model.Term;
using Model.Manager;
using Service.RoomsServices;
using System;

namespace Controller.RoomsControlers
{
    public class RoomController : IController<Room, int>
    {
        public RoomService roomService;

        public RoomController(RoomService roomService)
        {
            this.roomService = roomService;
        }

        public bool DetermineTypeOfRoom(TypeOfRoom typeOfRoom)
        {
            throw new NotImplementedException();
        }

        public bool AddEquipment(Equipment equipment)
        {
            throw new NotImplementedException();
        }

        public Model.Manager.Equipment TakeEquipment(Equipment equipment)
        {
            throw new NotImplementedException();
        }

        public Room GetEntity(int id)
        {
            throw new NotImplementedException();
        }

        public System.Collections.Generic.IEnumerable<Room> GetAllEntities()
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

    }
}