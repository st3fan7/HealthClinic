// File:    RecommendedDoctorBehaviour.cs
// Author:  Hacer
// Created: subota, 30. maj 2020. 22:08:25
// Purpose: Definition of Class RecommendedDoctorBehaviour

using System;

namespace Service.ExaminationSurgeryServices
{
   public class RecommendedDoctorBehaviour : IRecommendationBehaviour
   {
      public Model.Term.MedicalExamination RecommendMedicalExamination(Model.AllActors.Doctor doctor, Model.Term.Term dateRange)
      {
         throw new NotImplementedException();
      }
      
      public Repository.ExaminationSurgeryRepository.IMedicalExaminationRepository iMedicalExaminationRepository;
   
   }
}