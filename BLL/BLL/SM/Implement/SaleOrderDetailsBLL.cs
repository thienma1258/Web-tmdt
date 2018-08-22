using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAL.Model.SM;

namespace BLL.BLL.SM.Implement
{
    public class SaleOrderDetailsBLL:GenericBLL , ISaleOrderDetailsBLL
    {
        public SaleOrderDetailsBLL(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public Task<bool> Add(SaleOrderDetail entity, string CreatedUser = "adminstrator")
        {
            throw new NotImplementedException();
        }

        public int Cout(Expression<Func<SaleOrderDetail, bool>> filter = null)
        {
            return this.unitOfWork.SaleOrderDetailsRepository.Cout(filter);

        }

        public Task<bool> Delete(string entityID, string DeletedUser = "adminstrator")
        {
            throw new NotImplementedException();
        }

        public Task<SaleOrderDetail> Find(string ID)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<SaleOrderDetail>> Get(int intNumber = -1, int currentPage = -1, Expression<Func<SaleOrderDetail, bool>> filter = null, Func<IQueryable<SaleOrderDetail>, IOrderedQueryable<SaleOrderDetail>> orderBy = null, string includeProperties = null)

        {
            try
            {
                return unitOfWork.SaleOrderDetailsRepository.Get(filter: filter, orderBy: orderBy, number: intNumber, currentPage: currentPage,includeProperties:includeProperties);

            }
            catch (Exception objEx)
            {
                await AddError(objEx);
                return null;
            }
        }

        public Task<bool> Update(SaleOrderDetail entity, string UpdatedUser = "adminstrator")
        {
            throw new NotImplementedException();
        }
    }
}
