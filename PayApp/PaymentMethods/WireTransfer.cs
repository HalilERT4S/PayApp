using System;
using PayApp;

namespace PayApp.PaymentMethods
{
    public class WireTransfer : IPaymentMethod
    {
        public string GetPaymentDetails(decimal amount)
        {
            return $"Wire Transfer ile {amount} TL Ödeme Yapıldı. ";
        }
    }
}
