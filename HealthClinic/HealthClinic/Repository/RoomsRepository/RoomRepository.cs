/***********************************************************************
 * Module:  UserRepository.cs
 * Author:  Stefan
 * Purpose: Definition of the Class Repository.UserRepository
 ***********************************************************************/

using Model.Term;
using Repository.Csv;
using Repository.Csv.Stream;
using Repository.IDSequencer;
using System;
using System.Collections.Generic;

namespace Repository.RoomsRepository
{
   public class RoomRepository : CSVRepository<Room,int>, IRoomRepository
   {
        private String path;

        public RoomRepository(ICSVStream<Room> stream, ISequencer<int> sequencer)
          : base(stream, sequencer)
        {
        }

        public Renovation AddEntity(Renovation entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteEntity(Renovation entity)
        {
            throw new NotImplementedException();
        }

        public Term GetLastTermForRoom(Room room)
        {
            throw new NotImplementedException();
        }

        public bool GetOccupancyStatus(Room room, DateTime time)
        {
            throw new NotImplementedException();
        }

        public void UpdateEntity(Renovation entity)
        {
            throw new NotImplementedException();
        }

        /*IEnumerable<Renovation> IRepository<Renovation, int>.GetAllEntities()
        {
            throw new NotImplementedException();
        }

        Renovation IRepository<Renovation, int>.GetEntity(int id)
        {
            throw new NotImplementedException();
        }*/
    }
}