using DAL.DataContext;
using DAL.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Linq.Expressions;
namespace DAL.Repository
{
    public class SeoRepository<T> : TrackingObjectRepository<T>,ISeoRepository<T> where T : SeoObject
    {
        public SeoRepository(ShopContext context) : base(context)
        {
        }

        public T SearchByUrl(string url)
        {
            return dbSet.FirstOrDefault(p => p.UrlFriendly == url);
        }
    }
}
