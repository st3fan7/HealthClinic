/***********************************************************************
 * Module:  MedicalExaminationService.cs
 * Author:  Stefan
 * Purpose: Definition of the Class Service.MedicalExaminationService
 ***********************************************************************/

using Model.Term;
using System;
using System.Collections.Generic;

namespace Service.ExaminationSurgeryServices
{
   public class MedicalExaminationService : IService<MedicalExamination,int>
   {
      public List<MedicalExamination> GetByDate(DateTime date)
      {
         throw new NotImplementedException();
      }

        public List<MedicalExamination> GetAllMedicalExaminationsByDoctor(Model.AllActors.Doctor doctor)
        {
            throw new NotImplementedException();
        }

        public List<MedicalExamination> GetAllMedicalExaminationsByPatient(Model.AllActors.Patient patient)
        {
            throw new NotImplementedException();
        }

        public List<MedicalExamination> GetAllMedicalExaminationsByPatient(Model.Term.Room room)
        {
            throw new NotImplementedException();
        }

        public List<MedicalExamination> GetAllMedicalExaminationsByPatient2(DateTime time)
        {
            throw new NotImplementedException();
        }

        public MedicalExamination GetPreviousMedicalExemination(Model.AllActors.Patient patient)
        {
            throw new NotImplementedException();
        }

        public bool IsMedicalExaminationFreeForScheduling(Model.Term.MedicalExamination medicalExamination)
      {
         throw new NotImplementedException();
      }
      
      public bool IsRoomFreeForScheduling(Model.Term.Room room, DateTime time)
      {
         throw new NotImplementedException();
      }
      
      public Boolean IsDoctorFreeForScheduling(Model.AllActors.Doctor doctor, DateTime time)
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

        public Repository.ExaminationSurgeryRepository.IMedicalExaminationRepository iMedicalExaminationRepository;
   
   }
}