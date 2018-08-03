using System;
using System.Collections.Generic;
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
                AddError(objEx);
                return false;
            }
        }

        public Task<bool> Delete(string entityID, string DeletedUser = "adminstrator")
        {
            throw new NotImplementedException();
        }

        public Task<ProductDetails> Find(string ID)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<ProductDetails>> Get(int intNumber = -1, int intSkippage = -1)
        {
            try
            {
                return unitOfWork.ProductDetailsRepository.Get(filter: p => p.isDeleted == false, number: intNumber, skippage: intSkippage);

            }
            catch (Exception objEx)
            {
                AddError(objEx);
                return null;
            }
        }

        public Task<bool> Update(ProductDetails entity, string UpdatedUser = "adminstrator")
        {
            throw new NotImplementedException();
        }
    }
}
