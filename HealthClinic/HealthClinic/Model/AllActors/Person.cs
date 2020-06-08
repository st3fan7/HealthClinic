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