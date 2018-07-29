using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Aoo.Controllers.Admin.PM
{
    [Route("[controller]/[action]")]
    public class ProductController : BaseController
    {
        public async Task<IActionResult> Index()
        {
            
            return View(BASE_ADMIN_URL+"/PM/View.cshtml");
        }
    }
}