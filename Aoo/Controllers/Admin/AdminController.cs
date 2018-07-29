using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Aoo.Controllers.Manage
{
    public class AdminController : Controller
    {
        [Route("[controller]/[action]")]
        public async Task<IActionResult> Admin()
        {
            return View();
        }
    }
}