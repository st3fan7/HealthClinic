// File:    RoomCSVConverter.cs
// Author:  Hacer
// Created: ponedeljak, 25. maj 2020. 01:41:55
// Purpose: Definition of Class RoomCSVConverter

using Model.Manager;
using Model.Term;
using System;
using System.Collections.Generic;

namespace Repository.Csv.Converter
{
    public class RoomCSVConverter : ICSVConverter<Room>
    {
        private readonly string delimiter;

        public RoomCSVConverter(string delimiter)
        {
            this.delimiter = delimiter;
        }

        public string ConvertEntityToCSVFormat(Room entity)
        {
            String equipmentCSV = "";
            foreach (Equipment equipment in entity.Equipment)
            {
                equipmentCSV += string.Join(delimiter, equipment.GetId());
                equipmentCSV += delimiter;
            }
            return string.Join(delimiter, entity.GetId(), entity.RoomID, entity.TypeOfRoom, equipmentCSV);
        }

        public Room ConvertCSVFormatToEntity(string entityCSVFormat)
        {
            string[] tokens = entityCSVFormat.Split(delimiter.ToCharArray());
            List<Equipment> equipments = new List<Equipment>();
            FillList(equipments, tokens);
            return new Room(int.Parse(tokens[0]), tokens[1], (TypeOfRoom)Enum.Parse(typeof(TypeOfRoom), tokens[2]), equipments);
        }

        private void FillList(List<Equipment> equipment, string[] tokens)
        {
            int i = 3;
            while (i < tokens.Length - 1)
            {
                int id = int.Parse(tokens[i]);
                equipment.Add(new Equipment(id)); 
                i++;
            }
        }
    }
}