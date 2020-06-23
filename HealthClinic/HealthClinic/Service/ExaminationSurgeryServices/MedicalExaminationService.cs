/***********************************************************************
 * Module:  MedicalExaminationService.cs
 * Author:  Stefan
 * Purpose: Definition of the Class Service.MedicalExaminationService
 ***********************************************************************/

using Model.Term;
using Repository.ExaminationSurgeryRepository;
using System;
using System.Collections.Generic;

namespace Service.ExaminationSurgeryServices
{
    public class MedicalExaminationService : IService<MedicalExamination, int>
    {
        public IMedicalExaminationRepository medicalExaminationRepository;

        public MedicalExaminationService(IMedicalExaminationRepository medicalExaminationRepository)
        {
            this.medicalExaminationRepository = medicalExaminationRepository;
        }

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
            return medicalExaminationRepository.GetEntity(id);
        }

        public IEnumerable<MedicalExamination> GetAllEntities()
        {
            return medicalExaminationRepository.GetAllEntities();
        }

        public MedicalExamination AddEntity(MedicalExamination entity)
        {
            return medicalExaminationRepository.AddEntity(entity);
        }

        public void UpdateEntity(MedicalExamination entity)
        {
            medicalExaminationRepository.UpdateEntity(entity);
        }

        public void DeleteEntity(MedicalExamination entity)
        {
            medicalExaminationRepository.DeleteEntity(entity);
        }

    }
}