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
        public string host = "smtp.gmail.com";
        public int port = 587;
        public  async Task SendEmailAsync(List<string> listToEmail,string body, string subject, string message)
        {
            SmtpClient client = new SmtpClient(host);
            client.UseDefaultCredentials = true;
            client.EnableSsl = true;
            client.DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network;
            client.Credentials = new NetworkCredential(username, password);
            client.Port = port;
            MailMessage mailMessage = new MailMessage();
            mailMessage.From = new MailAddress("cpud1258@gmail.com");
            foreach(var toEmail in listToEmail)
            {
                mailMessage.To.Add(toEmail);
            }
            mailMessage.IsBodyHtml = true;
            mailMessage.Body = body;
            
            mailMessage.Subject = subject;
            client.Send(mailMessage);     

           await Task.CompletedTask;
            return;
        }
    }
}
