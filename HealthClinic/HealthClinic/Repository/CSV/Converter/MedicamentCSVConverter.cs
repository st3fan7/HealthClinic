// File:    MedicamentCSVConverter.cs
// Author:  Hacer
// Created: ponedeljak, 25. maj 2020. 01:41:55
// Purpose: Definition of Class MedicamentCSVConverter

using Model.DoctorMenager;
using System;

namespace Repository.Csv.Converter
{
    public class MedicamentCSVConverter : ICSVConverter<Medicament>
    {
        private readonly string delimiter;

        public MedicamentCSVConverter(string delimiter)
        {
            this.delimiter = delimiter;
        }

        public Medicament ConvertCSVFormatToEntity(string entityCSVFormat)
        {
            string[] tokens = entityCSVFormat.Split(delimiter.ToCharArray());
            //return new Medicament(tokens[0], tokens[1], tokens[2], State.Confirmed,  // Izmeni state
            //    int.Parse(tokens[4]), int.Parse(tokens[5]), new System.Collections.ArrayList());  // Izmeni listu
            return null;
        }

        public string ConvertEntityToCSVFormat(Medicament entity)
        {
            return string.Join(delimiter, entity.Code, entity.Name, entity.Producer,
                entity.StateOfValidation, entity.Quantity, entity.GetId(), entity.Ingredient);
        }
    }
}