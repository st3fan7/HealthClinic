// File:    WorkingTimeForDoctorCSVConverter.cs
// Author:  Hacer
// Created: ponedeljak, 25. maj 2020. 01:41:55
// Purpose: Definition of Class WorkingTimeForDoctorCSVConverter

using Model.Term;
using System;

namespace Repository.Csv.Converter
{
    public class WorkingTimeForDoctorCSVConverter : ICSVConverter<WorkingTimeForDoctor>
    {
        public WorkingTimeForDoctor ConvertCSVFormatToEntity(string entityCSVFormat)
        {
            throw new NotImplementedException();
        }

        public string ConvertEntityToCSVFormat(WorkingTimeForDoctor entity)
        {
            throw new NotImplementedException();
        }
    }
}