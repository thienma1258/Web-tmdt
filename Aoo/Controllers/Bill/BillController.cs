using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aoo.ViewModels;
using Aoo.ViewModels.CM;
using Aoo.ViewModels.SM;
using BLL.BLL.CM;
using BLL.BLL.PM;
using BLL.BLL.PM.Implement;
using BLL.BLL.SM;
using BLL.BLL.SM.Implement;
using DAL.Model.CM;
using DAL.Model.SM;
using Microsoft.AspNetCore.Mvc;

namespace Aoo.Controllers.Bill
{
    [Route("[controller]/[action]")]
    public class BillController : BaseController
    {
        private readonly ISaleOrderBLL SaleOrderBLL;
        private readonly ITransportPriceBLL TransportPriceBLL;
        private readonly ITransportTypeBLL TransportTypeBLL;
        private readonly ICustomerBLL CustomerBLL;
        private readonly IProductDetailsBLL ProductDetailsBLL;
        public BillController(IProductDetailsBLL productDetailsBLL,ISaleOrderBLL saleOrderBLL,ICustomerBLL customerBLL,ITransportPriceBLL transportPriceBLL,ITransportTypeBLL transportTypeBLL)
        {
            this.TransportPriceBLL = transportPriceBLL;
            this.TransportTypeBLL = transportTypeBLL;
            this.SaleOrderBLL = saleOrderBLL;
            this.CustomerBLL = customerBLL;
            this.ProductDetailsBLL = productDetailsBLL;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Payment()
        {
            return View();
        }
        public async Task<IActionResult> InfoCustomer() {
            return View();
        }
        [HttpPost]
        public async Task<JsonResult> ConfirmCode([FromBody]getFullParamViewModel ListFullParam,string code)
        {
            CM_Customer customer = await this.SaleOrderBLL.FindUserByCMND(ListFullParam.Customer.CMND);
           bool isSuccess= await SaleOrderBLL.ConfirmCode(customer, code);
            return Json(new ResponseMessage { Message = SaleOrderBLL.Message, IsSuccess = isSuccess, errorSaleOrder = SaleOrderBLL.enumErrorSaleOrder });

        }
        [HttpPost]
        public async Task<JsonResult>GetFullParam([FromBody]getFullParamViewModel ListFullParam)
        {
            var i = 0;
            CM_Customer CurrentCustomer = new CM_Customer()
            {
                CustomerName = ListFullParam.Customer.Name,
                CustomerPhone=ListFullParam.Customer.Phone,
                CMND=ListFullParam.Customer.CMND,
                TypeCustomerEnum=Common.Enum.SM.TypeCustomerEnum.KVL
                
            };
            SaleOrder CurrentSaleOrder = new SaleOrder()
            {
                ReceiveAddress = ListFullParam.saleOrder.ReceiveAddress,
                TotalPrice = ListFullParam.saleOrder.TotalPrice,
                PaymentMethod = (Common.Enum.SM.PaymentMethod)ListFullParam.saleOrder.PaymentMethod,
                DistrictID=ListFullParam.saleOrder.DistrictID
            };
            List<SaleOrderDetail> CurrentSaleDetails = new List<SaleOrderDetail>();
          
            foreach(var item in ListFullParam.saleOrderDetails)
            {
                SaleOrderDetail temp = new SaleOrderDetail()
                {
                    ProductDetailId=item.ProductDetailIDSale,
                    Quality=item.QuantitySale

                };
                CurrentSaleDetails.Add(temp);
            }
            var isSuccess=await  SaleOrderBLL.CreateBill(CurrentCustomer, CurrentSaleOrder, CurrentSaleDetails);
            if (isSuccess)
            {
                return Json(new ResponseMessage { Message=SaleOrderBLL.Message,IsSuccess=isSuccess,errorSaleOrder=SaleOrderBLL.enumErrorSaleOrder });
            }
            else
            {
                return Json(new ResponseMessage { Message = SaleOrderBLL.Message, IsSuccess = isSuccess, errorSaleOrder = SaleOrderBLL.enumErrorSaleOrder });

            }
        }
       
    }
}
public class ResponseMessage
{
    public string Message { get; set; } = string.Empty;
    public bool IsSuccess { get; set; } =false;
    public ErrorSaleOrder errorSaleOrder { get; set; }
}
