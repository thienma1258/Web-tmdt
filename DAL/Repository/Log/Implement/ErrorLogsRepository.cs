using DAL.DataContext;
using DAL.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repository.Log.Implement
{
    public class ErrorLogsRepository : GenericRepository<ErrorLogs, string>, IErrorLogsRepository
    {
        public ErrorLogsRepository(ShopContext context) : base(context)
        {
        }
        
        public bool DeleteAll()
        {
            foreach(var row in dbSet)
            {
                dbSet.Remove(row);
            }
            this.shopContext.SaveChanges();
            return true;
        }
    }
}
