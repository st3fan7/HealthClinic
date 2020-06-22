// File:    ValidationOfMedicament.cs
// Author:  Stefan
// Created: cetvrtak, 28. maj 2020. 01:56:34
// Purpose: Definition of Class ValidationOfMedicament

using HealthClinic.Repository;
using System;

namespace Model.DoctorMenager
{
    public class ValidationOfMedicament : IIdentifiable<int>
    {
        private bool approved { get; set; }

        private int id;

        public Medicament medicament { get; set; }
        public Model.AllActors.Doctor[] doctor { get; set; }
        public FeedbackOfValidation feedbackOfValidation { get; set; }

        public ValidationOfMedicament(int id)
        {
            this.id = id;
        }

        public ValidationOfMedicament()
        {
        }

        public ValidationOfMedicament(bool approved, int id, Medicament medicament, AllActors.Doctor[] doctor, FeedbackOfValidation feedbackOfValidation)
        {
            this.approved = approved;
            this.id = id;
            this.medicament = medicament;
            this.doctor = doctor;
            this.feedbackOfValidation = feedbackOfValidation;
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