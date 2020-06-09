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
      
      public Medicament medicament;
      public Model.AllActors.Doctor[] doctor;
      public FeedbackOfValidation feedbackOfValidation;

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