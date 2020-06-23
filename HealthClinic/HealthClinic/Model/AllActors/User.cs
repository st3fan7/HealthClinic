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
        private String username;
        private String password;       
        private int id;

        public string UserName { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }

        public User(int id)
        {
            this.id = id;
        }

        public User()
        {
        }

        public User(int id, string username, string password)
        {
            this.username = username;
            this.Password = password;
            this.id = id;
        }

        public User(string username, string password)
        {
            this.username = username;
            this.Password = password;
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