using Services.EmailServices;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace UniTest.EmailServices
{
    public class MailchimpServices_Test
    {
        [Fact]
        public void GetAllMailingLists_Test()
        {
            MailchimpSErvices mailchimpSErvices = new MailchimpSErvices();
            var test =   mailchimpSErvices.GetAllMailingLists();
            Assert.True(true);
        }
        [Fact]
        public void GetAllTemplete_Test()
        {

            MailchimpSErvices mailchimpSErvices = new MailchimpSErvices();
            var test = mailchimpSErvices.GetAllTemplates();
            Assert.True(true);
        }
        [Fact]
        public void SendEmailCampain_Test()
        {
            MailchimpSErvices mailchimpSErvices = new MailchimpSErvices();
             mailchimpSErvices.CreateAndSendCampaign("test");
            Assert.True(true);
        }
        [Fact]
        public void AddUserToList()
        {
            MailchimpSErvices mailchimpSErvices = new MailchimpSErvices();
            mailchimpSErvices.AddUserToList("cpud1258@gmail.com");
            Assert.True(true);
        }
    }
}
