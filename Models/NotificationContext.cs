using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Notification.Models
{
    public class NotificationContext: DbContext
    {
        public DbSet<Notification> notifications { get; set; }
        public NotificationContext(DbContextOptions<NotificationContext> options): base(options)
        {
            Database.EnsureCreated();
        }
    }
}
