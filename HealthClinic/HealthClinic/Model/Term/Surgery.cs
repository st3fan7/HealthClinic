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
        private bool urgency;
        private String shortDescription;
        private int id;
        private Room room;
        private DoctorSpecialist doctorSpecialist;
        public AllActors.Patient patient;

        public bool Urgency { get => urgency; set => urgency = value; }
        public string ShortDescription { get => shortDescription; set => shortDescription = value; }
        public Room Room { get => room; set => room = value; }
        public DoctorSpecialist DoctorSpecialist { get => doctorSpecialist; set => doctorSpecialist = value; }
        private DateTime fromDateTime;
        private DateTime toDateTime;
        public DateTime FromDateTime { get => fromDateTime; set => fromDateTime = value; }
        public DateTime ToDateTime { get => toDateTime; set => toDateTime = value; }

        public Surgery(int id)
        {
            this.id = id;
        }

        public Surgery()
        {
        }

        public Surgery(int id, bool urgency, string shortDescription, Room room, DoctorSpecialist doctorSpecialist, AllActors.Patient patient, DateTime fromDateTime, DateTime toDateTime)
        {
            this.Urgency = urgency;
            this.ShortDescription = shortDescription;
            this.id = id;
            this.Room = room;
            this.DoctorSpecialist = doctorSpecialist;
            this.patient = patient;
            this.FromDateTime = fromDateTime;
            this.ToDateTime = toDateTime;
        }

        public Surgery(bool urgency, string shortDescription, Room room, DoctorSpecialist doctorSpecialist, AllActors.Patient patient, DateTime fromDateTime, DateTime toDateTime)
        {
            this.Urgency = urgency;
            this.ShortDescription = shortDescription;
            this.Room = room;
            this.DoctorSpecialist = doctorSpecialist;
            this.patient = patient;
            this.FromDateTime = fromDateTime;
            this.ToDateTime = toDateTime;
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