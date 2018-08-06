using DAL.DataContext;
using DAL.Model.PM;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repository.PM.Implement
{
    public class StoreRepository : SeoRepository<Store>, IStoreRepository
    {
        public StoreRepository(ShopContext context) : base(context)
        {
            
        }
       
    }
}
