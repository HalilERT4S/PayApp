using System;
using PayApp;

public class Alipay : IPaymentMethod
{
    public string GetPaymentDetails(decimal amount)
    {
        return $"Alipay ile {amount} TL Ödeme Yapıldı. ";
    }
}
