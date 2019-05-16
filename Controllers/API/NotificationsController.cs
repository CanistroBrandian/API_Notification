using API_Notification.Interfaces;
using API_Notification.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Notification.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotificationsController : ControllerBase
    {
        private readonly NotificationContext _context;
        private readonly INotificationManager _notificationManager;
        private readonly INotificationScheduler _notificationScheduler;
        public NotificationsController(NotificationContext context,
            INotificationManager notificationManager,
            INotificationScheduler notificationScheduler)
        {
            _context = context;
            _notificationManager = notificationManager;
            _notificationScheduler = notificationScheduler;
        }


        // GET: api/Notifications
        [HttpGet]
        public IEnumerable<Notification> Getnotifications()
        {
            return _context.notifications;
        }

        // GET: api/Notifications/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetNotification([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var notification = await _context.notifications.FindAsync(id);

            if (notification == null)
            {
                return NotFound();
            }

            return Ok(notification);
        }

        // PUT: api/Notifications/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutNotification([FromRoute] int id, [FromBody] Notification notification)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != notification.Id)
            {
                return BadRequest();
            }
            if (!_notificationManager.IsValid(notification))
            {
                throw new DivideByZeroException("Невозможно создать напоминание в прошлом");
            }

            _context.Entry(notification).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NotificationExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            if (_notificationScheduler.CheckIfExists(notification))
                _notificationScheduler.UpdateScheduler(notification);
            return NoContent();
        }

        // POST: api/Notifications
        [HttpPost]
        public async Task<IActionResult> PostNotification([FromBody] Notification notification)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            if (!_notificationManager.IsValid(notification))
                return BadRequest("Невозможно создать напоминание в прошлом");

            _context.notifications.Add(notification);
            await _context.SaveChangesAsync();
            if (!_notificationScheduler.CheckIfExists(notification))
                _notificationScheduler.AddScheduler(notification);

            return CreatedAtAction("GetNotification", new { id = notification.Id }, notification);
        }

        // DELETE: api/Notifications/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteNotification([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var notification = await _context.notifications.FindAsync(id);
            if (notification == null)
            {
                return NotFound();
            }
            if (_notificationScheduler.CheckIfExists(notification))
                _notificationScheduler.DeleteScheduler(notification);
            _context.notifications.Remove(notification);
            await _context.SaveChangesAsync();
            return Ok(notification);
        }

        private bool NotificationExists(int id)
        {
            return _context.notifications.Any(e => e.Id == id);
        }
    }
}