using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public interface IGenericBLL<TEntity,T> where TEntity : class
    {
        Task<IEnumerable<TEntity>> Get(int intNumber = -1, int currentPage = -1, Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null);
        Task<bool> Update(TEntity entity, string UpdatedUser = "adminstrator");
        Task<bool> Delete(T entityID, string DeletedUser = "adminstrator");
        Task<bool> Add(TEntity entity, string CreatedUser = "adminstrator");
        Task<TEntity> Find(T ID);
        int Cout(Expression<Func<TEntity, bool>> filter = null);

    }
}
