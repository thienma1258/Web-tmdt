using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using CacheHelpers;
using DAL;
using DAL.Model.PM;

namespace BLL.BLL.PM.Implement
{
    public class ProductDetailsBLL : GenericBLL, IProductDetailsBLL
    {
        public ProductDetailsBLL(IUnitOfWork unitOfWork, IDataCache DataCache) : base(unitOfWork, DataCache)
        {
        }

        public async Task<bool> Add(ProductDetails productDetails, string CreatedUser = "adminstrator")
        {
            try
            {
                productDetails.CreatedUser = CreatedUser;
                this.unitOfWork.ProductDetailsRepository.Insert(productDetails);
                await this.unitOfWork.SaveChangeAsync();
                return true;
            }
            catch (Exception objEx)
            {
                await AddError(objEx);
                return false;
            }
        }

        public int Cout(Expression<Func<ProductDetails, bool>> filter = null)
        {
            return this.unitOfWork.ProductDetailsRepository.Cout(filter);
        }

        public Task<bool> Delete(string entityID, string DeletedUser = "adminstrator")
        {
            throw new NotImplementedException();
        }

        public async Task<ProductDetails> Find(string ID)
        {
            return this.unitOfWork.ProductDetailsRepository.Find(ID);
        }

        public async Task<IEnumerable<ProductDetails>> Get(int intNumber = -1, int currentPage = -1)
        {
            try
            {
                return unitOfWork.ProductDetailsRepository.Get( number: intNumber, currentPage: currentPage);

            }
            catch (Exception objEx)
            {
                await AddError(objEx);
                return null;
            }
        }

        public async Task<IEnumerable<ProductDetails>> Get(int intNumber = -1, int currentPage = -1, Expression<Func<ProductDetails, bool>> filter = null, Func<IQueryable<ProductDetails>, IOrderedQueryable<ProductDetails>> orderBy = null)
        {
            try
            {
                return unitOfWork.ProductDetailsRepository.Get(filter: filter, orderBy: orderBy, number: intNumber, currentPage: currentPage);

            }
            catch (Exception objEx)
            {
                await AddError(objEx);
                return null;
            }
        }

        public Task<bool> Update(ProductDetails entity, string UpdatedUser = "adminstrator")
        {
            throw new NotImplementedException();
        }
    }
}
