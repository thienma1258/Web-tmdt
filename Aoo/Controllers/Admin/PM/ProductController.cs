using System;
using System.Collections.Generic;
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
    public class ProductController : BaseController
    {
        private readonly IProductBLL ProductBLL;
        private readonly IGenericBLL<Brand, string> BrandBLL;
        private readonly ICategoryBLL CategorytBLL;
        private readonly IMainGroupBLL MainGroupBLL;
        private readonly ISubGroupBLL SubGroupBLL;
        public ProductController(IProductBLL productBLL, ISubGroupBLL subGrouptBLL, IMainGroupBLL mainGroupBL, IBrandBLL brandBLL,ICategoryBLL  categoryBLL, IImageServices imageServices) : base(imageServices)
        {
            ProductBLL = productBLL;
            this.MainGroupBLL = mainGroupBL;
            this.BrandBLL = brandBLL;
            this.CategorytBLL = categoryBLL;
            this.SubGroupBLL = subGrouptBLL;
        }

        public async Task<IActionResult> Index()
        {
            return View();
        }
        public async Task<IActionResult> AddProduct()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddProduct(ViewModels.PM.AddProductViewModel addProductViewModel)
        {

            if (ModelState.IsValid)
            {
                ImageErrorModel imageErrorModel = new ImageErrorModel();
                string ImagePath = UploadImage(addProductViewModel.DefaultImage, ref imageErrorModel);
                if (imageErrorModel.isSuccess)
                {
                    Product product = new Product()
                    {
                        Model = addProductViewModel.Model,
                        DefaultImage = ImagePath,
                        isOnlineOnly = addProductViewModel.isOnlineOnly,
                        StockMin = addProductViewModel.StockMin,
                        Details=addProductViewModel.Details
                        //LadingPage = addProductViewModel.LadingPage,


                    };
                    product.Brand = await BrandBLL.Find(addProductViewModel.Brand);
                    product.Category = await CategorytBLL.Find(addProductViewModel.Category);
                    product.MainGroup = await MainGroupBLL.Find(addProductViewModel.MainGroup);
                    product.SubGroup = await SubGroupBLL.Find(addProductViewModel.SubGroup);
                    await  ProductBLL.Add(product);
                    return RedirectToAction("Index");
                }
            }
            return View();
        }
    }
}