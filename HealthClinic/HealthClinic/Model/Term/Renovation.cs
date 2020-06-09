/***********************************************************************
 * Module:  Renovation.cs
 * Author:  Stefan
 * Purpose: Definition of the Class Manager.Renovation
 ***********************************************************************/

using HealthClinic.Repository;
using System;

namespace Model.Term
{
   public class Renovation : Term, IIdentifiable<int>
    {
      private String descriptionOfRenovation;
      private Boolean separateOnTwoParts;
      private Boolean connectTwoParts;
      private int id;
      
      public Model.Term.Room room;

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