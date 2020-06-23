// File:    EquipmentService.cs
// Author:  Stefan
// Created: cetvrtak, 28. maj 2020. 03:14:12
// Purpose: Definition of Class EquipmentService

using Model.DoctorMenager;
using Model.Manager;
using Repository.RoomsRepository;
using System;
using System.Collections.Generic;

namespace Service.RoomsServices
{
    public class EquipmentService : IService<Equipment, int>
    {
        public IEquipmentRepository equipmentRepository;

        public EquipmentService(IEquipmentRepository equipmentRepository)
        {
            this.equipmentRepository = equipmentRepository;
        }

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
            return equipmentRepository.GetEntity(id);
        }

        public IEnumerable<Equipment> GetAllEntities()
        {
            return equipmentRepository.GetAllEntities();
        }

        public Equipment AddEntity(Equipment entity)
        {
            return equipmentRepository.AddEntity(entity);
        }

        public void UpdateEntity(Equipment entity)
        {
            equipmentRepository.UpdateEntity(entity);
        }

        public void DeleteEntity(Equipment entity)
        {
            equipmentRepository.DeleteEntity(entity);
        }

    }
}