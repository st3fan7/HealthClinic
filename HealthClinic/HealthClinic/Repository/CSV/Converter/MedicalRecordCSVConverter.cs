// File:    MedicalRecordCSVConverter.cs
// Author:  Hacer
// Created: ponedeljak, 25. maj 2020. 01:41:55
// Purpose: Definition of Class MedicalRecordCSVConverter

using Model.PatientDoctor;
using System;

namespace Repository.Csv.Converter
{
    public class MedicalRecordCSVConverter : ICSVConverter<MedicalRecord>
    {
        private readonly string delimiter;

        public MedicalRecordCSVConverter(string delimiter)
        {
            this.delimiter = delimiter;
        }

        public MedicalRecord ConvertCSVFormatToEntity(string entityCSVFormat)
        {
            throw new NotImplementedException();
        }

        public string ConvertEntityToCSVFormat(MedicalRecord entity)
        {
            throw new NotImplementedException();
        }
    }
}