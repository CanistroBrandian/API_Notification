using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Timers;
using API_Notification.Models;
using Timer = System.Timers.Timer;

namespace API_Notification.Helpers
{
    public static class NotificationScheduleHelper
    {
        private static Dictionary<int, Timer> dictionaryTimers = new Dictionary<int, Timer>();
        public static void Intialize(NotificationContext context)
        {
            NotificationContext db = context;
            if (dictionaryTimers != null && dictionaryTimers.Any())
            {
                foreach (var key in dictionaryTimers.Keys)
                {
                    dictionaryTimers[key].Stop();
                }

            }
            dictionaryTimers = new Dictionary<int, Timer>();
            var list = db.notifications.Where(not => not.Date >= DateTime.UtcNow)
                .ToList();
            foreach (var i in list)
            {
                var tempTime = Convert.ToInt32((i.Date - DateTime.UtcNow).TotalMilliseconds);
                var tempTimer = new System.Timers.Timer(tempTime);
                tempTimer.Start();
                tempTimer.Elapsed += (o, e) => //анонимная функция 
                {
                    OnTimerTick(i, tempTimer);
                };
                dictionaryTimers.Add(i.Id, tempTimer);
                //var abc = new //анонимная тип 
                //{
                //    id = "asd"
                //};
                //  лист на ликшенари поменять

            }
        }

        public static void AddTimer(Notification not)
        {
            if (dictionaryTimers.ContainsKey(not.Id))
            {
                throw new InvalidOperationException("Такой таймер уже существует");
            }
            var tempTimer = new Timer();
            var tempTime = Convert.ToInt32((not.Date - DateTime.UtcNow).TotalMilliseconds);
            tempTimer.Interval = tempTime;
            tempTimer.Elapsed += (o, e) => //анонимная функция 
            {
                OnTimerTick(not, tempTimer);
            };
            tempTimer.Start();
            dictionaryTimers.Add(not.Id, tempTimer);
        }

        public static void UpdateTimer(Notification not)
        {
            if (!dictionaryTimers.ContainsKey(not.Id))
            {
                throw new InvalidOperationException("Такой таймер не существует");
            }
            var tempTimer = dictionaryTimers[not.Id];
            tempTimer.Stop();
            var tempTime = Convert.ToInt32((not.Date - DateTime.UtcNow).TotalMilliseconds);
            tempTimer.Interval = tempTime;
            tempTimer.Elapsed += (o, e) => //анонимная функция 
            {
                OnTimerTick(not, tempTimer);
            };
            tempTimer.Start();

        }

        public static void DeleteTimer(Notification not)
        {
            if (!dictionaryTimers.ContainsKey(not.Id))
                throw new InvalidOperationException("Такой таймер уже существует");
            dictionaryTimers[not.Id].Stop();
            dictionaryTimers.Remove(not.Id);
        }

        private static void OnTimerTick(Notification notification, Timer timer)
        {
            timer.Stop();
            Console.WriteLine($"сработал таймер {notification.Id}");
        }

        public static bool CheckIfExists(Notification not)
        {
            return dictionaryTimers.ContainsKey(not.Id);
        }

        public static int CheckLessNull(Notification not)
        {
            return Convert.ToInt32((not.Date - DateTime.UtcNow).TotalMilliseconds);


        }
    }
}
