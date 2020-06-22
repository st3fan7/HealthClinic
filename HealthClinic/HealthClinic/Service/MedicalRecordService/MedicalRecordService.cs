/***********************************************************************
 * Module:  MedicalRecordService.cs
 * Author:  Stefan
 * Purpose: Definition of the Class Service.MedicalRecordService
 ***********************************************************************/

using Model.PatientDoctor;
using Repository.MedicalRecordRepository;
using System;
using System.Collections.Generic;

namespace Service.MedicalRecordService
{
    public class MedicalRecordService : IService<MedicalRecord, int>
    {
        public IMedicalRecordRepository medicalRecordRepository;

        public MedicalRecordService(IMedicalRecordRepository medicalRecordRepository)
        {
            this.medicalRecordRepository = medicalRecordRepository;
        }

        public Model.PatientDoctor.MedicalRecord OpenMedicalRecord(Model.PatientDoctor.MedicalRecord medicalRecord)
        {
            throw new NotImplementedException();
        }

        public Model.PatientDoctor.MedicalRecord GetMedicalRecordByPatient(Model.AllActors.Patient patient)
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