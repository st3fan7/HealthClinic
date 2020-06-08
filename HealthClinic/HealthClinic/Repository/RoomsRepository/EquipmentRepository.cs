/***********************************************************************
 * Module:  UserRepository.cs
 * Author:  Stefan
 * Purpose: Definition of the Class Repository.UserRepository
 ***********************************************************************/

using Model.Manager;
using Repository.Csv;
using Repository.Csv.Stream;
using Repository.IDSequencer;
using System;

namespace Repository.RoomsRepository
{
    public class EquipmentRepository : CSVRepository<Equipment, int>, IEquipmentRepository
    {
        private String path;

        public EquipmentRepository(ICSVStream<Equipment> stream, ISequencer<int> sequencer)
           : base(stream, sequencer)
        {
        }

    }
}