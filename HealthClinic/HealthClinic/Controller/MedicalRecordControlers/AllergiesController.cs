/***********************************************************************
 * Module:  AllergiesService.cs
 * Author:  Stefan
 * Purpose: Definition of the Class Service.ExaminationSurgeryServices.AllergiesService
 ***********************************************************************/

using Model.PatientDoctor;
using Service.MedicalRecordService;
using System;
using System.Collections.Generic;

namespace Controller.MedicalRecordControlers
{
    public class AllergiesController : IController<Allergies, int>
    {
        public AllergiesService allergiesService;

        public AllergiesController(AllergiesService allergiesService)
        {
            this.allergiesService = allergiesService;
        }

        public Allergies AddEntity(Allergies entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteEntity(Allergies entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Allergies> GetAllEntities()
        {
            throw new NotImplementedException();
        }

        public Allergies GetEntity(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateEntity(Allergies entity)
        {
            throw new NotImplementedException();
        }
    }
}