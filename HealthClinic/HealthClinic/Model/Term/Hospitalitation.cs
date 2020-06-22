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
    public class Hospitalitation : Term, IIdentifiable<int>
    {
        private bool urgency { get; set; }
        private String shortDescription { get; set; }

        private int id;

        public Room room { get; set; }
        public Model.AllActors.Doctor doctor { get; set; }
        public Bed bedForLaying { get; set; }

        public Hospitalitation(int id)
        {
            this.id = id;
        }

        public Hospitalitation()
        {
        }

        public Hospitalitation(bool urgency, string shortDescription, int id, Room room, AllActors.Doctor doctor, Bed bedForLaying)
        {
            this.urgency = urgency;
            this.shortDescription = shortDescription;
            this.id = id;
            this.room = room;
            this.doctor = doctor;
            this.bedForLaying = bedForLaying;
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