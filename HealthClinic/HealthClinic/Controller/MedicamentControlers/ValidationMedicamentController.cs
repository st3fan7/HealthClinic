/***********************************************************************
 * Module:  ValidationMedicamentService.cs
 * Author:  Stefan
 * Purpose: Definition of the Class Service.ValidationMedicamentService
 ***********************************************************************/

using Model.DoctorMenager;
using System;
using System.Collections.Generic;

namespace Controller.MedicamentControlers
{
   public class ValidationMedicamentController : IController<ValidationOfMedicament,int>
   {
     

        public Service.MedicamentService.ValidationMedicamentService validationMedicamentService;

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