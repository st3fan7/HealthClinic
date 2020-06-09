// File:    RenovationCSVConverter.cs
// Author:  Hacer
// Created: ponedeljak, 25. maj 2020. 01:41:55
// Purpose: Definition of Class RenovationCSVConverter

using Model.Term;
using System;

namespace Repository.Csv.Converter
{
    public class RenovationCSVConverter : ICSVConverter<Renovation>
    {
        public Renovation ConvertCSVFormatToEntity(string entityCSVFormat)
        {
            throw new NotImplementedException();
        }

        public string ConvertEntityToCSVFormat(Renovation entity)
        {
            throw new NotImplementedException();
        }
    }
}