using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using BLL;
using BLL.BLL.PM;
using DAL.Model.PM;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Services;
using Services.ImageServices;

namespace Aoo.Controllers.Admin.PM
{
    [Route("[controller]/[action]")]
    [Area("PM")]
    [Authorize]
    public class StoreController : BaseController
    {
        private readonly IStoreBLL StoreBLL;
        
        public StoreController(IStoreBLL storeBLL, IImageServices imageServices ) : base(imageServices)
        {
            StoreBLL = storeBLL;
           
        }

        public async Task<IActionResult> Index(int page = 1)
        {
            ViewBag.currentPage = page;
            int totalcout = StoreBLL.Cout();
            ViewBag.totalPage = TotalPage(totalcout);
            var ListStore = await StoreBLL.Get(numberPerPage, page);
            //var ListBrandFilter = await BrandBLL.Get(filter: p => p.Name.Contains());
            return View(ListStore);
        }
        public async Task<IActionResult> AddStore()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddStore(ViewModels.PM.Store.AddViewStoreModel addViewStoreModel)
        {
            if (ModelState.IsValid)
            {
               
                ImageErrorModel imageErrorModel = new ImageErrorModel();
                string ImagePath = UploadImage(addViewStoreModel.DefaultImage, ref imageErrorModel);
                if (imageErrorModel.isSuccess)
                {
                    Store store = new Store()
                    {
                        Address = addViewStoreModel.Address,
                        NameStore = addViewStoreModel.NameStore,
                        DefaultImage = ImagePath,
                        Description = addViewStoreModel.Description

                    };
                    await StoreBLL.Add(store);
                    return RedirectToAction("Index");
                }
            }

            return View();

        }
        public async Task<IActionResult> EditStore(string id)
        {
            Store objStore = await this.StoreBLL.Find(id);
            ViewModels.PM.Store.EditViewStoreModel editViewStoreModel = new ViewModels.PM.Store.EditViewStoreModel
            {
                Address = objStore.Address,
                ID=objStore.ID,
                NameStore=objStore.NameStore,
                Description=objStore.Description,
                DefaultImageString = objStore.DefaultImage
            };
            return View(editViewStoreModel);
        }
        [HttpPost]
        public async Task<IActionResult> EditStore(ViewModels.PM.Store.EditViewStoreModel editViewStoreModel)
        {
            if (ModelState.IsValid)
            {

                ImageErrorModel imageErrorModel = new ImageErrorModel();
                string ImagePath = UploadImage(editViewStoreModel.DefaultImage, ref imageErrorModel);
                if (imageErrorModel.isSuccess)
                {
                    Store objStore = await this.StoreBLL.Find(editViewStoreModel.ID);
                    objStore.Address = editViewStoreModel.Address;
                    objStore.Description = editViewStoreModel.Description;
                    objStore.NameStore = editViewStoreModel.NameStore;
                    objStore.DefaultImage = ImagePath;
                    await StoreBLL.Update(objStore);
                    return RedirectToAction("Index");
                }
            }

            return View();
        }
        [HttpDelete("{id}")]
        public async Task<JsonResult> Delete(string id)
        {
            var isDelete = await StoreBLL.Delete(id);
            if (isDelete)
            {
                return Json(new { success = "true" });

            }
            return Json(new { success = "false" });
        }

    }
}