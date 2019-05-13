using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using API_Notification.Models;
using Timer = System.Timers.Timer;

namespace API_Notification.Controllers
{
    public class  NotificationScheduleHelper
    {
        private static System.Timers.Timer aTimer;
        private static List<Timer> timerList = new List<Timer>();

        public static void Intialize(NotificationContext context)
        {
           NotificationContext db = context;
           var list = db.notifications.Where(not => not.Date >= DateTime.UtcNow)
                .ToList();
        
            // Dictionary<int, int> timerList = new Dictionary<int, int>();
            if (!timerList.Any())
            {
                foreach (var i in list)
                {
                    var tempTime = Convert.ToInt32((i.Date - DateTime.Now).TotalMilliseconds);
                    aTimer = new System.Timers.Timer(tempTime);
                    aTimer.Start();
                    timerList.Add(aTimer);
                    
                }
            }
           
           
        }
        private static void SetTimer()
        {
            // Create a timer with a two second interval.
           
           
          
        }


    }
}
