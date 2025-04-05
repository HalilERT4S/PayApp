using System;
using PayApp;

public class CreditCard : IPaymentMethod
{
    public string GetPaymentDetails(decimal amount)
    {
        return $"Credit Card ile {amount} TL Ödeme Yapıldı. ";
    }
}
