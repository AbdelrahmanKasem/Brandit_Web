using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using System.Net;
using System.Net.Mail;

namespace RMSProjectAPI
{
    public static class MailService
    {
        public static void SendEmail(string email, string subject, string body)
        {
            var client = new SmtpClient("sandbox.smtp.mailtrap.io", 2525)
            {
                Credentials = new NetworkCredential(),
                EnableSsl = true
            };
            client.Send("from@example.com", email, subject, body);
            System.Console.WriteLine("Sent");
        }
    }
}