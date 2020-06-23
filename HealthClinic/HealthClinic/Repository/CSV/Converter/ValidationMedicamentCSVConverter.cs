
// File:    ValidationMedicamentCSVConverter.cs
// Author:  Stefan
// Created: nedelja, 31. maj 2020. 21:09:55
// Purpose: Definition of Class ValidationMedicamentCSVConverter

using Model.AllActors;
using Model.DoctorMenager;
using System;
using System.Collections.Generic;

namespace Repository.Csv.Converter
{
    public class ValidationMedicamentCSVConverter : ICSVConverter<ValidationOfMedicament>
    {
        private readonly string delimiter;

        public ValidationMedicamentCSVConverter(string delimiter)
        {
            this.delimiter = delimiter;
        }

        public string ConvertEntityToCSVFormat(ValidationOfMedicament entity)
        {
            String doctorsCSV = "";
            foreach(Doctor doctor in entity.Doctors)
            {
                doctorsCSV += string.Join(delimiter, doctor.GetId());
                doctorsCSV += delimiter;
            }
            return string.Join(delimiter, entity.GetId(), entity.Approved, entity.Medicament.GetId(), entity.FeedbackOfValidation.Comment, doctorsCSV);
        }

        public ValidationOfMedicament ConvertCSVFormatToEntity(string entityCSVFormat)
        {
            string[] tokens = entityCSVFormat.Split(delimiter.ToCharArray());
            List<Doctor> doctors = new List<Doctor>();
            FillList(doctors, tokens);
            return new ValidationOfMedicament(int.Parse(tokens[0]), bool.Parse(tokens[1]), new Medicament(int.Parse(tokens[2])), new FeedbackOfValidation(tokens[3]), doctors);

        }

        private void FillList(List<Doctor> doctors, string[] tokens)
        {
            int i = 3;
            while (i < tokens.Length - 1)
            {
                int id = int.Parse(tokens[i]);
                doctors.Add((Doctor)new User(id));
                i++;
            }
        }
    }
}