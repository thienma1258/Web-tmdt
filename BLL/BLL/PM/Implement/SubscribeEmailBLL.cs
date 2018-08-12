using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAL.Model.PM;

namespace BLL.BLL.PM.Implement
{
    public class SubscribeEmailBLL : GenericBLL, ISubscribeEmailBLL
    {
        public SubscribeEmailBLL(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public async Task<bool> Add(SubscribeEmail entity, string CreatedUser = "adminstrator")
        {
            try
            {
               
                this.unitOfWork.SubscribeEmailRepository.Insert(entity);
                await this.unitOfWork.SaveChangeAsync();
                return true;
            }
            catch (Exception objEx)
            {
                
                //await AddError(objEx);
                return false;
            }
            
        }

        public int Cout(Expression<Func<SubscribeEmail, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(string entityID, string DeletedUser = "adminstrator")
        {
            throw new NotImplementedException();
        }

        public Task<SubscribeEmail> Find(string ID)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<SubscribeEmail>> Get(int intNumber = -1, int currentPage = -1, Expression<Func<SubscribeEmail, bool>> filter = null, Func<IQueryable<SubscribeEmail>, IOrderedQueryable<SubscribeEmail>> orderBy = null)
        {
            try
            {
                return unitOfWork.SubscribeEmailRepository.Get(filter: filter, orderBy: orderBy, number: intNumber, currentPage: currentPage);

            }
            catch (Exception objEx)
            {
                await AddError(objEx);
                return null;
            }
        }

        public Task<bool> Update(SubscribeEmail entity, string UpdatedUser = "adminstrator")
        {
            throw new NotImplementedException();
        }
    }
}
