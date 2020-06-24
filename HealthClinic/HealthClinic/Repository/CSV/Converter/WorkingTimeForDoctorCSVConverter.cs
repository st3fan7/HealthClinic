// File:    WorkingTimeForDoctorCSVConverter.cs
// Author:  Hacer
// Created: ponedeljak, 25. maj 2020. 01:41:55
// Purpose: Definition of Class WorkingTimeForDoctorCSVConverter

using Model.AllActors;
using Model.Manager;
using Model.Term;
using System;
using System.Collections;

namespace Repository.Csv.Converter
{
    public class WorkingTimeForDoctorCSVConverter : ICSVConverter<WorkingTimeForDoctor>
    {
        private readonly string delimiter;

        public WorkingTimeForDoctorCSVConverter(string delimiter)
        {
            this.delimiter = delimiter;
        }

        public string ConvertEntityToCSVFormat(WorkingTimeForDoctor entity)
        {
            return string.Join(delimiter, entity.GetId(), entity.Day, entity.DoesWork, entity.Doctor.GetId());
        }

        public WorkingTimeForDoctor ConvertCSVFormatToEntity(string entityCSVFormat)
        {
            string[] tokens = entityCSVFormat.Split(delimiter.ToCharArray());
            return new WorkingTimeForDoctor(int.Parse(tokens[0]), (DaysInWeek)Enum.Parse(typeof(DaysInWeek), tokens[1]), bool.Parse(tokens[2]), (Doctor)new User(int.Parse(tokens[3])));
        }
    }
}