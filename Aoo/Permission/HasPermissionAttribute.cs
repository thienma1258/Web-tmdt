using BLL.BLL.System;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aoo.Permission
{
    public class HasPermissionAttribute:ActionFilterAttribute
    {
        private string _permission;
        private ISystem_User_PermissionBLL User_PermissionBLL;
        public HasPermissionAttribute(string Permission, ISystem_User_PermissionBLL User_PermissionBLL)
        {
            this._permission = Permission;
            this.User_PermissionBLL = User_PermissionBLL;
        }
        public override void OnActionExecuted(ActionExecutedContext context)
        {
            var User = context.HttpContext.User;
            if (User == null)
            {
                //not login;
                context.HttpContext.Response.Redirect("/System/Login");
            }
            else
            {
                var CheckPermission = this.User_PermissionBLL.CheckPermission(User.Identity.Name, _permission);
                if(!CheckPermission)
                    context.HttpContext.Response.Redirect("/Permission/Denided");
            }

        }
    }
}
