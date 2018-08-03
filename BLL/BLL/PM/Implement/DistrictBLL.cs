using CacheHelpers;
using DAL;
using DAL.Model.PM;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BLL.PM.Implement
{
    public class DistrictBLL : GenericBLL, IDistrictBLL
    {
        private readonly IDataCache DataCache;
        public DistrictBLL(IUnitOfWork unitOfWork,IDataCache dataCache) : base(unitOfWork)
        {
            this.DataCache = dataCache;
        }

       
        public async Task<IEnumerable<District>> Get()
        {
            var listDistrict= DataCache.Get<IEnumerable<District>>(CacheKey.DistrictKey);
            if (listDistrict == null)
            {
                listDistrict = this.unitOfWork.DistrictRepository.Get();
                DataCache.Set(listDistrict, CacheKey.DistrictKey);
               
            }
            return listDistrict;
        }

      
    }
}
