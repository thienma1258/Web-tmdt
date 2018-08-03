using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAL.Model;
using Microsoft.AspNetCore.Identity;

namespace BLL.BLL.System.Implement
{
    public class UserBLL : GenericBLL, IUserBLL
    {
        public UserBLL(IUnitOfWork unitOfWork, UserManager<System_User> userManager,
          SignInManager<System_User> signInManager) : base(unitOfWork)
        {
        }

        public Task<bool> Add(System_User entity, string CreatedUser = "adminstrator")
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(string entityID, string DeletedUser = "adminstrator")
        {
            throw new NotImplementedException();
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
    }
}
