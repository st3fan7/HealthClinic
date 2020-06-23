/***********************************************************************
 * Module:  UserRepository.cs
 * Author:  Stefan
 * Purpose: Definition of the Class Repository.UserRepository
 ***********************************************************************/

using Model.BlogAndNotification;
using Repository.Csv;
using Repository.Csv.Stream;
using Repository.IDSequencer;
using System;
using System.Collections.Generic;

namespace Repository.BlogNotificationRepository
{
    public class ArticleRepository : CSVRepository<Article, int>, IArticleRepository
    {
        private String path;

        public ArticleRepository(ICSVStream<Article> stream, ISequencer<int> sequencer)
            : base(stream, sequencer)
        {
        }
    }
}