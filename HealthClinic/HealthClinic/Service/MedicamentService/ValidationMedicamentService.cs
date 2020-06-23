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
            return validationOfMedicamentRepository.AddEntity(entity);
        }

        public void DeleteEntity(ValidationOfMedicament entity)
        {
            validationOfMedicamentRepository.DeleteEntity(entity);
        }

        public IEnumerable<ValidationOfMedicament> GetAllEntities()
        {
            return validationOfMedicamentRepository.GetAllEntities();
        }

        public ValidationOfMedicament GetEntity(int id)
        {
            return validationOfMedicamentRepository.GetEntity(id);
        }

        public void UpdateEntity(ValidationOfMedicament entity)
        {
            validationOfMedicamentRepository.UpdateEntity(entity);
        }
    }
}