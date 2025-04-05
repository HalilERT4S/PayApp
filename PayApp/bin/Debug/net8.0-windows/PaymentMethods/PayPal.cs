using System;
using PayApp;

public class PayPal : IPaymentMethod
{
    public string GetPaymentDetails(decimal amount)
    {
        return $"PayPal ile {amount} TL Ödeme Yapıldı. ";
    }
}
