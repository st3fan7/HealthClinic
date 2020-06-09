
// File:    SpetialitationController.cs
// Author:  Hacer
// Created: subota, 30. maj 2020. 20:25:24
// Purpose: Definition of Class SpetialitationController

using Model.Doctor;
using System;

namespace Controller.UsersControlers
{
   public class SpetialitationController : IController<Specialitation,int>
   {
      public Service.UsersServices.SpetialitationService spetialitationService;

        public Specialitation AddEntity(Specialitation entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteEntity(Specialitation entity)
        {
            throw new NotImplementedException();
        }

        public System.Collections.Generic.IEnumerable<Specialitation> GetAllEntities()
        {
            throw new NotImplementedException();
        }

        public Specialitation GetEntity(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateEntity(Specialitation entity)
        {
            throw new NotImplementedException();
        }
    }
}