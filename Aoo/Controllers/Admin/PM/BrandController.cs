using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL;
using DAL.Model.PM;
using Microsoft.AspNetCore.Mvc;

namespace Aoo.Controllers.Admin.PM
{
    [Route("[controller]/[action]")]
    [Area("PM")]
    public class BrandController : Controller
    {
        private readonly IGenericBLL<Brand> BrandBLL;

        public BrandController(IGenericBLL<Brand> brandBLL)
        {
            BrandBLL = brandBLL;
        }

        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> AddBrand()
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