using DAL.DataContext;
using DAL.Model.Log;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repository.Log.Implement
{
    public class SaleOrderLogsRepository : GenericRepository<SaleOrderLogs, string>,ISaleOrderLogsRepository
    {
        public SaleOrderLogsRepository(ShopContext context) : base(context)
        {
        }
    }
}
