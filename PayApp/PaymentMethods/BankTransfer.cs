using System;
using PayApp;

namespace PayApp.PaymentMethods
{
    public class BankTransfer : IPaymentMethod
    {
        public string GetPaymentDetails(decimal amount)
        {
            return $"Bank Transfer ile {amount} TL Ödeme Yapıldı. ";
        }
    }
}
