using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aoo.ViewModels.PM.TransportType;
using BLL.BLL.PM;
using BLL.BLL.PM.Implement;
using DAL.Model.PM;
using Microsoft.AspNetCore.Mvc;
using Services;

namespace Aoo.Controllers.Admin.PM
{
    [Route("[controller]/[action]")]
    [Area("PM")]
    public class TransportTypeController : BaseController
    {
        private ITransportTypeBLL TransportTypeBLL;
        private IDistrictBLL DistrictBLL;
        private ITransportPriceBLL TransportPriceBLL;
        public TransportTypeController(IDistrictBLL DistrictBLL,ITransportPriceBLL TransportPriceBLL,IImageServices imageServices, ITransportTypeBLL TransportTypeBLL) : base(imageServices)
        {
            this.TransportPriceBLL = TransportPriceBLL;
            this.TransportTypeBLL = TransportTypeBLL;
            this.DistrictBLL = DistrictBLL;
        }

        public async Task<IActionResult> Index(int page = 1)
        {
            
            return View(await this.TransportTypeBLL.Get());
        }
        public async Task<IActionResult> Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(ViewModels.PM.TransportType.AddTransportTypeViewModel AddTransportType)
        {
            if (ModelState.IsValid)
            {
                TransportType objTransportType = new TransportType
                {
                    Name = AddTransportType.Name,
                    Note = AddTransportType.Note,
                    Price = AddTransportType.Price
                };
                await TransportTypeBLL.Add(objTransportType);
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Edit(ViewModels.PM.TransportType.AddTransportTypeViewModel EditTransportType)
        {

            if (ModelState.IsValid)
            {
                TransportType objTransportType = await TransportTypeBLL.Find(EditTransportType.ID);

                objTransportType.Name = EditTransportType.Name;
                objTransportType.Note = EditTransportType.Note;
                objTransportType.Price = EditTransportType.Price;
                await TransportTypeBLL.Update(objTransportType);
                
                return RedirectToAction("Index");
            }
            return View(EditTransportType);
        }
        public async Task<IActionResult> Edit(string id)
        {

            TransportType objTransportType = await this.TransportTypeBLL.Find(id);
            ViewModels.PM.TransportType.AddTransportTypeViewModel EditTransportType = new ViewModels.PM.TransportType.AddTransportTypeViewModel
            {
                ID = objTransportType.ID,
                Name = objTransportType.Name,
                Note = objTransportType.Note,
                Price = objTransportType.Price,

            };
            return View(EditTransportType);
        }
        [HttpDelete("{id}")]
        public async Task<JsonResult> Delete(string id)
        {
            var isDelete = await TransportTypeBLL.Delete(id);
            if (isDelete)
            {
                return Json(new { success = "true" });

            }
            return Json(new { success = "false" });
        }
        [HttpDelete]
        public async Task<JsonResult> DeleteDetails(string id, string deleteTransportID)
        {
            var isDelete = await TransportPriceBLL.Delete(id);
            if (isDelete)
            {
                var listTransportPrice = await this.TransportPriceBLL.Get(filter: p => p.TransportTypeID == deleteTransportID);
                return Json(new { success = "true", data = listTransportPrice });
            }
            return Json(new { success = "false" });
        }
        [HttpPost]
        public async Task<JsonResult> AddDetails([FromBody]AddTransportTypePrice addTransportTypePrice)
        {
            TransportPrice transportPrice = new TransportPrice
            {
                DistrictID = addTransportTypePrice.DistrictID,
                TransportTypeID = addTransportTypePrice.IdTransport,
                Price = addTransportTypePrice.Price
            };
            bool bolInsertTransportPrice = await this.TransportPriceBLL.Add(transportPrice);
            if (bolInsertTransportPrice)
            {
                var listTransportPrice = await this.TransportPriceBLL.Get(filter: p => p.TransportTypeID ==addTransportTypePrice.IdTransport);
                return Json(new { success = "true" ,data=listTransportPrice});
            }
            return Json(new { success = "false" });
        }

        public async Task<JsonResult> Details(string Id)
        {
            var listTransportPrice = await this.TransportPriceBLL.Get(filter: p => p.TransportTypeID == Id);
            return Json(listTransportPrice);
        }
        public async Task<JsonResult> GetDistrict()
        {
            return Json(await this.DistrictBLL.Get());
        }
    }
}