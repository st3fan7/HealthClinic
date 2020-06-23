// File:    IssueMedicamentCSVConverter.cs
// Author:  Hacer
// Created: ponedeljak, 25. maj 2020. 01:41:55
// Purpose: Definition of Class IssueMedicamentCSVConverter

using Model.Doctor;
using System;

namespace Repository.Csv.Converter
{
    public class IssueMedicamentCSVConverter : ICSVConverter<IssueOfMedicaments>
    {
        private readonly string delimiter;

        public IssueMedicamentCSVConverter(string delimiter)
        {
            this.delimiter = delimiter;
        }

        public IssueOfMedicaments ConvertCSVFormatToEntity(string entityCSVFormat)
        {
            throw new NotImplementedException();
        }

        public string ConvertEntityToCSVFormat(IssueOfMedicaments entity)
        {
            throw new NotImplementedException();
        }
    }
}