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

        public string Name { get => name; set => name = value; }

        public Allergies(int id)
        {
            this.id = id;
        }

        public Allergies()
        {
        }

        public Allergies(int id, string name)
        {
            this.Name = name;
            this.id = id;
        }

        public Allergies(string name)
        {
            this.Name = name;
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