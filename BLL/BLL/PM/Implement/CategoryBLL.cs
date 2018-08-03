using DAL;
using DAL.Model.PM;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Helpers;
using CacheHelpers;

namespace BLL.BLL.PM.Implement
{
    public class CategoryBLL : GenericBLL, IGenericBLL<Category,string>
    {
        public CategoryBLL(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public async Task<Category> Find(string ID)
        {
            return this.unitOfWork.CategoryRepository.Find(ID);
        }
        public async Task<bool> Add(Category category, string CreatedUser = "adminstrator")
        {
            try
            {
                category.UrlFriendly = category.Name.UrlFriendLy();
                category.CreatedUser = CreatedUser;
                this.unitOfWork.CategoryRepository.Insert(category);
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
                this.unitOfWork.CategoryRepository.Delete(entityID, DeletedUser);
                await this.unitOfWork.SaveChangeAsync();
                return true;
            }
            catch (Exception objEx)
            {
                AddError(objEx);
                return false;
            }
        }

        public async Task<IEnumerable<Category>> Get(int intNumber = -1, int intSkippage = -1)
        {
            return this.unitOfWork.CategoryRepository.Get(filter: p => p.isDeleted == false, number: intNumber, skippage: intSkippage);
        }

        public async Task<bool> Update(Category category, string UpdatedUser = "adminstrator")
        {
            try
            {
                category.UrlFriendly = category.Name.UrlFriendLy();
                category.EditedUser = UpdatedUser;
                this.unitOfWork.CategoryRepository.Update(category);
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
