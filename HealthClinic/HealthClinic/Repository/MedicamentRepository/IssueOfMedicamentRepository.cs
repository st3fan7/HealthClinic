/***********************************************************************
 * Module:  IssueMedicamentRepository.cs
 * Author:  Stefan
 * Purpose: Definition of the Class Repository.IssueMedicamentRepository
 ***********************************************************************/

using Model.Doctor;
using Repository.Csv;
using Repository.Csv.Stream;
using Repository.IDSequencer;
using System;

namespace Repository.MedicamentRepository
{
    public class IssueOfMedicamentRepository : CSVRepository<IssueOfMedicaments, int>, IIssueOfMedicamentRepository
    {
        private string path;

        public IssueOfMedicamentRepository(ICSVStream<IssueOfMedicaments> stream, ISequencer<int> sequencer)
            : base(stream, sequencer)
        {
        }

    }
}