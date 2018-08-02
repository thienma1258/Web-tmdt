using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Aoo.Controllers.Admin.PM
{

    [Route("[controller]/[action]")]
    [Area("PM")]
    public class SubGroupController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AddSubGroup()
        {
            return View();
        }
        public IActionResult EditSubGroup()
        {
            return View();
        }
        public IActionResult DeleteSubGroup()
        {
            return View();
        }
    }
}