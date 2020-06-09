// File:    SpetialitationService.cs
// Author:  Stefan
// Created: cetvrtak, 28. maj 2020. 03:47:24
// Purpose: Definition of Class SpetialitationService

using Model.Doctor;
using System;
using System.Collections.Generic;

namespace Service.UsersServices
{
   public class SpetialitationService : IService<Specialitation,int>
   {
      public Repository.UsersRepository.ISpecialitationRepository iSpecialitationRepository;

        public Specialitation AddEntity(Specialitation entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteEntity(Specialitation entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Specialitation> GetAllEntities()
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