/***********************************************************************
 * Module:  UserRepository.cs
 * Author:  Stefan
 * Purpose: Definition of the Class Repository.UserRepository
 ***********************************************************************/

using Model.BlogAndNotification;
using Repository.Csv;
using Repository.Csv.Stream;
using Repository.IDSequencer;
using System;

namespace Repository.BlogNotificationRepository
{
   public class NotificationRepository : CSVRepository<Notification,int>, INotificationRepository
   {
        private String path;

        public NotificationRepository(ICSVStream<Notification> stream, ISequencer<int> sequencer)
             : base(stream, sequencer)
        {
        }
    }
}