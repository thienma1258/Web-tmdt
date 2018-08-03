using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAL.Model;
using DAL.Model.PM;
using Helpers;
namespace BLL.BLL.PM.Implement
{
    public class ProductBLL : GenericBLL,IProductBLL
    {
        public ProductBLL(IUnitOfWork unitOfWork) : base(unitOfWork)
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
                ErrorLogs errorLogs = new ErrorLogs
                {
                    ErrorLog = objEx.ToString(),
                    FunctionName = MethodBase.GetCurrentMethod().ToString(),
                    ModuleName = "PM->Product",
                    TableName = "product"

                };
                this.unitOfWork.ErrorLogsRepository.Insert(errorLogs);
                await this.unitOfWork.SaveChangeAsync();
                return false;
            }
        }

        public async Task<bool> Delete(Product product, string DeletedUser = "adminstrator")
        {
            try
            {
                product.UrlFriendly = product.Model.UrlFriendLy();
                product.DeletedUser = DeletedUser;
                this.unitOfWork.ProductRepository.Delete(product,DeletedUser);
                await this.unitOfWork.SaveChangeAsync();
                return true;
            }
            catch (Exception objEx)
            {
                ErrorLogs errorLogs = new ErrorLogs
                {
                    ErrorLog = objEx.ToString(),
                    FunctionName = MethodBase.GetCurrentMethod().ToString(),
                    ModuleName = "PM->product"

                };
                this.unitOfWork.ErrorLogsRepository.Insert(errorLogs);
                await this.unitOfWork.SaveChangeAsync();
                return false;
            }
        }

        public async Task<IEnumerable<Product>> Get(int intNumber = -1, int intSkippage = -1)
        {
            try
            {
                return unitOfWork.ProductRepository.Get(filter: p => p.isDeleted == false, number: intNumber, skippage: intSkippage);

            }
            catch (Exception objEx)
            {
                ErrorLogs errorLogs = new ErrorLogs
                {
                    ErrorLog = objEx.ToString(),
                    FunctionName = MethodBase.GetCurrentMethod().ToString(),
                    ModuleName = "PM->Product"

                };
                this.unitOfWork.ErrorLogsRepository.Insert(errorLogs);
                await this.unitOfWork.SaveChangeAsync();
                return null;
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
                ErrorLogs errorLogs = new ErrorLogs
                {
                    ErrorLog = objEx.ToString(),
                    FunctionName = MethodBase.GetCurrentMethod().ToString(),
                    ModuleName = "PM->product"

                };
                this.unitOfWork.ErrorLogsRepository.Insert(errorLogs);
                await this.unitOfWork.SaveChangeAsync();
                return false;
            }
        }
    }
}
