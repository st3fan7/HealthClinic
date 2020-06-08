/***********************************************************************
 * Module:  User.cs
 * Author:  Stefan
 * Purpose: Definition of the Class AllActors.User
 ***********************************************************************/

using HealthClinic.Repository;
using System;

namespace Model.AllActors
{
   public class User : Person, IIdentifiable<int>
    {
        private String userName;
        private String password;
        private int id;

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