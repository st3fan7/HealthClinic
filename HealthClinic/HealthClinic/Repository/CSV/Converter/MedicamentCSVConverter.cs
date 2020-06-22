// File:    MedicamentCSVConverter.cs
// Author:  Hacer
// Created: ponedeljak, 25. maj 2020. 01:41:55
// Purpose: Definition of Class MedicamentCSVConverter

using Model.DoctorMenager;
using System;
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

        public Medicament ConvertCSVFormatToEntity(string entityCSVFormat)
        {
            string[] tokens = entityCSVFormat.Split(delimiter.ToCharArray());
            System.Collections.ArrayList lista = new System.Collections.ArrayList();

            int i = 6;
            while(i < tokens.Length-1) 
            {
                lista.Add(tokens[i]);
                i++;
            }

            return new Medicament(tokens[0], tokens[1], tokens[2], (State)Enum.Parse(typeof(State), tokens[3]), 
                int.Parse(tokens[4]), int.Parse(tokens[5]), lista);  // Izmeni listu
            
        }

        public string ConvertEntityToCSVFormat(Medicament entity)
        {
            String list = "";

            foreach(String i in entity.ingredient)
            {
                list += string.Join(delimiter, i);
                list += delimiter; //??

            }

            return string.Join(delimiter, entity.Code, entity.Name, entity.Producer,
                entity.StateOfValidation, entity.Quantity, entity.GetId(), list);
        }
    }
}