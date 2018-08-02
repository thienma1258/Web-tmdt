using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Aoo.Controllers.Admin.PM
{
    [Route("[controller]/[action]")]
    [Area("PM")]
    public class MainGroupController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AddMainGroup()
        {
            return View();
        }
        public IActionResult EditMainGroup()
        {
            return View();
        }
        public IActionResult DelateMainGroup()
        {
            return View();
        }
    }
}