/***********************************************************************
 * Module:  Doctor.cs
 * Author:  Stefan
 * Purpose: Definition of the Class Doctor.Doctor
 ***********************************************************************/

using System;

namespace Model.AllActors
{
   public class Doctor : User
   {
        private String vocation;
        public string Vocation { get => vocation; set => vocation = value; }

        public Doctor(int id, string username, string password, string name, string surname, string jmbg, DateTime dateOfBirth, string contactNumber, string emailAddress, City city, String vocation)
            : base(id, username, password, name, surname, jmbg, dateOfBirth, contactNumber, emailAddress, city)
        {
            this.vocation = vocation;
        }

        public Doctor(int id) : base(id)
        {
        }

        public Doctor()
        {
        }

    }
}