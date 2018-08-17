using Aoo.Helpers;
using BLL.PayMentBLL;
using BLL.PayMentBLL.ConfigOptions;
using BLL.PayMentBLL.Implement;
using Microsoft.Extensions.DependencyInjection;
using Services;
using Services.EmailServices;
using Services.Implement;
using Services.SMSServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aoo.App_start
{
    public class RegisterServicesConfig
    {
        public static void RegisterServices(ref IServiceCollection services)
        {
            services.AddTransient<IImageServices, LocalImageServices>();
            services.AddSingleton<IViewRenderService, RenderView>();
            services.AddSingleton<IMailchimpServices, MailchimpSErvices>();
            services.AddSingleton<IEmailSender, EmailSender>();

            services.AddSingleton<IPaypalServices, PaypalServices>();
            services.AddSingleton<ISMSServices, SMSServices>();

        }
    }
}
