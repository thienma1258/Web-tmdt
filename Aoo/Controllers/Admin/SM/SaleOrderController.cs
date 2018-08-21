using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL.BLL.CM;
using BLL.BLL.SM;
using BLL.BLL.SM.Implement;
using DAL.Model.CM;
using DAL.Model.SM;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Aoo.Controllers.Admin.SM
{
    [Area("SM")]
    public class SaleOrderController : BaseController
    {
        ISaleOrderBLL ISaleOrderBLL;
        ISaleOrderDetailsBLL ISaleOrderDetailsBLL;
        ICustomerBLL ICustomerBLL;
        public SaleOrderController(ISaleOrderBLL SaleOrderBLL, ISaleOrderDetailsBLL SaleOrderDetailsBLL,ICustomerBLL CustomerBLL)
        {
            this.ISaleOrderDetailsBLL = SaleOrderDetailsBLL;
            this.ISaleOrderBLL = SaleOrderBLL;
            this.ISaleOrderDetailsBLL = SaleOrderDetailsBLL;
            this.ICustomerBLL = CustomerBLL;
        }
        [Route("don-hang")]
        public async  Task<IActionResult> Index(DateTime FromDate,DateTime ToDate,int page = 1, string Search = null,string StateSaleOrder=null)
        {
            IEnumerable<SaleOrder> listSaleOrder = null;
            if (FromDate != DateTime.MinValue && ToDate != DateTime.MinValue)
            {
                if (FromDate.Date < ToDate.Date)
                {
                    ModelState.AddModelError("A1", "Định dạng ngày không chính xác");
                    return View(null);
                }
                listSaleOrder = await this.ISaleOrderBLL.Get(numberPerPage, page, p => (Search ==null||( p.Customer.CustomerName.Contains(Search) || p.ReviewBy == Search ||(StateSaleOrder == null|| p.State.ToString() == StateSaleOrder)) && (p.ReviewDate.Date < FromDate.Date && p.ReviewDate.Date > ToDate.Date)));
                ViewBag.currentPage = page;
                ViewBag.totalPage = ISaleOrderBLL.Cout(p => (p.Customer.CustomerName.Contains(Search) || p.ReviewBy == Search || p.State.ToString() == StateSaleOrder) && (p.ReviewDate.Date < FromDate.Date && p.ReviewDate.Date > ToDate.Date));

            }
            else
            {
                listSaleOrder = await this.ISaleOrderBLL.Get(currentPage: page, intNumber: numberPerPage,filter: p =>Search==null||( p.Customer.CustomerName.Contains(Search) || p.ReviewBy == Search || (StateSaleOrder == null || p.State.ToString() == StateSaleOrder)));
                ViewBag.currentPage = page;
                ViewBag.totalPage = ISaleOrderBLL.Cout(p => Search == null || (p.Customer.CustomerName.Contains(Search) || p.ReviewBy == Search || (StateSaleOrder == null || p.State.ToString() == StateSaleOrder)));
            }
           var list=await ISaleOrderDetailsBLL.Get();
            return View(listSaleOrder);
        }
        public async Task<JsonResult> ConfirmSaleOrder(string strSaleOrderID)
        {
            SaleOrder objSaleOrder = await this.ISaleOrderBLL.Find(strSaleOrderID);
            if (objSaleOrder == null)
            {
                return Json(new { success = false, message = "Không tìm thấy đơn hàng" });
            }
            var ConfirmOrder = await this.ISaleOrderBLL.ConfirmSaleOrder(objSaleOrder, HttpContext.User.Identity.Name);
            if(ConfirmOrder)
                return Json(new { success = true, message = "Xac nhan don hang thang cong" });
                return Json(new { success = false, message = "Xac nhan don hang khong thanh cong vui long thu lai sau" });
        }
        public async Task<ActionResult> CreateBill(string SaleOrderID)
        {
            SaleOrder CurrentSale = await ISaleOrderBLL.Find(SaleOrderID);
            var ListCurrentDetails = await ISaleOrderDetailsBLL.Get(filter: p => p.SaleOrderID == SaleOrderID);
            return View(ListCurrentDetails);
        } 
    }
}