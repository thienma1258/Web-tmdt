using DAL.DataContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DAL.Repository
{
    public class GenericRepository<TEntity,T>:IGenericRepository<TEntity,T> where TEntity : class
    {
        public readonly  ShopContext shopContext;
        public readonly  DbSet<TEntity> dbSet;

        public GenericRepository(ShopContext context)
        {
            this.shopContext = context;
            this.dbSet = context.Set<TEntity>();
        }
        protected virtual IQueryable<TEntity> filterObject(Expression<Func<TEntity, bool>> filter = null, int currentPage = -1, int number = -1)
        {
            IQueryable<TEntity> query = dbSet;

            if (filter != null)
            {
                query = query.Where(filter);
            }

            if (number != -1)
            {
                if (currentPage != -1)
                    query = query.Skip(number * (currentPage - 1));
                query = query.Take(number);
            }
            return query;
        }

        public virtual IEnumerable<TEntity> Get(
          Expression<Func<TEntity, bool>> filter = null,
              Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, int currentPage = -1, int number = -1)
        {
            IQueryable<TEntity> query = dbSet;

            if (filter != null)
            {
                query = query.Where(filter);
            }
            
            if (number != -1)
            {
                if (currentPage != -1)
                    query = query.Skip(number * (currentPage - 1));
                query = query.Take(number);
            }
            if (orderBy != null)
            {
                return orderBy(query).ToList();
            }
            else
            {
                return query.ToList();
            }
        }

        public virtual TEntity Find(T id)
        {
            return dbSet.Find(id);
        }

        public virtual void Insert(TEntity entity)
        {
            dbSet.Add(entity);
        }

        public virtual void Delete(T id,string DeletedUser="adminstrator")
        {
            TEntity entityToDelete = dbSet.Find(id);
            if (shopContext.Entry(entityToDelete).State == EntityState.Detached)
            {
                dbSet.Attach(entityToDelete);
            }
            Delete(entityToDelete, DeletedUser);
        }

        public virtual void Delete(TEntity entityToDelete,string DeletedUser)
        {
            dbSet.Remove(entityToDelete);
        }

        public virtual void Update(TEntity entityToUpdate)
        {
            dbSet.Attach(entityToUpdate);
            shopContext.Entry(entityToUpdate).State = EntityState.Modified;
        }

        public virtual void Delete(TEntity entityToDelete)
        {
        }

        public virtual int Cout(Expression<Func<TEntity, bool>> filter = null)
        {
            if (filter != null)
                return dbSet.Where(filter).Count();
            return dbSet.Count();
        }
    }
}
