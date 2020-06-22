/***********************************************************************
 * Module:  UserService.cs
 * Author:  Stefan
 * Purpose: Definition of the Class Service.UserService
 ***********************************************************************/

using Model.AllActors;
using Service.UsersServices;
using System;
using System.Collections.Generic;

namespace Controller.UsersControlers
{
    public class UserController : IController<User, int>
    {
        public UserService userService;

        public UserController(UserService userService)
        {
            this.userService = userService;
        }

        public Model.AllActors.User Login(String username, String password)
        {
            return userService.Login(username, password);
        }

        public bool IsUsernameValid(String username)
        {
            return userService.IsUsernameValid(username);
        }

        public bool IsPasswordValid(String password)
        {
            return userService.IsPasswordValid(password);
        }

        public void DeactivateAccount(User user)
        {
            userService.DeactivateAccount(user);
        }

        public Model.AllActors.User ChangeUserData(User user)
        {
            throw new NotImplementedException();
        }

        public Model.AllActors.Patient TransformGuestAccount(Patient patient)
        {           
            return userService.TransformGuestAccount(patient);
        }

        public User GetEntity(int id)
        {
            return userService.GetEntity(id);
        }

        public IEnumerable<User> GetAllEntities()
        {
            return userService.GetAllEntities();
        }

        public User AddEntity(User entity)
        {
            return userService.AddEntity(entity);
        }

        public void UpdateEntity(User entity)
        {
            userService.UpdateEntity(entity);
        }

        public void DeleteEntity(User entity)
        {
            userService.DeleteEntity(entity);
        }

    }
}