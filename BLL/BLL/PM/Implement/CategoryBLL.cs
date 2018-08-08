using DAL;
using DAL.Model.PM;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Helpers;
using CacheHelpers;
using System.Linq;
using System.Linq.Expressions;

namespace BLL.BLL.PM.Implement
{
    public class CategoryBLL : GenericBLL, ICategoryBLL
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
                await AddError(objEx);
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
                await AddError(objEx);
                return false;
            }
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
                await AddError(objEx);
                return false;
            }
        }

        public int Cout(Expression<Func<Category, bool>> filter = null)
        {
            return this.unitOfWork.CategoryRepository.Cout(filter);
        }

        public async Task<IEnumerable<Category>> Get(int intNumber = -1, int currentPage = -1, Expression<Func<Category, bool>> filter = null, Func<IQueryable<Category>, IOrderedQueryable<Category>> orderBy = null)
        {
            try
            {
                return unitOfWork.CategoryRepository.Get(filter: filter, orderBy: orderBy, number: intNumber, currentPage: currentPage);

            }
            catch (Exception objEx)
            {
                await AddError(objEx);
                return null;
            }
        }
    }
}
