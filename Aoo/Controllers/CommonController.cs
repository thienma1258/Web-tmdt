using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL.BLL.PM;
using DAL.Model.PM;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.EmailServices;

namespace Aoo.Controllers
{
    [Produces("application/json")]
    [Route("api/Common")]
    public class CommonController : Controller
    {
        IProvinceBLL IProvinceBLL;
        ISubscribeEmailBLL subscribeEmailBLL;
        IMailchimpServices MailchimpServices;
        public CommonController(IMailchimpServices MailchimpServices,IProvinceBLL provinceBLL, ISubscribeEmailBLL subscribeEmailBLL)
        {
            this.IProvinceBLL = provinceBLL;
            this.subscribeEmailBLL = subscribeEmailBLL;
            this.MailchimpServices = MailchimpServices;
        }
        [Route("District")]
        public async Task<JsonResult> Province()
        {
            var listProvince = await this.IProvinceBLL.Get();
            return Json (listProvince);
        }
        [HttpPost]
        [Route("SubscribeEmail")]
        public async Task<JsonResult> SubscribeEmail([FromBody]SubscribeEmail Email)
        {
            if (ModelState.IsValid)
            {
               bool isRegistersuccess=await this.subscribeEmailBLL.Add(Email);
                if (isRegistersuccess)
                {
                    MailchimpServices.AddUserToList(Email.Email);
                    return Json(new { success = "true" });

                }
                return Json(new { success = "false", message = "Email đã được đăng ký" });
            }
            return Json(new { success = "false",message="Định dạng email không chính xác" });
        }

    }
}