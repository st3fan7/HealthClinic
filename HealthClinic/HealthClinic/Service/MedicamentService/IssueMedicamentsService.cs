// File:    IssueMedicamentsService.cs
// Author:  Stefan
// Created: cetvrtak, 28. maj 2020. 03:10:35
// Purpose: Definition of Class IssueMedicamentsService

using Model.Doctor;
using Repository.MedicamentRepository;
using System;
using System.Collections.Generic;

namespace Service.MedicamentService
{
    public class IssueMedicamentsService : IService<IssueOfMedicaments, int>
    {
        public Model.Doctor.IssueOfMedicaments IssueOfMedicaments(Model.Doctor.IssueOfMedicaments issueOfMedicaments)
        {
            throw new NotImplementedException();
        }

        public IssueOfMedicaments GetEntity(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IssueOfMedicaments> GetAllEntities()
        {
            throw new NotImplementedException();
        }

        public IssueOfMedicaments AddEntity(IssueOfMedicaments entity)
        {
            throw new NotImplementedException();
        }

        public void UpdateEntity(IssueOfMedicaments entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteEntity(IssueOfMedicaments entity)
        {
            throw new NotImplementedException();
        }

        public IIssueOfMedicamentRepository issueOfMedicamentRepository;

    }
}