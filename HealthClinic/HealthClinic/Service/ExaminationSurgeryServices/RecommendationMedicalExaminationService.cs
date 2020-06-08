// File:    RecommendationMedicalExaminationService.cs
// Author:  Hacer
// Created: subota, 30. maj 2020. 22:08:23
// Purpose: Definition of Class RecommendationMedicalExaminationService

using System;

namespace Service.ExaminationSurgeryServices
{
   public class RecommendationMedicalExaminationService
   {
      public Model.Term.MedicalExamination RecommendMedicalExamination(Model.AllActors.Doctor doctor, Model.Term.Term dateRange)
      {
         throw new NotImplementedException();
      }
      
      public IRecommendationBehaviour iRecommendationBehaviour;
   
   }
}