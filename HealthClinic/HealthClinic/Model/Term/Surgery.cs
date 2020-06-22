/***********************************************************************
 * Module:  SurgerySchedule.cs
 * Author:  Stefan
 * Purpose: Definition of the Class Doctor.SurgerySchedule
 ***********************************************************************/

using HealthClinic.Repository;
using Model.Doctor;
using System;

namespace Model.Term
{
    public class Surgery : Term, IIdentifiable<int>
    {
        private bool urgency { get; set; }
        private String shortDescription { get; set; }

        private int id;

        public Room room { get; set; }
        public Model.Doctor.DoctorSpecialist doctorSpecialist { get; set; }

        public Model.AllActors.Patient patient;

        public Surgery(int id)
        {
            this.id = id;
        }

        public Surgery()
        {
        }

        public Surgery(bool urgency, string shortDescription, int id, Room room, DoctorSpecialist doctorSpecialist, AllActors.Patient patient)
        {
            this.urgency = urgency;
            this.shortDescription = shortDescription;
            this.id = id;
            this.room = room;
            this.doctorSpecialist = doctorSpecialist;
            this.patient = patient;
        }


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