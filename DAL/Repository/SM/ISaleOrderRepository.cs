using DAL.Model.SM;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repository.SM
{
    public interface ISaleOrderRepository : IGenericRepository<SaleOrder, string>
    {
    }
}
