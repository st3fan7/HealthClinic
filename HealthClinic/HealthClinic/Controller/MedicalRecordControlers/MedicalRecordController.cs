/***********************************************************************
 * Module:  MedicalRecordService.cs
 * Author:  Stefan
 * Purpose: Definition of the Class Service.MedicalRecordService
 ***********************************************************************/

using Model.PatientDoctor;
using Service.MedicalRecordService;
using Model.AllActors;
using System;
using System.Collections.Generic;

namespace Controller.MedicalRecordControlers
{
    public class MedicalRecordController : IController<MedicalRecord, int>
    {
        public MedicalRecordService medicalRecordService;

        public MedicalRecordController(MedicalRecordService medicalRecordService)
        {
            this.medicalRecordService = medicalRecordService;
        }

        public MedicalRecord OpenMedicalRecord(MedicalRecord medicalRecord)
        {
            throw new NotImplementedException();
        }

        public Model.PatientDoctor.MedicalRecord GetMedicalRecordByPatient(Patient patient)
        {
            throw new NotImplementedException();
        }

        public MedicalRecord GetEntity(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<MedicalRecord> GetAllEntities()
        {
            throw new NotImplementedException();
        }

        public MedicalRecord AddEntity(MedicalRecord entity)
        {
            throw new NotImplementedException();
        }

        public void UpdateEntity(MedicalRecord entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteEntity(MedicalRecord entity)
        {
            throw new NotImplementedException();
        }

    }
}