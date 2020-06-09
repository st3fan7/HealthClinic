// File:    SymptomsService.cs
// Author:  Stefan
// Created: cetvrtak, 28. maj 2020. 03:11:26
// Purpose: Definition of Class SymptomsService

using Model.PatientDoctor;
using System;
using System.Collections.Generic;

namespace Service.MedicalRecordService
{
   public class SymptomsService : IService<Symptoms,int>
   {
      public System.Collections.ArrayList iSymptomsRepository;
      
      /// <summary>
      /// Property for collection of Repository.MedicalRecordRepository.ISymptomsRepository
      /// </summary>
      /// <pdGenerated>Default opposite class collection property</pdGenerated>
      public System.Collections.ArrayList ISymptomsRepository
      {
         get
         {
            if (iSymptomsRepository == null)
               iSymptomsRepository = new System.Collections.ArrayList();
            return iSymptomsRepository;
         }
         set
         {
            RemoveAllISymptomsRepository();
            if (value != null)
            {
               foreach (Repository.MedicalRecordRepository.ISymptomsRepository oISymptomsRepository in value)
                  AddISymptomsRepository(oISymptomsRepository);
            }
         }
      }
      
      /// <summary>
      /// Add a new Repository.MedicalRecordRepository.ISymptomsRepository in the collection
      /// </summary>
      /// <pdGenerated>Default Add</pdGenerated>
      public void AddISymptomsRepository(Repository.MedicalRecordRepository.ISymptomsRepository newISymptomsRepository)
      {
         if (newISymptomsRepository == null)
            return;
         if (this.iSymptomsRepository == null)
            this.iSymptomsRepository = new System.Collections.ArrayList();
         if (!this.iSymptomsRepository.Contains(newISymptomsRepository))
            this.iSymptomsRepository.Add(newISymptomsRepository);
      }
      
      /// <summary>
      /// Remove an existing Repository.MedicalRecordRepository.ISymptomsRepository from the collection
      /// </summary>
      /// <pdGenerated>Default Remove</pdGenerated>
      public void RemoveISymptomsRepository(Repository.MedicalRecordRepository.ISymptomsRepository oldISymptomsRepository)
      {
         if (oldISymptomsRepository == null)
            return;
         if (this.iSymptomsRepository != null)
            if (this.iSymptomsRepository.Contains(oldISymptomsRepository))
               this.iSymptomsRepository.Remove(oldISymptomsRepository);
      }
      
      /// <summary>
      /// Remove all instances of Repository.MedicalRecordRepository.ISymptomsRepository from the collection
      /// </summary>
      /// <pdGenerated>Default removeAll</pdGenerated>
      public void RemoveAllISymptomsRepository()
      {
         if (iSymptomsRepository != null)
            iSymptomsRepository.Clear();
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