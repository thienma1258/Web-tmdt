using DAL.Model;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BLL.System
{
    public enum UserAccoutType
    {
        Lock=1,
        UnLock=0,
    }
    public interface IUserBLL
    {
        Task<bool> Add(System_User user, string Password, string Role);
        Task<bool> Lockout(string Username, bool isLock);
         IdentityResult IdentityResult { get; set; }
         SignInResult SignInResult { get; set; }

    }
}
