using System;
using PayApp;

namespace PayApp.PaymentMethods
{
    public class Alipay : IPaymentMethod
    {
        public string GetPaymentDetails(decimal amount)
        {
            return $"Alipay ile {amount} TL Ödeme Yapıldı. ";
        }
    }
}
