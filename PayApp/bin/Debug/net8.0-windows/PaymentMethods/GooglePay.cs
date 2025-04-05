using System;
using PayApp;

public class GooglePay : IPaymentMethod
{
    public string GetPaymentDetails(decimal amount)
    {
        return $"Google Pay ile {amount} TL Ödeme Yapıldı. ";
    }
}
