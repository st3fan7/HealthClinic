/***********************************************************************
 * Module:  UserRepository.cs
 * Author:  Stefan
 * Purpose: Definition of the Class Repository.UserRepository
 ***********************************************************************/

using Model.DoctorMenager;
using Repository.Csv;
using Repository.Csv.Stream;
using Repository.IDSequencer;
using System;

namespace Repository.MedicamentRepository
{
   public class MedicamentRepository : CSVRepository<Medicament,int>, IMedicamentRepository
   {
        private string path;

        public MedicamentRepository(ICSVStream<Medicament> stream, ISequencer<int> sequencer)
           : base(stream, sequencer)
        {
        }

    }
}