/***********************************************************************
 * Module:  MedicalRecordRepository.cs
 * Author:  Stefan
 * Purpose: Definition of the Class Repository.MedicalRecordRepository
 ***********************************************************************/

using Model.AllActors;
using Model.PatientDoctor;
using Repository.Csv;
using Repository.Csv.Stream;
using Repository.IDSequencer;
using System;

namespace Repository.MedicalRecordRepository
{
   public class MedicalRecordRepository : CSVRepository<MedicalRecord,int>, IMedicalRecordRepository
   {
        private string path;

        public MedicalRecordRepository(ICSVStream<MedicalRecord> stream, ISequencer<int> sequencer)
           : base(stream, sequencer)
        {
        }

        public MedicalRecord GetMedicalRecordByPatient(Patient patient)
        {
            throw new NotImplementedException();
        }
    }
}