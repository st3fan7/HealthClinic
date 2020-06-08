// File:    ArticleCSVConverter.cs
// Author:  Hacer
// Created: ponedeljak, 25. maj 2020. 01:41:55
// Purpose: Definition of Class ArticleCSVConverter

using Model.BlogAndNotification;
using System;

namespace Repository.Csv.Converter
{
    public class ArticleCSVConverter : ICSVConverter<Article>
    {
        public Article ConvertCSVFormatToEntity(string entityCSVFormat)
        {
            throw new NotImplementedException();
        }

        public string ConvertEntityToCSVFormat(Article entity)
        {
            throw new NotImplementedException();
        }
    }
}