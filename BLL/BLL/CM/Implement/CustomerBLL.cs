using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAL.Model.CM;

namespace BLL.BLL.CM.Implement
{
    public class CustomerBLL : GenericBLL, ICustomerBLL
    {
        public CustomerBLL(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public async Task<bool> Add(CM_Customer customer, string CreatedUser = "adminstrator")
        {
            return false;
        }

        public int Cout(Expression<Func<CM_Customer, bool>> filter = null)
        {
            return this.unitOfWork.CM_Customer_Repository.Cout(filter);

        }

        public Task<bool> Delete(string entityID, string DeletedUser = "adminstrator")
        {
            throw new NotImplementedException();
        }

        public Task<CM_Customer> Find(string ID)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<CM_Customer>> Get(int intNumber = -1, int currentPage = -1, Expression<Func<CM_Customer, bool>> filter = null, Func<IQueryable<CM_Customer>, IOrderedQueryable<CM_Customer>> orderBy = null, string includeProperties = null)
        {
            try
            {
                return  unitOfWork.CM_Customer_Repository.Get(filter: filter, orderBy: orderBy, number: intNumber, currentPage: currentPage,includeProperties:includeProperties);

            }
            catch (Exception objEx)
            {
                await AddError(objEx);
                return null;
            }
        }

        public Task<bool> Update(CM_Customer entity, string UpdatedUser = "adminstrator")
        {
            throw new NotImplementedException();
        }
    }
}
