using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_Notification.Models;
using Microsoft.EntityFrameworkCore;

namespace API_Notification.Models
{
    public static class SampleData
    {
        public static void Initialize(NotificationContext context)
        {
            if (!context.notifications.Any())
            {
                context.AddRange(new Notification
                {                   
                    
                    Name= "Пора выходить",
                    Text = "Костян настало твое время, выходи!",
                    Date = new DateTime(2019, 05, 11, 18, 30, 25),
                    State = false,
                    PhoneNumber= "375291488923",
                    Email= "asd@mail.ru"
                                       
                });

                context.AddRange(new Notification
                {
                    Name = "Срочно выходи",
                    Text = "Ты уже опаздывешь, выходи!",
                    Date = new DateTime(2019, 05, 11, 18, 35, 25),
                    State = false,
                    PhoneNumber = "375291488923",
                    Email = "asd@mail.ru"

                });

                context.AddRange(new Notification
                {
                    Name = "Ты опаздал",
                    Text = "МОжешь не торопиться - ты опаздал",
                    Date = new DateTime(2019, 05, 11, 18, 40, 25),
                    State = false,
                    PhoneNumber = "375291488923",
                    Email = "asd@mail.ru"

                });

            }
            context.SaveChanges();
        }
    }
}
