using MailChimp.Net.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Services.EmailServices
{
    public interface IMailchimpServices
    {
        void CreateAndSendCampaign(string html);
        List<Template> GetAllTemplates();
        List<List> GetAllMailingLists();
        Content GetTemplateDefaultContent(string templateId);
        void AddUserToList(string Email);
    }
}
