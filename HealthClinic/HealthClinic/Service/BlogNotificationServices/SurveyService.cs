/***********************************************************************
 * Module:  SurveyService.cs
 * Author:  Stefan
 * Purpose: Definition of the Class Service.SurveyService
 ***********************************************************************/

using Model.Patient;
using Repository.BlogNotificationRepository;
using System;
using System.Collections.Generic;

namespace Service.BlogNotificationServices
{
    public class SurveyService : IService<Survey, int>
    {
        public ISurveyRepository surveyRepository;

        public SurveyService(ISurveyRepository surveyRepository)
        {
            this.surveyRepository = surveyRepository;
        }

        public Survey CompletingSurvey(Survey survey)
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

    }
}