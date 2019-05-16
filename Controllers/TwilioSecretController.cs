using API_Notification.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Notification.Controllers
{
    public class MessageController : Controller
    {
        private readonly TwilioAccountDetails _twilioAccountDetails;
        // I’ve injected twilioAccountDetails into the constructor
        public MessageController(IOptions<TwilioAccountDetails> twilioAccountDetails)
        {
            // We want to know if twilioAccountDetails is null so we throw an exception if it is           
            _twilioAccountDetails = twilioAccountDetails.Value ?? throw new ArgumentException(nameof(twilioAccountDetails));
        }

        [HttpGet]
        public IActionResult GetAccountSid()
        {
            return Content(_twilioAccountDetails.AccountSid);
        }
        [HttpGet]
        public IActionResult GetAccountAuth()
        {
            return Content(_twilioAccountDetails.AuthToken);
        }
    }
}
