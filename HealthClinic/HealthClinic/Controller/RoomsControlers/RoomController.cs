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
            // return roomService.DetermineTypeOfRoom(typeOfRoom)
            throw new NotImplementedException();
        }

        public bool AddEquipment(Equipment equipment)
        {
            //return roomService.add
            throw new NotImplementedException();
        }

        public Model.Manager.Equipment TakeEquipment(Equipment equipment)
        {
            //return roomService.take
            throw new NotImplementedException();
        }

        public Room GetEntity(int id)
        {
            return roomService.GetEntity(id);
        }

        public System.Collections.Generic.IEnumerable<Room> GetAllEntities()
        {
            return roomService.GetAllEntities();
        }

        public Room AddEntity(Room entity)
        {
            return roomService.AddEntity(entity);
        }

        public void UpdateEntity(Room entity)
        {
            roomService.UpdateEntity(entity);
        }

        public void DeleteEntity(Room entity)
        {
            roomService.DeleteEntity(entity);
        }

    }
}