/***********************************************************************
 * Module:  Soba.cs
 * Author:  Stefan
 * Purpose: Definition of the Class Term.Soba
 ***********************************************************************/

using HealthClinic.Repository;
using Model.Manager;
using System;

namespace Model.Term
{
   public class Room : Term, IIdentifiable<int>
    {
      private String roomID;
      private int id;
      
      public TypeOfRoom typeOfRoom;
      public System.Collections.ArrayList equipment;
      
      /// <summary>
      /// Property for collection of Equipment
      /// </summary>
      /// <pdGenerated>Default opposite class collection property</pdGenerated>
      public System.Collections.ArrayList Equipment
      {
         get
         {
            if (equipment == null)
               equipment = new System.Collections.ArrayList();
            return equipment;
         }
         set
         {
            RemoveAllEquipment();
            if (value != null)
            {
               foreach (Equipment oEquipment in value)
                  AddEquipment(oEquipment);
            }
         }
      }
      
      /// <summary>
      /// Add a new Equipment in the collection
      /// </summary>
      /// <pdGenerated>Default Add</pdGenerated>
      public void AddEquipment(Equipment newEquipment)
      {
         if (newEquipment == null)
            return;
         if (this.equipment == null)
            this.equipment = new System.Collections.ArrayList();
         if (!this.equipment.Contains(newEquipment))
            this.equipment.Add(newEquipment);
      }
      
      /// <summary>
      /// Remove an existing Equipment from the collection
      /// </summary>
      /// <pdGenerated>Default Remove</pdGenerated>
      public void RemoveEquipment(Equipment oldEquipment)
      {
         if (oldEquipment == null)
            return;
         if (this.equipment != null)
            if (this.equipment.Contains(oldEquipment))
               this.equipment.Remove(oldEquipment);
      }
      
      /// <summary>
      /// Remove all instances of Equipment from the collection
      /// </summary>
      /// <pdGenerated>Default removeAll</pdGenerated>
      public void RemoveAllEquipment()
      {
         if (equipment != null)
            equipment.Clear();
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