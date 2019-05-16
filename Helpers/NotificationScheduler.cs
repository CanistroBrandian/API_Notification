using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Timers;
using API_Notification.Models;
using Timer = System.Timers.Timer;
using API_Notification.Services;
using API_Notification.Interfaces;
using API_Notification.Events;

namespace API_Notification.Helpers
{
    public class NotificationScheduler : INotificationScheduler
    {

        private static Dictionary<int, Timer> dictionaryTimers = new Dictionary<int, Timer>();

        public event EventHandler<OnNotificationEventArgs> OnNotification;

        public void AddScheduler(Notification not)
        {
            if (dictionaryTimers.ContainsKey(not.Id))
            {
                throw new InvalidOperationException("Такой таймер уже существует");
            }
            var tempTimer = new Timer();
            var tempTime = Convert.ToInt32((not.Date - DateTime.UtcNow).TotalMilliseconds);
            tempTimer.Interval = tempTime;
            tempTimer.Elapsed += (o, e) =>
            {
                tempTimer.Stop();
                OnNotification?.Invoke(o, new OnNotificationEventArgs(not));
            };
            tempTimer.Start();
            dictionaryTimers.Add(not.Id, tempTimer);
        }

        public void UpdateScheduler(Notification not)
        {
            if (!dictionaryTimers.ContainsKey(not.Id))
            {
                throw new InvalidOperationException("Такой таймер не существует");
            }
            var tempTimer = dictionaryTimers[not.Id];
            tempTimer.Stop();
            var tempTime = Convert.ToInt32((not.Date - DateTime.UtcNow).TotalMilliseconds);
            tempTimer.Interval = tempTime;
            tempTimer.Elapsed += (o, e) =>
            {
                tempTimer.Stop();
                OnNotification?.Invoke(o, new OnNotificationEventArgs(not));
            };
            tempTimer.Start();

        }

        public void DeleteScheduler(Notification not)
        {
            if (!dictionaryTimers.ContainsKey(not.Id))
                throw new InvalidOperationException("Такой таймер уже существует");
            dictionaryTimers[not.Id].Stop();
            dictionaryTimers.Remove(not.Id);
        }

        public bool CheckIfExists(Notification not)
        {
            return dictionaryTimers.ContainsKey(not.Id);
        }
    }
}
