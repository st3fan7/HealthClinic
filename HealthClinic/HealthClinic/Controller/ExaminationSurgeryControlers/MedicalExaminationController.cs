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
    public class MedicalExaminationController : IController<MedicalExamination, int>
    {
        public MedicalExaminationService medicalExaminationService;

        public MedicalExaminationController(MedicalExaminationService medicalExaminationService)
        {
            this.medicalExaminationService = medicalExaminationService;
        }

        public void GetByDate(DateTime date)
        {
            throw new NotImplementedException();
        }

        public List<MedicalExamination> GetAllMedicalExaminationsByDoctor(Doctor doctor)
        {
            throw new NotImplementedException();
        }

        public List<MedicalExamination> GetAllMedicalExaminationsByPatient(Patient patient)
        {
            throw new NotImplementedException();
        }

        public List<MedicalExamination> GetAllMedicalExaminationsByPatient(Room room)
        {
            throw new NotImplementedException();
        }

        public List<MedicalExamination> GetAllMedicalExaminationsByPatient2(DateTime time)
        {
            throw new NotImplementedException();
        }

        public MedicalExamination GetPreviousMedicalExemination(Patient patient)
        {
            throw new NotImplementedException();
        }

        public MedicalExamination GetEntity(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<MedicalExamination> GetAllEntities()
        {
            throw new NotImplementedException();
        }

        public MedicalExamination AddEntity(MedicalExamination entity)
        {
            throw new NotImplementedException();
        }

        public void UpdateEntity(MedicalExamination entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteEntity(MedicalExamination entity)
        {
            throw new NotImplementedException();
        }

    }
}