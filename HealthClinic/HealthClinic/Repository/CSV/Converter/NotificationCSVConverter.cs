// File:    NotificationCSVConverter.cs
// Author:  Hacer
// Created: ponedeljak, 25. maj 2020. 01:41:55
// Purpose: Definition of Class NotificationCSVConverter

using Model.BlogAndNotification;
using System;

namespace Repository.Csv.Converter
{
    public class NotificationCSVConverter : ICSVConverter<Notification>
    {
        private readonly string delimiter;

        public NotificationCSVConverter(string delimiter)
        {
            this.delimiter = delimiter;
        }

        public Notification ConvertCSVFormatToEntity(string entityCSVFormat)
        {
            throw new NotImplementedException();
        }

        public string ConvertEntityToCSVFormat(Notification entity)
        {
            throw new NotImplementedException();
        }
    }
}