using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using CacheHelpers;
using DAL;
using DAL.Model.PM;

namespace BLL.BLL.PM.Implement
{
    public class ProvinceBLL : GenericBLL, IProvinceBLL
    {
        

        public ProvinceBLL(IUnitOfWork unitOfWork, IDataCache DataCache) : base(unitOfWork, DataCache)
        {
        }

        public async Task<IEnumerable<Province>> Get()
        {
            var listProvince = dataCache.Get<IEnumerable<Province>>(CacheKey.ProvinceKey);
            if (listProvince == null)
            {
                listProvince = this.unitOfWork.ProvinceRepository.Get();
                dataCache.Set(listProvince, CacheKey.ProvinceKey);
            }
            return listProvince;
        }
    }
}
