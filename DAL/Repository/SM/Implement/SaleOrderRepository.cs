using DAL.DataContext;
using DAL.Model.SM;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DAL.Repository.SM.Implement
{
    public class SaleOrderRepository : TrackingObjectRepository<SaleOrder>, ISaleOrderRepository
    {
        public SaleOrderRepository(ShopContext context) : base(context)
        {
        }
        public  SaleOrder Find(Expression<Func<SaleOrder, bool>> filter = null)
        {
            return dbSet.FirstOrDefault(filter);
        }
        //public override IEnumerable<SaleOrder> Get(Expression<Func<SaleOrder, bool>> filter = null, Func<IQueryable<SaleOrder>, IOrderedQueryable<SaleOrder>> orderBy = null, int currentPage = -1, int number = -1)
        //{
        //    var query = filterObject(filter, currentPage, number);
        //    query = query.Include(p => p.Customer);
        //    if (orderBy != null)
        //    {
        //        var listSaleOrder = orderBy(query).ToList();
        //        return listSaleOrder;
        //    }
        //    else
        //    {
        //        return query.ToList(); ;
        //    }
        //}
    }
}
