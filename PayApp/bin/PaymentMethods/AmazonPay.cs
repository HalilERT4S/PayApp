using System;
using PayApp;

public class AmazonPay : IPaymentMethod
{
    public string GetPaymentDetails(decimal amount)
    {
        return $"Amazon Pay ile {amount} TL Ödeme Yapıldı. ";
    }
}
