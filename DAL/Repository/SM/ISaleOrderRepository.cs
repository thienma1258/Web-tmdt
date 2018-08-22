using DAL.Model.SM;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DAL.Repository.SM
{
    public interface ISaleOrderRepository : IGenericRepository<SaleOrder, string>
    {
        SaleOrder Find(Expression<Func<SaleOrder, bool>> filter = null);
    }
}
