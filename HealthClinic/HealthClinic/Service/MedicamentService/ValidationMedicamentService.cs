/***********************************************************************
 * Module:  ValidationMedicamentService.cs
 * Author:  Stefan
 * Purpose: Definition of the Class Service.ValidationMedicamentService
 ***********************************************************************/

using Model.DoctorMenager;
using Repository.MedicamentRepository;
using System;
using System.Collections.Generic;

namespace Service.MedicamentService
{
    public class ValidationMedicamentService : IService<ValidationOfMedicament, int>
    {
        public IValidationOfMedicamentRepository validationOfMedicamentRepository;

        public ValidationMedicamentService(IValidationOfMedicamentRepository validationOfMedicamentRepository)
        {
            this.validationOfMedicamentRepository = validationOfMedicamentRepository;
        }

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