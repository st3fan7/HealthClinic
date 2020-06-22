/***********************************************************************
 * Module:  Content.cs
 * Author:  Hacer
 * Purpose: Definition of the Class Blog.Content
 ***********************************************************************/

using System;

namespace Model.BlogAndNotification
{
    public class Content
    {
        private String text { get; set; }
        private DateTime publishingDate { get; set; }

        public Content()
        {
        }

        public Content(string text, DateTime publishingDate)
        {
            this.text = text;
            this.publishingDate = publishingDate;
        }
    }
}