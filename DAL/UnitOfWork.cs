using System;
using System.Collections.Generic;
using System.Text;
using DAL.Model;
using DAL.Repository;

namespace DAL
{
   public class UnitOfWork:IUnitOfWork
    {
        private DataContext.DataContext dataContext;
        public UnitOfWork(DataContext.DataContext dataContext)
        {
            this.dataContext = dataContext;
        }
        private bool disposed = false;

        private IGenericRepository<User, string> userRepository;

        public IGenericRepository<User, string> UserRepository { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    dataContext.Dispose();
                }
            }
            this.disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
            this.dataContext.Dispose();
        }
    }
}
