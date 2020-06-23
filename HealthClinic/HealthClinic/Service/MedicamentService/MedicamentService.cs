// File:    MedicamentService.cs
// Author:  Stefan
// Created: cetvrtak, 28. maj 2020. 03:37:00
// Purpose: Definition of Class MedicamentService


using Model.DoctorMenager;
using Repository.MedicamentRepository;
using System;
using System.Collections.Generic;

namespace Service.MedicamentService
{
    public class MedicamentService : IService<Medicament, int>
    {
        public IMedicamentRepository medicamentRepository;

        public MedicamentService(IMedicamentRepository medicamentRepository)
        {
            this.medicamentRepository = medicamentRepository;
        }

        public void AddExistingMedicament(String medicamentID, int quantity)
        {
            throw new NotImplementedException();
        }

        public Medicament GetEntity(int id)
        {
            return medicamentRepository.GetEntity(id);
        }

        public IEnumerable<Medicament> GetAllEntities()
        {
            return medicamentRepository.GetAllEntities();
        }

        public Medicament AddEntity(Medicament entity)
        {
            return medicamentRepository.AddEntity(entity);
        }

        public void UpdateEntity(Medicament entity)
        {
            medicamentRepository.UpdateEntity(entity);
        }

        public void DeleteEntity(Medicament entity)
        {
            medicamentRepository.DeleteEntity(entity);
        }

    }
}