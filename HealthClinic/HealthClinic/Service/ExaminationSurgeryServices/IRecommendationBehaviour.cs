// File:    IRecommendationBehaviour.cs
// Author:  Hacer
// Created: subota, 30. maj 2020. 22:08:28
// Purpose: Definition of Interface IRecommendationBehaviour

using System;

namespace Service.ExaminationSurgeryServices
{
   public interface IRecommendationBehaviour
   {
      Model.Term.MedicalExamination RecommendMedicalExamination(Model.AllActors.Doctor doctor, Model.Term.Term dateRange);
   
   }
}