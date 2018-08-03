using DAL;
using DAL.Model.PM;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BLL.PM.Implement
{
    public class TransportTypeBLL : GenericBLL, IGenericBLL<TransportType, string>
    {
        public TransportTypeBLL(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public async Task<bool> Add(TransportType transportType, string CreatedUser = "adminstrator")
        {
            try
            {
                transportType.CreatedUser = CreatedUser;
                this.unitOfWork.TransportTypeRepository.Insert(transportType);
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

        public async Task<TransportType> Find(string ID)
        {
            return this.unitOfWork.TransportTypeRepository.Find(ID);

        }

        public async Task<IEnumerable<TransportType>> Get(int intNumber = -1, int intSkippage = -1)
        {
            return this.unitOfWork.TransportTypeRepository.Get(filter: p => p.isDeleted == false, number: intNumber, skippage: intSkippage);
        }

        public async Task<bool> Update(TransportType transportType, string UpdatedUser = "adminstrator")
        {
            try
            {
                transportType.EditedUser = UpdatedUser;
                this.unitOfWork.TransportTypeRepository.Update(transportType);
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
