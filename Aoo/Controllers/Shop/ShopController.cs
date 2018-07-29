using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Aoo.Controllers.Shop
{
    [Route("[controller]/[action]")]
    public class ShopController : Controller
    {
        
        public async Task<IActionResult> MenShop()
        {
            return View();
        }
        public IActionResult WomenShop()
        {
            return View();
        }
        public IActionResult Detail()
        {
            return View();
        }
        public IActionResult CartItem()
        {
            return View();
        }
    }
}