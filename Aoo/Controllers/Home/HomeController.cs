using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Aoo.Models;
using DAL.DataContext;
using Microsoft.EntityFrameworkCore;
using DAL.Model.PM;
using Services;
using BLL.BLL.PM.Implement;
using BLL.BLL.PM;

namespace Aoo.Controllers
{
    public class HomeController : BaseController
    {
        
        private readonly IHomeSliderBLL HomeSliderBLL;
        private readonly ShopContext shopContext;
        public HomeController(ShopContext shopContext,IHomeSliderBLL homeSliderBLL,IImageServices imageServices):base(imageServices)
        {
            HomeSliderBLL = homeSliderBLL;
            this.shopContext = shopContext;
        }
        public async Task<IActionResult> Index()
        {
         
            return View(await HomeSliderBLL.Get());
        }
       
        public async Task<IActionResult> About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }
        public async Task<IActionResult> Login()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }
        public async Task<IActionResult>  Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public async Task<IActionResult> Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
