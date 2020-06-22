// File:    MedicamentController.cs
// Author:  Hacer
// Created: subota, 30. maj 2020. 20:29:30
// Purpose: Definition of Class MedicamentController

using Model.DoctorMenager;
using Service.MedicamentService;
using System;
using System.Collections.Generic;

namespace Controller.MedicamentControlers
{
    public class MedicamentController : IController<Medicament, int>
    {
        public MedicamentService medicamentService;

        public MedicamentController(MedicamentService medicamentService)
        {
            this.medicamentService = medicamentService;
        }

        public void AddExistingMedicament(String medicamentID, int quantity)
        {
            medicamentService.AddExistingMedicament(medicamentID, quantity);
        }

        public Medicament GetEntity(int id)
        {
            return medicamentService.GetEntity(id);
        }

        public IEnumerable<Medicament> GetAllEntities()
        {
            return medicamentService.GetAllEntities();
        }

        public Medicament AddEntity(Medicament entity)
        {
            return medicamentService.AddEntity(entity);
        }

        public void UpdateEntity(Medicament entity)
        {
            medicamentService.UpdateEntity(entity);
        }

        public void DeleteEntity(Medicament entity)
        {
            medicamentService.DeleteEntity(entity);
        }

    }
}