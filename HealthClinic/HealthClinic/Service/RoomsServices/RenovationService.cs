/***********************************************************************
 * Module:  RenovationService.cs
 * Author:  Stefan
 * Purpose: Definition of the Class Service.RenovationService
 ***********************************************************************/

using Model.Term;
using System;
using System.Collections.Generic;

namespace Service.RoomsServices
{
   public class RenovationService : IService<Renovation,int>
   {
      public Model.Term.Renovation SeparateOnTwoParts(Model.Term.Renovation renovation)
      {
         throw new NotImplementedException();
      }
      
      public Model.Term.Renovation ConnectTwoParts(Model.Term.Renovation renovation)
      {
         throw new NotImplementedException();
      }
      
      public bool IsRoomFreeForRenovation(Model.Term.Room room, Model.Term.Term term)
      {
         throw new NotImplementedException();
      }
      
      public Model.Term.Room FindSecondPart(Model.Term.Room room)
      {
         throw new NotImplementedException();
      }
      
      public Model.Term.Room RelocateHalfEquipment(Model.Term.Room fromRoom, Model.Term.Room toRoom)
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

        public Repository.RoomsRepository.IRenovationRepository iRenovationRepository;
      public RoomService roomService;
   
   }
}