/***********************************************************************
 * Module:  UserService.cs
 * Author:  Stefan
 * Purpose: Definition of the Class Service.UserService
 ***********************************************************************/

using Model.AllActors;
using System;
using System.Collections.Generic;

namespace Controller.UsersControlers
{
   public class UserController : IController<User,int>
   {
      public Model.AllActors.User Login(String username, String password)
      {
         throw new NotImplementedException();
      }
      
      public bool IsUsernameValid(String username)
      {
         throw new NotImplementedException();
      }
      
      public bool IsPasswordValid(String password)
      {
         throw new NotImplementedException();
      }
      
      public void DeactivateAccount(Model.AllActors.User user)
      {
         throw new NotImplementedException();
      }
      
      public Model.AllActors.User ChangeUserData(Model.AllActors.User user)
      {
         throw new NotImplementedException();
      }
      
      public Model.AllActors.Patient TransformGuestAccount(Model.AllActors.Patient patient)
      {
         throw new NotImplementedException();
      }

        public User GetEntity(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetAllEntities()
        {
            throw new NotImplementedException();
        }

        public User AddEntity(User entity)
        {
            throw new NotImplementedException();
        }

        public void UpdateEntity(User entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteEntity(User entity)
        {
            throw new NotImplementedException();
        }

        public Service.UsersServices.UserService userService;
   
   }
}