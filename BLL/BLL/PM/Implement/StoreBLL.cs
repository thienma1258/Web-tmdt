using DAL;
using DAL.Model.PM;
using Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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
                await AddError(objEx);
                return false;
            }
        }

        public int Cout(Expression<Func<Store, bool>> filter = null)
        {
            return this.unitOfWork.StoreRepository.Cout(filter);
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
                await AddError(objEx);
                return false;
            }
        }

        public async Task<Store> Find(string ID)
        {
            return this.unitOfWork.StoreRepository.Find(ID);
        }

      

        public async Task<IEnumerable<Store>> Get(int intNumber = -1, int currentPage = -1, Expression<Func<Store, bool>> filter = null, Func<IQueryable<Store>, IOrderedQueryable<Store>> orderBy = null, string includeProperties = null)
        {
            try
            {
                return unitOfWork.StoreRepository.Get(filter: filter, orderBy: orderBy, number: intNumber, currentPage: currentPage,includeProperties:includeProperties);

            }
            catch (Exception objEx)
            {
                await AddError(objEx);
                return null;
            }
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
                await AddError(objEx);
                return false;
            }
        }
    }
}
