/***********************************************************************
 * Module:  DiagnosisRepository.cs
 * Author:  Stefan
 * Purpose: Definition of the Class Repository.DiagnosisRepository
 ***********************************************************************/

using Model.PatientDoctor;
using Repository.Csv;
using Repository.Csv.Stream;
using Repository.IDSequencer;
using System;

namespace Repository.MedicalRecordRepository
{
   public class DiagnosisRepository : CSVRepository<Diagnosis,int>, IDiagnosisRepository
   {
        private string path;

        public DiagnosisRepository(ICSVStream<Diagnosis> stream, ISequencer<int> sequencer)
            : base(stream, sequencer)
        {
        }

    }
}