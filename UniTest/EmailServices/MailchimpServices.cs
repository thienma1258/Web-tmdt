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
            
        }
        [Fact]
        public void GetAllTemplete_Test()
        {
            MailchimpSErvices mailchimpSErvices = new MailchimpSErvices();
            var test = mailchimpSErvices.GetAllTemplates();

        }
        [Fact]
        public void SendEmailCampain_Test()
        {
            MailchimpSErvices mailchimpSErvices = new MailchimpSErvices();
             mailchimpSErvices.CreateAndSendCampaign("test");
        }
        [Fact]
        public void AddUserToList()
        {
            MailchimpSErvices mailchimpSErvices = new MailchimpSErvices();
            mailchimpSErvices.AddUserToList("cpud1258@gmail.com");
        }
    }
}
