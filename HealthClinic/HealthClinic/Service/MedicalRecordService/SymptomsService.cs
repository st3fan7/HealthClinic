// File:    SymptomsService.cs
// Author:  Stefan
// Created: cetvrtak, 28. maj 2020. 03:11:26
// Purpose: Definition of Class SymptomsService

using Model.PatientDoctor;
using Repository.MedicalRecordRepository;
using System;
using System.Collections.Generic;

namespace Service.MedicalRecordService
{
    public class SymptomsService : IService<Symptoms, int>
    {
        public ISymptomsRepository symptomsRepository;

        public SymptomsService(ISymptomsRepository symptomsRepository)
        {
            this.symptomsRepository = symptomsRepository;
        }

        public Symptoms GetEntity(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Symptoms> GetAllEntities()
        {
            throw new NotImplementedException();
        }

        public Symptoms AddEntity(Symptoms entity)
        {
            throw new NotImplementedException();
        }

        public void UpdateEntity(Symptoms entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteEntity(Symptoms entity)
        {
            throw new NotImplementedException();
        }
    }
}