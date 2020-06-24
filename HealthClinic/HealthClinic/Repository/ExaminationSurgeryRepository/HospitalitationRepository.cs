/***********************************************************************
 * Module:  HospitalitationRepository.cs
 * Author:  Stefan
 * Purpose: Definition of the Class Repository.HospitalitationRepository
 ***********************************************************************/

using Model.Term;
using Repository.Csv;
using Repository.Csv.Converter;
using Repository.Csv.Stream;
using Repository.IDSequencer;
using System;
using System.Collections.Generic;

namespace Repository.ExaminationSurgeryRepository
{
    public class HospitalitationRepository : CSVRepository<Hospitalitation, int>, IHospitalitationRepository
    {
        private string path;
        private const string HOSPITALITATION_FILE = "../../Resources/Data/hospitalitations.csv";
        private static HospitalitationRepository instance;

        public static HospitalitationRepository Instance()
        {
            if (instance == null)
            {
                instance = new HospitalitationRepository(
                new CSVStream<Hospitalitation>(HOSPITALITATION_FILE, new HospitalitationCSVConverter(",")),
                new IntSequencer());
            }
            return instance;
        }

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