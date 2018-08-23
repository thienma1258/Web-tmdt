using BLL.BLL.SM.Implement;
using DAL.Model.CM;
using DAL.Model.SM;
using PayPal.v1.Payments;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BLL.SM
{
    public interface ISaleOrderBLL:IGenericBLL<SaleOrder,string>
    {
         string Message { get; }
         Task<CM_Customer> FindUserByCMND(string CMND);
         ErrorSaleOrder enumErrorSaleOrder { get; set; }
        Task<bool> ExcutePayment(string paymentid,string payerID);
        Task<bool> ConfirmSaleOrder(SaleOrder objSaleOrder, string ReviewUser);
        Task<bool> SuccessOrder(SaleOrder objSaleOrder, string ReviewUser);
        Task<bool> ConfirmCode(CM_Customer objCustomer, string Code);
        Task<bool> CreateBill(CM_Customer objCustomer,SaleOrder objSaleOrder, List<SaleOrderDetail> saleOrderDetails);
    }
}
