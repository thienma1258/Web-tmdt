using DAL;
using DAL.Model;
using DAL.Model.PM;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Helpers;
namespace BLL.BLL.PM
{
    public class BrandBLL
    {
        public IUnitOfWork unitOfWork;
        public BrandBLL(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public async Task<bool> Update(Brand brand)
        {
            try
            {
                brand.UrlFriendly = brand.Name.UrlFriendLy();
                this.unitOfWork.BrandRepository.Update(brand);
                await this.unitOfWork.SaveChangeAsync();
                return true;
            }
            catch (Exception objEx)
            {
                ErrorLogs errorLogs = new ErrorLogs
                {
                    ErrorLog = objEx.ToString(),
                    FunctionName = MethodBase.GetCurrentMethod().ToString(),
                    ModuleName = "PM->Brand"

                };
                this.unitOfWork.ErrorLogsRepository.Insert(errorLogs);
                await this.unitOfWork.SaveChangeAsync();
                return false;
            }
        }
        public async Task<bool> Delete(Brand brand)
        {
            try
            {
                this.unitOfWork.BrandRepository.Delete(brand);
                await this.unitOfWork.SaveChangeAsync();
                return true;
            }
            catch (Exception objEx)
            {
                ErrorLogs errorLogs = new ErrorLogs
                {
                    ErrorLog = objEx.ToString(),
                    FunctionName = MethodBase.GetCurrentMethod().ToString(),
                    ModuleName = "PM->Brand"

                };
                this.unitOfWork.ErrorLogsRepository.Insert(errorLogs);
                await this.unitOfWork.SaveChangeAsync();
                return false;
            }
        }
        public async Task<bool> Add(Brand brand)
        {
            try
            {
                brand.UrlFriendly = brand.Name.UrlFriendLy();
                this.unitOfWork.BrandRepository.Insert(brand);
                await this.unitOfWork.SaveChangeAsync();
                return true;
            }
            catch (Exception objEx)
            {
                ErrorLogs errorLogs = new ErrorLogs
                {
                    ErrorLog = objEx.ToString(),
                    FunctionName = MethodBase.GetCurrentMethod().ToString(),
                    ModuleName = "PM->Brand",
                    TableName="Brand"

                };
                this.unitOfWork.ErrorLogsRepository.Insert(errorLogs);
                await this.unitOfWork.SaveChangeAsync();
                return false;
            }
        }
        public async Task<IEnumerable<Brand>> Get(int intNumber=-1,int intSkippage=-1)
        {
            try
            {
                return  this.unitOfWork.BrandRepository.Get(filter:p=>p.isDeleted==false,number:intNumber,skippage:intSkippage);

            }
            catch (Exception objEx)
            {
                ErrorLogs errorLogs = new ErrorLogs
                {
                    ErrorLog = objEx.ToString(),
                    FunctionName = MethodBase.GetCurrentMethod().ToString(),
                    ModuleName = "PM->Brand"

                };
                this.unitOfWork.ErrorLogsRepository.Insert(errorLogs);
                await this.unitOfWork.SaveChangeAsync();
                return null;
            }
        }
    }
}
