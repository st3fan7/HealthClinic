/***********************************************************************
 * Module:  ValidationMedicamentService.cs
 * Author:  Stefan
 * Purpose: Definition of the Class Service.ValidationMedicamentService
 ***********************************************************************/

using Model.DoctorMenager;
using System;
using System.Collections.Generic;

namespace Service.MedicamentService
{
   public class ValidationMedicamentService : IService<ValidationOfMedicament,int>
   {
      

        public Repository.MedicamentRepository.IValidationOfMedicamentRepository iValidationOfMedicamentRepository;

        public ValidationOfMedicament AddEntity(ValidationOfMedicament entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteEntity(ValidationOfMedicament entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ValidationOfMedicament> GetAllEntities()
        {
            throw new NotImplementedException();
        }

        public ValidationOfMedicament GetEntity(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateEntity(ValidationOfMedicament entity)
        {
            throw new NotImplementedException();
        }
    }
}