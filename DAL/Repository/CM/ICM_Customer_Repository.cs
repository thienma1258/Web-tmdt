using DAL.Model.CM;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository.CM
{
    public interface ICM_Customer_Repository:IGenericRepository<CM_Customer,string>
    {
         Task<CM_Customer> FindCustomer(Expression<Func<CM_Customer, bool>> filter = null);
    }
}
