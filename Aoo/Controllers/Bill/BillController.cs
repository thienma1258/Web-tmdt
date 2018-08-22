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
using BLL.ServicesGatewayBLL;
using DAL.Model.CM;
using DAL.Model.SM;
using Microsoft.AspNetCore.Mvc;
using Services.Logging;

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
        private readonly IPaypalServicesGatewayBLL _paypalServicesGatewayBLL;
        public BillController(IProductDetailsBLL productDetailsBLL,ISaleOrderBLL saleOrderBLL,ICustomerBLL customerBLL,ITransportPriceBLL transportPriceBLL,ITransportTypeBLL transportTypeBLL, IPaypalServicesGatewayBLL paypalServicesGatewayBLL)
        {
            this.TransportPriceBLL = transportPriceBLL;
            this.TransportTypeBLL = transportTypeBLL;
            this.SaleOrderBLL = saleOrderBLL;
            this.CustomerBLL = customerBLL;
            this.ProductDetailsBLL = productDetailsBLL;
            this._paypalServicesGatewayBLL = paypalServicesGatewayBLL;
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
        public async Task<JsonResult> ExcutePayment(PayPal.v1.Payments.Payment  payment)
        {
            Logging logging = new Logging();
            logging.ErrorLogs(payment.ToString());

            return Json(payment);
        }
        public async  Task<JsonResult> ErrorBill(PayPal.v1.Payments.Payment payment)
        {
            Logging logging = new Logging();
            logging.ErrorLogs(payment.ToString());

            return Json(payment);
        }
        private async Task<decimal> GetTransportPrice(string TransportPriceId,string TransportTypeId)
        {
            if (!string.IsNullOrEmpty(TransportPriceId))
            {
                if (string.IsNullOrEmpty(TransportTypeId))
                    return -1;
                else
                {
                   var objTransportType=  await  this.TransportTypeBLL.Find(TransportTypeId);
                   
                    return objTransportType.Price;
                }
            }
            else
            {
                var objTransportPrice = await this.TransportPriceBLL.Find(TransportPriceId);
                return objTransportPrice.Price;
            }
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
            #region validateSaleOrder
            SaleOrder CurrentSaleOrder = new SaleOrder()
            {
                ReceiveAddress = ListFullParam.saleOrder.ReceiveAddress,
                TotalPrice = ListFullParam.saleOrder.TotalPrice,
                PaymentMethod = (Common.Enum.SM.PaymentMethod)ListFullParam.saleOrder.PaymentMethod,
                DistrictID=ListFullParam.saleOrder.DistrictID,
                TransportPriceID=ListFullParam.saleOrder.TransportTypeID,
            };
            CurrentSaleOrder.TransportTypePrice = await GetTransportPrice(ListFullParam.saleOrder.TransportPriceID, ListFullParam.saleOrder.TransportTypeID);
            if (CurrentSaleOrder.TransportTypePrice == -1)
            {
                return Json(new ResponseMessage { Message ="Vui long chon nha van chuyen ",IsSuccess=false});

            }
            #endregion
            List<SaleOrderDetail> CurrentSaleDetails = new List<SaleOrderDetail>();
          
            foreach(var item in ListFullParam.saleOrderDetails)
            {
                var productDetails = await ProductDetailsBLL.Find(item.ProductDetailIDSale);
                SaleOrderDetail temp = new SaleOrderDetail()
                {
                    ProductDetailId=item.ProductDetailIDSale,
                    Quality=item.QuantitySale,
                    ProductDetail= productDetails


                };
                CurrentSaleDetails.Add(temp);
            }
            var isSuccess=await  SaleOrderBLL.CreateBill(CurrentCustomer, CurrentSaleOrder, CurrentSaleDetails);
            if (isSuccess)
            {
                if (CurrentSaleOrder.PaymentMethod == Common.Enum.SM.PaymentMethod.Paypal)
                {

                  string BaseUrl = string.Format("{0}://{1}", HttpContext.Request.Scheme, HttpContext.Request.Host);
                  string SuccessUrl= BaseUrl+ Url.Action("ExcutePayment", "Bill");
                  string ErrorUrl = BaseUrl+ Url.Action("ErrorBill", "Bill");
                  var payment=await this._paypalServicesGatewayBLL.CreatePayment(SuccessUrl, ErrorUrl,CurrentSaleOrder , CurrentSaleDetails, CurrentCustomer);
                  CurrentSaleOrder.AuthenticationMethodGuid = payment.Id;
                  await  this.SaleOrderBLL.Update(CurrentSaleOrder);
                   return Json(new ResponseMessage { Message = SaleOrderBLL.Message, IsSuccess = isSuccess, errorSaleOrder = SaleOrderBLL.enumErrorSaleOrder,RedirectoURl=payment.Links[1].Href });


                }
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
    public string RedirectoURl { get; set; } = string.Empty;
    public ErrorSaleOrder errorSaleOrder { get; set; }
}
