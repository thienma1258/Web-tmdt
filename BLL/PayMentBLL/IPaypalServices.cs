using System;
using System.Collections.Generic;
using System.Text;
using PayPal.Api;
namespace BLL.PayMentBLL
{
    public interface IPaypalServices
    {
        Payment CreatePayment(decimal amount, string returnUrl, string cancelUrl, string intent);

        Payment ExecutePayment(string paymentId, string payerId);
    }
}
