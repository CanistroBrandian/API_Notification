using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;
using API_Notification.Models;
using API_Notification.Interface;

namespace API_Notification.Services
{
    public class EmailNotificationServicce : INotificationService
    {
        public void SendAsync(Notification notification)
        {
            {
                EmailDetails emailDetails = new EmailDetails();
                // отправитель - устанавливаем адрес и отображаемое в письме имя
                MailAddress from = new MailAddress("brovkokosty@gmail.com", "Notification");
                // кому отправляем
                MailAddress to = new MailAddress("brovkokosty@mail.ru");
                // создаем объект сообщения
                MailMessage m = new MailMessage(from, to);
                // тема письма
                m.Subject = notification.Name;
                // текст письма
                m.Body = "<h2>" + notification.Text + "</h2>";
                // письмо представляет код html
                m.IsBodyHtml = true;
                // адрес smtp-сервера и порт, с которого будем отправлять письмо
                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                // логин и пароль
                smtp.Credentials = new NetworkCredential("brovkokosty@gmail.com","gjl_dq_em");
                smtp.EnableSsl = true;
                smtp.Send(m);
                Console.Read();

            }
        }
    }
}
