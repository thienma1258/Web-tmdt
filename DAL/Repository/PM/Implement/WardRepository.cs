using DAL.DataContext;
using DAL.Model.PM;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repository.PM.Implement
{
    public class WardRepository : GenericRepository<Ward, string>, IWardRepository
    {
        public WardRepository(ShopContext context) : base(context)
        {
        }
       
    }
}
