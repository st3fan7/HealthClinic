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
        private String descriptionOfRenovation { get; set; }
        private Boolean separateOnTwoParts { get; set; }
        private Boolean connectTwoParts { get; set; }
        
        private int id;

        public Room room { get; set; }

        public Renovation(int id)
        {
            this.id = id;
        }

        public Renovation()
        {
        }

        public Renovation(string descriptionOfRenovation, bool separateOnTwoParts, bool connectTwoParts, int id, Room room)
        {
            this.descriptionOfRenovation = descriptionOfRenovation;
            this.separateOnTwoParts = separateOnTwoParts;
            this.connectTwoParts = connectTwoParts;
            this.id = id;
            this.room = room;
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