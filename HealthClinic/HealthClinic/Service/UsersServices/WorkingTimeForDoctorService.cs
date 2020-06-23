/***********************************************************************
 * Module:  WorkingTimeForDoctorService.cs
 * Author:  Stefan
 * Purpose: Definition of the Class Service.WorkingTimeForDoctorService
 ***********************************************************************/

using Model.Term;
using Model.AllActors;
using System;
using System.Collections.Generic;
using Repository.UsersRepository;

namespace Service.UsersServices
{
    public class WorkingTimeForDoctorService : IService<WorkingTimeForDoctor, int>
    {
        public IWorkingTimeForDoctorRepository workingTimeForDoctorRepository;

        public WorkingTimeForDoctorService(IWorkingTimeForDoctorRepository workingTimeForDoctorRepository)
        {
            this.workingTimeForDoctorRepository = workingTimeForDoctorRepository;
        }

        public WorkingTimeForDoctor DetermineDoctorWorkTime(WorkingTimeForDoctor workingTimeForDoctor)
        {
            throw new NotImplementedException();
        }

        public List<WorkingTimeForDoctor> GetWorkTimeForDoctor(Doctor doctor)
        {
            throw new NotImplementedException();
        }

        public WorkingTimeForDoctor GetEntity(int id)
        {
            return workingTimeForDoctorRepository.GetEntity(id);
        }

        public IEnumerable<WorkingTimeForDoctor> GetAllEntities()
        {
            return workingTimeForDoctorRepository.GetAllEntities();
        }

        public WorkingTimeForDoctor AddEntity(WorkingTimeForDoctor entity)
        {
            return workingTimeForDoctorRepository.AddEntity(entity);
        }

        public void UpdateEntity(WorkingTimeForDoctor entity)
        {
            workingTimeForDoctorRepository.UpdateEntity(entity);
        }

        public void DeleteEntity(WorkingTimeForDoctor entity)
        {
            workingTimeForDoctorRepository.DeleteEntity(entity);
        }

    }
}