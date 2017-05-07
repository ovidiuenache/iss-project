using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace App.Utils
{
    class MailSender
    {
        public void sendMail(MailAddress sender, MailAddress receiver, string message, string subject)
        {
            MailMessage mail = new MailMessage(sender, receiver);
            mail.Subject = subject;
            mail.Body = message;

            SmtpClient client = new SmtpClient();
            client.Host = "dad@gmail.com";
            client.EnableSsl = false;
            client.Port = 26;
            client.Credentials = new NetworkCredential("username", "password");

            client.Send(mail);
            /*
            SmtpClient client = new SmtpClient();
            client.Port = 557;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;
            client.Credentials = new System.Net.NetworkCredential("user", "pass");
            client.Host = "smtp.gmail.com";
            mail.Subject = subject;
            mail.Body = message;
            client.Send(mail);*/
        }
    }
}
