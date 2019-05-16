using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_Notification.Events;
using API_Notification.Helpers;
using API_Notification.Models;

namespace API_Notification.Interfaces
{
    public interface INotificationScheduler
    {
        void AddScheduler(Notification notification);
        void UpdateScheduler(Notification notification);
        void DeleteScheduler(Notification notification);
        bool CheckIfExists(Notification notification);

        event EventHandler<OnNotificationEventArgs> OnNotification;

    }
}
