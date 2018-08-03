using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using BLL;
using DAL.Model.PM;
using Microsoft.AspNetCore.Mvc;
using Services;
using Services.ImageServices;

namespace Aoo.Controllers.Admin.PM
{
    [Route("[controller]/[action]")]
    [Area("PM")]
    public class BrandController : Controller
    {
        private readonly IGenericBLL<Brand,string> BrandBLL;
        public readonly IImageServices ImageServices;
        public BrandController(IGenericBLL<Brand,string> brandBLL,IImageServices imageServices)
        {
            BrandBLL = brandBLL;
            this.ImageServices = imageServices;
        }

        public async Task<IActionResult> Index()
        {
            return View(await BrandBLL.Get(6));
        }
        public async Task<IActionResult> AddBrand()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddBrand(ViewModels.PM.Brand.AddBrandViewModel addBrandViewModel)
        {
            if (ModelState.IsValid)
            {
                ImageErrorModel imageErrorModel;
                MemoryStream memoryStream = new MemoryStream();
               await  addBrandViewModel.DefaultImage.CopyToAsync(memoryStream);
                string ImagePath = this.ImageServices.UploadImage(memoryStream, addBrandViewModel.DefaultImage.FileName, out imageErrorModel);
                if (imageErrorModel.isSuccess)
                {
                    Brand brand = new Brand()
                    {
                        Name = addBrandViewModel.Name,
                        DefaultImage = ImagePath,
                        Description = addBrandViewModel.Description

                    };
                    await BrandBLL.Add(brand);
                }
            }
          
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