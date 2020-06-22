/***********************************************************************
 * Module:  NotificationService.cs
 * Author:  Stefan
 * Purpose: Definition of the Class Service.NotificationService
 ***********************************************************************/

using Model.BlogAndNotification;
using Repository.BlogNotificationRepository;
using System;
using System.Collections.Generic;

namespace Service.BlogNotificationServices
{
    public class NotificationService : IService<Notification, int>
    {
        public INotificationRepository notificationRepository;

        public NotificationService(INotificationRepository notificationRepository)
        {
            this.notificationRepository = notificationRepository;
        }

        public Notification SendNotification(Notification notification)
        {
            throw new NotImplementedException();
        }

        public Notification ReadNotification(Notification notification)
        {
            throw new NotImplementedException();
        }

        public List<Notification> GetAllNotificationsForUser(string username)
        {
            throw new NotImplementedException();
        }

        public Notification GetEntity(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Notification> GetAllEntities()
        {
            throw new NotImplementedException();
        }

        public Notification AddEntity(Notification entity)
        {
            throw new NotImplementedException();
        }

        public void UpdateEntity(Notification entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteEntity(Notification entity)
        {
            throw new NotImplementedException();
        }

    }
}