/***********************************************************************
 * Module:  ValidationMedicamentService.cs
 * Author:  Stefan
 * Purpose: Definition of the Class Service.ValidationMedicamentService
 ***********************************************************************/

using Model.DoctorMenager;
using Service.MedicamentService;
using System;
using System.Collections.Generic;

namespace Controller.MedicamentControlers
{
    public class ValidationMedicamentController : IController<ValidationOfMedicament, int>
    {
        public ValidationMedicamentService validationMedicamentService;

        public ValidationMedicamentController(ValidationMedicamentService validationMedicamentService)
        {
            this.validationMedicamentService = validationMedicamentService;
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