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
        private readonly string delimiter;

        public RenovationCSVConverter(string delimiter)
        {
            this.delimiter = delimiter;
        }

        public Renovation ConvertCSVFormatToEntity(string entityCSVFormat)
        {
            string[] tokens = entityCSVFormat.Split(delimiter.ToCharArray());
            return new Renovation(int.Parse(tokens[0]), tokens[1], new Room(int.Parse(tokens[2])));
        }

        public string ConvertEntityToCSVFormat(Renovation entity)
        {
            return string.Join(delimiter, entity.GetId(), entity.DescriptionOfRenovation, entity.Room.GetId());
        }
    }
}