using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.BLL.System
{
   public interface ISystem_User_PermissionBLL
    {
        bool CheckPermission(string UserName, string Permission);
    }
}
