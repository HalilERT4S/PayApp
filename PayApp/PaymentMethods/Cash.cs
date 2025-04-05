using System;
using PayApp;

namespace PayApp.PaymentMethods
{
    public class Cash : IPaymentMethod
    {
        public string GetPaymentDetails(decimal amount)
        {
            return $"Cash ile {amount} TL Ödeme Yapıldı. ";
        }
    }
}
