/***********************************************************************
 * Module:  HospitalitationService.cs
 * Author:  Stefan
 * Purpose: Definition of the Class Service.HospitalitationService
 ***********************************************************************/
using Model.Doctor;
using Model.Term;
using System;
using System.Collections.Generic;
using Service.ExaminationSurgeryServices;

namespace Controller.ExaminationSurgeryControlers
{
   public class HospitalitationController : IController<Hospitalitation,int>
   {
        public HospitalitationService hospitalitationService;

        public HospitalitationController(HospitalitationService hospitalitationService)
        {
            this.hospitalitationService = hospitalitationService;
        }

        public Hospitalitation AddEntity(Hospitalitation entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteEntity(Hospitalitation entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Hospitalitation> GetAllEntities()
        {
            throw new NotImplementedException();
        }

        public Hospitalitation GetEntity(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateEntity(Hospitalitation entity)
        {
            throw new NotImplementedException();
        }
    }
}