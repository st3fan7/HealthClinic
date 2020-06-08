/***********************************************************************
 * Module:  UserService.cs
 * Author:  Stefan
 * Purpose: Definition of the Class Service.UserService
 ***********************************************************************/

using Model.AllActors;
using Model.Doctor;
using System;
using System.Collections.Generic;

namespace Service.UsersServices
{
   public class UserService : IService<User,int>
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
      
      public bool DoesJmbgExsist(String jmbg)
      {
         throw new NotImplementedException();
      }
      
      public List<Doctor> GetAllDoctors()
        {
            throw new NotImplementedException();
        }

        public List<Patient> GetAllPatients()
        {
            throw new NotImplementedException();
        }

        public List<Secretary> GetAllSecretaries()
        {
            throw new NotImplementedException();
        }

        public List<DoctorSpecialist> GetDoctorBySpecialitation(Model.Doctor.Specialitation specialitation)
      {
         throw new NotImplementedException();
      }
      
      public Model.AllActors.Patient TransformGuestAccount(Model.AllActors.Patient patient)
      {
         throw new NotImplementedException();
      }
      
      public Boolean GetOccupancyStatus(Model.AllActors.Doctor doctor, DateTime time)
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

        public Repository.UsersRepository.IUserRepository iUserRepository;
   
   }
}