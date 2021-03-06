﻿using System;
using System.Collections.Generic;
using System.Linq;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using API_Notification.Interface;
using API_Notification.Models;

namespace API_Notification.Services
{
    public class SmsNotificationService : INotificationService
    {
        public void SendAsync(Notification notification)
        {
            TwilioAccountDetails twilioAccountDetails = new TwilioAccountDetails();
            const string sid = "AC5912529f023b71f40103d8ca51720fcc";
            const string auth = "a6cd92f087cc20db158f34780bd9dc0e";
            TwilioClient.Init(sid, auth);
            var message = MessageResource.Create(
    body: notification.Text,
    from: new Twilio.Types.PhoneNumber("+12055510531"),
    to: new Twilio.Types.PhoneNumber("+" + notification.PhoneNumber)
);
        }
    }
}

