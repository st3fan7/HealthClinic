/***********************************************************************
 * Module:  HospitalitationRepository.cs
 * Author:  Stefan
 * Purpose: Definition of the Class Repository.HospitalitationRepository
 ***********************************************************************/

using Model.Term;
using Repository.Csv;
using Repository.Csv.Stream;
using Repository.IDSequencer;
using System;
using System.Collections.Generic;

namespace Repository.ExaminationSurgeryRepository
{
    public class HospitalitationRepository : CSVRepository<Hospitalitation, int>, IHospitalitationRepository
    {
        private string path;

        public HospitalitationRepository(ICSVStream<Hospitalitation> stream, ISequencer<int> sequencer)
            : base(stream, sequencer)
        {
        }

        public List<Hospitalitation> GetAllHospitalitationsByRoom(Room room)
        {
            throw new NotImplementedException();
        }

        public List<Hospitalitation> GetByDate(DateTime date)
        {
            throw new NotImplementedException();
        }
    }
}