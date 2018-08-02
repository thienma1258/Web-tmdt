using DAL.Model;
using DAL.Repository;
using DAL.Repository.Log;
using DAL.Repository.PM;
using DAL.Repository.System;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IUnitOfWork : IDisposable
    {
        IUserRepository UserRepository { get;  }
        #region Log
        IErrorLogsRepository ErrorLogsRepository { get; }
        #endregion
        #region PM
        IBrandRepository BrandRepository { get; }
        ICategoryRepository CategoryRepository { get; }
        IDiscoutRepository DiscoutRepository { get; }
        IDistrictRepository DistrictRepository { get; }
        IHomeCarouselRepository HomeCarouselRepository { get; }
        IHomeSliderRepository HomeSliderRepository { get; }
        IMainGroupRepository MainGroupRepository { get; }

        IProductRepository ProductRepository { get; }
        IProductDetailsRepository ProductDetailsRepository { get; }
        IProductRatingRepository ProductRatingRepository { get; }
        IProvinceRepository ProvinceRepository { get; }
        IStoreRepository StoreRepository { get; }
        ISubGroupRepository SubGroupRepository { get; }
         
        #endregion
        Task<int> SaveChangeAsync();
    }
}
