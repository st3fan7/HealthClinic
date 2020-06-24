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

        public string ConvertEntityToCSVFormat(Medicament entity)
        {
            String listOfIngredients = "";
            foreach (Ingredient ingredient in entity.Ingredients)
            {
                listOfIngredients += string.Join(delimiter, ingredient);
                listOfIngredients += delimiter;
            }
            return string.Join(delimiter, entity.GetId(), entity.Code, entity.Name, entity.Producer, entity.StateOfValidation, entity.Quantity, listOfIngredients);
        }

        public Medicament ConvertCSVFormatToEntity(string entityCSVFormat)
        {
            string[] tokens = entityCSVFormat.Split(delimiter.ToCharArray());
            List<Ingredient> listOfIngredients = new List<Ingredient>();
            FillList(listOfIngredients, tokens);
            return new Medicament(int.Parse(tokens[0]), tokens[1], tokens[2], tokens[3], (State)Enum.Parse(typeof(State), tokens[4]), int.Parse(tokens[5]), listOfIngredients);
        }

        private void FillList(List<Ingredient> ingredients, string[] tokens)
        {
            int i = 6;
            while (i < tokens.Length - 1)
            {
                ingredients.Add(new Ingredient(tokens[i]));
                i++;
            }
        }


    }
}