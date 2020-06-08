// File:    EquipmentController.cs
// Author:  Hacer
// Created: subota, 30. maj 2020. 20:26:06
// Purpose: Definition of Class EquipmentController

using Model.DoctorMenager;
using Model.Manager;
using System;
using System.Collections.Generic;

namespace Controller.RoomsControlers
{
   public class EquipmentController : IController<Equipment,int>
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

        public Service.RoomsServices.EquipmentService equipmentService;
   
   }
}