// File:    Diagnosis.cs
// Author:  Stefan
// Created: subota, 16. maj 2020. 22:29:28
// Purpose: Definition of Class Diagnosis

using HealthClinic.Repository;
using System;

namespace Model.PatientDoctor
{
    public class Diagnosis : IIdentifiable<int>
    {
        private String name { get; set; }

        private int id;

        public Diagnosis(int id)
        {
            this.id = id;
        }

        public Diagnosis()
        {
        }

        public Diagnosis(string name, int id)
        {
            this.name = name;
            this.id = id;
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