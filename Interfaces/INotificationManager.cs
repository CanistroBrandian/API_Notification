using API_Notification.Models;

namespace API_Notification.Interfaces
{
   public interface INotificationManager
    {
        void Initilize(NotificationContext notificationContext);
        bool IsValid(Notification notification);
    }
}
