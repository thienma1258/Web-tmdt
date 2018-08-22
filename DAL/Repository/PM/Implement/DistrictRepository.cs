using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using DAL.DataContext;
using DAL.Model.PM;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.PM
{
    public class DistrictRepository :GenericRepository<District,string>, IDistrictRepository
    {
        public DistrictRepository(ShopContext shopContext) : base(shopContext)
        {

        }
      

        public override District Find(string ID)
        {
            return this.shopContext.Districts.Find(ID);
        }

        public override IEnumerable<District> Get(Expression<Func<District, bool>> filter = null, Func<IQueryable<District>, IOrderedQueryable<District>> orderBy = null, int skippage = -1, int number = -1, string includeProperties = null)
        {

            var IQuery = this.shopContext.Districts
             .Include(p => p.Province);
            if (skippage != -1)
            {
                IQuery.Skip(skippage * number);
            }
            if (number != -1)
            {
                IQuery.Take( number);
            }
            if (orderBy != null)
            {
                return orderBy(IQuery).ToList();
            }
            return IQuery.ToList();
           
        }

  

        public override void Insert(District entity)
        {
            return ;
        }

        public override void Update(District entity)
        {
            return ;
        }

       
    }
}
