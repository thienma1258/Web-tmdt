using DAL.DataContext;
using DAL.Model.PM;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repository.PM.Implement
{
    public class SubGroupRepository : SeoRepository<SubGroup>, ISubGroupRepository
    {
        public SubGroupRepository(ShopContext context) : base(context)
        {
        }
        
    }
}
