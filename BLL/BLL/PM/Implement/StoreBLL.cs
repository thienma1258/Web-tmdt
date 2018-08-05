using DAL;
using DAL.Model.PM;
using Helpers;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BLL.PM.Implement
{
    public class StoreBLL : GenericBLL, IStoreBLL
    {
        public StoreBLL(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
        public async Task<bool> Add(Store store, string CreatedUser = "adminstrator")
        {
            try
            {
                store.UrlFriendly = store.NameStore.UrlFriendLy();
                store.CreatedUser = CreatedUser;
                this.unitOfWork.StoreRepository.Insert(store);
                await this.unitOfWork.SaveChangeAsync();
                return true;
            }
            catch (Exception objEx)
            {
                AddError(objEx);
                return false;
            }
        }

        public async Task<bool> Delete(string storeID, string DeletedUser = "adminstrator")
        {
            try
            {
                this.unitOfWork.StoreRepository.Delete(storeID, DeletedUser);
                await this.unitOfWork.SaveChangeAsync();
                return true;
            }
            catch (Exception objEx)
            {
                AddError(objEx);
                return false;
            }
        }

        public async Task<Store> Find(string ID)
        {
            return this.unitOfWork.StoreRepository.Find(ID);
        }

        public async Task<IEnumerable<Store>> Get(int intNumber = -1, int intSkippage = -1)
        {
            return this.unitOfWork.StoreRepository.Get(filter: p => p.isDeleted == false, number: intNumber, skippage: intSkippage);

        }

        public async Task<bool> Update(Store store, string UpdatedUser = "adminstrator")
        {
            try
            {
                store.UrlFriendly = store.NameStore.UrlFriendLy();
                store.EditedUser = UpdatedUser;
                this.unitOfWork.StoreRepository.Update(store);
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
