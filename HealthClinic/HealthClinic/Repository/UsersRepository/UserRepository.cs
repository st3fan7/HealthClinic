/***********************************************************************
 * Module:  UserRepository.cs
 * Author:  Stefan
 * Purpose: Definition of the Class Repository.UserRepository
 ***********************************************************************/

using Model.AllActors;
using Model.Doctor;
using Repository.Csv;
using Repository.Csv.Stream;
using Repository.IDSequencer;
using System;
using System.Collections.Generic;

namespace Repository.UsersRepository
{
   public class UserRepository : CSVRepository<User,int>, IUserRepository
   {
        private String path;

        public UserRepository(ICSVStream<User> stream, ISequencer<int> sequencer)
         : base(stream, sequencer)
        {
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

        public List<DoctorSpecialist> GetDoctorBySpecialitation(Specialitation specialitation)
        {
            throw new NotImplementedException();
        }

        public bool GetOccupancyStatus(Doctor doctor, DateTime time)
        {
            throw new NotImplementedException();
        }

        public Patient GetPatientByJmbg(string jmbg)
        {
            throw new NotImplementedException();
        }
    }
}