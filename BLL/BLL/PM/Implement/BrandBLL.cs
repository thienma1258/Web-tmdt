using DAL;
using DAL.Model;
using DAL.Model.PM;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Helpers;
using System.Linq;
using System.Linq.Expressions;

namespace BLL.BLL.PM.Implement
{
    public class BrandBLL : GenericBLL, IBrandBLL
    {
        public BrandBLL(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public async Task<bool> Update(Brand brand, string UpdatedUser = "adminstrator")
        {
            try
            {
                brand.UrlFriendly = brand.Name.UrlFriendLy();
                brand.EditedUser = UpdatedUser;
                this.unitOfWork.BrandRepository.Update(brand);
                await this.unitOfWork.SaveChangeAsync();
                return true;
            }
            catch (Exception objEx)
            {
                await AddError(objEx);
                return false;
            }
        }
        public async Task<bool> Delete(string brand, string DeletedUser = "adminstrator")
        {
            try
            {
                this.unitOfWork.BrandRepository.Delete(brand, DeletedUser);
                await this.unitOfWork.SaveChangeAsync();
                return true;
            }
            catch (Exception objEx)
            {
                await AddError(objEx);
                return false;
            }
        }
        public async Task<bool> Add(Brand brand, string CreatedUser = "adminstrator")
        {
            try
            {

                brand.UrlFriendly = brand.Name.UrlFriendLy();
                brand.CreatedUser = CreatedUser;
                this.unitOfWork.BrandRepository.Insert(brand);
                await this.unitOfWork.SaveChangeAsync();
                return true;
            }
            catch (Exception objEx)
            {
                await AddError(objEx);
                return false;
            }
        }


        public async Task<Brand> Find(string ID)
        {
            return this.unitOfWork.BrandRepository.Find(ID);
        }

        public int Cout(Expression<Func<Brand, bool>> filter = null)
        {
            return this.unitOfWork.BrandRepository.Cout(filter);
        }

        public async Task<IEnumerable<Brand>> Get(int intNumber = -1, int currentPage = -1, Expression<Func<Brand, bool>> filter = null, Func<IQueryable<Brand>, IOrderedQueryable<Brand>> orderBy = null, string includeProperties = null)
        {
            try
            {
                return unitOfWork.BrandRepository.Get(filter: filter, orderBy: orderBy, number: intNumber, currentPage: currentPage,includeProperties:includeProperties);

            }
            catch (Exception objEx)
            {
                await AddError(objEx);
                return null;
            }
        }

        public Brand SearchByUrl(string url)
        {
            return this.unitOfWork.BrandRepository.SearchByUrl(url);
        }
    }
}
