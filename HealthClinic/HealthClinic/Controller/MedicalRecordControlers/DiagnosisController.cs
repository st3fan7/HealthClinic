/***********************************************************************
 * Module:  DiagnosisService.cs
 * Author:  Stefan
 * Purpose: Definition of the Class Service.ExaminationSurgeryServices.DiagnosisService
 ***********************************************************************/

using Model.PatientDoctor;
using System;
using System.Collections.Generic;

namespace Controller.MedicalRecordControlers
{
   public class DiagnosisController : IController<Diagnosis,int>
   {
      public Service.MedicalRecordService.DiagnosisService diagnosisService;

        public Diagnosis AddEntity(Diagnosis entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteEntity(Diagnosis entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Diagnosis> GetAllEntities()
        {
            throw new NotImplementedException();
        }

        public Diagnosis GetEntity(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateEntity(Diagnosis entity)
        {
            throw new NotImplementedException();
        }
    }
}