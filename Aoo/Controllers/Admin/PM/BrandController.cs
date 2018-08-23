using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Aoo.ViewModels.PM.Brand;
using BLL;
using BLL.BLL.PM;
using DAL.Model.PM;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Services;
using Services.ImageServices;
using Services.Logging;

namespace Aoo.Controllers.Admin.PM
{
    [Authorize]
    [Route("[controller]/[action]")]
    [Area("PM")]
    public class BrandController : BaseController
    {
        
        private readonly IBrandBLL BrandBLL;
        public BrandController(IBrandBLL brandBLL,IImageServices imageServices):base(imageServices)
        {
            BrandBLL = brandBLL;
        }

        public async Task<IActionResult> Index(int page=1)
        {
            ViewBag.currentPage = page;
            int totalcout = BrandBLL.Cout();
            ViewBag.totalPage = TotalPage(totalcout);
            var ListBrand = await BrandBLL.Get(numberPerPage, page, orderBy: p => p.OrderByDescending(x => x.EditedDate));
            //var ListBrandFilter = await BrandBLL.Get(filter: p => p.Name.Contains());
            return View(ListBrand);
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
                ImageErrorModel imageErrorModel=new ImageErrorModel();
                string ImagePath = UploadImage(addBrandViewModel.DefaultImage, ref imageErrorModel);
                if (imageErrorModel.isSuccess)
                {
                    Brand brand = new Brand()
                    {
                        Name = addBrandViewModel.Name,
                        DefaultImage = ImagePath,
                        Description = addBrandViewModel.Description

                    };
                    await BrandBLL.Add(brand);
                    return RedirectToAction("Index");
                }
            }
            return View();

        }


        public async Task<IActionResult> EditBrand(string id)
        {
          
            Brand objbrand = await this.BrandBLL.Find(id);
            ViewModels.PM.Brand.EditBrandViewModel editViewBrandModel = new ViewModels.PM.Brand.EditBrandViewModel
            {
                ID=objbrand.ID,
                Name = objbrand.Name,
                Description = objbrand.Description,
                OldImage=objbrand.DefaultImage

            };
            return View(editViewBrandModel);
        }
        [HttpPost]
        public async Task<IActionResult> EditBrand(ViewModels.PM.Brand.EditBrandViewModel editBrand)
        {
            ImageErrorModel imageErrorModel = new ImageErrorModel();
            string ImagePath=null;
            if (editBrand.DefaultImage == null)
            {
                ImagePath = editBrand.OldImage;
            }
            else
            {
                ImagePath = UploadImage(editBrand.DefaultImage, ref imageErrorModel);
            }
            if (ModelState.IsValid)
            {          
                    Brand objbrand = await this.BrandBLL.Find(editBrand.ID);
                    objbrand.Description = editBrand.Description;
                    objbrand.Name = editBrand.Name;
                    objbrand.DefaultImage = ImagePath;
                    await BrandBLL.Update(objbrand);
                    return RedirectToAction("Index");
                

            }
            return View(editBrand);
        }
        [HttpDelete("{id}")]
        public  async Task<JsonResult> Delete(string id)
        {
            var isDelete = await BrandBLL.Delete(id);
            if (isDelete) 
            {
                return Json(new { success = "true"});

            }
            return Json(new { success = "false" });
        }
        //public async Task<IActionResult> DeleteBrand(string id)
        //{
        //    //chưa xử lý code
        //    Brand obj = await BrandBLL.Find(id);
        //    await BrandBLL.Delete(id);
        //    return View(obj);
        //}
    }
}