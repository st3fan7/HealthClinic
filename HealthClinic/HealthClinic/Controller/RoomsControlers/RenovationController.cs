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
            // return renovationService.SeparateOnTwoParts(room);
            throw new NotImplementedException();
        }

        public bool ConnectTwoParts(Room room)
        {
            //return renovationService.ConnectTwoParts(room);
            throw new NotImplementedException();
        }

        public Renovation GetEntity(int id)
        {
            return renovationService.GetEntity(id);
        }

        public IEnumerable<Renovation> GetAllEntities()
        {
            return renovationService.GetAllEntities();
        }

        public Renovation AddEntity(Renovation entity)
        {
            return renovationService.AddEntity(entity);
        }

        public void UpdateEntity(Renovation entity)
        {
            renovationService.UpdateEntity(entity);
        }

        public void DeleteEntity(Renovation entity)
        {
            renovationService.DeleteEntity(entity);
        }

    }
}