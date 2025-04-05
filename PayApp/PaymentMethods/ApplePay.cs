using System;
using PayApp;

namespace PayApp.PaymentMethods
{
    public class ApplePay : IPaymentMethod
    {
        public string GetPaymentDetails(decimal amount)
        {
            return $"Apple Pay ile {amount} TL Ödeme Yapıldı. ";
        }
    }
}
