/***********************************************************************
 * Module:  SymptomsRepository.cs
 * Author:  Stefan
 * Purpose: Definition of the Class Repository.SymptomsRepository
 ***********************************************************************/

using Model.PatientDoctor;
using Repository.Csv;
using Repository.Csv.Stream;
using Repository.IDSequencer;
using System;

namespace Repository.MedicalRecordRepository
{
    public class SymptomsRepository : CSVRepository<Symptoms, int>, ISymptomsRepository
    {
        private string path;

        public SymptomsRepository(ICSVStream<Symptoms> stream, ISequencer<int> sequencer)
            : base(stream, sequencer)
        {
        }

    }
}