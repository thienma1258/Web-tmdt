using DAL;
using DAL.Model;
using DAL.Model.PM;
using Helpers;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BLL.PM
{
    public class MainGroupBLL : GenericBLL, IMainGroupBLL
    {
        public MainGroupBLL(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public async Task<MainGroup> Find(string ID)
        {
            return this.unitOfWork.MainGroupRepository.Find(ID);
        }
        public async Task<bool> Update(MainGroup MainGroup, string UpdatedUser = "adminstrator")
        {
            try
            {
                MainGroup.EditedUser = UpdatedUser;
                MainGroup.UrlFriendly = MainGroup.Name.UrlFriendLy();
                this.unitOfWork.MainGroupRepository.Update(MainGroup);
                await this.unitOfWork.SaveChangeAsync();
                return true;
            }
            catch (Exception objEx)
            {
                AddError(objEx);
                return false;
            }
        }
        public async Task<bool> Delete(string MainGroupID, string DeletedUser = "adminstrator")
        {
            try
            {
                this.unitOfWork.MainGroupRepository.Delete(MainGroupID, DeletedUser);
                await this.unitOfWork.SaveChangeAsync();
                return true;
            }
            catch (Exception objEx)
            {
                AddError(objEx);
                return false;
            }
        }
        public async Task<bool> Add(MainGroup MainGroup, string CreatedUser = "adminstrator")
        {
            try
            {
                MainGroup.CreatedUser = CreatedUser;
                this.unitOfWork.MainGroupRepository.Insert(MainGroup);
                await this.unitOfWork.SaveChangeAsync();
                return true;
            }
            catch (Exception objEx)
            {
                AddError(objEx);
                return false;
            }
        }
        public async Task<IEnumerable<MainGroup>> Get(int intNumber = -1, int intSkippage = -1)
        {
            try
            {
                return this.unitOfWork.MainGroupRepository.Get(filter: p => p.isDeleted == false, number: intNumber, skippage: intSkippage);

            }
            catch (Exception objEx)
            {
                AddError(objEx);
                return null;
            }
        }
    }
}
