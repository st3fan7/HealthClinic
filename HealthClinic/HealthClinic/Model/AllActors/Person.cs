/***********************************************************************
 * Module:  Actor.cs
 * Author:  Stefan
 * Purpose: Definition of the Class AllActors.Actor
 ***********************************************************************/

using System;

namespace Model.AllActors
{
    public class Person
    {
        private String name;
        private String surname;
        private String jmbg;
        private DateTime dateOfBirth;
        private String contactNumber;
        private String eMail;
        public City city;

        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string Jmbg { get => jmbg; set => jmbg = value; }
        public DateTime DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
        public string ContactNumber { get => contactNumber; set => contactNumber = value; }
        public string EMail { get => eMail; set => eMail = value; }

        public Person()
        {
        }

        public Person(string name, string surname, string jmbg, DateTime dateOfBirth, string contactNumber, string eMail, City city)
        {
            this.Name = name;
            this.Surname = surname;
            this.Jmbg = jmbg;
            this.DateOfBirth = dateOfBirth;
            this.ContactNumber = contactNumber;
            this.EMail = eMail;
            City = city;
        }


        /// <summary>
        /// Property for City
        /// </summary>
        /// <pdGenerated>Default opposite class property</pdGenerated>
        public City City
        {
            get
            {
                return city;
            }
            set
            {
                if (this.city == null || !this.city.Equals(value))
                {
                    if (this.city != null)
                    {
                        City oldCity = this.city;
                        this.city = null;
                        oldCity.RemovePerson(this);
                    }
                    if (value != null)
                    {
                        this.city = value;
                        this.city.AddPerson(this);
                    }
                }
            }
        }
    }
}