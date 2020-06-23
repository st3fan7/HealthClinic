// File:    DiagnosisCSVConverter.cs
// Author:  Hacer
// Created: ponedeljak, 25. maj 2020. 01:41:55
// Purpose: Definition of Class DiagnosisCSVConverter

using Model.PatientDoctor;
using System;

namespace Repository.Csv.Converter
{
    public class DiagnosisCSVConverter : ICSVConverter<Diagnosis>
    {
        private readonly string delimiter;

        public DiagnosisCSVConverter(string delimiter)
        {
            this.delimiter = delimiter;
        }

        public Diagnosis ConvertCSVFormatToEntity(string entityCSVFormat)
        {
            throw new NotImplementedException();
        }

        public string ConvertEntityToCSVFormat(Diagnosis entity)
        {
            throw new NotImplementedException();
        }
    }
}