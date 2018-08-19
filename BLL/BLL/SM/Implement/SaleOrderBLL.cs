using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAL.Model.Log;
using DAL.Model.SM;
using DAL.Model.CM;
namespace BLL.BLL.SM.Implement
{
    public class SaleOrderBLL : GenericBLL,ISaleOrderBLL
    {
        private string strMessage = string.Empty;
        public string Message { get { return strMessage; }  }
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
                await AddError(objEx);
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
                await AddError(objEx);
                return false;
            }
        }

        public async Task<SaleOrder> Find(string saleOrderID)
        {
            try
            {
               return  this.unitOfWork.SaleOrderRepository.Find(saleOrderID);
               
            }
            catch(Exception objEx)
            {
                await AddError(objEx);
                return null;
            }
        }

        public async Task<IEnumerable<SaleOrder>> Get(int intNumber = -1, int currentPage = -1)
        {
            try
            {
                return this.unitOfWork.SaleOrderRepository.Get( number: intNumber, currentPage: currentPage);
            }
            catch (Exception objEx)
            {
                await AddError(objEx);
                return null;
            }
        }

        public async Task<bool> Update(SaleOrder saleOrder, string UpdatedUser = "adminstrator")
        {
            try
            {
                this.unitOfWork.SaleOrderRepository.Update(saleOrder);
                await this.unitOfWork.SaveChangeAsync();
                AddLogSaleOrder(saleOrder);
                return true;
            }
            catch (Exception objEx)
            {
                await AddError(objEx);
                return false;
            }
        }

        public async Task<IEnumerable<SaleOrder>> Get(int intNumber = -1, int currentPage = -1, Expression<Func<SaleOrder, bool>> filter = null, Func<IQueryable<SaleOrder>, IOrderedQueryable<SaleOrder>> orderBy = null)
        {
            try
            {
                return unitOfWork.SaleOrderRepository.Get(filter: filter, orderBy: orderBy, number: intNumber, currentPage: currentPage);

            }
            catch (Exception objEx)
            {
                await AddError(objEx);
                return null;
            }
        }

        public int Cout(Expression<Func<SaleOrder, bool>> filter = null)
        {
            return this.unitOfWork.SaleOrderRepository.Cout(filter);

        }

        public async Task<bool> ConfirmSaleOrder(SaleOrder objSaleOrder, string ReviewUser)
        {
            objSaleOrder.ReviewBy = ReviewUser;
            objSaleOrder.ReviewDate = DateTime.Now;
            objSaleOrder.State = Common.Enum.SM.StateConfirmEnum.Pending;

            return await Update(objSaleOrder);
        }
        public async Task<bool> SuccessOrder(SaleOrder objSaleOrder, string ReviewUser)
        {
           
            objSaleOrder.ReviewBy = ReviewUser;
            objSaleOrder.ReviewDate = DateTime.Now;
            objSaleOrder.State = Common.Enum.SM.StateConfirmEnum.Success;

            return await Update(objSaleOrder);
        }

        public Task<bool> CreateSaleOrder(SaleOrder objSaleOrder, List<SaleOrderDetail> saleOrderDetails, string CreateUser)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> CreateBill(CM_Customer objCustomer,SaleOrder objSaleOrder, List<SaleOrderDetail> saleOrderDetails, string CreateUser)
        {
            try
            {
                return true;
            }
            catch (Exception objEx)
            {
                await AddError(objEx);
                return false;
            }
        }
    }
}
