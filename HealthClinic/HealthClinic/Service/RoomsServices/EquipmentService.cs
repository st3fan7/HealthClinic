// File:    EquipmentService.cs
// Author:  Stefan
// Created: cetvrtak, 28. maj 2020. 03:14:12
// Purpose: Definition of Class EquipmentService

using Model.DoctorMenager;
using Model.Manager;
using System;
using System.Collections.Generic;

namespace Service.RoomsServices
{
   public class EquipmentService : IService<Equipment,int>
   {
      public bool AddExistingEquipment(String equipmentID, int quantity)
      {
         throw new NotImplementedException();
      }
      
      public Medicament TakeMedicament(Medicament medicament)
      {
         throw new NotImplementedException();
      }

        public Equipment GetEntity(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Equipment> GetAllEntities()
        {
            throw new NotImplementedException();
        }

        public Equipment AddEntity(Equipment entity)
        {
            throw new NotImplementedException();
        }

        public void UpdateEntity(Equipment entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteEntity(Equipment entity)
        {
            throw new NotImplementedException();
        }

        public Repository.RoomsRepository.IEquipmentRepository iEquipmentRepository;
   
   }
}