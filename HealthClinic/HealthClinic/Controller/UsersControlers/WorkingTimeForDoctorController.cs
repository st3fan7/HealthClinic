/***********************************************************************
 * Module:  WorkingTimeForDoctorService.cs
 * Author:  Stefan
 * Purpose: Definition of the Class Service.WorkingTimeForDoctorService
 ***********************************************************************/

using Model.Term;
using Service.UsersServices;
using Model.AllActors;
using System;
using System.Collections.Generic;

namespace Controller.UsersControlers
{
    public class WorkingTimeForDoctorController : IController<WorkingTimeForDoctor, int>
    {
        public WorkingTimeForDoctorService workingTimeForDoctorService;

        public WorkingTimeForDoctorController(WorkingTimeForDoctorService workingTimeForDoctorService)
        {
            this.workingTimeForDoctorService = workingTimeForDoctorService;
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

    }
}