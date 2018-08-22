using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aoo.Services;
using Aoo.ViewModels.PM.EmailMarketing;
using BLL.BLL.PM;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Services;
using Services.EmailServices;

namespace Aoo.Controllers.Admin.PM
{
    [Route("[controller]")]
    [Area("PM")]
    [Authorize]
    public class EmailMarketingController : BaseController
    {
        private ISubscribeEmailBLL SubscribeEmailBLL;
        private IEmailSender EmailSender;

        public EmailMarketingController(IEmailSender EmailSender,ISubscribeEmailBLL SubscribeEmailBLL,IImageServices imageServices) : base(imageServices)
        {
            this.EmailSender = EmailSender;
            this.SubscribeEmailBLL = SubscribeEmailBLL;
        }
        [Route("")]
        public async Task<IActionResult> Index()
        {
            
            return View(await this.SubscribeEmailBLL.Get());
        }
        [HttpPost]
        [Route("SendEmail")]
        public async Task<JsonResult> SendEmail([FromBody]AddEmailMarketingViewModel addEmailMarketingViewModel)
        {
            if (ModelState.IsValid)
            {
                 await this.EmailSender.SendEmailAsync(addEmailMarketingViewModel.listEmail, addEmailMarketingViewModel.Body, addEmailMarketingViewModel.Subject, addEmailMarketingViewModel.Title);
                return Json(new { success = "true" });
            }
            return Json(new { success = "false" } );
        }
    }
}