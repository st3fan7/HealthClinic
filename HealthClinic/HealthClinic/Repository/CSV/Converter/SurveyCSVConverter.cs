// File:    SurveyCSVConverter.cs
// Author:  Hacer
// Created: ponedeljak, 25. maj 2020. 01:41:55
// Purpose: Definition of Class SurveyCSVConverter

using Model.AllActors;
using Model.Patient;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Documents;

namespace Repository.Csv.Converter
{
    public class SurveyCSVConverter : ICSVConverter<Survey>
    {
        private readonly string delimiter;

        public SurveyCSVConverter(string delimiter)
        {
            this.delimiter = delimiter;
        }
       
        public string ConvertEntityToCSVFormat(Survey entity)
        {
            String questionsCSV = "";
            foreach (Question doctor in entity.Question)
            {
                questionsCSV += string.Join(delimiter, doctor.GetId());
                questionsCSV += delimiter;
            }
            return string.Join(delimiter, entity.GetId(), entity.Title, entity.PublishingDate, entity.CommentSurvey, entity.Patient, questionsCSV);
        }

        public Survey ConvertCSVFormatToEntity(string entityCSVFormat)
        {
            string[] tokens = entityCSVFormat.Split(delimiter.ToCharArray());
            List<Question> questions = new List<Question>();
            FillList(questions, tokens);
            return new Survey(int.Parse(tokens[0]), tokens[1], Convert.ToDateTime(tokens[2]), tokens[3], (Patient)new User(int.Parse(tokens[3])), questions);

        }

        private void FillList(List<Question> questions, string[] tokens)
        {
            int i = 4;
            while (i < tokens.Length - 1)
            {
                int id = int.Parse(tokens[i]);
                questions.Add(new Question(id));
                i++;
            }
        }
    }
}