// File:    DiagnosisService.cs
// Author:  Stefan
// Created: cetvrtak, 28. maj 2020. 03:11:26
// Purpose: Definition of Class DiagnosisService

using Model.PatientDoctor;
using System;
using System.Collections.Generic;

namespace Service.MedicalRecordService
{
   public class DiagnosisService : IService<Diagnosis,int>
   {
      public System.Collections.ArrayList iDiagnosisRepository;
      
      /// <summary>
      /// Property for collection of Repository.MedicalRecordRepository.IDiagnosisRepository
      /// </summary>
      /// <pdGenerated>Default opposite class collection property</pdGenerated>
      public System.Collections.ArrayList IDiagnosisRepository
      {
         get
         {
            if (iDiagnosisRepository == null)
               iDiagnosisRepository = new System.Collections.ArrayList();
            return iDiagnosisRepository;
         }
         set
         {
            RemoveAllIDiagnosisRepository();
            if (value != null)
            {
               foreach (Repository.MedicalRecordRepository.IDiagnosisRepository oIDiagnosisRepository in value)
                  AddIDiagnosisRepository(oIDiagnosisRepository);
            }
         }
      }
      
      /// <summary>
      /// Add a new Repository.MedicalRecordRepository.IDiagnosisRepository in the collection
      /// </summary>
      /// <pdGenerated>Default Add</pdGenerated>
      public void AddIDiagnosisRepository(Repository.MedicalRecordRepository.IDiagnosisRepository newIDiagnosisRepository)
      {
         if (newIDiagnosisRepository == null)
            return;
         if (this.iDiagnosisRepository == null)
            this.iDiagnosisRepository = new System.Collections.ArrayList();
         if (!this.iDiagnosisRepository.Contains(newIDiagnosisRepository))
            this.iDiagnosisRepository.Add(newIDiagnosisRepository);
      }
      
      /// <summary>
      /// Remove an existing Repository.MedicalRecordRepository.IDiagnosisRepository from the collection
      /// </summary>
      /// <pdGenerated>Default Remove</pdGenerated>
      public void RemoveIDiagnosisRepository(Repository.MedicalRecordRepository.IDiagnosisRepository oldIDiagnosisRepository)
      {
         if (oldIDiagnosisRepository == null)
            return;
         if (this.iDiagnosisRepository != null)
            if (this.iDiagnosisRepository.Contains(oldIDiagnosisRepository))
               this.iDiagnosisRepository.Remove(oldIDiagnosisRepository);
      }
      
      /// <summary>
      /// Remove all instances of Repository.MedicalRecordRepository.IDiagnosisRepository from the collection
      /// </summary>
      /// <pdGenerated>Default removeAll</pdGenerated>
      public void RemoveAllIDiagnosisRepository()
      {
         if (iDiagnosisRepository != null)
            iDiagnosisRepository.Clear();
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