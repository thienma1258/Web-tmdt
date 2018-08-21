using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL.PayMentBLL;
using Microsoft.AspNetCore.Mvc;

namespace Aoo.Controllers.Payment
{
    public class PaypalController : Controller
    {
        private IPaypalServices _PaypalServices;

        public PaypalController(IPaypalServices paypalServices)
        {
            _PaypalServices = paypalServices;
        }

        public IActionResult Index()
        {
            return View();
        }
        [Route("thanh-toan/payment")]
        public  IActionResult CreatePayment()
        {
            var payment = _PaypalServices.CreatePayment(100, "http://localhost:28079/Payment/ExecutePayment", "http://localhost:28079/Payment/Cancel", "sale");

            return new JsonResult(payment);
        }

        public IActionResult ExecutePayment(string paymentId, string token, string PayerID)
        {
            var payment = _PaypalServices.ExecutePayment(paymentId, PayerID);
            // Hint: You can save the transaction details to your database using payment/buyer info

            return Ok();
        }

        public IActionResult Success()
        {
            return View();
        }

        public IActionResult Cancel()
        {
            return View();
        }

    }
}