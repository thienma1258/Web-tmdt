using DAL;
using DAL.Model.PM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BLL.PM.Implement
{
    public class DiscoutBLL: GenericBLL, IGenericBLL<Discout, string>
    {
        public DiscoutBLL(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public async Task<Discout> Find(string ID)
        {
            return this.unitOfWork.DiscoutRepository.Find(ID);
        }
        public async Task<bool> Add(Discout discout, string CreatedUser = "adminstrator")
        {
            try
            {
                discout.CreatedUser = CreatedUser;
                this.unitOfWork.DiscoutRepository.Insert(discout);
                await this.unitOfWork.SaveChangeAsync();
                return true;
            }
            catch (Exception objEx)
            {
                AddError(objEx);
                return false;
            }
        }

        public async Task<bool> Delete(string entityID, string DeletedUser = "adminstrator")
        {
            try
            {
                this.unitOfWork.DiscoutRepository.Delete(entityID, DeletedUser);
                await this.unitOfWork.SaveChangeAsync();
                return true;
            }
            catch (Exception objEx)
            {
                AddError(objEx);
                return false;
            }
        }

      

        public async Task<bool> Update(Discout discout, string UpdatedUser = "adminstrator")
        {
            try
            {
                discout.EditedUser = UpdatedUser;
                this.unitOfWork.DiscoutRepository.Update(discout);
                await this.unitOfWork.SaveChangeAsync();
                return true;
            }
            catch (Exception objEx)
            {
                AddError(objEx);
                return false;
            }
        }

        public int Cout()
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Discout>> Get(int intNumber = -1, int currentPage = -1, Expression<Func<Discout, bool>> filter = null, Func<IQueryable<Discout>, IOrderedQueryable<Discout>> orderBy = null)
        {
            try
            {
                return unitOfWork.DiscoutRepository.Get(filter: filter, orderBy: orderBy, number: intNumber, currentPage: currentPage);

            }
            catch (Exception objEx)
            {
                AddError(objEx);
                return null;
            }
        }
    }
}
