using DAL.DataContext;
using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DAL.Repository
{
    public class TrackingObjectRepository<TTrackingObject> : GenericRepository<TTrackingObject, string>, IGenericRepository<TTrackingObject, string> where TTrackingObject : TrackingObject
    {
        public TrackingObjectRepository(ShopContext context) : base(context)
        {
        }
        public override IEnumerable<TTrackingObject> Get(Expression<Func<TTrackingObject, bool>> filter = null, Func<IQueryable<TTrackingObject>, IOrderedQueryable<TTrackingObject>> orderBy = null, int currentPage = -1, int number = -1)
        {
            IQueryable<TTrackingObject> query = dbSet;
            query=query.Where(p => p.isDeleted == false);
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
                return query.ToList(); ;
            }
        }
        public override TTrackingObject Find(string id)
        {
            return dbSet.Where(p => p.isDeleted == false && p.ID == id).FirstOrDefault();
        }
        public override void Delete(TTrackingObject entityToDelete,string DeletedUser="Aminstrator")
        {
          
            entityToDelete.isDeleted = true;
            entityToDelete.DeletedDate = DateTime.Now;
            entityToDelete.DeletedUser = DeletedUser;
        }
        public override int Cout(Expression<Func<TTrackingObject, bool>> filter = null)
        {
            if (filter != null)
                return dbSet.Where(p => p.isDeleted == false).Where(filter).Count();
          return  dbSet.Where(p => p.isDeleted == false).Count();
        }
    }
}
