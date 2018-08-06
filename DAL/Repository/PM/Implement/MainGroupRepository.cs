using DAL.DataContext;
using DAL.Model.PM;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repository.PM.Implement
{
    public class MainGroupRepository :SeoRepository<MainGroup>, IMainGroupRepository
    {
        public MainGroupRepository(ShopContext context) : base(context)
        {
        }
        
    }
}
