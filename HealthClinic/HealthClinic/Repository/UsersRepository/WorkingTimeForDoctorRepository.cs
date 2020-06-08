/***********************************************************************
 * Module:  WorkingTimeForDoctorRepository.cs
 * Author:  Stefan
 * Purpose: Definition of the Class Repository.WorkingTimeForDoctorRepository
 ***********************************************************************/

using Model.AllActors;
using Model.Term;
using Repository.Csv;
using Repository.Csv.Stream;
using Repository.IDSequencer;
using System;
using System.Collections.Generic;

namespace Repository.UsersRepository
{
   public class WorkingTimeForDoctorRepository : CSVRepository<WorkingTimeForDoctor,int>, IWorkingTimeForDoctorRepository
   {
        private string path;

        public WorkingTimeForDoctorRepository(ICSVStream<WorkingTimeForDoctor> stream, ISequencer<int> sequencer)
         : base(stream, sequencer)
        {
        }

        public List<WorkingTimeForDoctor> GetWorkTimeForDoctor(Doctor doctor)
        {
            throw new NotImplementedException();
        }
    }
}