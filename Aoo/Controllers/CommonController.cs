using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aoo.ViewModels.CM;
using BLL.BLL.PM;
using DAL.Model.CM;
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
        ITransportPriceBLL TransportPriceBLL;
        ITransportTypeBLL TransportTypeBLL;
        public CommonController(ITransportPriceBLL transportPriceBLL,ITransportTypeBLL transportTypeBLL, IMailchimpServices MailchimpServices,IProvinceBLL provinceBLL, ISubscribeEmailBLL subscribeEmailBLL)
        {
            this.IProvinceBLL = provinceBLL;
            this.subscribeEmailBLL = subscribeEmailBLL;
            this.MailchimpServices = MailchimpServices;
            this.TransportPriceBLL = transportPriceBLL;
            this.TransportTypeBLL = transportTypeBLL;
        }
        [Route("Type")]
        public async Task<JsonResult> TransportType()
        {
            var listTransportType = await this.TransportTypeBLL.Get();
            return Json(listTransportType);
        }
        [Route("Price")]
        public async Task<JsonResult> TransportPrice()
        {
            var listTransportPrice = await this.TransportPriceBLL.Get();
            return Json(listTransportPrice);
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