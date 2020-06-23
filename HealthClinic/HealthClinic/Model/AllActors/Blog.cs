/***********************************************************************
 * Module:  Blog.cs
 * Author:  Stefan
 * Purpose: Definition of the Class AllActors.Blog
 ***********************************************************************/

using HealthClinic.Repository;
using Model.BlogAndNotification;
using System;
using System.Collections;

namespace Model.AllActors
{
    public class Blog : IIdentifiable<int>
    {
        private String name;

        public ArrayList articles;

        private int id;

        public string Name { get => name; set => name = value; }

        public Blog(int id)
        {
            this.id = id;
        }

        public Blog()
        {
        }

        public Blog(int id, string name, ArrayList articles)
        {
            this.Name = name;
            this.articles = articles;
            this.id = id;
        }

        public Blog(string name, ArrayList articles)
        {
            this.Name = name;
            this.articles = articles;
        }

        /// <summary>
        /// Property for collection of Article
        /// </summary>
        /// <pdGenerated>Default opposite class collection property</pdGenerated>
        public ArrayList Articles
        {
            get
            {
                if (articles == null)
                    articles = new ArrayList();
                return articles;
            }
            set
            {
                RemoveAllArticles();
                if (value != null)
                {
                    foreach (Article oArticle in value)
                        AddArticles(oArticle);
                }
            }
        }

        


        /// <summary>
        /// Add a new Article in the collection
        /// </summary>
        /// <pdGenerated>Default Add</pdGenerated>
        public void AddArticles(Article newArticle)
        {
            if (newArticle == null)
                return;
            if (this.articles == null)
                this.articles = new ArrayList();
            if (!this.articles.Contains(newArticle))
            {
                this.articles.Add(newArticle);
                newArticle.Blog = this;
            }
        }

        /// <summary>
        /// Remove an existing Article from the collection
        /// </summary>
        /// <pdGenerated>Default Remove</pdGenerated>
        public void RemoveArticles(Article oldArticle)
        {
            if (oldArticle == null)
                return;
            if (this.articles != null)
                if (this.articles.Contains(oldArticle))
                {
                    this.articles.Remove(oldArticle);
                    oldArticle.Blog = null;
                }
        }

        /// <summary>
        /// Remove all instances of Article from the collection
        /// </summary>
        /// <pdGenerated>Default removeAll</pdGenerated>
        public void RemoveAllArticles()
        {
            if (articles != null)
            {
                ArrayList tmpArticles = new ArrayList();
                foreach (Article oldArticle in articles)
                    tmpArticles.Add(oldArticle);
                articles.Clear();
                foreach (Article oldArticle in tmpArticles)
                    oldArticle.Blog = null;
                tmpArticles.Clear();
            }
        }

        public int GetId()
        {
            return id;
        }

        public void SetId(int id)
        {
            this.id = id;
        }
    }
}