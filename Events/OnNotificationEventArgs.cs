using API_Notification.Models;
using System;

namespace API_Notification.Events
{
    public class OnNotificationEventArgs : EventArgs
    {
        public OnNotificationEventArgs(Notification notification)
        {
            Notification = notification;
        }
        public Notification Notification { get; private set; }
    }
}
