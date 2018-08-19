using DAL.Model.SM;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BLL.SM
{
    public interface ISaleOrderBLL
    {
        Task<bool> ConfirmSaleOrder(SaleOrder objSaleOrder, string ReviewUser);
        Task<bool> SuccessOrder(SaleOrder objSaleOrder, string ReviewUser);
        Task<bool> CreateSaleOrder(SaleOrder objSaleOrder, List<SaleOrderDetail> saleOrderDetails, string CreateUser);
    }
}
