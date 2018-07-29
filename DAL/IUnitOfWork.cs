using DAL.Model;
using DAL.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public interface IUnitOfWork : IDisposable
    {
          IGenericRepository<System_User,string> UserRepository { get; set; }
    }
}
