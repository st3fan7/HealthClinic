/***********************************************************************
 * Module:  SymptomsService.cs
 * Author:  Stefan
 * Purpose: Definition of the Class Service.ExaminationSurgeryServices.SymptomsService
 ***********************************************************************/

using Model.PatientDoctor;
using Service.MedicalRecordService;
using System;

namespace Controller.MedicalRecordControlers
{
    public class SymptomsController : IController<Symptoms, int>
    {
        public SymptomsService symptomsService;

        public SymptomsController(SymptomsService symptomsService)
        {
            this.symptomsService = symptomsService;
        }

        public Symptoms AddEntity(Symptoms entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteEntity(Symptoms entity)
        {
            throw new NotImplementedException();
        }

        public System.Collections.Generic.IEnumerable<Symptoms> GetAllEntities()
        {
            throw new NotImplementedException();
        }

        public Symptoms GetEntity(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateEntity(Symptoms entity)
        {
            throw new NotImplementedException();
        }
    }
}