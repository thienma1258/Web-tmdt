using DAL.DataContext;
using DAL.Model.PM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Microsoft.EntityFrameworkCore;
namespace DAL.Repository.PM.Implement
{
    public class ProductDetailsRepository :TrackingObjectRepository<ProductDetails>, IProductDetailsRepository
    {
        public ProductDetailsRepository(ShopContext context) : base(context)
        {
        }
        public override IEnumerable<ProductDetails> Get(Expression<Func<ProductDetails, bool>> filter = null, Func<IQueryable<ProductDetails>, IOrderedQueryable<ProductDetails>> orderBy = null, int currentPage = -1, int number = -1)
        {
            var query = filterObject(filter, currentPage, number);
            query = query.Include(p => p.Product);
            if (orderBy != null)
            {
                return orderBy(query).ToList();
            }
            else
            {
                return query.ToList(); ;
            }
        }


    }
}
