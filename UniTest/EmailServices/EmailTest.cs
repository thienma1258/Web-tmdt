using Services.EmailServices;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace UniTest.EmailServices
{
    public class EmailTest
    {
        [Fact]
        public async void GetAllTemplete_Test()
        {
            EmailSender mailchimpSErvices = new EmailSender();
            List<string> listemail = new List<string>();
            listemail.Add("cpud1258@gmail.com");
           await mailchimpSErvices.SendEmailAsync(listemail,"adsad","dsadsa","adssads");

        }
    }
}
