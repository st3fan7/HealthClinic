// File:    AllergiesService.cs
// Author:  Stefan
// Created: cetvrtak, 28. maj 2020. 03:11:26
// Purpose: Definition of Class AllergiesService

using Model.PatientDoctor;
using System;
using System.Collections.Generic;

namespace Service.MedicalRecordService
{
   public class AllergiesService : IService<Allergies,int>
   {
      public System.Collections.ArrayList iAllergiesRepository;
      
      /// <summary>
      /// Property for collection of Repository.MedicalRecordRepository.IAllergiesRepository
      /// </summary>
      /// <pdGenerated>Default opposite class collection property</pdGenerated>
      public System.Collections.ArrayList IAllergiesRepository
      {
         get
         {
            if (iAllergiesRepository == null)
               iAllergiesRepository = new System.Collections.ArrayList();
            return iAllergiesRepository;
         }
         set
         {
            RemoveAllIAllergiesRepository();
            if (value != null)
            {
               foreach (Repository.MedicalRecordRepository.IAllergiesRepository oIAllergiesRepository in value)
                  AddIAllergiesRepository(oIAllergiesRepository);
            }
         }
      }
      
      /// <summary>
      /// Add a new Repository.MedicalRecordRepository.IAllergiesRepository in the collection
      /// </summary>
      /// <pdGenerated>Default Add</pdGenerated>
      public void AddIAllergiesRepository(Repository.MedicalRecordRepository.IAllergiesRepository newIAllergiesRepository)
      {
         if (newIAllergiesRepository == null)
            return;
         if (this.iAllergiesRepository == null)
            this.iAllergiesRepository = new System.Collections.ArrayList();
         if (!this.iAllergiesRepository.Contains(newIAllergiesRepository))
            this.iAllergiesRepository.Add(newIAllergiesRepository);
      }
      
      /// <summary>
      /// Remove an existing Repository.MedicalRecordRepository.IAllergiesRepository from the collection
      /// </summary>
      /// <pdGenerated>Default Remove</pdGenerated>
      public void RemoveIAllergiesRepository(Repository.MedicalRecordRepository.IAllergiesRepository oldIAllergiesRepository)
      {
         if (oldIAllergiesRepository == null)
            return;
         if (this.iAllergiesRepository != null)
            if (this.iAllergiesRepository.Contains(oldIAllergiesRepository))
               this.iAllergiesRepository.Remove(oldIAllergiesRepository);
      }
      
      /// <summary>
      /// Remove all instances of Repository.MedicalRecordRepository.IAllergiesRepository from the collection
      /// </summary>
      /// <pdGenerated>Default removeAll</pdGenerated>
      public void RemoveAllIAllergiesRepository()
      {
         if (iAllergiesRepository != null)
            iAllergiesRepository.Clear();
      }

        public Allergies GetEntity(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Allergies> GetAllEntities()
        {
            throw new NotImplementedException();
        }

        public Allergies AddEntity(Allergies entity)
        {
            throw new NotImplementedException();
        }

        public void UpdateEntity(Allergies entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteEntity(Allergies entity)
        {
            throw new NotImplementedException();
        }
    }
}