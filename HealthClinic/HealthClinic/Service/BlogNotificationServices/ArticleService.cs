/***********************************************************************
 * Module:  ArticleService.cs
 * Author:  Stefan
 * Purpose: Definition of the Class Service.ArticleService
 ***********************************************************************/

using Model.BlogAndNotification;
using Repository.BlogNotificationRepository;
using System;
using System.Collections.Generic;

namespace Service.BlogNotificationServices
{
    public class ArticleService : IService<Article, int>
    {
        public IArticleRepository articleRepository;
        //public CommentService commentService;

        public ArticleService(IArticleRepository articleRepository)
        {
            this.articleRepository = articleRepository;
        }       

        public Article ReadArticle(Model.BlogAndNotification.Article article)
        {
            throw new NotImplementedException();
        }

        public Article GetEntity(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Article> GetAllEntities()
        {
            throw new NotImplementedException();
        }

        public Article AddEntity(Article entity)
        {
            throw new NotImplementedException();
        }

        public void UpdateEntity(Article entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteEntity(Article entity)
        {
            throw new NotImplementedException();
        }

    }
}