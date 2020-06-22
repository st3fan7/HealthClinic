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
        private bool urgency { get; set; }
        private String shortDescription { get; set; }

        private int id;

        public Room room { get; set; }
        public Model.AllActors.Doctor doctor { get; set; }

        public Model.AllActors.Patient patient;

        public MedicalExamination(int id)
        {
            this.id = id;
        }

        public MedicalExamination()
        {
        }

        public MedicalExamination(bool urgency, string shortDescription, int id, Room room, AllActors.Doctor doctor, AllActors.Patient patient)
        {
            this.urgency = urgency;
            this.shortDescription = shortDescription;
            this.id = id;
            this.room = room;
            this.doctor = doctor;
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