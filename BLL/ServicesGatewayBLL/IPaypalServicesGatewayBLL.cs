using DAL.Model.CM;
using DAL.Model.SM;
using PayPal.v1.Payments;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BLL.ServicesGatewayBLL
{
    public interface IPaypalServicesGatewayBLL
    {
        Task<Payment> CreatePayment(string SuccessURl, string ErrorUrl, SaleOrder saleOrder, List<SaleOrderDetail> listSaleOrderDetails, CM_Customer _Customer);
        Task<bool> ExcutePayment(Payment payment);
    }
}
