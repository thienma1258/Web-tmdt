using DAL.Model.SM;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BLL.SM
{
    public interface ISaleOrderBLL:IGenericBLL<SaleOrder,string>
    {
        Task<bool> ConfirmSaleOrder(SaleOrder objSaleOrder, string ReviewUser);
        Task<bool> SuccessOrder(SaleOrder objSaleOrder, string ReviewUser);
        Task<bool> CreateBill(SaleOrder objSaleOrder, List<SaleOrderDetail> saleOrderDetails, string CreateUser);
    }
}
