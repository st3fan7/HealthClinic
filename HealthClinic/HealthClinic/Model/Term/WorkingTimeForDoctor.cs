/***********************************************************************
 * Module:  WorkingTimeForDoctor.cs
 * Author:  Stefan
 * Purpose: Definition of the Class Manager.WorkingTimeForDoctor
 ***********************************************************************/

using HealthClinic.Repository;
using System;

namespace Model.Term
{
   public class WorkingTimeForDoctor : Term, IIdentifiable<int>
   {
      private Model.Manager.DaysInWeek day;
      private Boolean doesWork;
      private int id;
      
      public Model.AllActors.Doctor doctor;

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