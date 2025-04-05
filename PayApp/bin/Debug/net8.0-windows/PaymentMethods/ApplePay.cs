using System;
using PayApp;

public class ApplePay : IPaymentMethod
{
    public string GetPaymentDetails(decimal amount)
    {
        return $"Apple Pay ile {amount} TL Ödeme Yapıldı. ";
    }
}
