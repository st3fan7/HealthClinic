/***********************************************************************
 * Module:  Notification.cs
 * Author:  Hacer
 * Purpose: Definition of the Class Patient.Notification
 ***********************************************************************/

using HealthClinic.Repository;
using Model.AllActors;
using System;
using System.Collections;

namespace Model.BlogAndNotification
{
    public class Notification : Content, IIdentifiable<int>
    {
        private String title { get; set; }
        private int id;
        public User sendNotificationByUser { get; set; }

        public System.Collections.ArrayList receiveNotifications;

        public Notification(int id)
        {
            this.id = id;
        }

        public Notification()
        {
        }

        public Notification(string title, int id, User sendNotificationByUser, ArrayList receiveNotifications)
        {
            this.title = title;
            this.id = id;
            this.sendNotificationByUser = sendNotificationByUser;
            this.receiveNotifications = receiveNotifications;
        }

        public int GetId()
        {
            return id;
        }

        public void SetId(int id)
        {
            this.id = id;
        }

        /// <summary>
        /// Property for collection of User
        /// </summary>
        /// <pdGenerated>Default opposite class collection property</pdGenerated>
        public System.Collections.ArrayList ReceiveNotifications
        {
            get
            {
                if (receiveNotifications == null)
                    receiveNotifications = new System.Collections.ArrayList();
                return receiveNotifications;
            }
            set
            {
                RemoveAllReceiveNotifications();
                if (value != null)
                {
                    foreach (User oUser in value)
                        AddReceiveNotifications(oUser);
                }
            }
        }

        /// <summary>
        /// Add a new User in the collection
        /// </summary>
        /// <pdGenerated>Default Add</pdGenerated>
        public void AddReceiveNotifications(User newUser)
        {
            if (newUser == null)
                return;
            if (this.receiveNotifications == null)
                this.receiveNotifications = new System.Collections.ArrayList();
            if (!this.receiveNotifications.Contains(newUser))
                this.receiveNotifications.Add(newUser);
        }

        /// <summary>
        /// Remove an existing User from the collection
        /// </summary>
        /// <pdGenerated>Default Remove</pdGenerated>
        public void RemoveReceiveNotifications(User oldUser)
        {
            if (oldUser == null)
                return;
            if (this.receiveNotifications != null)
                if (this.receiveNotifications.Contains(oldUser))
                    this.receiveNotifications.Remove(oldUser);
        }

        /// <summary>
        /// Remove all instances of User from the collection
        /// </summary>
        /// <pdGenerated>Default removeAll</pdGenerated>
        public void RemoveAllReceiveNotifications()
        {
            if (receiveNotifications != null)
                receiveNotifications.Clear();
        }        

    }
}