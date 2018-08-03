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
  
        public DistrictBLL(IUnitOfWork unitOfWork,IDataCache dataCache) : base(unitOfWork,dataCache)
        {
            
        }

       
        public async Task<IEnumerable<District>> Get()
        {
            var listDistrict= dataCache.Get<IEnumerable<District>>(CacheKey.DistrictKey);
            if (listDistrict == null)
            {
                listDistrict = this.unitOfWork.DistrictRepository.Get();
                dataCache.Set(listDistrict, CacheKey.DistrictKey);
            }
            return listDistrict;
        }

      
    }
}
