// File:    Specialitation.cs
// Author:  Stefan
// Created: subota, 16. maj 2020. 22:07:34
// Purpose: Definition of Class Specialitation

using HealthClinic.Repository;
using System;

namespace Model.Doctor
{
    public class Specialitation : IIdentifiable<int>
    {
        private int id;
        private String specialitationForDoctor; // promenjen naziv

        public string SpecialitationForDoctor { get => specialitationForDoctor; set => specialitationForDoctor = value; }

        public Specialitation(int id)
        {
            this.id = id;
        }

        public Specialitation()
        {
        }

        public Specialitation(int id, string specialitation)
        {
            this.SpecialitationForDoctor = specialitation;
            this.id = id;
        }

        public Specialitation(string specialitation)
        {
            this.SpecialitationForDoctor = specialitation;
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