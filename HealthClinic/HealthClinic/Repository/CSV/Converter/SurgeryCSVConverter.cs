// File:    SurgeryCSVConverter.cs
// Author:  Hacer
// Created: ponedeljak, 25. maj 2020. 01:41:55
// Purpose: Definition of Class SurgeryCSVConverter

using Model.AllActors;
using Model.Term;
using System;

namespace Repository.Csv.Converter
{
    public class SurgeryCSVConverter : ICSVConverter<Surgery>
    {
        private readonly string delimiter;

        public SurgeryCSVConverter(string delimiter)
        {
            this.delimiter = delimiter;
        }

        public string ConvertEntityToCSVFormat(Surgery entity)
        {
            return string.Join(delimiter, entity.GetId(), entity.Urgency, entity.ShortDescription, entity.Room.GetId(), entity.DoctorSpecialist.GetId(), entity.Patient.GetId());
        }

        public Surgery ConvertCSVFormatToEntity(string entityCSVFormat)
        {
            string[] tokens = entityCSVFormat.Split(delimiter.ToCharArray());
            return new Surgery(int.Parse(tokens[0]), bool.Parse(tokens[1]), tokens[2], new Room(int.Parse(tokens[3])), (Model.Doctor.DoctorSpecialist)new User(int.Parse(tokens[4])), (Patient)new User(int.Parse(tokens[5])));
        }

    }
}