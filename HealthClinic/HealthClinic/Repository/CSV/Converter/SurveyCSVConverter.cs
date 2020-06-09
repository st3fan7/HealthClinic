// File:    SurveyCSVConverter.cs
// Author:  Hacer
// Created: ponedeljak, 25. maj 2020. 01:41:55
// Purpose: Definition of Class SurveyCSVConverter

using Model.Patient;
using System;

namespace Repository.Csv.Converter
{
    public class SurveyCSVConverter : ICSVConverter<Survey>
    {
        public Survey ConvertCSVFormatToEntity(string entityCSVFormat)
        {
            throw new NotImplementedException();
        }

        public string ConvertEntityToCSVFormat(Survey entity)
        {
            throw new NotImplementedException();
        }
    }
}