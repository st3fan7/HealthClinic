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
        private int id;
        private Room room;

        public string DescriptionOfRenovation { get => descriptionOfRenovation; set => descriptionOfRenovation = value; }
        public Room Room { get => room; set => room = value; }
        private DateTime fromDateTime;
        private DateTime toDateTime;
        public DateTime FromDateTime { get => fromDateTime; set => fromDateTime = value; }
        public DateTime ToDateTime { get => toDateTime; set => toDateTime = value; }

        public Renovation(int id)
        {
            this.id = id;
        }

        public Renovation()
        {
        }

        public Renovation(int id, string descriptionOfRenovation, Room room, DateTime fromDateTime, DateTime toDateTime)
        {
            this.DescriptionOfRenovation = descriptionOfRenovation;
            this.id = id;
            this.Room = room;
            this.FromDateTime = fromDateTime;
            this.ToDateTime = toDateTime;
        }

        public Renovation(string descriptionOfRenovation,  Room room, DateTime fromDateTime, DateTime toDateTime)
        {
            this.DescriptionOfRenovation = descriptionOfRenovation;
            this.Room = room;
            this.FromDateTime = fromDateTime;
            this.ToDateTime = toDateTime;
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