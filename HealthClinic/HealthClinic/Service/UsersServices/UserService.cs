/***********************************************************************
 * Module:  UserService.cs
 * Author:  Stefan
 * Purpose: Definition of the Class Service.UserService
 ***********************************************************************/

using Model.AllActors;
using Model.Doctor;
using System;
using System.Collections.Generic;
using Repository.UsersRepository;

namespace Service.UsersServices
{
    public class UserService : IService<User, int>
    {
        public IUserRepository userRepository;

        public UserService(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public User Login(String username, String password)
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
            return userRepository.GetAllDoctors();
        }

        public List<Patient> GetAllPatients()
        {
            return userRepository.GetAllPatients();
        }

        public List<Secretary> GetAllSecretaries()
        {
            return userRepository.GetAllSecretaries();
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
            return userRepository.GetEntity(id);
        }

        public IEnumerable<User> GetAllEntities()
        {
            return userRepository.GetAllEntities();
        }

        public User AddEntity(User entity)
        {
            return userRepository.AddEntity(entity);
        }

        public void UpdateEntity(User entity)
        {
            userRepository.UpdateEntity(entity);
        }

        public void DeleteEntity(User entity)
        {
            userRepository.DeleteEntity(entity);
        }
    }
}