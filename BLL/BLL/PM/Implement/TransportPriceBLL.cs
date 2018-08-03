using CacheHelpers;
using DAL;
using DAL.Model.PM;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BLL.PM.Implement
{
    public class TransportPriceBLL : GenericBLL, IGenericBLL<TransportPrice, string>
    {
        public TransportPriceBLL(IUnitOfWork unitOfWork, IDataCache DataCache) : base(unitOfWork, DataCache)
        {
        }

        public async Task<bool> Add(TransportPrice transportPrice, string CreatedUser = "adminstrator")
        {
            try
            {
                transportPrice.CreatedUser = CreatedUser;
                this.unitOfWork.TransportPriceRepository.Insert(transportPrice);
                await this.unitOfWork.SaveChangeAsync();
                return true;
            }
            catch (Exception objEx)
            {
                AddError(objEx);
                return false;
            }
        }

        public async Task<bool> Delete(string entityID, string DeletedUser = "adminstrator")
        {
            try
            {
                this.unitOfWork.TransportPriceRepository.Delete(entityID, DeletedUser);
                await this.unitOfWork.SaveChangeAsync();
                return true;
            }
            catch (Exception objEx)
            {
                AddError(objEx);
                return false;
            }
        }

        public async Task<TransportPrice> Find(string ID)
        {
            return this.unitOfWork.TransportPriceRepository.Find(ID);
        }

        public async Task<IEnumerable<TransportPrice>> Get(int intNumber = -1, int intSkippage = -1)
        {
            return this.unitOfWork.TransportPriceRepository.Get(filter: p => p.isDeleted == false, number: intNumber, skippage: intSkippage);

        }

        public async Task<bool> Update(TransportPrice transportPrice, string UpdatedUser = "adminstrator")
        {
            try
            {
                transportPrice.EditedUser = UpdatedUser;
                this.unitOfWork.TransportPriceRepository.Update(transportPrice);
                await this.unitOfWork.SaveChangeAsync();
                return true;
            }
            catch (Exception objEx)
            {
                AddError(objEx);
                return false;
            }
        }
    }
}
