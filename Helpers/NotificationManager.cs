using API_Notification.Events;
using API_Notification.Interfaces;
using API_Notification.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace API_Notification.Helpers
{
    public class NotificationManager : INotificationManager
    {
        private readonly INotificationScheduler _notificationScheduler;
        private readonly IEnumerable<INotificationService> _notificationServices;

        //Почитать про конструкторы
        public NotificationManager(
            INotificationScheduler notificationScheduler,
            IEnumerable<INotificationService> notificationServices)
        {
            _notificationScheduler = notificationScheduler;
            _notificationServices = notificationServices;

        }

        public void Initilize(NotificationContext notificationContext)
        {
            var notifications = notificationContext.notifications.Where(not => not.Date >= DateTime.UtcNow)
                .ToList();
            foreach (var notification in notifications)
            {
                _notificationScheduler.AddScheduler(notification);
            }
            _notificationScheduler.OnNotification += OnNotificationHandlerAsync;
        }

        private async void OnNotificationHandlerAsync(object args, OnNotificationEventArgs e)
        {
            foreach (var notificationService in _notificationServices)
            {
                await notificationService.SendAsync(e.Notification);
            }
        }
        public bool IsValid(Notification notification)
        {
            return (notification.Date - DateTime.UtcNow).TotalMilliseconds > 0;
        }

    }

}