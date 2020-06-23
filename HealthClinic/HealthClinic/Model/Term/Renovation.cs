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
        private Room room;

        public string DescriptionOfRenovation { get => descriptionOfRenovation; set => descriptionOfRenovation = value; }
        public bool SeparateOnTwoParts { get => separateOnTwoParts; set => separateOnTwoParts = value; }
        public bool ConnectTwoParts { get => connectTwoParts; set => connectTwoParts = value; }
        public Room Room { get => room; set => room = value; }

        public Renovation(int id)
        {
            this.id = id;
        }

        public Renovation()
        {
        }

        public Renovation(int id, string descriptionOfRenovation, bool separateOnTwoParts, bool connectTwoParts, Room room)
        {
            this.DescriptionOfRenovation = descriptionOfRenovation;
            this.SeparateOnTwoParts = separateOnTwoParts;
            this.ConnectTwoParts = connectTwoParts;
            this.id = id;
            this.Room = room;
        }

        public Renovation(string descriptionOfRenovation, bool separateOnTwoParts, bool connectTwoParts, Room room)
        {
            this.DescriptionOfRenovation = descriptionOfRenovation;
            this.SeparateOnTwoParts = separateOnTwoParts;
            this.ConnectTwoParts = connectTwoParts;
            this.Room = room;
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