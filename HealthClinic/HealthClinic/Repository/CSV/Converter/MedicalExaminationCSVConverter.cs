// File:    MedicalExaminationCSVConverter.cs
// Author:  Hacer
// Created: ponedeljak, 25. maj 2020. 01:41:55
// Purpose: Definition of Class MedicalExaminationCSVConverter

using Model.Term;
using System;

namespace Repository.Csv.Converter
{
    public class MedicalExaminationCSVConverter : ICSVConverter<MedicalExamination>
    {
        public MedicalExamination ConvertCSVFormatToEntity(string entityCSVFormat)
        {
            throw new NotImplementedException();
        }

        public string ConvertEntityToCSVFormat(MedicalExamination entity)
        {
            throw new NotImplementedException();
        }
    }
}