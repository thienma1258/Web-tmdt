using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL.BLL.PM;
using Microsoft.AspNetCore.Mvc;
using Services;

namespace Aoo.Controllers.Admin.PM
{
    [Route("[controller]")]
    [Area("PM")]
    public class EmailMarketingController : BaseController
    {
        private ISubscribeEmailBLL SubscribeEmailBLL;

        public EmailMarketingController(ISubscribeEmailBLL SubscribeEmailBLL,IImageServices imageServices) : base(imageServices)
        {
            this.SubscribeEmailBLL = SubscribeEmailBLL;
        }
        [Route("")]
        public async Task<IActionResult> Index()
        {
            
            return View(await this.SubscribeEmailBLL.Get());
        }
    }
}