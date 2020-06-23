// File:    SymptomsCSVConverter.cs
// Author:  Hacer
// Created: ponedeljak, 25. maj 2020. 01:41:55
// Purpose: Definition of Class SymptomsCSVConverter

using Model.PatientDoctor;
using System;

namespace Repository.Csv.Converter
{
    public class SymptomsCSVConverter : ICSVConverter<Symptoms>
    {
        private readonly string delimiter;

        public SymptomsCSVConverter(string delimiter)
        {
            this.delimiter = delimiter;
        }

        public Symptoms ConvertCSVFormatToEntity(string entityCSVFormat)
        {
            throw new NotImplementedException();
        }

        public string ConvertEntityToCSVFormat(Symptoms entity)
        {
            throw new NotImplementedException();
        }
    }
}