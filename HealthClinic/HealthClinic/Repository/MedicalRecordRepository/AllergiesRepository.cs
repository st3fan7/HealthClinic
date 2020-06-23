/***********************************************************************
 * Module:  AllergiesRepository.cs
 * Author:  Stefan
 * Purpose: Definition of the Class Repository.AllergiesRepository
 ***********************************************************************/

using Model.PatientDoctor;
using Repository.Csv;
using Repository.Csv.Stream;
using Repository.IDSequencer;
using System;
using System.Collections.Generic;

namespace Repository.MedicalRecordRepository
{
    public class AllergiesRepository : CSVRepository<Allergies, int>, IAllergiesRepository
    {
        private string path;

        public AllergiesRepository(ICSVStream<Allergies> stream, ISequencer<int> sequencer)
            : base(stream, sequencer)
        {
        }

    }
}