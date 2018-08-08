using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL.BLL.PM;
using BLL.BLL.PM.Implement;
using Microsoft.AspNetCore.Mvc;
using Services;

namespace Aoo.Controllers.Admin.PM
{
    [Route("[controller]/[action]")]
    [Area("PM")]
    public class TransportTypeController : BaseController
    {
        private ITransportTypeBLL TransportTypeBLL;
        public TransportTypeController(IImageServices imageServices, ITransportTypeBLL TransportTypeBLL) : base(imageServices)
        {
            this.TransportTypeBLL = TransportTypeBLL;
        }

        public async Task<IActionResult> Index(int page = 1)
        {
            
            return View(await this.TransportTypeBLL.Get());
        }
    }
}