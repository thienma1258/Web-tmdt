using System;
using System.Collections.Generic;
using System.Text;
using MailChimp.Net;
using MailChimp.Net.Core;
using MailChimp.Net.Models;
using System.Globalization;
using System.Linq;
namespace Services.EmailServices
{
 
    public class MailchimpSErvices: IMailchimpServices
    {
        private const string ApiKey = "f84c8c30dfa44554044308fbc474c4ca-us19";
        private const string ListId = "90c9ff5c23";
        private const int TemplateId = 2117; // (your template id)
        private MailChimpManager _mailChimpManager = new MailChimpManager(ApiKey);
        private Setting _campaignSettings = new Setting
        {
            ReplyTo = "cpud1258@gmail.com",
            FromName = "The name that others will see when they receive the email",
            Title = "Your campaign title",
            SubjectLine = "The email subject",
        };

        // `html` contains the content of your email using html notation
        public void CreateAndSendCampaign(string html)
        {
            var campaign = _mailChimpManager.Campaigns.AddAsync(new Campaign
            {
                Settings = _campaignSettings,
                Recipients = new Recipient { ListId = ListId },
                Type = CampaignType.Regular
            }).Result;
            var timeStr = DateTime.Now.ToString();
            var content = _mailChimpManager.Content.AddOrUpdateAsync(
             campaign.Id,
             new ContentRequest()
             {
                 Template = new ContentTemplate
                 {
                     Id = TemplateId,
                     Sections = new Dictionary<string, object>()
                {
       { "body_content", html },
       { "preheader_leftcol_content", $"<p>{timeStr}</p>" }
                }
                 }
             }).Result;
            _mailChimpManager.Campaigns.SendAsync(campaign.Id).Wait();
        }
        public List<Template> GetAllTemplates()
          => _mailChimpManager.Templates.GetAllAsync().Result.ToList();
        public List<List> GetAllMailingLists()
          => _mailChimpManager.Lists.GetAllAsync().Result.ToList();
        public Content GetTemplateDefaultContent(string templateId)
          => (Content)_mailChimpManager.Templates.GetDefaultContentAsync(templateId).Result;
        public async void AddUserToList(string Email)
        {
            
            // Use the Status property if updating an existing member
            var member = new Member { EmailAddress = $""+Email+"", StatusIfNew = Status.Subscribed };
            await this._mailChimpManager.Members.AddOrUpdateAsync(ListId, member);
        }
    }
}
