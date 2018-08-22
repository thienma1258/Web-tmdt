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
    public class SaleOrderDetailsRepository :TrackingObjectRepository<SaleOrderDetail>, ISaleOrderDetailsRepository
    {
        public SaleOrderDetailsRepository(ShopContext context) : base(context)
        {
        }
      
        //public override IEnumerable<SaleOrderDetail> Get(Expression<Func<SaleOrderDetail, bool>> filter = null, Func<IQueryable<SaleOrderDetail>, IOrderedQueryable<SaleOrderDetail>> orderBy = null, int currentPage = -1, int number = -1,string i)
        //{
        //    var query = filterObject(filter, currentPage, number);
        //    query = query.Include(p => p.SaleOrder);
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
