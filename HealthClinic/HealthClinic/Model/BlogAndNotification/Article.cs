/***********************************************************************
 * Module:  Article.cs
 * Author:  Hacer
 * Purpose: Definition of the Class Blog.Article
 ***********************************************************************/

using HealthClinic.Repository;
using Model.AllActors;
using System;
using System.Collections;

namespace Model.BlogAndNotification
{
    public class Article : Content, IIdentifiable<int>
    {
        private String title { get; set; }
        
        private int id;
        
        public Model.AllActors.Blog blog;

        public System.Collections.ArrayList comments;

        public Article(int id)
        {
            this.id = id;
        }

        public Article()
        {
        }

        public Article(string title, int id, Blog blog, ArrayList comments)
        {
            this.title = title;
            this.id = id;
            this.blog = blog;
            this.comments = comments;
        }

        public int GetId()
        {
            return id;
        }

        public void SetId(int id)
        {
            this.id = id;
        }

        /// <summary>
        /// Property for collection of Comment
        /// </summary>
        /// <pdGenerated>Default opposite class collection property</pdGenerated>
        public System.Collections.ArrayList Comments
        {
            get
            {
                if (comments == null)
                    comments = new System.Collections.ArrayList();
                return comments;
            }
            set
            {
                RemoveAllComments();
                if (value != null)
                {
                    foreach (Comment oComment in value)
                        AddComments(oComment);
                }
            }
        }

        /// <summary>
        /// Add a new Comment in the collection
        /// </summary>
        /// <pdGenerated>Default Add</pdGenerated>
        public void AddComments(Comment newComment)
        {
            if (newComment == null)
                return;
            if (this.comments == null)
                this.comments = new System.Collections.ArrayList();
            if (!this.comments.Contains(newComment))
                this.comments.Add(newComment);
        }

        /// <summary>
        /// Remove an existing Comment from the collection
        /// </summary>
        /// <pdGenerated>Default Remove</pdGenerated>
        public void RemoveComments(Comment oldComment)
        {
            if (oldComment == null)
                return;
            if (this.comments != null)
                if (this.comments.Contains(oldComment))
                    this.comments.Remove(oldComment);
        }

        /// <summary>
        /// Remove all instances of Comment from the collection
        /// </summary>
        /// <pdGenerated>Default removeAll</pdGenerated>
        public void RemoveAllComments()
        {
            if (comments != null)
                comments.Clear();
        }    

        /// <summary>
        /// Property for Model.AllActors.Blog
        /// </summary>
        /// <pdGenerated>Default opposite class property</pdGenerated>
        public Model.AllActors.Blog Blog
        {
            get
            {
                return blog;
            }
            set
            {
                if (this.blog == null || !this.blog.Equals(value))
                {
                    if (this.blog != null)
                    {
                        Model.AllActors.Blog oldBlog = this.blog;
                        this.blog = null;
                        oldBlog.RemoveArticles(this);
                    }
                    if (value != null)
                    {
                        this.blog = value;
                        this.blog.AddArticles(this);
                    }
                }
            }
        }

    }
}