using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using CacheHelpers;
using DAL;
using DAL.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;

namespace BLL.BLL.System.Implement
{
    public class UserBLL : GenericBLL, IUserBLL
    {
        SignInManager<System_User> signInManager;
        UserManager<System_User> userManager;
        RoleManager<IdentityRole> roleManager;
        public UserBLL(IUnitOfWork unitOfWork, RoleManager<IdentityRole> roleManager, UserManager<System_User> userManager,
          SignInManager<System_User> signInManager,IDataCache dataCache) : base(unitOfWork,dataCache)
        {
            this.signInManager = signInManager;
            this.userManager = userManager;
            this.roleManager = roleManager;
        }
        #region ResultProperty
        public IdentityResult IdentityResult { get; set; }
        public SignInResult SignInResult { get; set; }
        #endregion
        public async Task<bool> Add(System_User user,string Password,string Role)
        {
            try
            {
                bool roleExists = await roleManager.RoleExistsAsync(Role);
                if (!roleExists)
                {

                    // first we create Admin rool    
                    var role = new IdentityRole();
                    role.Name = Role;
                    await roleManager.CreateAsync(role);
                }
                    ///Add User
                var result = await userManager.CreateAsync(user, Password);

                IdentityResult = result;
                if (result.Succeeded)
                {
                    var currentUser = await userManager.FindByNameAsync(user.UserName);
                    var roleresult = await userManager.AddToRoleAsync(currentUser, Role);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch(Exception objEx)
            {
                await AddError(objEx);
                return false;
            }
        }

        public Task<bool> Delete(string entityID, string DeletedUser = "adminstrator")
        {
            throw new NotImplementedException();
        }
        public async Task<bool> SignIn(string UserName,string Password,bool RememberMe)
        {
            SignInResult = await signInManager.PasswordSignInAsync(UserName, Password, RememberMe, lockoutOnFailure: true);
            if (SignInResult.Succeeded)
            {
            //    _logger.LogInformation("User"+UserName+" logged in."+DateTime.Now);
                return true;
            }
            return false;
            
        }
        public Task<System_User> Find(string ID)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<System_User>> Get(int intNumber = -1, int intSkippage = -1)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(System_User entity, string UpdatedUser = "adminstrator")
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Lockout(string Username, bool isLock)
        {
            var User = await userManager.FindByNameAsync(Username);
            if (User == null)
            {
                return false;
            }
            else
            {
                await userManager.SetLockoutEnabledAsync(User, isLock);
                return true;
            }
        }
    }
}
