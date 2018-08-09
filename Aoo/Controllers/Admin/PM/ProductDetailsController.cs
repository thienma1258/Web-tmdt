using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL.BLL.PM;
using DAL.Model.PM;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services;
using Services.ImageServices;

namespace Aoo.Controllers.Admin.PM
{
    [Route("[controller]/[action]")]
    [Area("PM")]
    
    public class ProductDetailsController : BaseController
    {
        private readonly IProductBLL ProductBLL;
        private readonly IProductDetailsBLL ProductDetailsBLL;

        public async Task<IActionResult> Index()
        {
            var list = await ProductDetailsBLL.Get();
            return View(list);
        }
        public ProductDetailsController(IProductBLL productBLL, IProductDetailsBLL productDetailsBLL, IImageServices imageServices) : base(imageServices)
        {
            ProductDetailsBLL = productDetailsBLL;
            this.ProductBLL = productBLL;

        }
        public async Task<IActionResult> AddProductDetails()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddProductDetails(Aoo.ViewModels.PM.ProductDetails.AddProductDetailsViewModel addProductDetailsViewModel)
        {
            List<ImageErrorModel> imageErrorModels = new List<ImageErrorModel>();
            List<string> ListImagePath = UploadListImage(addProductDetailsViewModel.ListDefaultImage, ref imageErrorModels);
            ProductDetails productDetails = new ProductDetails()
            {
                TypeColor=addProductDetailsViewModel.TypeColor,
                Size=addProductDetailsViewModel.Size,
                Specification=addProductDetailsViewModel.Specification,
                Note=addProductDetailsViewModel.Note,
                Price=addProductDetailsViewModel.Price,
                Quantity=addProductDetailsViewModel.Quantity,
                MaxQuantityBuy=addProductDetailsViewModel.MaxQuantityBuy
            };
            Product product = await ProductBLL.Find(addProductDetailsViewModel.Product);
            productDetails.Product = product;
            productDetails.StockMin = product.StockMin;
            productDetails.ListImages = ListImagePath;
            await ProductDetailsBLL.Add(productDetails);
            //chua kiem tra issuccess
            return RedirectToAction("Index");
        }
        public async Task<ActionResult> Details(string id)
        {
            var result = await ProductDetailsBLL.Get(filter:p=>p.ID==id);
            return View(result);
        }
    }
}