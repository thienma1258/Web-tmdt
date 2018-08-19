using DAL.DataContext;
using DAL.Model.CM;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace DAL.Repository.CM.Implement
{
    class CM_Customer_Repository : GenericRepository<CM_Customer, string>, ICM_Customer_Repository
    {
        public CM_Customer_Repository(ShopContext context) : base(context)
        {
        }

        public async Task<CM_Customer> FindCustomer(Expression<Func<CM_Customer, bool>> filter = null)
        {
            return await this.dbSet.FirstOrDefaultAsync(filter);
        }
    }
}
