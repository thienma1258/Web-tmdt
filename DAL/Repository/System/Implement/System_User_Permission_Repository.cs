using DAL.DataContext;
using DAL.Model.System;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Linq.Expressions;
namespace DAL.Repository.System.Implement
{
    public class System_User_Permission_Repository : TrackingObjectRepository<System_User_Permission>, ISystem_User_Permission_Repository
    {
        public System_User_Permission_Repository(ShopContext context) : base(context)
        {
        }

        public bool CheckPermission(string Username, string Permission)
        {
            var check=shopContext.System_User_Permissions.FirstOrDefault(p => p.System_Permission.PermissionName == Permission && p.UserName == Username);
            if (check == null)
                return false;
            return true;
        }
    }
}
