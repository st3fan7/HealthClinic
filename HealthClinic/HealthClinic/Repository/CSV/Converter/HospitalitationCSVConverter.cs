// File:    HospitalitationCSVConverter.cs
// Author:  Hacer
// Created: ponedeljak, 25. maj 2020. 01:41:55
// Purpose: Definition of Class HospitalitationCSVConverter

using Model.Term;
using System;

namespace Repository.Csv.Converter
{
    public class HospitalitationCSVConverter : ICSVConverter<Hospitalitation>
    {
        public Hospitalitation ConvertCSVFormatToEntity(string entityCSVFormat)
        {
            throw new NotImplementedException();
        }

        public string ConvertEntityToCSVFormat(Hospitalitation entity)
        {
            throw new NotImplementedException();
        }
    }
}