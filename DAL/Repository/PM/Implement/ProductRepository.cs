using DAL.DataContext;
using DAL.Model.PM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace DAL.Repository.PM.Implement
{
    public class ProductRepository :SeoRepository<Product>, IProductRepository
    {
        public ProductRepository(ShopContext context) : base(context)
        {
        }
        public override IEnumerable<Product> Get(Expression<Func<Product, bool>> filter = null, Func<IQueryable<Product>, IOrderedQueryable<Product>> orderBy = null, int currentPage = -1, int number = -1)
        {
            var query = filterObject(filter, currentPage, number);
            query = query.Include(p => p.Brand).Include(p => p.SubGroup).Include(p => p.Category);
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
