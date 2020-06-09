/***********************************************************************
 * Module:  NotificationService.cs
 * Author:  Stefan
 * Purpose: Definition of the Class Service.NotificationService
 ***********************************************************************/

using Model.BlogAndNotification;
using System;
using System.Collections.Generic;

namespace Controller.BlogNotificationControlers
{
   public class NotificationController : IController<Notification,int>
   {
      public Notification SendNotification(Model.BlogAndNotification.Notification notification, Model.AllActors.User user)
      {
         throw new NotImplementedException();
      }
      
      public Notification ReadNotification(Model.BlogAndNotification.Notification notification)
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

        public Service.BlogNotificationServices.NotificationService notificationService;
   
   }
}