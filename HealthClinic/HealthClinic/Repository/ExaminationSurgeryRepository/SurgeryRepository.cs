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
   public class SurgeryRepository : CSVRepository<Surgery,int>, ISurgeryRepository
   {
        private string path;

        public SurgeryRepository(ICSVStream<Surgery> stream, ISequencer<int> sequencer)
            : base(stream, sequencer)
        {
        }

        public List<Surgery> GetAllMedicalExaminationsByPatient(Room room)
        {
            throw new NotImplementedException();
        }

        public List<Surgery> GetAllMedicalExaminationsByPatient2(DateTime time)
        {
            throw new NotImplementedException();
        }

        public List<Surgery> GetAllSurgeryByDoctor(Doctor doctor)
        {
            throw new NotImplementedException();
        }

        public List<Surgery> GetAllSurgeryByPatient(Patient patient)
        {
            throw new NotImplementedException();
        }

        public Surgery GetPreviousSurgery(Patient patient)
        {
            throw new NotImplementedException();
        }
    }
}