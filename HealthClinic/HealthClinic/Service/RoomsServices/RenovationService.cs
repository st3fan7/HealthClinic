/***********************************************************************
 * Module:  RenovationService.cs
 * Author:  Stefan
 * Purpose: Definition of the Class Service.RenovationService
 ***********************************************************************/

using Model.Term;
using Repository.RoomsRepository;
using System;
using System.Collections.Generic;

namespace Service.RoomsServices
{
    public class RenovationService : IService<Renovation, int>
    {
        public IRenovationRepository renovationRepository;
        //public RoomService roomService;

        public RenovationService(IRenovationRepository renovationRepository)
        {
            this.renovationRepository = renovationRepository;
        }

        public Renovation SeparateOnTwoParts(Renovation renovation)
        {
            throw new NotImplementedException();
        }

        public Renovation ConnectTwoParts(Renovation renovation)
        {
            throw new NotImplementedException();
        }

        public bool IsRoomFreeForRenovation(Room room, Term term)
        {
            throw new NotImplementedException();
        }

        public Room FindSecondPart(Room room)
        {
            throw new NotImplementedException();
        }

        public Room RelocateHalfEquipment(Room fromRoom, Room toRoom)
        {
            throw new NotImplementedException();
        }

        public Renovation GetEntity(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Renovation> GetAllEntities()
        {
            throw new NotImplementedException();
        }

        public Renovation AddEntity(Renovation entity)
        {
            throw new NotImplementedException();
        }

        public void UpdateEntity(Renovation entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteEntity(Renovation entity)
        {
            throw new NotImplementedException();
        }

    }
}