/***********************************************************************
 * Module:  Equipment.cs
 * Author:  Stefan
 * Purpose: Definition of the Class Manager.Equipment
 ***********************************************************************/

using HealthClinic.Repository;
using System;

namespace Model.Manager
{
   public class Equipment : IIdentifiable<int>
    {
      private String code;
      private String name;
      private String typeOfEquipment;
      private int amount;
      private int id;

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