using DAL.DataContext;
using DAL.Model.PM;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DAL.Repository.PM.Implement
{
    public class ProvinceRepository : GenericRepository<Province, string>, IProvinceRepository
    {
        public ProvinceRepository(ShopContext context) : base(context)
        {
        }
        public override IEnumerable<Province> Get(Expression<Func<Province, bool>> filter = null, Func<IQueryable<Province>, IOrderedQueryable<Province>> orderBy = null, int skippage = -1, int number = -1)
        {

            var IQuery = this.shopContext.Provinces
                 .Include(p => p.Districts);
            if (skippage != -1)
            {
                IQuery.Skip(skippage * number);
            }
            if (number != -1)
            {
                IQuery.Take(number);
            }
            if (orderBy != null)
            {
                return orderBy(IQuery).ToList();
            }
            return IQuery.ToList();

        }
    }
}
