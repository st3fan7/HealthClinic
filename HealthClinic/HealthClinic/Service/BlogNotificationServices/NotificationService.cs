/***********************************************************************
 * Module:  NotificationService.cs
 * Author:  Stefan
 * Purpose: Definition of the Class Service.NotificationService
 ***********************************************************************/

using Model.BlogAndNotification;
using System;
using System.Collections.Generic;

namespace Service.BlogNotificationServices
{
   public class NotificationService : IService<Notification,int>
   {
      public Model.BlogAndNotification.Notification SendNotification(Notification notification)
      {
         throw new NotImplementedException();
      }
      
      public Model.BlogAndNotification.Notification ReadNotification(Notification notification)
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

        public System.Collections.Generic.IEnumerable<Notification> GetAllEntities()
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

        public Repository.BlogNotificationRepository.INotificationRepository iNotificationRepository;
   
   }
}