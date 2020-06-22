// File:    ArticleCSVConverter.cs
// Author:  Hacer
// Created: ponedeljak, 25. maj 2020. 01:41:55
// Purpose: Definition of Class ArticleCSVConverter

using Model.AllActors;
using Model.BlogAndNotification;
using System;

namespace Repository.Csv.Converter
{
    public class ArticleCSVConverter : ICSVConverter<Article>
    {
        private readonly string delimiter;

        public ArticleCSVConverter(string delimiter)
        {

            this.delimiter = delimiter;
        }

        public Article ConvertCSVFormatToEntity(string entityCSVFormat)
        {
            string[] tokens = entityCSVFormat.Split(delimiter.ToCharArray());
            return new Article(tokens[0], int.Parse(tokens[1]), new Blog(int.Parse(tokens[2])), new System.Collections.ArrayList() ); //lista
        }

        public string ConvertEntityToCSVFormat(Article entity)
        {
            return string.Join(delimiter, entity.Title, entity.GetId(), entity.blog.GetId(), entity.comments);
        }
    }
}