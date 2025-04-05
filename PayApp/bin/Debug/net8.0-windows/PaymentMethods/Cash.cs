using System;
using PayApp;

public class Cash : IPaymentMethod
{
    public string GetPaymentDetails(decimal amount)
    {
        return $"Cash ile {amount} TL Ödeme Yapıldı. ";
    }
}
