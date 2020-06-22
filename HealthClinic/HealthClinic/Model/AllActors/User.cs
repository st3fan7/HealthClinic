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
        private String userName { get; set; }
        private String password { get; set; }
        
        private int id;

        public User(int id)
        {
            this.id = id;
        }

        public User()
        {
        }

        public User(string userName, string password, int id)
        {
            this.userName = userName;
            this.password = password;
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