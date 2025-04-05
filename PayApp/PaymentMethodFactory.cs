using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace PayApp
{
    public class PaymentMethodFactory
    {
        public IPaymentMethod CreatePaymentMethod(string className)
        {
            object? newObject = Assembly.GetAssembly(typeof(IPaymentMethod))?.CreateInstance("PayApp.PaymentMethods." + className);

            if (newObject == null)
            {
                throw new ArgumentException($"'{className}' adında bir paymentMethod sınıfı bulunamadı.");
            }

            return (IPaymentMethod)newObject;
        }
    }
}
