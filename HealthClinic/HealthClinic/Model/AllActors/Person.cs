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
        private String name { get; set; }
        private String surname { get; set; }
        private String jmbg { get; set; }
        private DateTime dateOfBirth { get; set; }
        private String contactNumber { get; set; }
        private String eMail { get; set; }

        public City city;

        public Person()
        {
        }

        public Person(string name, string surname, string jmbg, DateTime dateOfBirth, string contactNumber, string eMail, City city)
        {
            this.name = name;
            this.surname = surname;
            this.jmbg = jmbg;
            this.dateOfBirth = dateOfBirth;
            this.contactNumber = contactNumber;
            this.eMail = eMail;
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