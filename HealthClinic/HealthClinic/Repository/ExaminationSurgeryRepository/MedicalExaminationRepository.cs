/***********************************************************************
 * Module:  UserRepository.cs
 * Author:  Stefan
 * Purpose: Definition of the Class Repository.UserRepository
 ***********************************************************************/

using Model.AllActors;
using Model.Term;
using Repository.Csv;
using Repository.Csv.Stream;
using Repository.IDSequencer;
using System;
using System.Collections.Generic;

namespace Repository.ExaminationSurgeryRepository
{
    public class MedicalExaminationRepository : CSVRepository<MedicalExamination, int>, IMedicalExaminationRepository
    {
        private string path;

        public MedicalExaminationRepository(ICSVStream<MedicalExamination> stream, ISequencer<int> sequencer)
            : base(stream, sequencer)
        {
        }

        public List<MedicalExamination> GetAllMedicalExaminationsByDoctor(Doctor doctor)
        {
            throw new NotImplementedException();
        }

        public List<MedicalExamination> GetAllMedicalExaminationsByPatient(Patient patient)
        {
            throw new NotImplementedException();
        }

        public List<MedicalExamination> GetAllMedicalExaminationsByPatient(Room room)
        {
            throw new NotImplementedException();
        }

        public List<MedicalExamination> GetAllMedicalExaminationsByPatient2(DateTime time)
        {
            throw new NotImplementedException();
        }

        public bool GetOccupancyStatus(MedicalExamination medicalExamination)
        {
            throw new NotImplementedException();
        }

        public MedicalExamination GetPreviousMedicalExemination(Patient patient)
        {
            throw new NotImplementedException();
        }
    }
}