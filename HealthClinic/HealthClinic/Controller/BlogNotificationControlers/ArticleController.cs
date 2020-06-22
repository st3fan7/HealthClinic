/***********************************************************************
 * Module:  ArticleService.cs
 * Author:  Stefan
 * Purpose: Definition of the Class Service.ArticleService
 ***********************************************************************/

using Model.BlogAndNotification;
using System;
using System.Collections.Generic;
using Service.BlogNotificationServices;

namespace Controller.BlogNotificationControlers
{
    public class ArticleController : IController<Article, int>
    {
        public ArticleService articleService;

        public ArticleController(ArticleService articleService)
        {
            this.articleService = articleService;
        }

        public Article AddEntity(Article entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteEntity(Article entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Article> GetAllEntities()
        {
            throw new NotImplementedException();
        }

        public Article GetEntity(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateEntity(Article entity)
        {
            throw new NotImplementedException();
        }

    }
}