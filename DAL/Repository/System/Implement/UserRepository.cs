using DAL.DataContext;
using DAL.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repository.System.Implement
{
    public class UserRepository : GenericRepository<System_User, string>, IUserRepository
    {
        public UserRepository(ShopContext context) : base(context)
        {
        }
    
    }
}
