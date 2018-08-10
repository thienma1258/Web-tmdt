using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using CacheHelpers;
using DAL;
using DAL.Model;
using DAL.Model.PM;
using Helpers;
namespace BLL.BLL.PM.Implement
{
    public class ProductBLL : GenericBLL,IProductBLL
    {
        public ProductBLL(IUnitOfWork unitOfWork, IDataCache DataCache) : base(unitOfWork, DataCache)
        {
        }

        public async Task<Product> Find(string ID)
        {
            return this.unitOfWork.ProductRepository.Find(ID);
        }
        public async Task<bool> Add(Product product, string CreatedUser = "adminstrator")
        {
            try
            {
                product.UrlFriendly = product.Model.UrlFriendLy();
                product.CreatedUser = CreatedUser;
                this.unitOfWork.ProductRepository.Insert(product);
                await this.unitOfWork.SaveChangeAsync();
                return true;
            }
            catch (Exception objEx)
            {
                await AddError(objEx);
                return false;
            }
        }

        public async Task<bool> Delete(string productID, string DeletedUser = "adminstrator")
        {
            try
            {
                this.unitOfWork.ProductRepository.Delete(productID, DeletedUser);
                await this.unitOfWork.SaveChangeAsync();
                return true;
            }
            catch (Exception objEx)
            {
                await AddError(objEx);
                return false;
            }
        }

      

        public async Task<bool> Update(Product product, string UpdatedUser = "adminstrator")
        {
            try
            {
                product.UrlFriendly = product.Model.UrlFriendLy();
                product.EditedUser = UpdatedUser;
                this.unitOfWork.ProductRepository.Update(product);
                await this.unitOfWork.SaveChangeAsync();
                return true;
            }
            catch (Exception objEx)
            {
                await AddError(objEx);
                return false;
            }
        }

        public int Cout(Expression<Func<Product, bool>> filter = null)
        {
            return this.unitOfWork.ProductRepository.Cout(filter);
        }

      

        public async Task<IEnumerable<Product>> Get(int intNumber = -1, int currentPage = -1, Expression<Func<Product, bool>> filter = null, Func<IQueryable<Product>, IOrderedQueryable<Product>> orderBy = null)
        {
            try
            {
                return unitOfWork.ProductRepository.Get(filter: filter, orderBy: orderBy, number: intNumber, currentPage: currentPage);

            }
            catch (Exception objEx)
            {
                await AddError(objEx);
                return null;
            }
        }

        public Product SearchByUrl(string url)
        {
            return this.unitOfWork.ProductRepository.SearchByUrl(url);
        }
    }
}
