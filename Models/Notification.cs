using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Notification.Models
{
    public class Notification
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }
        public bool State { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

    }
}
