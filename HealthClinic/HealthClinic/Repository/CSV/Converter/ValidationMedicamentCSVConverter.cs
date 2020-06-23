
// File:    ValidationMedicamentCSVConverter.cs
// Author:  Stefan
// Created: nedelja, 31. maj 2020. 21:09:55
// Purpose: Definition of Class ValidationMedicamentCSVConverter

using Model.DoctorMenager;
using System;

namespace Repository.Csv.Converter
{
    public class ValidationMedicamentCSVConverter : ICSVConverter<ValidationOfMedicament>
    {
        private readonly string delimiter;

        public ValidationMedicamentCSVConverter(string delimiter)
        {
            this.delimiter = delimiter;
        }

        public ValidationOfMedicament ConvertCSVFormatToEntity(string entityCSVFormat)
        {
            throw new NotImplementedException();
        }

        public string ConvertEntityToCSVFormat(ValidationOfMedicament entity)
        {
            throw new NotImplementedException();
        }
    }
}