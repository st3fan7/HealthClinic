/***********************************************************************
 * Module:  RenovationRepository.cs
 * Author:  Stefan
 * Purpose: Definition of the Class Repository.RenovationRepository
 ***********************************************************************/

using Model.Term;
using Repository.Csv;
using Repository.Csv.Stream;
using Repository.IDSequencer;
using System;
using System.Collections.Generic;

namespace Repository.RoomsRepository
{
    public class RenovationRepository : CSVRepository<Renovation, int>, IRenovationRepository
    {
        private string path;

        public RenovationRepository(ICSVStream<Renovation> stream, ISequencer<int> sequencer)
           : base(stream, sequencer)
        {
        }

        public Room AddEntity(Room entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteEntity(Room entity)
        {
            throw new NotImplementedException();
        }

        public void UpdateEntity(Room entity)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Room> IRepository<Room, int>.GetAllEntities()
        {
            throw new NotImplementedException();
        }

        Room IRepository<Room, int>.GetEntity(int id)
        {
            throw new NotImplementedException();
        }
    }
}