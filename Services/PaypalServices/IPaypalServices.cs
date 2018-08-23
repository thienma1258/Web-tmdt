using PayPal.v1.Payments;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Services.PaypalServices
{
    public interface IPaypalServices
    {
        Task<Payment> CreatePayment(string successUrl, string ErrorUrl, Transaction objTransaction, string note_to_player = "Web ban giay BMT");
        Task<Payment> ExecutePayment(PaymentExecution objPaymentExecution,string paymentID);
    }
}
