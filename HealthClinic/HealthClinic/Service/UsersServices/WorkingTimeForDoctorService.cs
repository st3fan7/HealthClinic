/***********************************************************************
 * Module:  WorkingTimeForDoctorService.cs
 * Author:  Stefan
 * Purpose: Definition of the Class Service.WorkingTimeForDoctorService
 ***********************************************************************/

using Model.Term;
using System;
using System.Collections.Generic;

namespace Service.UsersServices
{
   public class WorkingTimeForDoctorService : IService<WorkingTimeForDoctor,int>
   {
        public Model.Term.WorkingTimeForDoctor DetermineDoctorWorkTime(Model.Term.WorkingTimeForDoctor workingTimeForDoctor)
        {
            throw new NotImplementedException();
        }
      
        public List<WorkingTimeForDoctor> GetWorkTimeForDoctor(Model.AllActors.Doctor doctor)
        {
            throw new NotImplementedException();
        }
        
        public WorkingTimeForDoctor GetEntity(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<WorkingTimeForDoctor> GetAllEntities()
        {
            throw new NotImplementedException();
        }

        public WorkingTimeForDoctor AddEntity(WorkingTimeForDoctor entity)
        {
            throw new NotImplementedException();
        }

        public void UpdateEntity(WorkingTimeForDoctor entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteEntity(WorkingTimeForDoctor entity)
        {
            throw new NotImplementedException();
        }

        public Repository.UsersRepository.IWorkingTimeForDoctorRepository iWorkingTimeForDoctorRepository;
   
   }
}