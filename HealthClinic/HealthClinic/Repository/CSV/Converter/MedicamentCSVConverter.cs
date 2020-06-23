// File:    MedicamentCSVConverter.cs
// Author:  Hacer
// Created: ponedeljak, 25. maj 2020. 01:41:55
// Purpose: Definition of Class MedicamentCSVConverter

using Model.DoctorMenager;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Repository.Csv.Converter
{
    public class MedicamentCSVConverter : ICSVConverter<Medicament>
    {
        private readonly string delimiter;

        public MedicamentCSVConverter(string delimiter)
        {
            this.delimiter = delimiter;
        }

        public string ConvertEntityToCSVFormat(Medicament entity)
        {
            String ingridientsCSV = "";
            foreach (String ingridient in entity.ingredient)
            {
                ingridientsCSV += string.Join(delimiter, ingridient);
                ingridientsCSV += delimiter;
            }

            return string.Join(delimiter, entity.GetId(), entity.Code, entity.Name, entity.Producer,
                entity.StateOfValidation, entity.Quantity, ingridientsCSV);
        }

        public Medicament ConvertCSVFormatToEntity(string entityCSVFormat)
        {
            string[] tokens = entityCSVFormat.Split(delimiter.ToCharArray());
            ArrayList indigrients = new ArrayList();
            FillList(indigrients, tokens);
            return new Medicament(int.Parse(tokens[0]), tokens[1], tokens[2], tokens[3], (State)Enum.Parse(typeof(State), tokens[4]), 
                int.Parse(tokens[5]), indigrients);            
        }

        private void FillList(ArrayList indigrients, string[] tokens)
        {
            int i = 3;
            while (i < tokens.Length - 1)
            {
                indigrients.Add(tokens[i]);   
                i++;
            }
        }
    }
}