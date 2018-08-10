using DAL.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repository
{
    public interface ITrackingObjectRepository<TEntity>: IGenericRepository<TEntity, string> where TEntity :TrackingObject
    {
    }
}
