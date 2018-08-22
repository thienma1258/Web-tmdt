using CacheHelpers;
using DAL;
using DAL.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class GenericBLL
    {
        public readonly IUnitOfWork unitOfWork;
        public  readonly IDataCache dataCache;
        public GenericBLL(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public GenericBLL(IUnitOfWork unitOfWork, IDataCache DataCache)
        {
            this.unitOfWork = unitOfWork;
            this.dataCache = DataCache; ;
        }
        public async Task<bool> AddError(Exception objEx)
        {
            StackTrace stackTrace = new StackTrace();
            ErrorLogs errorLogs = new ErrorLogs
            {
                ErrorLog = objEx.ToString(),
                FunctionName = stackTrace.GetFrame(1).GetMethod().Name,
                ModuleName = "BLL/"+this.GetType().Name,
            };
            this.unitOfWork.ErrorLogsRepository.Insert(errorLogs);
            await this.unitOfWork.SaveChangeAsync();
            return true;
           
        }

    }
}
