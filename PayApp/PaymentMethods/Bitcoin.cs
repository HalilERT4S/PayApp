using System;
using PayApp;

namespace PayApp.PaymentMethods
{
    public class Bitcoin : IPaymentMethod
    {
        public string GetPaymentDetails(decimal amount)
        {
            return $"Bitcoin ile {amount} TL Ödeme Yapıldı. ";
        }
    }
}
