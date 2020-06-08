/***********************************************************************
 * Module:  MedicalRecordService.cs
 * Author:  Stefan
 * Purpose: Definition of the Class Service.MedicalRecordService
 ***********************************************************************/

using Model.PatientDoctor;
using System;
using System.Collections.Generic;

namespace Service.MedicalRecordService
{
   public class MedicalRecordService : IService<MedicalRecord,int>
   {
      public Model.PatientDoctor.MedicalRecord OpenMedicalRecord(Model.PatientDoctor.MedicalRecord medicalRecord)
      {
         throw new NotImplementedException();
      }
      
      public Model.PatientDoctor.MedicalRecord GetMedicalRecordByPatient(Model.AllActors.Patient patient)
      {
         throw new NotImplementedException();
      }
      
      public System.Collections.ArrayList iMedicalRecordRepository;
      
      /// <summary>
      /// Property for collection of Repository.MedicalRecordRepository.IMedicalRecordRepository
      /// </summary>
      /// <pdGenerated>Default opposite class collection property</pdGenerated>
      public System.Collections.ArrayList IMedicalRecordRepository
      {
         get
         {
            if (iMedicalRecordRepository == null)
               iMedicalRecordRepository = new System.Collections.ArrayList();
            return iMedicalRecordRepository;
         }
         set
         {
            RemoveAllIMedicalRecordRepository();
            if (value != null)
            {
               foreach (Repository.MedicalRecordRepository.IMedicalRecordRepository oIMedicalRecordRepository in value)
                  AddIMedicalRecordRepository(oIMedicalRecordRepository);
            }
         }
      }
      
      /// <summary>
      /// Add a new Repository.MedicalRecordRepository.IMedicalRecordRepository in the collection
      /// </summary>
      /// <pdGenerated>Default Add</pdGenerated>
      public void AddIMedicalRecordRepository(Repository.MedicalRecordRepository.IMedicalRecordRepository newIMedicalRecordRepository)
      {
         if (newIMedicalRecordRepository == null)
            return;
         if (this.iMedicalRecordRepository == null)
            this.iMedicalRecordRepository = new System.Collections.ArrayList();
         if (!this.iMedicalRecordRepository.Contains(newIMedicalRecordRepository))
            this.iMedicalRecordRepository.Add(newIMedicalRecordRepository);
      }
      
      /// <summary>
      /// Remove an existing Repository.MedicalRecordRepository.IMedicalRecordRepository from the collection
      /// </summary>
      /// <pdGenerated>Default Remove</pdGenerated>
      public void RemoveIMedicalRecordRepository(Repository.MedicalRecordRepository.IMedicalRecordRepository oldIMedicalRecordRepository)
      {
         if (oldIMedicalRecordRepository == null)
            return;
         if (this.iMedicalRecordRepository != null)
            if (this.iMedicalRecordRepository.Contains(oldIMedicalRecordRepository))
               this.iMedicalRecordRepository.Remove(oldIMedicalRecordRepository);
      }
      
      /// <summary>
      /// Remove all instances of Repository.MedicalRecordRepository.IMedicalRecordRepository from the collection
      /// </summary>
      /// <pdGenerated>Default removeAll</pdGenerated>
      public void RemoveAllIMedicalRecordRepository()
      {
         if (iMedicalRecordRepository != null)
            iMedicalRecordRepository.Clear();
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