using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL.BLL.PM;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Aoo.Controllers
{
    [Produces("application/json")]
    [Route("api/Common")]
    public class CommonController : Controller
    {
        IProvinceBLL IProvinceBLL;
        public CommonController(IProvinceBLL provinceBLL)
        {
            this.IProvinceBLL = provinceBLL;
        }
        [Route("District")]
        public async Task<JsonResult> Province()
        {
            var listProvince = await this.IProvinceBLL.Get();
            return Json (listProvince);
        }
    }
}