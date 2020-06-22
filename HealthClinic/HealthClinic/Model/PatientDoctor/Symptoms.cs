// File:    Symptoms.cs
// Author:  Stefan
// Created: subota, 16. maj 2020. 22:43:51
// Purpose: Definition of Class Symptoms

using HealthClinic.Repository;
using System;

namespace Model.PatientDoctor
{
    public class Symptoms : IIdentifiable<int>
    {
        private String name { get; set; }
        private int id;

        public Symptoms(int id)
        {
            this.id = id;
        }

        public Symptoms()
        {
        }

        public Symptoms(string name, int id)
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