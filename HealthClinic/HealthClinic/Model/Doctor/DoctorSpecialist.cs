/***********************************************************************
 * Module:  AllRounderDoctor.cs
 * Author:  Stefan
 * Purpose: Definition of the Class Doctor.AllRounderDoctor
 ***********************************************************************/

using System;

namespace Model.Doctor
{
   public class DoctorSpecialist : AllActors.Doctor
   {
      public System.Collections.ArrayList specialitation;

        public DoctorSpecialist()
        {
        }

        /// <summary>
        /// Property for collection of Specialitation
        /// </summary>
        /// <pdGenerated>Default opposite class collection property</pdGenerated>
        public System.Collections.ArrayList Specialitation
      {
         get
         {
            if (specialitation == null)
               specialitation = new System.Collections.ArrayList();
            return specialitation;
         }
         set
         {
            RemoveAllSpecialitation();
            if (value != null)
            {
               foreach (Specialitation oSpecialitation in value)
                  AddSpecialitation(oSpecialitation);
            }
         }
      }
      
      /// <summary>
      /// Add a new Specialitation in the collection
      /// </summary>
      /// <pdGenerated>Default Add</pdGenerated>
      public void AddSpecialitation(Specialitation newSpecialitation)
      {
         if (newSpecialitation == null)
            return;
         if (this.specialitation == null)
            this.specialitation = new System.Collections.ArrayList();
         if (!this.specialitation.Contains(newSpecialitation))
            this.specialitation.Add(newSpecialitation);
      }
      
      /// <summary>
      /// Remove an existing Specialitation from the collection
      /// </summary>
      /// <pdGenerated>Default Remove</pdGenerated>
      public void RemoveSpecialitation(Specialitation oldSpecialitation)
      {
         if (oldSpecialitation == null)
            return;
         if (this.specialitation != null)
            if (this.specialitation.Contains(oldSpecialitation))
               this.specialitation.Remove(oldSpecialitation);
      }
      
      /// <summary>
      /// Remove all instances of Specialitation from the collection
      /// </summary>
      /// <pdGenerated>Default removeAll</pdGenerated>
      public void RemoveAllSpecialitation()
      {
         if (specialitation != null)
            specialitation.Clear();
      }
   
   }
}