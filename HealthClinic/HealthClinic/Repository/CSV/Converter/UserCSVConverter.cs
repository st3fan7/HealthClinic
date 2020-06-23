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
            string[] tokens = entityCSVFormat.Split(delimiter.ToCharArray());
            return new User(int.Parse(tokens[0]),  tokens[1], tokens[2]);
        }

        public string ConvertEntityToCSVFormat(User entity)
        {
            return string.Join(delimiter, entity.GetId(), entity.UserName, entity.Password);
        }
    }
}