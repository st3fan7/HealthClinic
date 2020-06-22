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
            throw new NotImplementedException();
        }

        public Medicament GetEntity(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Medicament> GetAllEntities()
        {
            throw new NotImplementedException();
        }

        public Medicament AddEntity(Medicament entity)
        {
            throw new NotImplementedException();
        }

        public void UpdateEntity(Medicament entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteEntity(Medicament entity)
        {
            throw new NotImplementedException();
        }

    }
}