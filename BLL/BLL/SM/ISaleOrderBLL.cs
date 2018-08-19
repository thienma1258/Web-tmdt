using BLL.BLL.SM.Implement;
using DAL.Model.CM;
using DAL.Model.SM;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BLL.SM
{
    public interface ISaleOrderBLL:IGenericBLL<SaleOrder,string>
    {
         string Message { get; }
         ErrorSaleOrder enumErrorSaleOrder { get; set; }
        Task<bool> ConfirmSaleOrder(SaleOrder objSaleOrder, string ReviewUser);
        Task<bool> SuccessOrder(SaleOrder objSaleOrder, string ReviewUser);
        Task<bool> CreateBill(CM_Customer objCustomer,SaleOrder objSaleOrder, List<SaleOrderDetail> saleOrderDetails, string CreateUser);
    }
}
