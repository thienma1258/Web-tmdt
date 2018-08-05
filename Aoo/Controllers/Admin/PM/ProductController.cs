using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Services;

namespace Aoo.Controllers.Admin.PM
{
    [Route("[controller]/[action]")]
    [Area("PM")]
    public class ProductController : BaseController
    {
        public ProductController(IImageServices imageServices) : base(imageServices)
        {
        }

        public async Task<IActionResult> Index()
        {
            return View();
        }
        public async Task<IActionResult> AddProduct()
        {
            return View();
        }
    }
}