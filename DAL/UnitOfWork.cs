using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DAL.Model;
using DAL.Repository;
using DAL.Repository.CM;
using DAL.Repository.CM.Implement;
using DAL.Repository.CRM;
using DAL.Repository.Log;
using DAL.Repository.Log.Implement;
using DAL.Repository.PM;
using DAL.Repository.PM.Implement;
using DAL.Repository.SM;
using DAL.Repository.SM.Implement;
using DAL.Repository.System;
using DAL.Repository.System.Implement;

namespace DAL
{
   public class UnitOfWork:IUnitOfWork
    {
        private DataContext.ShopContext dataContext;

        #region Filed
        #region CM
        private ICM_Customer_Repository cm_Customer_Repository;
        #endregion
        #region CRM
        private ICRM_FeedBack_Repository crm_FeedBack_Repository;
        #endregion
        #region Log
        private IErrorLogsRepository errorLogsRepository;
        private ISaleOrderLogsRepository saleOrderLogsRepository;
        private IImageUploadLogRepository imageUploadLogRepository;

        #endregion

        #region PM
        private IBrandRepository brandRepository;
        private ICategoryRepository categoryRepository;
        private IDiscoutRepository discoutRepository;
        private IDistrictRepository districtRepository;
        private IHomeCarouselRepository homeCarouselRepository;
        private IHomeSliderRepository homeSliderRepository;
        private IMainGroupRepository mainGroupRepository;
        private IProductDetailsRepository productDetailsRepository;
        private IProductRatingRepository productRatingRepository;
        private IProductRepository productRepository;
        private IProvinceRepository provinceRepository;
        private IStoreRepository storeRepository;
        private ISubGroupRepository subGroupRepository;
        private ITransportPriceRepository transportPriceRepository;
        private ITransportTypeRepository transportTypeRepository;
        private IVoucherRepository voucherRepository;
        private ISubscribeEmailRepository subscribeEmailRepository;


        #endregion
        #region SM
        private ISaleOrderDetailsRepository saleOrderDetailsRepository;
        private ISaleOrderRepository saleOrderRepository;
        #endregion
        #region System
        private ISystem_Policy_Repository system_Policy_Repository;
        private ISystem_Position_Repository system_Position_Repository;
        private ISystem_User_Permission_Repository system_User_Permission_Repository;
        private IUserRepository userRepository;

        #endregion
        #endregion

        public UnitOfWork(DataContext.ShopContext dataContext)
        {
            this.dataContext = dataContext;
        }

        private bool disposed = false;
        #region Property
        #region CM
        public ICM_Customer_Repository CM_Customer_Repository
        {
            get
            {
                if (this.cm_Customer_Repository == null)
                    cm_Customer_Repository = new CM_Customer_Repository(dataContext);
                return cm_Customer_Repository;
            }
        }
        #endregion
        #region CRM

        #endregion
        #region Log
        public IErrorLogsRepository ErrorLogsRepository
        {
            get
            {
                if (this.errorLogsRepository == null)
                    errorLogsRepository = new ErrorLogsRepository(dataContext);
                return errorLogsRepository;
            }
        }
        public ISaleOrderLogsRepository SaleOrderLogsRepository
        {
            get
            {
                if (this.saleOrderLogsRepository == null)
                    saleOrderLogsRepository = new SaleOrderLogsRepository(dataContext);
                return saleOrderLogsRepository;
            }
        }
        #endregion
        #region PM
        public IBrandRepository BrandRepository
        {
            get
            {
                if (this.brandRepository == null)
                    brandRepository = new BrandRepository(dataContext);
                return brandRepository;
            }
        }

        public ICategoryRepository CategoryRepository
        {
            get
            {
                if (this.categoryRepository == null)
                    categoryRepository = new CategoryRepository(dataContext);
                return categoryRepository;
            }
        }
        public IDiscoutRepository DiscoutRepository
        {
            get
            {
                if (this.discoutRepository == null)
                    discoutRepository = new DiscoutRepository(dataContext);
                return discoutRepository;
            }
        }
        public IDistrictRepository DistrictRepository
        {
            get
            {
                if (this.districtRepository == null)
                    districtRepository = new DistrictRepository(dataContext);
                return districtRepository;
            }
        }
        public IHomeCarouselRepository HomeCarouselRepository
        {
            get
            {
                if (this.homeCarouselRepository == null)
                    homeCarouselRepository = new HomeCarouselRepository(dataContext);
                return homeCarouselRepository;
            }
        }
        public IHomeSliderRepository HomeSliderRepository
        {
            get
            {
                if (this.homeSliderRepository == null)
                    homeSliderRepository = new HomeSliderRepository(dataContext);
                return homeSliderRepository;
            }
        }
        public IMainGroupRepository MainGroupRepository
        {
            get
            {
                if (this.mainGroupRepository == null)
                    mainGroupRepository = new MainGroupRepository(dataContext);
                return mainGroupRepository;
            }
        }
        public IProductDetailsRepository ProductDetailsRepository
        {
            get
            {
                if (this.productDetailsRepository == null)
                    productDetailsRepository = new ProductDetailsRepository(dataContext);
                return productDetailsRepository;
            }
        }
        public IProductRatingRepository ProductRatingRepository
        {
            get
            {
                if (this.productRatingRepository == null)
                    productRatingRepository = new ProductRatingRepository(dataContext);
                return productRatingRepository;
            }
        }

        public IProductRepository ProductRepository
        {
            get
            {
                if (this.productRepository == null)
                    productRepository = new ProductRepository(dataContext);
                return productRepository;
            }
        }
        public IProvinceRepository ProvinceRepository
        {
            get
            {
                if (this.provinceRepository == null)
                    provinceRepository = new ProvinceRepository(dataContext);
                return provinceRepository;
            }
        }
        public IStoreRepository StoreRepository
        {
            get
            {
                if (this.storeRepository == null)
                    storeRepository = new StoreRepository(dataContext);
                return storeRepository;
            }
        }

        public ISubGroupRepository SubGroupRepository
        {
            get
            {
                if (this.subGroupRepository == null)
                    subGroupRepository = new SubGroupRepository(dataContext);
                return subGroupRepository;
            }
        }
        public ITransportPriceRepository TransportPriceRepository
        {
            get
            {
                if (this.transportPriceRepository == null)
                    transportPriceRepository = new TransportPriceRepository(dataContext);
                return transportPriceRepository;
            }
        }
        public ITransportTypeRepository TransportTypeRepository
        {
            get
            {
                if (this.transportTypeRepository == null)
                    transportTypeRepository = new TransportTypeRepository(dataContext);
                return transportTypeRepository;
            }
        }

        public IVoucherRepository VoucherRepository
        {
            get
            {
                if (this.voucherRepository == null)
                    voucherRepository = new VoucherRepository(dataContext);
                return voucherRepository;
            }
        }
        public ISubscribeEmailRepository SubscribeEmailRepository
        {
            get
            {
                if (this.subscribeEmailRepository == null)
                    subscribeEmailRepository = new SubscribeEmailRepository(dataContext);
                return subscribeEmailRepository;
            }
        }
        #endregion

        #region SM
        public ISaleOrderDetailsRepository SaleOrderDetailsRepository
        {
            get
            {
                if (this.saleOrderDetailsRepository == null)
                    saleOrderDetailsRepository = new SaleOrderDetailsRepository(dataContext);
                return saleOrderDetailsRepository;
            }
        }
        public ISaleOrderRepository SaleOrderRepository
        {
            get
            {
                if (this.saleOrderRepository == null)
                    saleOrderRepository = new SaleOrderRepository(dataContext);
                return saleOrderRepository;
            }
        }

        #endregion
        #region System
        public ISystem_Policy_Repository  System_Policy_Repository
        {
            get
            {
                if (this.system_Policy_Repository == null)
                    system_Policy_Repository = new System_Policy_Repository(dataContext);
                return system_Policy_Repository;
            }
        }

        public ISystem_Position_Repository System_Position_Repository
        {
            get
            {
                if (this.system_Position_Repository == null)
                    system_Position_Repository = new System_Position_Repository(dataContext);
                return system_Position_Repository;
            }
        }

        public ISystem_User_Permission_Repository System_User_Permission_Repository
        {
            get
            {
                if (this.system_User_Permission_Repository == null)
                    system_User_Permission_Repository = new System_User_Permission_Repository(dataContext);
                return system_User_Permission_Repository;
            }
        }
        public IUserRepository UserRepository
        {
            get
            {
                if (this.userRepository == null)
                    userRepository = new UserRepository(dataContext);
                return userRepository;
            }
        }


        #endregion
        #endregion
        #region Method
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    dataContext.Dispose();
                }
            }
            this.disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
            this.dataContext.Dispose();
        }

        public async Task<int> SaveChangeAsync()
        {
            return await dataContext.SaveChangesAsync();
        }
        #endregion
    }
}