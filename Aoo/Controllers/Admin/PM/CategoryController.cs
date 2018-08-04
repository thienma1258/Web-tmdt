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
    public class CategoryController : Controller
    {
        private readonly IGenericBLL<Category, string> CategoryBLL;
        public readonly IImageServices ImageServices;
        public CategoryController(IGenericBLL<Category, string> categoryBLL, IImageServices imageServices)
        {
            CategoryBLL = categoryBLL;
            this.ImageServices = imageServices;
        }
        public async Task<IActionResult> Index()
        {
            return View(await CategoryBLL.Get(6));
        }

        public async Task<IActionResult> AddCategory()
        {
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> AddCategory(ViewModels.PM.Category.AddCategoryViewModel addCategoryViewModel)
        {
            if (ModelState.IsValid)
            {
                ImageErrorModel imageErrorModel;
                MemoryStream memoryStream = new MemoryStream();
                await addCategoryViewModel.DefaultImage.CopyToAsync(memoryStream);
                string ImagePath = this.ImageServices.UploadImage(memoryStream, addCategoryViewModel.DefaultImage.FileName, out imageErrorModel);
                if (imageErrorModel.isSuccess)
                {
                    Category category = new Category()
                    {
                        Name = addCategoryViewModel.Name,
                        DefaultImage = ImagePath,
                        Description = addCategoryViewModel.Description

                    };
                    await CategoryBLL.Add(category);
                    return RedirectToAction("Index");
                }
            }
            return View();

        }
        public async Task<IActionResult> EditCategory(string id)
        {
            //chưa xử lý code
            Category obj = await CategoryBLL.Find(id);
            return View(obj);
        }
        [HttpPost]
        public async Task<IActionResult> EditCategory(ViewModels.PM.Category.AddCategoryViewModel editCategoryViewModel)
        {
          
            return View();
        }
        public async Task<IActionResult> DeleteCategory(string id)
        {
            //chưa xử lý code
            Category obj = await CategoryBLL.Find(id);
            return View(obj);
        }
    }
}