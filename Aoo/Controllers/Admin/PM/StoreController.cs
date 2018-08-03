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
        public IActionResult EditStore()
        {
            return View();
        }
        public IActionResult DeleteStore()
        {
            return View();
        }
    }
}