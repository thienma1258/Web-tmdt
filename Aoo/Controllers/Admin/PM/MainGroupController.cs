using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Aoo.Controllers.Admin.PM
{
    public class MainGroupController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}