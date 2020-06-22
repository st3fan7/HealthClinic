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
        private String specialitation { get; set; }
        private int id;

        public Specialitation(int id)
        {
            this.id = id;
        }

        public Specialitation()
        {
        }

        public Specialitation(string specialitation, int id)
        {
            this.specialitation = specialitation;
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