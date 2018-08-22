using Aoo.Helpers;
using Microsoft.Extensions.DependencyInjection;
using Services;
using Services.EmailServices;
using Services.Implement;
using Services.PaypalServices;
using Services.PaypalServices.Implement;
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

            services.AddSingleton<ISMSServices, SMSServices>();
            services.AddSingleton<IPaypalServices, PaypalSDKServices>();


        }
    }
}
