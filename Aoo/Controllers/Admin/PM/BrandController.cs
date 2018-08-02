using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Aoo.Controllers.Admin.PM
{
    [Route("[controller]/[action]")]
    [Area("PM")]
    public class BrandController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AddBrand()
        {
            return View();
        }
        public IActionResult EditBrand()
        {
            return View();
        }
        public IActionResult DeleteBrand()
        {
            return View();
        }
    }
}