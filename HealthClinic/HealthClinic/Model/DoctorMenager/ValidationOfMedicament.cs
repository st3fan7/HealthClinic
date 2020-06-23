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
        private bool approved;
        private int id;
        private Medicament medicament;
        private Model.AllActors.Doctor[] doctor;
        private FeedbackOfValidation feedbackOfValidation;

        public bool Approved { get => approved; set => approved = value; }
        public Medicament Medicament { get => medicament; set => medicament = value; }
        public AllActors.Doctor[] Doctor { get => doctor; set => doctor = value; }
        public FeedbackOfValidation FeedbackOfValidation { get => feedbackOfValidation; set => feedbackOfValidation = value; }

        public ValidationOfMedicament(int id)
        {
            this.id = id;
        }

        public ValidationOfMedicament()
        {
        }

        public ValidationOfMedicament(int id, bool approved,  Medicament medicament, AllActors.Doctor[] doctor, FeedbackOfValidation feedbackOfValidation)
        {
            this.Approved = approved;
            this.id = id;
            this.Medicament = medicament;
            this.Doctor = doctor;
            this.FeedbackOfValidation = feedbackOfValidation;
        }


        public ValidationOfMedicament(bool approved, Medicament medicament, AllActors.Doctor[] doctor, FeedbackOfValidation feedbackOfValidation)
        {
            this.Approved = approved;
            this.Medicament = medicament;
            this.Doctor = doctor;
            this.FeedbackOfValidation = feedbackOfValidation;
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