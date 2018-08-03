using DAL;
using DAL.Model;
using DAL.Model.PM;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BLL.PM
{
    public class SubGroupBLL : GenericBLL, IGenericBLL<SubGroup,string>
    {
        public SubGroupBLL(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public async Task<bool> Add(SubGroup SubGroup, string CreatedUser = "adminstrator")
        {
            try
            {
                SubGroup.CreatedUser = CreatedUser;
                this.unitOfWork.SubGroupRepository.Insert(SubGroup);
                await this.unitOfWork.SaveChangeAsync();
                return true;
            }
            catch (Exception objEx)
            {
                AddError(objEx);
                return false;
            }
        }

        public async Task<bool> Delete(string SubGroupID, string DeletedUser = "adminstrator")
        {
            try
            {
                this.unitOfWork.SubGroupRepository.Delete(SubGroupID,DeletedUser);
                await this.unitOfWork.SaveChangeAsync();
                return true;
            }
            catch (Exception objEx)
            {
                AddError(objEx);
                return false;
            }
        }

        public async Task<SubGroup> Find(string ID)
        {
           return this.unitOfWork.SubGroupRepository.Find(ID);
        }

        public async Task<IEnumerable<SubGroup>> Get(int intNumber = -1, int intSkippage = -1)
        {
            try
            {
                return this.unitOfWork.SubGroupRepository.Get(filter: p => p.isDeleted == false, number: intNumber, skippage: intSkippage);

            }
            catch (Exception objEx)
            {
                AddError(objEx);
                return null;
            }
        }

        public async Task<bool> Update(SubGroup subGroup, string UpdatedUser = "adminstrator")
        {
            try
            {
                subGroup.EditedUser = UpdatedUser;
                this.unitOfWork.SubGroupRepository.Update(subGroup);
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
