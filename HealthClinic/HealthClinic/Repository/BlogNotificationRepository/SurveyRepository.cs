/***********************************************************************
 * Module:  UserRepository.cs
 * Author:  Stefan
 * Purpose: Definition of the Class Repository.UserRepository
 ***********************************************************************/

using Model.Patient;
using Repository.Csv;
using Repository.Csv.Stream;
using Repository.IDSequencer;
using System;

namespace Repository.BlogNotificationRepository
{
   public class SurveyRepository : CSVRepository<Survey,int>, ISurveyRepository
   {
        private String path;

        public SurveyRepository(ICSVStream<Survey> stream, ISequencer<int> sequencer)
             : base(stream, sequencer)
        {
        }

    }
}