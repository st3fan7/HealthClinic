/***********************************************************************
 * Module:  Hospitalitation.cs
 * Author:  Stefan
 * Purpose: Definition of the Class Doctor.Hospitalitation
 ***********************************************************************/

using HealthClinic.Repository;
using Model.Doctor;
using System;

namespace Model.Term
{
   public class Hospitalitation : Term , IIdentifiable<int>
    {
      private bool urgency;
      private String shortDescription;
      private int id;
      
      public Room room;
      public Model.AllActors.Doctor doctor;
      public Bed bedForLaying;

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