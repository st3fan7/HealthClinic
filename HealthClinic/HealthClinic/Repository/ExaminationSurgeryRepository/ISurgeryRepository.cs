// File:    ISurgeryRepository.cs
// Author:  Stefan
// Created: cetvrtak, 28. maj 2020. 00:41:49
// Purpose: Definition of Interface ISurgeryRepository

using Model.Term;
using System;
using System.Collections.Generic;

namespace Repository.ExaminationSurgeryRepository
{
   public interface ISurgeryRepository : IRepository<Surgery,int>
   {
      List<Surgery> GetAllSurgeryByDoctor(Model.AllActors.Doctor doctor);
      
      List<Surgery> GetAllSurgeryByPatient(Model.AllActors.Patient patient);
      
      List<Surgery> GetAllMedicalExaminationsByPatient(Model.Term.Room room);
      
      List<Surgery> GetAllMedicalExaminationsByPatient2(DateTime time);
      
      Model.Term.Surgery GetPreviousSurgery(Model.AllActors.Patient patient);
   
   }
}