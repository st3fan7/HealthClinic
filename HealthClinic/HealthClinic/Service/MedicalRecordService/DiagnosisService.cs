// File:    DiagnosisService.cs
// Author:  Stefan
// Created: cetvrtak, 28. maj 2020. 03:11:26
// Purpose: Definition of Class DiagnosisService

using Model.PatientDoctor;
using Repository.MedicalRecordRepository;
using System;
using System.Collections.Generic;

namespace Service.MedicalRecordService
{
    public class DiagnosisService : IService<Diagnosis, int>
    {
        public IDiagnosisRepository diagnosisRepository;

        public DiagnosisService(IDiagnosisRepository diagnosisRepository)
        {
            this.diagnosisRepository = diagnosisRepository;
        }

        public Diagnosis GetEntity(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Diagnosis> GetAllEntities()
        {
            throw new NotImplementedException();
        }

        public Diagnosis AddEntity(Diagnosis entity)
        {
            throw new NotImplementedException();
        }

        public void UpdateEntity(Diagnosis entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteEntity(Diagnosis entity)
        {
            throw new NotImplementedException();
        }
    }
}