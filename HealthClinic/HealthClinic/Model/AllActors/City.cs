/***********************************************************************
 * Module:  City.cs
 * Author:  Stefan
 * Purpose: Definition of the Class AllActors.City
 ***********************************************************************/

using System;
using System.Collections;

namespace Model.AllActors
{
    public class City
    {
        private String name;
        private int postCode;
        private String adress;
        private Country country;
        public System.Collections.ArrayList person;

        public string Name { get => name; set => name = value; }
        public int PostCode { get => postCode; set => postCode = value; }
        public string Adress { get => adress; set => adress = value; }
        public Country Country { get => country; set => country = value; }


        public City()
        {
        }

        public City(string name, int postCode, string adress, Country country, ArrayList person)
        {
            this.Name = name;
            this.PostCode = postCode;
            this.Adress = adress;
            this.Country = country;
            this.person = person;
        }



        /// <summary>
        /// Property for collection of Person
        /// </summary>
        /// <pdGenerated>Default opposite class collection property</pdGenerated>
        public System.Collections.ArrayList Person
        {
            get
            {
                if (person == null)
                    person = new System.Collections.ArrayList();
                return person;
            }
            set
            {
                RemoveAllPerson();
                if (value != null)
                {
                    foreach (Person oPerson in value)
                        AddPerson(oPerson);
                }
            }
        }

        /// <summary>
        /// Add a new Person in the collection
        /// </summary>
        /// <pdGenerated>Default Add</pdGenerated>
        public void AddPerson(Person newPerson)
        {
            if (newPerson == null)
                return;
            if (this.person == null)
                this.person = new System.Collections.ArrayList();
            if (!this.person.Contains(newPerson))
            {
                this.person.Add(newPerson);
                newPerson.City = this;
            }
        }

        /// <summary>
        /// Remove an existing Person from the collection
        /// </summary>
        /// <pdGenerated>Default Remove</pdGenerated>
        public void RemovePerson(Person oldPerson)
        {
            if (oldPerson == null)
                return;
            if (this.person != null)
                if (this.person.Contains(oldPerson))
                {
                    this.person.Remove(oldPerson);
                    oldPerson.City = null;
                }
        }

        /// <summary>
        /// Remove all instances of Person from the collection
        /// </summary>
        /// <pdGenerated>Default removeAll</pdGenerated>
        public void RemoveAllPerson()
        {
            if (person != null)
            {
                System.Collections.ArrayList tmpPerson = new System.Collections.ArrayList();
                foreach (Person oldPerson in person)
                    tmpPerson.Add(oldPerson);
                person.Clear();
                foreach (Person oldPerson in tmpPerson)
                    oldPerson.City = null;
                tmpPerson.Clear();
            }
        }

    }
}