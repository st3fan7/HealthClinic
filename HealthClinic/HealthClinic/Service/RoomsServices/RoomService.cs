/***********************************************************************
 * Module:  RoomService.cs
 * Author:  Stefan
 * Purpose: Definition of the Class Service.RoomService
 ***********************************************************************/

using System;
using System.Collections.Generic;
using Model.Term;
using Model.Manager;
using Repository.RoomsRepository;

namespace Service.RoomsServices
{
    public class RoomService : IService<Room, int>
    {
        public IRoomRepository roomRepository;

        public RoomService(IRoomRepository roomRepository)
        {
            this.roomRepository = roomRepository;
        }

        public Term GetLastTermForRoom(Room room)
        {
            throw new NotImplementedException();
        }

        public void DetermineTypeOfRoom(TypeOfRoom typeOfRoom, String roomID)
        {
            throw new NotImplementedException();
        }

        public bool AddEquipmentInRoom(Equipment equipment, String roomID)
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
            return roomRepository.GetEntity(id);
        }

        public IEnumerable<Room> GetAllEntities()
        {
            return roomRepository.GetAllEntities();
        }

        public List<Room> GetAllRoomForMedicalExamination()
        {
            List<Room> medicalExaminationRooms = new List<Room>();
            foreach (Room room in GetAllEntities())
                if (room.TypeOfRoom.NameOfType.Equals("Soba za preglede"))
                    medicalExaminationRooms.Add(room);
            return medicalExaminationRooms;
        }

        public List<Room> GetAllRoomForSurgery()
        {
            List<Room> surgeryRooms = new List<Room>();
            foreach (Room room in GetAllEntities())
                if (room.TypeOfRoom.NameOfType.Equals("Soba za operacije"))
                    surgeryRooms.Add(room);
            return surgeryRooms;
        }

        public Room AddEntity(Room entity)
        {
            return roomRepository.AddEntity(entity);
        }

        public void UpdateEntity(Room entity)
        {
            roomRepository.UpdateEntity(entity);
        }

        public void DeleteEntity(Room entity)
        {
            roomRepository.UpdateEntity(entity);
        }

    }
}