// File:    AlergiesCSVConverter.cs
// Author:  Hacer
// Created: ponedeljak, 25. maj 2020. 01:41:55
// Purpose: Definition of Class AlergiesCSVConverter

using Model.AllActors;
using Model.PatientDoctor;
using System;
using System.Collections;

namespace Repository.Csv.Converter
{
    public class AlergiesCSVConverter : ICSVConverter<Allergies>
    {
        private readonly string delimiter;

        public AlergiesCSVConverter(string delimiter)
        {
            this.delimiter = delimiter;
        }

        public Allergies ConvertCSVFormatToEntity(string entityCSVFormat)
        {
            string[] tokens = entityCSVFormat.Split(delimiter.ToCharArray());
            return new Allergies(tokens[0], int.Parse(tokens[1]));
            
            
        }

        public string ConvertEntityToCSVFormat(Allergies entity)
        {        
            return string.Join(delimiter, entity.Name, entity.GetId());
            //entity
        }
    }
}