/***********************************************************************
 * Module:  HospitalitationService.cs
 * Author:  Stefan
 * Purpose: Definition of the Class Service.HospitalitationService
 ***********************************************************************/

using Model.Term;
using System;
using System.Collections.Generic;

namespace Service.ExaminationSurgeryServices
{
   public class HospitalitationService : IService<Hospitalitation,int>
   {
      public Model.Term.Hospitalitation DetermineHospitalitation(Hospitalitation hospitalitation)
      {
         throw new NotImplementedException();
      }
      
      public List<Hospitalitation> GetAllHospitalitationsByRoom(Room room)
      {
         throw new NotImplementedException();
      }
      
      public List<Hospitalitation> GetByDate(DateTime date)
      {
         throw new NotImplementedException();
      }

        public Hospitalitation GetEntity(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Hospitalitation> GetAllEntities()
        {
            throw new NotImplementedException();
        }

        public Hospitalitation AddEntity(Hospitalitation entity)
        {
            throw new NotImplementedException();
        }

        public void UpdateEntity(Hospitalitation entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteEntity(Hospitalitation entity)
        {
            throw new NotImplementedException();
        }

        public Repository.ExaminationSurgeryRepository.IHospitalitationRepository iHospitalitationRepository;
   
   }
}