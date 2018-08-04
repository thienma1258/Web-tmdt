using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using BLL;
using BLL.BLL.PM;
using DAL.Model.PM;
using Microsoft.AspNetCore.Mvc;
using Services;
using Services.ImageServices;

namespace Aoo.Controllers.Admin.PM
{
    [Route("[controller]/[action]")]
    [Area("PM")]
    public class StoreController : Controller
    {
        private readonly IGenericBLL<Store,string> StoreBLL;
        public readonly IImageServices ImageServices;
        public StoreController(IGenericBLL<Store, string> storeBLL, IImageServices imageServices )
        {
            StoreBLL = storeBLL;
            this.ImageServices = imageServices;
        }

        public async Task<IActionResult> Index()
        {
          
            return View(await StoreBLL.Get(6));
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
                ImageErrorModel imageErrorModel;
                MemoryStream memoryStream = new MemoryStream();
                await addViewStoreModel.DefaultImage.CopyToAsync(memoryStream);
                string ImagePath = this.ImageServices.UploadImage(memoryStream, addViewStoreModel.DefaultImage.FileName, out imageErrorModel);
                if (imageErrorModel.isSuccess)
                {
                    Store store = new Store()
                    {
                        NameStore = addViewStoreModel.NameStore,
                        DefaultImage = ImagePath,
                        Description = addViewStoreModel.Description

                    };
                    await StoreBLL.Add(store);
                }
            }

            return View();

        }
        public async Task<IActionResult> EditStore(string id)
        {
            Store objStore = await this.StoreBLL.Find(id);
            ViewModels.PM.Store.EditViewStoreModel editViewStoreModel=new ViewModels.PM.Store.EditViewStoreModel
            {
                ID=objStore.ID,
                NameStore=objStore.NameStore,
                Description=objStore.Description,

            };
            return View(editViewStoreModel);
        }
        [HttpPost]
        public async Task<IActionResult> EditStore(ViewModels.PM.Store.EditViewStoreModel editViewStoreModel)
        {
            if (ModelState.IsValid)
            {
               
                ImageErrorModel imageErrorModel;
                MemoryStream memoryStream = new MemoryStream();
                await editViewStoreModel.DefaultImage.CopyToAsync(memoryStream);
                string ImagePath = this.ImageServices.UploadImage(memoryStream, editViewStoreModel.DefaultImage.FileName, out imageErrorModel);
                if (imageErrorModel.isSuccess)
                {
                    Store objStore = await this.StoreBLL.Find(editViewStoreModel.ID);
                    objStore.Description = editViewStoreModel.Description;
                    objStore.NameStore = editViewStoreModel.NameStore;
                    objStore.DefaultImage = ImagePath;
                    await StoreBLL.Update(objStore);
                }
            }

            return View();
        }
            public IActionResult DeleteStore()
        {
            return View();
        }
       
    }
}