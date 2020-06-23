// File:    EquipmentCSVConverter.cs
// Author:  Hacer
// Created: ponedeljak, 25. maj 2020. 01:41:55
// Purpose: Definition of Class EquipmentCSVConverter

using Model.Manager;
using System;

namespace Repository.Csv.Converter
{
    public class EquipmentCSVConverter : ICSVConverter<Equipment>
    {
        private readonly string delimiter;

        public EquipmentCSVConverter(string delimiter)
        {
            this.delimiter = delimiter;
        }

        public Equipment ConvertCSVFormatToEntity(string entityCSVFormat)
        {
            throw new NotImplementedException();
        }

        public string ConvertEntityToCSVFormat(Equipment entity)
        {
            throw new NotImplementedException();
        }
    }
}