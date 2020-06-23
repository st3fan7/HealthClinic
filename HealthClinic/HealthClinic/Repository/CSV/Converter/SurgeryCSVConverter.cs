// File:    SurgeryCSVConverter.cs
// Author:  Hacer
// Created: ponedeljak, 25. maj 2020. 01:41:55
// Purpose: Definition of Class SurgeryCSVConverter

using Model.Term;
using System;

namespace Repository.Csv.Converter
{
    public class SurgeryCSVConverter : ICSVConverter<Surgery>
    {
        private readonly string delimiter;

        public SurgeryCSVConverter(string delimiter)
        {
            this.delimiter = delimiter;
        }

        public Surgery ConvertCSVFormatToEntity(string entityCSVFormat)
        {
            throw new NotImplementedException();
        }

        public string ConvertEntityToCSVFormat(Surgery entity)
        {
            throw new NotImplementedException();
        }
    }
}