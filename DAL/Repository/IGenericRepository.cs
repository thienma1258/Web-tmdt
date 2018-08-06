using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DAL.Repository
{
    public interface IGenericRepository<TEntity,T> where TEntity : class
    {
        IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> filter = null,
              Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, int skippage = -1, int number = -1);
        TEntity Find(T id);
        void Insert(TEntity entity);
        void Delete(T entityToDelete,string DeletedUser="adminstrator");

        void Update(TEntity entityToUpdate);
        int Cout();
    }
}
