/***********************************************************************
 * Module:  SurgerySchedule.cs
 * Author:  Stefan
 * Purpose: Definition of the Class Doctor.SurgerySchedule
 ***********************************************************************/

using HealthClinic.Repository;
using System;

namespace Model.Term
{
   public class Surgery : Term, IIdentifiable<int>
    {
      private bool urgency;
      private String shortDescription;
      private int id;
      
      public Room room;
      public Model.Doctor.DoctorSpecialist doctorSpecialist;
      public Model.AllActors.Patient patient;
      
      /// <summary>
      /// Property for Model.AllActors.Patient
      /// </summary>
      /// <pdGenerated>Default opposite class property</pdGenerated>
      public Model.AllActors.Patient Patient
      {
         get
         {
            return patient;
         }
         set
         {
            this.patient = value;
         }
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