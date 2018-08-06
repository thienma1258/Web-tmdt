using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAL.Model.Log;
using DAL.Model.SM;

namespace BLL.BLL.SM.Implement
{
    public class SaleOrderBLL : GenericBLL,ISaleOrderBLL
    {
        public SaleOrderBLL(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
        private async void AddLogSaleOrder(SaleOrder saleOrder)
        {
            SaleOrderLogs saleOrderLogs = new SaleOrderLogs
            {
                AuthenticationMethodGuid = saleOrder.AuthenticationMethodGuid,
                Logs = "Loi o order "+saleOrder.ID,
                IsPay = saleOrder.IsPay,
                TotalPrice = saleOrder.TotalPrice,
                TransportTypePrice = saleOrder.TransportPrice.Price,
                State = saleOrder.State,
                ReviewBy = saleOrder.ReviewBy,
                ReviewDate = saleOrder.ReviewDate,
                Customer = saleOrder.Customer,
                PaymentMethod = saleOrder.PaymentMethod,
                
            };
            this.unitOfWork.SaleOrderLogsRepository.Insert(saleOrderLogs);
            await this.unitOfWork.SaveChangeAsync();
        }
        public async Task<bool> Add(SaleOrder saleOrder, string CreatedUser = "adminstrator")
        {
            try
            {
                saleOrder.CreatedUser = CreatedUser;
                this.unitOfWork.SaleOrderRepository.Insert(saleOrder);
                await this.unitOfWork.SaveChangeAsync();
                AddLogSaleOrder( saleOrder);
                return true;
            }
            catch (Exception objEx)
            {
                AddError(objEx);
                return false;
            }
        }

        public async Task<bool> Delete(string saleOrderID, string DeletedUser = "adminstrator")
        {
            try
            {
                this.unitOfWork.SaleOrderRepository.Delete(saleOrderID, DeletedUser);
                await this.unitOfWork.SaveChangeAsync();
                return true;
            }
            catch (Exception objEx)
            {
                AddError(objEx);
                return false;
            }
        }

        public async Task<SaleOrder> Find(string saleOrderID)
        {
            try
            {
               return  this.unitOfWork.SaleOrderRepository.Find(saleOrderID);
               
            }
            catch(Exception e)
            {
                return null;
            }
        }

        public async Task<IEnumerable<SaleOrder>> Get(int intNumber = -1, int intSkippage = -1)
        {
            try
            {
                return this.unitOfWork.SaleOrderRepository.Get(filter: p => p.isDeleted == false, number: intNumber, skippage: intSkippage);
            }
            catch (Exception objEx)
            {
                AddError(objEx);
                return null;
            }
        }

        public async Task<bool> Update(SaleOrder saleOrder, string UpdatedUser = "adminstrator")
        {
            try
            {
                saleOrder.EditedUser = UpdatedUser;
                this.unitOfWork.SaleOrderRepository.Update(saleOrder);
                await this.unitOfWork.SaveChangeAsync();
                AddLogSaleOrder(saleOrder);
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
