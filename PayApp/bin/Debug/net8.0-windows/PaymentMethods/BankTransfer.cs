using System;
using PayApp;

public class BankTransfer : IPaymentMethod
{
    public string GetPaymentDetails(decimal amount)
    {
        return $"Bank Transfer ile {amount} TL Ödeme Yapıldı. ";
    }
}
