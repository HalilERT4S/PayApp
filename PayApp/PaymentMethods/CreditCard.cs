using System;
using PayApp;

namespace PayApp.PaymentMethods
{
    public class CreditCard : IPaymentMethod
    {
        public string GetPaymentDetails(decimal amount)
        {
            return $"Credit Card ile {amount} TL Ödeme Yapıldı. ";
        }
    }
}
