// File:    AlergiesCSVConverter.cs
// Author:  Hacer
// Created: ponedeljak, 25. maj 2020. 01:41:55
// Purpose: Definition of Class AlergiesCSVConverter

using Model.PatientDoctor;
using System;

namespace Repository.Csv.Converter
{
    public class AlergiesCSVConverter : ICSVConverter<Allergies>
    {
        public Allergies ConvertCSVFormatToEntity(string entityCSVFormat)
        {
            throw new NotImplementedException();
        }

        public string ConvertEntityToCSVFormat(Allergies entity)
        {
            throw new NotImplementedException();
        }
    }
}