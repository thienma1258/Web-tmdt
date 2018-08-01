using DAL.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repository.System
{
    public interface IUserRepository : IGenericRepository<System_User, string>
    {
    }
}
