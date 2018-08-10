using DAL.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public interface ISeoRepository<TEntity> : ITrackingObjectRepository<TEntity> where TEntity : SeoObject
    {
        TEntity SearchByUrl(string url);
    }
}
