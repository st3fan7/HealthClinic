/***********************************************************************
 * Module:  IssueMedicamentsService.cs
 * Author:  Stefan
 * Purpose: Definition of the Class Service.ExaminationSurgeryServices.IssueMedicamentsService
 ***********************************************************************/

using Model.Doctor;
using Service.MedicamentService;
using System;
using System.Collections.Generic;

namespace Controller.MedicamentControlers
{
    public class IssueMedicamentsController : IController<IssueOfMedicaments, int>
    {
        public IssueMedicamentsService issueMedicamentsService;

        public IssueMedicamentsController(IssueMedicamentsService issueMedicamentsService)
        {
            this.issueMedicamentsService = issueMedicamentsService;
        }

        public Model.Doctor.IssueOfMedicaments IssueOfMedicaments(IssueOfMedicaments issueOfMedicaments)
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

    }
}