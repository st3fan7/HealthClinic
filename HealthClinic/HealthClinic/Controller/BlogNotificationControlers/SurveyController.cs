/***********************************************************************
 * Module:  SurveyService.cs
 * Author:  Stefan
 * Purpose: Definition of the Class Service.SurveyService
 ***********************************************************************/

using Model.Patient;
using System;
using System.Collections.Generic;

namespace Controller.BlogNotificationControlers
{
   public class SurveyController : IController<Survey,int>
   {
      public Survey CompletingSurvey(Model.Patient.Survey survey)
      {
         throw new NotImplementedException();
      }

        public Survey GetEntity(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Survey> GetAllEntities()
        {
            throw new NotImplementedException();
        }

        public Survey AddEntity(Survey entity)
        {
            throw new NotImplementedException();
        }

        public void UpdateEntity(Survey entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteEntity(Survey entity)
        {
            throw new NotImplementedException();
        }

        public Service.BlogNotificationServices.SurveyService surveyService;
   
   }
}