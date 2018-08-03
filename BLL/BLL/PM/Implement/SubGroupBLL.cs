using DAL;
using DAL.Model;
using DAL.Model.PM;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BLL.PM
{
    public class SubGroupBLL : GenericBLL, IGenericBLL<SubGroup>
    {
        public SubGroupBLL(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public async Task<bool> Add(SubGroup SubGroup, string CreatedUser = "adminstrator")
        {
            try
            {
                SubGroup.CreatedUser = CreatedUser;
                this.unitOfWork.SubGroupRepository.Insert(SubGroup);
                await this.unitOfWork.SaveChangeAsync();
                return true;
            }
            catch (Exception objEx)
            {
                ErrorLogs errorLogs = new ErrorLogs
                {
                    ErrorLog = objEx.ToString(),
                    FunctionName = MethodBase.GetCurrentMethod().ToString(),
                    ModuleName = "PM->SubGroup",
                    TableName = "SubGroup"

                };
                this.unitOfWork.ErrorLogsRepository.Insert(errorLogs);
                await this.unitOfWork.SaveChangeAsync();
                return false;
            }
        }

        public async Task<bool> Delete(SubGroup SubGroup, string DeletedUser = "adminstrator")
        {
            try
            {
                SubGroup.DeletedUser = DeletedUser;
                this.unitOfWork.SubGroupRepository.Delete(SubGroup);
                await this.unitOfWork.SaveChangeAsync();
                return true;
            }
            catch (Exception objEx)
            {
                ErrorLogs errorLogs = new ErrorLogs
                {
                    ErrorLog = objEx.ToString(),
                    FunctionName = MethodBase.GetCurrentMethod().ToString(),
                    ModuleName = "PM->SubGroup"

                };
                this.unitOfWork.ErrorLogsRepository.Insert(errorLogs);
                await this.unitOfWork.SaveChangeAsync();
                return false;
            }
        }

        public async Task<IEnumerable<SubGroup>> Get(int intNumber = -1, int intSkippage = -1)
        {
            try
            {
                return this.unitOfWork.SubGroupRepository.Get(filter: p => p.isDeleted == false, number: intNumber, skippage: intSkippage);

            }
            catch (Exception objEx)
            {
                ErrorLogs errorLogs = new ErrorLogs
                {
                    ErrorLog = objEx.ToString(),
                    FunctionName = MethodBase.GetCurrentMethod().ToString(),
                    ModuleName = "PM->SubGroup"

                };
                this.unitOfWork.ErrorLogsRepository.Insert(errorLogs);
                await this.unitOfWork.SaveChangeAsync();
                return null;
            }
        }

        public Task<bool> Update(SubGroup entity, string UpdatedUser = "adminstrator")
        {
            throw new NotImplementedException();
        }
    }
}
