// File:    NotificationCSVConverter.cs
// Author:  Hacer
// Created: ponedeljak, 25. maj 2020. 01:41:55
// Purpose: Definition of Class NotificationCSVConverter

using Model.AllActors;
using Model.BlogAndNotification;
using System;
using System.Collections;

namespace Repository.Csv.Converter
{
    public class NotificationCSVConverter : ICSVConverter<Notification>
    {
        private readonly string delimiter;

        public NotificationCSVConverter(string delimiter)
        {
            this.delimiter = delimiter;
        }

        public string ConvertEntityToCSVFormat(Notification entity)
        {
            String receiveNotificationsCSV = "";
            foreach (User user in entity.receiveNotifications)
            {
                receiveNotificationsCSV += string.Join(delimiter, user.GetId());
                receiveNotificationsCSV += delimiter;
            }

            return string.Join(delimiter, entity.GetId(), entity.Title, entity.SendNotificationByUser, receiveNotificationsCSV);
        }

        public Notification ConvertCSVFormatToEntity(string entityCSVFormat)
        {
            string[] tokens = entityCSVFormat.Split(delimiter.ToCharArray());
            ArrayList receiveNotifications = new ArrayList();
            FillList(receiveNotifications, tokens);
            return new Notification(int.Parse(tokens[0]), tokens[1], new User(int.Parse(tokens[2])), receiveNotifications);
        }

        private void FillList(ArrayList receiveNotifications, string[] tokens)
        {
            int i = 3;
            while (i < tokens.Length - 1)
            {
                int id = int.Parse(tokens[i]);
                receiveNotifications.Add(new Notification(id));     
                i++;
            }
        }
    }
}