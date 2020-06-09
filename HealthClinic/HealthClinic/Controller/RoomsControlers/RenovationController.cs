/***********************************************************************
 * Module:  RenovationService.cs
 * Author:  Stefan
 * Purpose: Definition of the Class Service.RenovationService
 ***********************************************************************/

using Model.Term;
using System;
using System.Collections.Generic;

namespace Controller.RoomsControlers
{
   public class RenovationController : IController<Renovation,int>
   {
      public bool SeparateOnTwoParts(Model.Term.Room room)
      {
         throw new NotImplementedException();
      }
      
      public bool ConnectTwoParts(Model.Term.Room room)
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

        public Service.RoomsServices.RenovationService renovationService;
   
   }
}