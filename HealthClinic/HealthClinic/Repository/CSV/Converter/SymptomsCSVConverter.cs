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
            string[] tokens = entityCSVFormat.Split(delimiter.ToCharArray());
            return new Symptoms(int.Parse(tokens[0]), tokens[1]);
        }

        public string ConvertEntityToCSVFormat(Symptoms entity)
        {
            return string.Join(delimiter, entity.GetId(), entity.Name);
        }
    }
}