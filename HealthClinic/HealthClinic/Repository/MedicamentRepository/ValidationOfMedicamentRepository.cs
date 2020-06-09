// File:    ValidationOfMedicamentRepository.cs
// Author:  Stefan
// Created: cetvrtak, 28. maj 2020. 02:04:51
// Purpose: Definition of Class ValidationOfMedicamentRepository

using Model.AllActors;
using Model.DoctorMenager;
using Repository.Csv;
using Repository.Csv.Stream;
using Repository.IDSequencer;
using System;
using System.Collections.Generic;

namespace Repository.MedicamentRepository
{
    public class ValidationOfMedicamentRepository : CSVRepository<ValidationOfMedicament, int>, IValidationOfMedicamentRepository
    {
        private string path;

        public ValidationOfMedicamentRepository(ICSVStream<ValidationOfMedicament> stream, ISequencer<int> sequencer)
            : base(stream, sequencer)
        {
        }

        public List<ValidationOfMedicament> GetMedicamentsOnValidationForDoctor(Doctor doctor)
        {
            throw new NotImplementedException();
        }
    }
}