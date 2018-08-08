using DAL;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.BLL.System.Implement
{
    public class System_User_Permission_BLL:ISystem_User_PermissionBLL
    {
        private IUnitOfWork UnitOfWork;
        public System_User_Permission_BLL(IUnitOfWork unitOfWork)
        {
            this.UnitOfWork = unitOfWork;
        }
        public bool CheckPermission(string UserName,string Permission)
        {
           return this.UnitOfWork.System_User_Permission_Repository.CheckPermission(UserName, Permission);
        }
    }
}
