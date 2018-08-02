using DAL.DataContext;
using DAL.Model.SM;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repository.SM.Implement
{
    public class SaleOrderDetailsRepository : GenericRepository<SaleOrderDetail, string>, ISaleOrderDetailsRepository
    {
        public SaleOrderDetailsRepository(ShopContext context) : base(context)
        {
        }
    }
}
