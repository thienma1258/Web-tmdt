using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Twilio.Rest.Api.V2010.Account;

namespace Services.SMSServices
{
    public interface ISMSServices
    {
        Task<MessageResource> sendSMS(string Phone, string ConfirmCode);
    }
}
