using API_Notification.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace API_Notification.Controllers
{
    public class EmailSecretController : Controller
    {
        private readonly EmailDetails _emailDetails;
        public EmailSecretController(IOptions<EmailDetails> emailDetails)
        {
            _emailDetails = emailDetails.Value ?? throw new ArgumentException(nameof(emailDetails));
        }

     
        public string GetEmail()
        {
            return _emailDetails.Email;
        }

        [HttpGet]
        public IActionResult GetPass()
        {
            return Content(_emailDetails.Pass);
        }
    }
}
