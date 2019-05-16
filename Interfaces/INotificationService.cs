using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_Notification.Models;

namespace API_Notification.Interface
{
    interface INotificationService
    {
        void SendAsync(Notification notification);
    }
}
