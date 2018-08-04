using DAL.Model.SM;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BLL.SM
{
    public interface ISaleOrderBLL
    {
        Task<IEnumerable<SaleOrder>> Get(int intNumber = -1, int intSkippage = -1);
        Task<bool> Update(SaleOrder saleOrder, string UpdatedUser = "adminstrator");
        Task<bool> Delete(string saleOrderID, string DeletedUser = "adminstrator");
        Task<bool> Add(SaleOrder saleOrder, string CreatedUser = "adminstrator");
        Task<SaleOrder> Find(string saleOrderID);
    }
}
