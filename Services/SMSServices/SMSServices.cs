using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Twilio;
using Twilio.Rest.Api.V2010.Account;

namespace Services.SMSServices
{
    public class SMSServices : ISMSServices
    {
        const string accountSid = "AC164a6d2b1267cbe3b443ea6f687c3b8d";
        const string authToken = "b95e1ccc724fce8893bfd70db8c3b305";
     
        public async Task<MessageResource> sendSMS(string Phone, string ConfirmCode)
        {
            TwilioClient.Init(accountSid, authToken);
            var ToPhone = "+84"+ Phone.Substring(1, Phone.Length - 1);
            var message = await MessageResource.CreateAsync(
                body: "Mã xác nhận đơn hàng là"+ConfirmCode,
                from: new Twilio.Types.PhoneNumber("+16012589591"),
                to: new Twilio.Types.PhoneNumber(ToPhone)
            );
            return message;
        }
    }
}
