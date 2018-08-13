using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Services.EmailServices
{
    public interface IEmailSender
    {
        Task SendEmailAsync( List<string> listToEmail, string body, string subject, string message);


    }
}
