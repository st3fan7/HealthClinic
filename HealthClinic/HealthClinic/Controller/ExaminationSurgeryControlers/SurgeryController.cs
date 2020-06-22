/***********************************************************************
 * Module:  MedicalExaminationService.cs
 * Author:  Stefan
 * Purpose: Definition of the Class Service.MedicalExaminationService
 ***********************************************************************/

using Model.Term;
using Model.AllActors;
using Service.ExaminationSurgeryServices;
using System;
using System.Collections.Generic;

namespace Controller.ExaminationSurgeryControlers
{
    public class SurgeryController : IController<Surgery, int>
    {
        public SurgeryService surgeryService;

        public SurgeryController(SurgeryService surgeryService)
        {
            this.surgeryService = surgeryService;
        }

        public List<Surgery> GetByDate(DateTime date)
        {
            throw new NotImplementedException();
        }

        public List<Surgery> GetAllSurgeryByDoctor(Doctor doctor)
        {
            throw new NotImplementedException();
        }

        public List<Surgery> GetAllSurgeryByPatient(Patient patient)
        {
            throw new NotImplementedException();
        }

        public List<Surgery> GetAllMedicalExaminationsByPatient(Room room)
        {
            throw new NotImplementedException();
        }

        public List<Surgery> GetAllMedicalExaminationsByPatient2(DateTime time)
        {
            throw new NotImplementedException();
        }

        public Model.Term.Surgery GetPreviousSurgery(Patient patient)
        {
            throw new NotImplementedException();
        }

        public Surgery GetEntity(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Surgery> GetAllEntities()
        {
            throw new NotImplementedException();
        }

        public Surgery AddEntity(Surgery entity)
        {
            throw new NotImplementedException();
        }

        public void UpdateEntity(Surgery entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteEntity(Surgery entity)
        {
            throw new NotImplementedException();
        }

    }
}