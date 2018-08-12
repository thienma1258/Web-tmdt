using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Services.EmailServices
{
    public class EmailSender:IEmailSender
    {
        public string username = "thienma1258z@gmail.com";
        public string password = "blogtruyen.com";
        public Task SendEmailAsync(string email,List<string> listToEmail,string body, string subject, string message)
        {
            SmtpClient client = new SmtpClient("mysmtpserver");
            client.UseDefaultCredentials = false;
            client.Credentials = new NetworkCredential(username, password);

            MailMessage mailMessage = new MailMessage();
            mailMessage.From = new MailAddress("cpud1258@gmail.com");
            foreach(var toEmail in listToEmail)
            {
                mailMessage.To.Add(toEmail);
            }
            mailMessage.Body = body;
            mailMessage.Subject = subject;
            client.Send(mailMessage);
            return Task.CompletedTask;
        }
    }
}
