/***********************************************************************
 * Module:  WorkingTimeForDoctor.cs
 * Author:  Stefan
 * Purpose: Definition of the Class Manager.WorkingTimeForDoctor
 ***********************************************************************/

using HealthClinic.Repository;
using Model.Manager;
using System;

namespace Model.Term
{
    public class WorkingTimeForDoctor : Term, IIdentifiable<int>
    {
        private Model.Manager.DaysInWeek day { get; set; }
        private Boolean doesWork { get; set; }

        private int id;

        public Model.AllActors.Doctor doctor { get; set; }

        public WorkingTimeForDoctor(int id)
        {
            this.id = id;
        }

        public WorkingTimeForDoctor()
        {
        }

        public WorkingTimeForDoctor(DaysInWeek day, bool doesWork, int id, AllActors.Doctor doctor)
        {
            this.day = day;
            this.doesWork = doesWork;
            this.id = id;
            this.doctor = doctor;
        }

        public int GetId()
        {
            return id;
        }

        public void SetId(int id)
        {
            this.id = id;
        }
    }
}