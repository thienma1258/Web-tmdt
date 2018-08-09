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
    public class TransportPriceRepository :TrackingObjectRepository<TransportPrice>, ITransportPriceRepository
    {
        public TransportPriceRepository(ShopContext context) : base(context)
        {
        }
        public override IEnumerable<TransportPrice> Get(Expression<Func<TransportPrice, bool>> filter = null, Func<IQueryable<TransportPrice>, IOrderedQueryable<TransportPrice>> orderBy = null, int currentPage = -1, int number = -1)
        {
            IQueryable<TransportPrice> query = dbSet;
            query = query.Where(p => p.isDeleted == false);
            if (filter != null)
            {
                query = query.Where(filter);
            }

           return query.Include(p => p.District).Include(p=>p.District.Province).ToList();
        }

    }
}
