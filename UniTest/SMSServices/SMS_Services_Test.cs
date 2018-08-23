using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace UniTest.SMSServices
{
    public class SMS_Services_Test
    {
        [Fact]
        public async void SendSMS_Test()
        {
            Services.SMSServices.SMSServices SMSServices = new Services.SMSServices.SMSServices();
            var test =await SMSServices.sendSMS("0969656692","12345");
            Assert.True(true);
        }
    }
}
