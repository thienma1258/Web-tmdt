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
using Services.SMSServices;
using System.Text.RegularExpressions;

namespace BLL.BLL.SM.Implement
{
   
    public enum ErrorSaleOrder
    {
        ConfirmUser=0,
        CreateBill=1,
        NotValid=2,
        Success=3,
        ConfirmCodeError=4

    }
    public class SaleOrderBLL : GenericBLL,ISaleOrderBLL
    {
        private  bool IsPhoneNumber(string number)
        {
            return Regex.Match(number, @"^(\0[0-9]{9,12})$").Success;
        }
        private bool CheckCMND(string number)
        {
            return Regex.Match(number, @"^(([A-Z0-9]){9,12})$").Success;
        }
        private string strMessage = string.Empty;
        public ErrorSaleOrder enumErrorSaleOrder { get; set; }
        public string Message { get { return strMessage; }  }
        ISMSServices SMSServices { get; set; }
        public SaleOrderBLL(IUnitOfWork unitOfWork, ISMSServices SMSServices) : base(unitOfWork)
        {
            this.SMSServices = SMSServices;
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
                IEnumerable<SaleOrderDetail> listSaleOrderdetails =  this.unitOfWork.SaleOrderDetailsRepository.Get(p => p.SaleOrderID == saleOrderID);
                foreach(var SaleOrderDetail in listSaleOrderdetails)
                {
                    this.unitOfWork.SaleOrderDetailsRepository.Delete(SaleOrderDetail.SaleOrderID);
                }
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
        private async void validateCustomer(CM_Customer objCustomer)
        {
            CM_Customer Customer = await this.unitOfWork.CM_Customer_Repository.FindCustomer(p => p.CMND == objCustomer.CMND );
            if (Customer == null)
            {
                try
                {
                    //check valid phonenumber
                    if (string.IsNullOrEmpty(Customer.CustomerPhone) || !IsPhoneNumber(Customer.CustomerPhone))
                    {
                        this.enumErrorSaleOrder = ErrorSaleOrder.NotValid;
                        strMessage = "Số điện thoại nhập vào không phù hợp";
                        return;
                    }
                    else if (string.IsNullOrEmpty(Customer.CMND) || CheckCMND(Customer.CMND))
                    {
                        this.enumErrorSaleOrder = ErrorSaleOrder.NotValid;
                        strMessage = "Số CMND không phù hợp";
                        return;
                    }

                    sendCode(Customer);
                }
                catch(Exception objEx)
                {
                    throw objEx;
                }

                return;
            }
            else
            {
                if (string.IsNullOrEmpty(Customer.CustomerPhone) || !IsPhoneNumber(Customer.CustomerPhone))
                {
                    this.enumErrorSaleOrder = ErrorSaleOrder.NotValid;
                    strMessage = "Số điện thoại nhập vào không phù hợp";
                    return;
                }
                var rng = new Random();
                string first = rng.Next(10).ToString();
                string second = rng.Next(10).ToString();
                string third = rng.Next(10).ToString();
                string fourth = rng.Next(10).ToString();
                Customer.ConfirmCode = first + second + third + fourth;
                this.unitOfWork.CM_Customer_Repository.Update(Customer);

                enumErrorSaleOrder = ErrorSaleOrder.ConfirmUser;
                strMessage = "Vui lòng nhập  mã xác nhận  " + Customer.ConfirmCode;
                await this.SMSServices.sendSMS(Customer.CustomerPhone, Customer.ConfirmCode);

                await this.unitOfWork.SaveChangeAsync();
            }
        }
        public async void sendCode(CM_Customer Customer)
        {
            var rng = new Random();
            string first = rng.Next(10).ToString();
            string second = rng.Next(10).ToString();
            string third = rng.Next(10).ToString();
            string fourth = rng.Next(10).ToString();
            Customer.ConfirmCode = first + second + third + fourth;
            this.unitOfWork.CM_Customer_Repository.Update(Customer);

            enumErrorSaleOrder = ErrorSaleOrder.ConfirmUser;
            strMessage = "Vui lòng nhập  mã xác nhận  " + Customer.ConfirmCode;
            await this.SMSServices.sendSMS(Customer.CustomerPhone, Customer.ConfirmCode);

            await this.unitOfWork.SaveChangeAsync();
        }
        public async Task<bool> ConfirmCode(CM_Customer objCustomer,string Code)
        {
            if (objCustomer.ConfirmCode == Code)
            {
                objCustomer.ConfirmCode ="true";
                this.unitOfWork.CM_Customer_Repository.Update(objCustomer);
                await this.unitOfWork.SaveChangeAsync();
                return true;
            }
            else
            {
                enumErrorSaleOrder = ErrorSaleOrder.ConfirmCodeError;
                strMessage = "Mã nhập vào không chính xác ";
                return false;
            }
        }
        public async Task<bool> CreateBill(CM_Customer objCustomer,SaleOrder objSaleOrder, List<SaleOrderDetail> listSaleOrderDetails, string CreateUser)
        {
            try
            {
                CM_Customer Customer = await this.unitOfWork.CM_Customer_Repository.FindCustomer(p => p.CMND == objCustomer.CMND  && p.CustomerPhone == objCustomer.CustomerPhone);
                if (Customer==null||Customer.ConfirmCode!="true")
                {
                    validateCustomer(objCustomer);
                    return false;
                }
                foreach(var SaleOrderDetail in listSaleOrderDetails)
                {
                    SaleOrderDetail.SaleOrderID = objSaleOrder.ID;
                    this.unitOfWork.SaleOrderDetailsRepository.Insert(SaleOrderDetail);
                }
                this.unitOfWork.SaleOrderRepository.Insert(objSaleOrder);
                await this.unitOfWork.SaveChangeAsync();
                this.enumErrorSaleOrder = ErrorSaleOrder.Success;
               
                return true;
            }
            catch (Exception objEx)
            {
                await AddError(objEx);
                this.enumErrorSaleOrder = ErrorSaleOrder.CreateBill;
                strMessage = "Tạo đơn hàng không thành công vui lòng liên hệ nhân viên kiểm tra";
                return false;
            }
        }
    }
}
