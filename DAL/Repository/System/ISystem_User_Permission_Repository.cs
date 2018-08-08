using DAL.Model.System;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repository.System
{
   public interface ISystem_User_Permission_Repository:IGenericRepository<System_User_Permission,string>
    {
        bool CheckPermission(string Username, string Permission);
    }
}
