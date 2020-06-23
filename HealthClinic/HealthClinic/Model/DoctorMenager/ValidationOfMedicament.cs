// File:    ValidationOfMedicament.cs
// Author:  Stefan
// Created: cetvrtak, 28. maj 2020. 01:56:34
// Purpose: Definition of Class ValidationOfMedicament

using HealthClinic.Repository;
using System;
using System.Collections.Generic;
using System.Windows.Documents;
namespace Model.DoctorMenager
{
    public class ValidationOfMedicament : IIdentifiable<int>
    {
        private bool approved;
        private int id;
        private Medicament medicament;
        private List<AllActors.Doctor> doctors;

        private FeedbackOfValidation feedbackOfValidation;

        public bool Approved { get => approved; set => approved = value; }
        public Medicament Medicament { get => medicament; set => medicament = value; }
        public FeedbackOfValidation FeedbackOfValidation { get => feedbackOfValidation; set => feedbackOfValidation = value; }
        public List<AllActors.Doctor> Doctors { get => doctors; set => doctors = value; }

        public ValidationOfMedicament(int id)
        {
            this.id = id;
        }

        public ValidationOfMedicament()
        {
        }

        public ValidationOfMedicament(int id, bool approved, Medicament medicament, FeedbackOfValidation feedbackOfValidation, List<AllActors.Doctor> doctors)
        {
            this.Approved = approved;
            this.id = id;
            this.Medicament = medicament;
            this.FeedbackOfValidation = feedbackOfValidation;
            this.doctors = doctors;
        }


        public ValidationOfMedicament(bool approved, Medicament medicament, FeedbackOfValidation feedbackOfValidation, List<AllActors.Doctor> doctors)
        {
            this.Approved = approved;
            this.Medicament = medicament;
            this.FeedbackOfValidation = feedbackOfValidation;
            this.doctors = doctors;
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