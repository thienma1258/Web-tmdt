﻿using DAL;
using DAL.Model;
using DAL.Model.PM;
using Helpers;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BLL.PM
{
    public class MainGroupBLL
    {
        public IUnitOfWork unitOfWork;
        public MainGroupBLL(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public async Task<bool> Update(MainGroup MainGroup)
        {
            try
            {
                MainGroup.UrlFriendly = MainGroup.Name.UrlFriendLy();

                this.unitOfWork.MainGroupRepository.Update(MainGroup);
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
        public async Task<bool> Delete(MainGroup MainGroup)
        {
            try
            {
                this.unitOfWork.MainGroupRepository.Delete(MainGroup);
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
        public async Task<bool> Add(MainGroup MainGroup)
        {
            try
            {
                this.unitOfWork.MainGroupRepository.Insert(MainGroup);
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
                    TableName = "Brand"

                };
                this.unitOfWork.ErrorLogsRepository.Insert(errorLogs);
                await this.unitOfWork.SaveChangeAsync();
                return false;
            }
        }
        public async Task<IEnumerable<MainGroup>> Get(int intNumber = -1, int intSkippage = -1)
        {
            try
            {
                return this.unitOfWork.MainGroupRepository.Get(filter: p => p.isDeleted == false, number: intNumber, skippage: intSkippage);

            }
            catch (Exception objEx)
            {
                ErrorLogs errorLogs = new ErrorLogs
                {
                    ErrorLog = objEx.ToString(),
                    FunctionName = MethodBase.GetCurrentMethod().ToString(),
                    ModuleName = "PM->MainGroup"

                };
                this.unitOfWork.ErrorLogsRepository.Insert(errorLogs);
                await this.unitOfWork.SaveChangeAsync();
                return null;
            }
        }
    }
}
