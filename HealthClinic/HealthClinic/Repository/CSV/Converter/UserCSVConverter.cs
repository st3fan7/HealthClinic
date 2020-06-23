// File:    UserCSVConverter.cs
// Author:  Hacer
// Created: ponedeljak, 25. maj 2020. 01:41:55
// Purpose: Definition of Class UserCSVConverter

using Model.AllActors;
using System;

namespace Repository.Csv.Converter
{
    public class UserCSVConverter : ICSVConverter<User>
    {
        private readonly string delimiter;

        public UserCSVConverter(string delimiter)
        {
            this.delimiter = delimiter;
        }

        public User ConvertCSVFormatToEntity(string entityCSVFormat)
        {
            throw new NotImplementedException();
        }

        public string ConvertEntityToCSVFormat(User entity)
        {
            throw new NotImplementedException();
        }
    }
}