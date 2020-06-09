// File:    Allergies.cs
// Author:  Stefan
// Created: subota, 16. maj 2020. 22:29:27
// Purpose: Definition of Class Allergies

using HealthClinic.Repository;
using System;

namespace Model.PatientDoctor
{
   public class Allergies : IIdentifiable<int>
   {
      private String name;
      private int id;

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