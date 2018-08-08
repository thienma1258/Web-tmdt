using DAL.DataContext;
using DAL.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repository
{
    public class SeoRepository<T> : TrackingObjectRepository<T> where T : SeoObject
    {
        public SeoRepository(ShopContext context) : base(context)
        {
        }

    }
}
