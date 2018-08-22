using PayPal.v1.Payments;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using PayPal.Core;
using BraintreeHttp;
using System.Threading.Tasks;
using DAL.Model.SM;
using DAL.Model.CM;

namespace Services.PaypalServices.Implement
{
    public class PaypalSDKServices:IPaypalServices
    {
        string ClientID = "AfCRA5WhUKekcea2LHhTYMHVsDNixBuPFeqygJ9W3m6IkfKHrmp8JHryqWe_XMVXH1TJnaHIphmYJg6Z";
        string SecretID = "EL00PS-mY7IzkA-_NsGkHxTdBFE2Wz2jPh8NnaDjkIbCUJJSY-6iOA73q12Gpwuw0cn3Kb6e8z76PlVF";
        SandboxEnvironment environment;
        public PaypalSDKServices()
        {

            environment = new SandboxEnvironment(ClientID, SecretID);


        }


        public decimal currencyExchange = 23269.00M;

        public async  Task<Payment> CreatePayment(string successUrl,string ErrorUrl,Transaction objTransaction, string note_to_player = "Web ban giay BMT")
        {
            var client = new PayPalHttpClient(environment);
            string intent = "sale";
            var listTransaction = new List<Transaction>();
            listTransaction.Add(objTransaction);
            var payment = new Payment()
            {
                Intent = intent,
                NoteToPayer=note_to_player,
                Transactions = listTransaction,
                //CreateTime=DateTime.Now.ToString(),
                
                
                RedirectUrls = new RedirectUrls()
                {
                    CancelUrl = successUrl,
                    ReturnUrl = ErrorUrl
                },
                
                 Payer = new Payer()
                {
                    PaymentMethod = "paypal",
                   
                    
                }
            };

            PaymentCreateRequest request = new PaymentCreateRequest();
            request.RequestBody(payment);

            try
            {
                HttpResponse response = await client.Execute(request);
                var statusCode = response.StatusCode;
                Payment result = response.Result<Payment>();
                
                return result;
              
            }
            catch(Exception objException)
            {
                throw objException;
            }
        }
        public async Task<Payment> ExecutePayment(PaymentExecution objPaymentExecution)
        {
            var client = new PayPalHttpClient(environment);
            string intent = "sale";
            

            PaymentExecuteRequest request = new PaymentExecuteRequest(objPaymentExecution.PayerId);
            request.RequestBody(objPaymentExecution);

            try
            {
                HttpResponse response = await client.Execute(request);
                var statusCode = response.StatusCode;

                Payment result = response.Result<Payment>();

                return result;

            }
            catch (Exception objException)
            {
                throw objException;
            }
        }
        public async Task<Payment> CreatePayment()
        {
            var environment = new SandboxEnvironment("AfCRA5WhUKekcea2LHhTYMHVsDNixBuPFeqygJ9W3m6IkfKHrmp8JHryqWe_XMVXH1TJnaHIphmYJg6Z", "EL00PS-mY7IzkA-_NsGkHxTdBFE2Wz2jPh8NnaDjkIbCUJJSY-6iOA73q12Gpwuw0cn3Kb6e8z76PlVF");
            var client = new PayPalHttpClient(environment);
            string intent = "sale";

            var payment = new Payment()
            {
                Intent = intent,

                Transactions = new List<Transaction>()
                {
                    new Transaction()
                    {
                        Amount = new Amount()
                        {
                            Total = "10",
                            Currency = "VND",
                        }

                    }


                },

                RedirectUrls = new RedirectUrls()
                {
                    CancelUrl = "https://example.com/cancel",
                    ReturnUrl = "https://example.com/return"
                },
                Payer = new Payer()
                {
                    PaymentMethod = "paypal",

                }
            };

            PaymentCreateRequest request = new PaymentCreateRequest();
            request.RequestBody(payment);

            try
            {
                HttpResponse response = await client.Execute(request);
                var statusCode = response.StatusCode;
                Payment result = response.Result<Payment>();

                return result;
            }
            catch (Exception exception)
            {
                return null;
            }
        }
    }
}
