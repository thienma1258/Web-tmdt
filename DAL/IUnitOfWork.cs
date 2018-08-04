using DAL.Model;
using DAL.Repository;
using DAL.Repository.Log;
using DAL.Repository.PM;
using DAL.Repository.SM;
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
        ISaleOrderLogsRepository SaleOrderLogsRepository { get; }
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
        ITransportPriceRepository TransportPriceRepository { get; }
        ITransportTypeRepository TransportTypeRepository { get; }
        IVoucherRepository VoucherRepository { get; }
        #endregion
        #region SM
        ISaleOrderRepository SaleOrderRepository { get; }
        #endregion
        #region System
        ISystem_Policy_Repository System_Policy_Repository { get; }
        ISystem_Position_Repository System_Position_Repository { get; }

        #endregion
        Task<int> SaveChangeAsync();
    }
}
