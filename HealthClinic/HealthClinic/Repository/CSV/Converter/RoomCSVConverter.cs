// File:    RoomCSVConverter.cs
// Author:  Hacer
// Created: ponedeljak, 25. maj 2020. 01:41:55
// Purpose: Definition of Class RoomCSVConverter

using Model.Term;
using System;

namespace Repository.Csv.Converter
{
    public class RoomCSVConverter : ICSVConverter<Room>
    {
        public Room ConvertCSVFormatToEntity(string entityCSVFormat)
        {
            throw new NotImplementedException();
        }

        public string ConvertEntityToCSVFormat(Room entity)
        {
            throw new NotImplementedException();
        }
    }
}