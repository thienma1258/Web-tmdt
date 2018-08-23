using DAL;
using DAL.Model.CM;
using DAL.Model.SM;
using PayPal.v1.Payments;
using Services.Logging;
using Services.PaypalServices;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Threading.Tasks;

namespace BLL.ServicesGatewayBLL
{
    public class PaypalServicesGatewayBLL : GenericBLL, IPaypalServicesGatewayBLL
    {
        public decimal currencyExchange = 23000.00M;
        IPaypalServices _paypalServices;
        public PaypalServicesGatewayBLL(IPaypalServices paypalServices, IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            this._paypalServices = paypalServices;
        }



        public async Task<Payment> CreatePayment(string SuccessURl, string ErrorUrl, SaleOrder saleOrder, List<SaleOrderDetail> listSaleOrderDetails, CM_Customer _Customer)
        {
            try
            {
                Amount amount = new Amount
                {
                    Currency = "USD",
                    Total = FormatCurrencyUSDToPayPal(ExchangeMoneyCurrency(saleOrder.TotalPrice)),
                    Details = new AmountDetails
                    {
                      
                        Subtotal = FormatCurrencyUSDToPayPal(ExchangeMoneyCurrency(saleOrder.TotalPrice) -ExchangeMoneyCurrency( saleOrder.TransportTypePrice)),
                        Shipping = FormatCurrencyUSDToPayPal(ExchangeMoneyCurrency(saleOrder.TransportTypePrice)),
                        Tax= "0.00",
                        HandlingFee="0.00",
                        Insurance="0.00",
                        ShippingDiscount="0.00"
                       
                        
                    }
                };
                List<Item> listItem = new List<Item>();
                foreach (var detail in listSaleOrderDetails)
                {
                    Item item = new Item
                    {
                        Currency = "USD",
                        Price = FormatCurrencyUSDToPayPal(ExchangeMoneyCurrency(detail.ProductDetail.Product.Price)),
                        Quantity = detail.Quality.ToString(),
                        Name = detail.ProductDetail.Product.Model,
                    };
                    listItem.Add(item);
                }
                ItemList itemList = new ItemList
                {

                    Items = listItem

                };
                Transaction transaction = new Transaction
                {
                    Amount = amount,
                    Description = "Phi tien cho Shop BMT",
                    ItemList = itemList,
                   
                    NoteToPayee = "Goi dien cho 0937019527 cho moi cau hoi",

                };
                return await this._paypalServices.CreatePayment(SuccessURl, ErrorUrl, transaction);
            }
            catch(Exception objEx)
            {
                Exception exception = new Exception(objEx.Message + "loi goi paypal o sale" + saleOrder.ID);

                await AddError(exception);

                return null;
            }

        }

        public async Task<bool> ExcutePayment(string paymentId,string payerID)
        {
            try
            {
                 
                 PaymentExecution paymentExecution = new PaymentExecution
                    {

                        
                        PayerId=payerID


                    };

                    var paymentrespond = await this._paypalServices.ExecutePayment(paymentExecution,paymentId);
                    if (paymentrespond.State == "approved")
                    {
                        return true;
                    }
                
                return false;
            }
            catch(Exception objEx)
            {
                Logging logging = new Logging();
                logging.ErrorLogs(objEx.ToString());
                return false;
            }
        }
        private decimal ExchangeMoneyCurrency(decimal VNDMoney)
        {
            return (System.Math.Round(VNDMoney / currencyExchange * 100) / 100);
        }
        private string FormatCurrencyUSDToPayPal(decimal Money)
        {
            CultureInfo USDCulture = new CultureInfo("en-US");
           
            //  Money = ExchangeMoneyCurrency(Money);
            string stringMoney = Money.ToString("N", USDCulture);
            return stringMoney;
        }
    }
}