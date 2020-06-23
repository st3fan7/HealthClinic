// File:    IMedicalExaminationRepository.cs
// Author:  Stefan
// Created: cetvrtak, 28. maj 2020. 00:41:44
// Purpose: Definition of Interface IMedicalExaminationRepository

using Model.Term;
using System;
using System.Collections.Generic;

namespace Repository.ExaminationSurgeryRepository
{
    public interface IMedicalExaminationRepository : IRepository<MedicalExamination, int>
    {
        List<MedicalExamination> GetAllMedicalExaminationsByDoctor(Model.AllActors.Doctor doctor);

        List<MedicalExamination> GetAllMedicalExaminationsByPatient(Model.AllActors.Patient patient);

        List<MedicalExamination> GetAllMedicalExaminationsByPatient(Model.Term.Room room);

        List<MedicalExamination> GetAllMedicalExaminationsByPatient2(DateTime time);

        MedicalExamination GetPreviousMedicalExemination(Model.AllActors.Patient patient);

        Boolean GetOccupancyStatus(Model.Term.MedicalExamination medicalExamination);

    }
}