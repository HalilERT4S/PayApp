using System;
using PayApp;

namespace PayApp.PaymentMethods
{
    public class PayPal : IPaymentMethod
    {
        public string GetPaymentDetails(decimal amount)
        {
            return $"PayPal ile {amount} TL Ödeme Yapıldı. ";
        }
    }
}
