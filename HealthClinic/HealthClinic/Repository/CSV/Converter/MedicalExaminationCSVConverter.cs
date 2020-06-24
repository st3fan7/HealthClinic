// File:    MedicalExaminationCSVConverter.cs
// Author:  Hacer
// Created: ponedeljak, 25. maj 2020. 01:41:55
// Purpose: Definition of Class MedicalExaminationCSVConverter

using Model.AllActors;
using Model.Term;
using System;

namespace Repository.Csv.Converter
{
    public class MedicalExaminationCSVConverter : ICSVConverter<MedicalExamination>
    {
        private readonly string delimiter;

        public MedicalExaminationCSVConverter(string delimiter)
        {
            this.delimiter = delimiter;
        }

        public string ConvertEntityToCSVFormat(MedicalExamination entity)
        {
            return string.Join(delimiter, entity.GetId(), entity.Urgency, entity.ShortDescription, entity.Room.GetId(),
                entity.Doctor.GetId(), entity.Patient.GetId(), entity.FromDateTime, entity.ToDateTime);
        }

        public MedicalExamination ConvertCSVFormatToEntity(string entityCSVFormat)
        {
            string[] tokens = entityCSVFormat.Split(delimiter.ToCharArray());
            return new MedicalExamination(int.Parse(tokens[0]), bool.Parse(tokens[1]), tokens[2], new Room(int.Parse(tokens[3])),
                (Doctor) new User(int.Parse(tokens[4])), (Patient) new User(int.Parse(tokens[5])), DateTime.Parse(tokens[6]), DateTime.Parse(tokens[7]));
        }

    }
}