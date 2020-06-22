/***********************************************************************
 * Module:  RenovationService.cs
 * Author:  Stefan
 * Purpose: Definition of the Class Service.RenovationService
 ***********************************************************************/

using Model.Term;
using Service.RoomsServices;
using System;
using System.Collections.Generic;

namespace Controller.RoomsControlers
{
    public class RenovationController : IController<Renovation, int>
    {
        public RenovationService renovationService;

        public RenovationController(RenovationService renovationService)
        {
            this.renovationService = renovationService;
        }

        public bool SeparateOnTwoParts(Room room)
        {
            throw new NotImplementedException();
        }

        public bool ConnectTwoParts(Room room)
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