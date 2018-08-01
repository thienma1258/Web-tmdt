using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using DAL.DataContext;
using DAL.Model.PM;

namespace DAL.Repository.PM
{
    public class DistrictRepository : IDistrictRepository
    {
        public readonly ShopContext shopContext;
        public DistrictRepository(DataContext.ShopContext shopContext)
        {
            this.shopContext = shopContext;
        }
        public bool Delete(District entity)
        {
            return false;
        }

        public District Find(string ID)
        {
            return this.shopContext.Districts.Find(ID);
        }

        public IEnumerable<District> Get(Expression<Func<District, bool>> filter = null, Func<IQueryable<District>, IOrderedQueryable<District>> orderBy = null, int number = 0,int skippage = 0)
        {
           var IQuery= this.shopContext.Districts.Where(filter);
            if (skippage != 0)
            {
                IQuery.Skip(skippage * number);
            }
            if (number != 0)
            {
                IQuery.Take( number);
            }
            if (orderBy != null)
            {
                return orderBy(IQuery).ToList();
            }
            return IQuery.ToList();
           
        }

        public bool Insert(District entity)
        {
            return false;
        }

        public bool Update(District entity)
        {
            return false;
        }
    }
}
