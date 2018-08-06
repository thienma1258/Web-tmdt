using DAL;
using DAL.Model.PM;
using System;
using System.Collections.Generic;
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

        public async Task<IEnumerable<Discout>> Get(int intNumber = -1, int intSkippage = -1)
        {
            return  this.unitOfWork.DiscoutRepository.Get(filter: p => p.isDeleted == false, number: intNumber, skippage: intSkippage);
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
    }
}
