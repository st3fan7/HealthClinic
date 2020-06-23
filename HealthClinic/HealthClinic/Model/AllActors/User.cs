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

        public string UserName { get => userName; set => userName = value; }
        public string Password { get => password; set => password = value; }

        public User(int id)
        {
            this.id = id;
        }

        public User()
        {
        }

        public User(int id, string userName, string password)
        {
            this.UserName = userName;
            this.Password = password;
            this.id = id;
        }

        public User(string userName, string password)
        {
            this.UserName = userName;
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