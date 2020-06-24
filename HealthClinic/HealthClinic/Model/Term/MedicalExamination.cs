/***********************************************************************
 * Module:  MedicalExamination.cs
 * Author:  Stefan
 * Purpose: Definition of the Class Term.MedicalExamination
 ***********************************************************************/

using HealthClinic.Repository;
using System;

namespace Model.Term
{
    public class MedicalExamination : Term, IIdentifiable<int>
    {
        private bool urgency;
        private String shortDescription;
        private int id;
        private Room room;
        private AllActors.Doctor doctor;
        public AllActors.Patient Patient { get; set; }

        public bool Urgency { get => urgency; set => urgency = value; }
        public string ShortDescription { get => shortDescription; set => shortDescription = value; }
        public Room Room { get => room; set => room = value; }
        public AllActors.Doctor Doctor { get => doctor; set => doctor = value; }
        private DateTime fromDateTime;
        private DateTime toDateTime;
        public DateTime FromDateTime { get => fromDateTime; set => fromDateTime = value; }
        public DateTime ToDateTime { get => toDateTime; set => toDateTime = value; }

        public MedicalExamination(int id)
        {
            this.id = id;
        }

        public MedicalExamination()
        {
        }

        public MedicalExamination(int id, bool urgency, string shortDescription, Room room, AllActors.Doctor doctor, AllActors.Patient patient, DateTime fromDateTime, DateTime toDateTime)
        {
            this.Urgency = urgency;
            this.ShortDescription = shortDescription;
            this.id = id;
            this.Room = room;
            this.Doctor = doctor;
            Patient = patient;
            this.FromDateTime = fromDateTime;
            this.ToDateTime = toDateTime;
        }

        public MedicalExamination(bool urgency, string shortDescription, Room room, AllActors.Doctor doctor, AllActors.Patient patient, DateTime fromDateTime, DateTime toDateTime)
        {
            this.Urgency = urgency;
            this.ShortDescription = shortDescription;
            this.Room = room;
            this.Doctor = doctor;
            Patient = patient;
            this.FromDateTime = fromDateTime;
            this.ToDateTime = toDateTime;
        }

        /// <summary>
        /// Property for Model.AllActors.Patient
        /// </summary>
        /// <pdGenerated>Default opposite class property</pdGenerated>
        /// 
        /*
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
        }*/

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